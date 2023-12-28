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
    public partial class frmttkhachhang : Form
    {
        public string TaiKhoanUserDaDangNhap { get; set; }
        public frmttkhachhang()
        {
            InitializeComponent();
        }

        private void frmttkhachhang_Load(object sender, EventArgs e)
        {
            TenKH();
            NgSinhKH();
            QueKH();
            SDTKH();
            EmailKH();
        }
        private void TenKH()
        {
            string TaiKhoan = TaiKhoanUserDaDangNhap;
            frmkhachhanggiaodien frmkhachhanggiaodien = new frmkhachhanggiaodien();
            frmkhachhanggiaodien.TaiKhoanUserDaDangNhap = TaiKhoan;
            //laythongtin
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    connection.Open();

                    // Tạo câu truy vấn SQL
                    string query = "SELECT TenKhachHang FROM KhachHang WHERE TaiKhoan = @TaiKhoan";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Đặt giá trị tham số @UserID tại đây (chẳng hạn là ID của người dùng cụ thể)
                        command.Parameters.AddWithValue("@TaiKhoan", TaiKhoanUserDaDangNhap);

                        string tenKhachHang = command.ExecuteScalar()?.ToString();

                        // Gán tên người dùng vào Label
                        lblname.Text = tenKhachHang;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void NgSinhKH()
        {
            string TaiKhoan = TaiKhoanUserDaDangNhap;
            frmkhachhanggiaodien frmkhachhanggiaodien = new frmkhachhanggiaodien();
            frmkhachhanggiaodien.TaiKhoanUserDaDangNhap = TaiKhoan;

            //laythongtin
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    connection.Open();
                    
                    // Tạo câu truy vấn SQL
                    string query = "SELECT CAST(NgaySinh AS DATE) AS NgaySinh FROM KhachHang WHERE TaiKhoan = @TaiKhoan";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Đặt giá trị tham số @UserID tại đây (chẳng hạn là ID của người dùng cụ thể)
                        command.Parameters.AddWithValue("@TaiKhoan", TaiKhoanUserDaDangNhap);

                        string ngsinh = command.ExecuteScalar()?.ToString();

                        // Gán tên người dùng vào Label
                        lblbirthday.Text = ngsinh;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void QueKH()
        {
            string TaiKhoan = TaiKhoanUserDaDangNhap;
            frmkhachhanggiaodien frmkhachhanggiaodien = new frmkhachhanggiaodien();
            frmkhachhanggiaodien.TaiKhoanUserDaDangNhap = TaiKhoan;

            //laythongtin
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    connection.Open();

                    // Tạo câu truy vấn SQL
                    string query = "SELECT QueQuan FROM KhachHang WHERE TaiKhoan = @TaiKhoan";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Đặt giá trị tham số @UserID tại đây (chẳng hạn là ID của người dùng cụ thể)
                        command.Parameters.AddWithValue("@TaiKhoan", TaiKhoanUserDaDangNhap);

                        string quequan = command.ExecuteScalar()?.ToString();

                        // Gán tên người dùng vào Label
                        lbladress.Text = quequan;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void SDTKH()
        {
            string TaiKhoan = TaiKhoanUserDaDangNhap;
            frmkhachhanggiaodien frmkhachhanggiaodien = new frmkhachhanggiaodien();
            frmkhachhanggiaodien.TaiKhoanUserDaDangNhap = TaiKhoan;

            //laythongtin
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    connection.Open();

                    // Tạo câu truy vấn SQL
                    string query = "SELECT SoDienThoai FROM KhachHang WHERE TaiKhoan = @TaiKhoan";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Đặt giá trị tham số @UserID tại đây (chẳng hạn là ID của người dùng cụ thể)
                        command.Parameters.AddWithValue("@TaiKhoan", TaiKhoanUserDaDangNhap);

                        string sdt = command.ExecuteScalar()?.ToString();

                        // Gán tên người dùng vào Label
                        lblhotline.Text = sdt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void EmailKH()
        {
            string TaiKhoan = TaiKhoanUserDaDangNhap;
            frmkhachhanggiaodien frmkhachhanggiaodien = new frmkhachhanggiaodien();
            frmkhachhanggiaodien.TaiKhoanUserDaDangNhap = TaiKhoan;

            //laythongtin
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    connection.Open();

                    // Tạo câu truy vấn SQL
                    string query = "SELECT Email FROM KhachHang WHERE TaiKhoan = @TaiKhoan";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Đặt giá trị tham số @UserID tại đây (chẳng hạn là ID của người dùng cụ thể)
                        command.Parameters.AddWithValue("@TaiKhoan", TaiKhoanUserDaDangNhap);

                        string email = command.ExecuteScalar()?.ToString();

                        // Gán tên người dùng vào Label
                        lblmail.Text = email;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }



        private void boxcancel_Click(object sender, EventArgs e)
        {
            Close();
            frmkhachhanggiaodien frmkhachhanggiaodien = new frmkhachhanggiaodien();
            string TaiKhoan = TaiKhoanUserDaDangNhap;
            frmkhachhanggiaodien.TaiKhoanUserDaDangNhap = TaiKhoan;
            frmkhachhanggiaodien.Show();
        }

        private void btnchange_Click(object sender, EventArgs e)
        {

        }
    }
}
