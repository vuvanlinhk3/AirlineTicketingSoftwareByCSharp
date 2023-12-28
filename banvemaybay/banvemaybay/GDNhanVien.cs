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
    public partial class frmnhanviengiaodien : Form
    {
        public string TaiKhoanEmployeeDaDangNhap { get; set; }

        public frmnhanviengiaodien()
        {
            InitializeComponent();
        }

        private void tboxqlttcn_Click(object sender, EventArgs e)
        {
            Close();
            string taikhoan = TaiKhoanEmployeeDaDangNhap;
            frmttnhanvien frmttnhanvien = new frmttnhanvien();
            frmttnhanvien.TaiKhoanEmployeeDaDangNhap = taikhoan;
            frmttnhanvien.Show();
        }

        private void tboxdangxuat_Click(object sender, EventArgs e)
        {
            Close();
            frmdangnhap frmdangnhap = new frmdangnhap();
            frmdangnhap.Show();
        }
        private void LoadDataIntoGridView()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    connection.Open();

                    // Tạo câu truy vấn SQL
                    string query = "SELECT FlightID, SanBayDi, SanBayDen, GioKhoiHanh, GiaVeThuongGia, GiaVeThuong FROM ChuyenBay";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Gán dữ liệu từ DataTable vào DataGridView
                        dataload.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnallchuyenbay_Click(object sender, EventArgs e)
        {
            LoadDataIntoGridView();
        }
        private void LoadDataIntoGridViewNowDate()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    connection.Open();

                    // Lấy thời gian hiện tại
                    DateTime currentTime = DateTime.Now;

                    // Tạo câu truy vấn SQL với điều kiện thời gian khởi hành lớn hơn thời gian hiện tại
                    string query = "SELECT FlightID, SanBayDi, SanBayDen, GioKhoiHanh, GiaVeThuongGia, GiaVeThuong FROM ChuyenBay WHERE GioKhoiHanh > @CurrentTime";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        // Thêm tham số thời gian hiện tại vào câu truy vấn
                        adapter.SelectCommand.Parameters.AddWithValue("@CurrentTime", currentTime);

                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Gán dữ liệu từ DataTable vào DataGridView
                        dataload.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void tboxchenbayhientai_Click(object sender, EventArgs e)
        {
            LoadDataIntoGridViewNowDate();
        }

        private void tboxchuyenbaylink_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    connection.Open();

                    // Tạo câu truy vấn SQL
                    string query = "SELECT FlightID, SanBayDi, SanBayDen, GioKhoiHanh, GiaVeThuongGia, GiaVeThuong FROM ChuyenBay WHERE DanhGia = '5'";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Gán dữ liệu từ DataTable vào DataGridView
                        dataload.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void tboxlichsu_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    connection.Open();

                    // Tạo câu truy vấn SQL với INNER JOIN giữa các bảng để lấy thông tin cần thiết
                    string query = @"
                        SELECT KhachHang.TenKhachHang, ChuyenBay.SanBayDi, ChuyenBay.SanBayDen, ChuyenBay.GioKhoiHanh, Ve.LoaiVe
                        FROM KhachHang
                        INNER JOIN Ve ON KhachHang.UserID = Ve.UserID
                        INNER JOIN ChuyenBay ON Ve.FlightID = ChuyenBay.FlightID
                        WHERE ChuyenBay.GioKhoiHanh >= DATEADD(DAY, -5, GETDATE())";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(dataTable);

                        // Gán dữ liệu từ DataTable vào DataGridView hoặc nơi bạn muốn hiển thị kết quả
                        dataload.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnttkhachhang_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    connection.Open();

                    // Tạo câu truy vấn SQL
                    string query = "SELECT * FROM KhachHang";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Gán dữ liệu từ DataTable vào DataGridView
                        dataload.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void frmnhanviengiaodien_Load(object sender, EventArgs e)
        {
            string taikhoan = TaiKhoanEmployeeDaDangNhap;
            //MessageBox.Show(taikhoan);
        }

        private void tboxseach_Click(object sender, EventArgs e)
        {
            frmtimkiem frmtimkiem = new frmtimkiem();
            frmtimkiem.Show();
        }

        private void tboxdatve_Click(object sender, EventArgs e)
        {
            string taikhoan = TaiKhoanEmployeeDaDangNhap;
            frmdatvenhanvien frmdatvenhanvien = new frmdatvenhanvien();
            frmdatvenhanvien.TaiKhoanEmployeeDaDangNhap = taikhoan;
            frmdatvenhanvien.Show();
        }

        private void btnkiemtrattkhach_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    connection.Open();

                    // Tạo câu truy vấn SQL
                    string query = "SELECT * FROM Ve";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Gán dữ liệu từ DataTable vào DataGridView
                        dataload.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btncf_Click(object sender, EventArgs e)
        {
            try
    {
        string maVeCanTim = tboxnhapmave.Text.Trim(); // Lấy thông tin nhập từ textbox

        if (string.IsNullOrEmpty(maVeCanTim))
        {
            MessageBox.Show("Vui lòng nhập mã vé cần tìm.");
            return;
        }

        using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
        {
            connection.Open();

                    // Tạo câu truy vấn SQL để tìm vé dựa trên mã vé
                string query = @"
                SELECT Ve.TicketID, KhachHang.TenKhachHang, Ve.FlightID, Ve.SoGhe, Ve.NgayMuaVe, Ve.TrangThai, Ve.LoaiVe, Ve.GhiChu
                FROM Ve
                INNER JOIN KhachHang ON Ve.UserID = KhachHang.UserID
                WHERE Ve.TicketID = @MaVe
            ";

                    using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaVe", maVeCanTim);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                        if (dataTable.Rows.Count == 0)
                        {
                            MessageBox.Show("Không tìm thấy thông tin mã vé.");
                        }
                        else
                        {
                            // Hiển thị kết quả trong datagridview
                            dataload.DataSource = dataTable;
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
