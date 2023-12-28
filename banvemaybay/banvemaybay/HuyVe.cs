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

namespace banvemaybay
{
    public partial class frmhuyve : Form
    {
        public string TaiKhoanUserDaDangNhap { get; set; }
        public frmhuyve()
        {
            InitializeComponent();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void boxcancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmhuyve_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TaiKhoanUserDaDangNhap))
            {
                // Gọi hàm để lấy dữ liệu chuyến bay dựa trên tài khoản đã đăng nhập
                DataSet chuyenBayData = GetChuyenBayData(TaiKhoanUserDaDangNhap);

                if (chuyenBayData != null && chuyenBayData.Tables.Count > 0)
                {
                    // Hiển thị dữ liệu lên DataGridView
                    dataGridView.DataSource = chuyenBayData.Tables[0];
                    foreach (DataRow row in chuyenBayData.Tables[0].Rows)
                    {
                        string flightID = row["FlightID"].ToString();
                        cbboxmachuyenbay.Items.Add(flightID);
                    }
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

        private void btnhuyve_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy mã chuyến bay từ ComboBox
                string selectedFlight = cbboxmachuyenbay.SelectedItem.ToString();
                if (string.IsNullOrEmpty(selectedFlight))
                {
                    MessageBox.Show("Hãy Chọn Mã Chuyến Bay Bạn Muốn Xóa !");
                    return;
                }
                else
                {
                    // Lấy UserID từ tài khoản đăng nhập
                    string selectedTaiKhoan = TaiKhoanUserDaDangNhap;

                    // Lấy UserID từ bảng KhachHang dựa trên tên tài khoản
                    string queryUserID = "SELECT UserID FROM KhachHang WHERE TaiKhoan = @TaiKhoan";

                    using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                    using (SqlCommand commandUserID = new SqlCommand(queryUserID, connection))
                    {
                        commandUserID.Parameters.AddWithValue("@TaiKhoan", selectedTaiKhoan);

                        connection.Open();
                        string selectedUserID = commandUserID.ExecuteScalar()?.ToString();

                        if (selectedUserID != null)
                        {
                            // Chuỗi truy vấn SQL để xóa thông tin vé
                            string queryDelete = "DELETE FROM Ve WHERE FlightID = @FlightID AND UserID = @UserID";

                            using (SqlCommand commandDelete = new SqlCommand(queryDelete, connection))
                            {
                                // Thêm các tham số cho câu truy vấn xóa
                                commandDelete.Parameters.AddWithValue("@FlightID", selectedFlight);
                                commandDelete.Parameters.AddWithValue("@UserID", selectedUserID);

                                int rowsAffected = commandDelete.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Hủy vé thành công!");
                                    GetChuyenBayData(TaiKhoanUserDaDangNhap);
                                }
                                else
                                {
                                    MessageBox.Show("Không tìm thấy vé để hủy.");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy thông tin tài khoản.");
                        }
                    }
                }
            }
                
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
