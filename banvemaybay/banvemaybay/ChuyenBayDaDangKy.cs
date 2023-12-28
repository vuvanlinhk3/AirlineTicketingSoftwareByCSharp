using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace banvemaybay
{
    public partial class frmchuyenbaydadangky : Form
    {
        public string TaiKhoanUserDaDangNhap { get; set; }
        public frmchuyenbaydadangky()
        {
            InitializeComponent();
        }

        private void boxcancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmchuyenbaydadangky_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(TaiKhoanUserDaDangNhap);
            // Kiểm tra xem đã có tài khoản đăng nhập hay chưa
            if (!string.IsNullOrEmpty(TaiKhoanUserDaDangNhap))
            {
                // Gọi hàm để lấy dữ liệu chuyến bay dựa trên tài khoản đã đăng nhập
                DataSet chuyenBayData = GetChuyenBayData(TaiKhoanUserDaDangNhap);

                if (chuyenBayData != null && chuyenBayData.Tables.Count > 0)
                {
                    // Hiển thị dữ liệu lên DataGridView
                    dataGridView.DataSource = chuyenBayData.Tables[0];
                    // Tùy chỉnh hiển thị các cột (tên cột và cỡ cột)
                    CustomizeDataGridViewColumns();
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu chuyến bay cho tài khoản này.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng đăng nhập trước khi sử dụng tính năng này.");
            }
        }
        private void CustomizeDataGridViewColumns()
        {
            // Tùy chỉnh hiển thị các cột
            dataGridView.Columns["FlightID"].HeaderText = "Mã Chuyến Bay";
            dataGridView.Columns["SanBayDi"].HeaderText = "Sân Bay Đi";
            dataGridView.Columns["SanBayDen"].HeaderText = "Sân Bay Đến";
            dataGridView.Columns["GioKhoiHanh"].HeaderText = "Giờ Khởi Hành";
            dataGridView.Columns["LoaiVe"].HeaderText = "Loại Vé";
            dataGridView.Columns["GiaVe"].HeaderText = "Giá Vé";

            // Tự động điều chỉnh kích thước cột cho phù hợp với dữ liệu
            dataGridView.AutoResizeColumns();
        }
        private DataSet GetChuyenBayData(string taiKhoan)
        {
            try
            {
                DataSet data = new DataSet();

                string query = @"
                    SELECT ChuyenBay.FlightID, ChuyenBay.SanBayDi, ChuyenBay.SanBayDen, 
                           ChuyenBay.GioKhoiHanh, Ve.LoaiVe, 
                           CASE
                               WHEN Ve.LoaiVe = 'GiaVeThuongGia' THEN ChuyenBay.GiaVeThuongGia
                               WHEN Ve.LoaiVe = 'GiaVeThuong' THEN ChuyenBay.GiaVeThuong
                               ELSE 0 -- Xử lý trường hợp mặc định nếu cần
                           END AS GiaVe
                    FROM KhachHang
                    INNER JOIN Ve ON KhachHang.UserID = Ve.UserID
                    INNER JOIN ChuyenBay ON Ve.FlightID = ChuyenBay.FlightID
                    WHERE KhachHang.TaiKhoan = @TaiKhoan";

                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TaiKhoan", taiKhoan);

                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(data);
                }

                return data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return null;
            }
        }
        private void btnlaydulieu_Click(object sender, EventArgs e)
        {

            // Kiểm tra xem đã có tài khoản đăng nhập hay chưa
            if (!string.IsNullOrEmpty(TaiKhoanUserDaDangNhap))
            {
                // Gọi hàm để lấy dữ liệu chuyến bay dựa trên tài khoản đã đăng nhập
                DataSet chuyenBayData = GetChuyenBayData(TaiKhoanUserDaDangNhap);

                if (chuyenBayData != null && chuyenBayData.Tables.Count > 0)
                {
                    // Hiển thị dữ liệu lên DataGridView
                    dataGridView.DataSource = chuyenBayData.Tables[0];
                    // Tùy chỉnh hiển thị các cột (tên cột và cỡ cột)
                    CustomizeDataGridViewColumns();
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu chuyến bay cho tài khoản này.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng đăng nhập trước khi sử dụng tính năng này.");
            }
        }
    }
    }
