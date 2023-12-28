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
    public partial class frmttnhanvien : Form
    {
        public string TaiKhoanEmployeeDaDangNhap { get; set; }

        public frmttnhanvien()
        {
            InitializeComponent();
        }

        private void boxcancel_Click(object sender, EventArgs e)
        {
            Close();
            string taikhoan = TaiKhoanEmployeeDaDangNhap;
            frmnhanviengiaodien frmnhanviengiaodien = new frmnhanviengiaodien();
            frmnhanviengiaodien.TaiKhoanEmployeeDaDangNhap = taikhoan;
            frmnhanviengiaodien.Show();
        }

        private void frmttnhanvien_Load(object sender, EventArgs e)
        {
            TenKH();
            NgSinhKH();
            QueKH();
            SDTKH();
            EmailKH();
        }

        private void TenKH()
        {
            

            //laythongtin
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    connection.Open();

                    // Tạo câu truy vấn SQL
                    string query = "SELECT TenNhanVien FROM NhanVien WHERE TaiKhoan = @TaiKhoan";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Đặt giá trị tham số @UserID tại đây (chẳng hạn là ID của người dùng cụ thể)
                        command.Parameters.AddWithValue("@TaiKhoan", TaiKhoanEmployeeDaDangNhap);

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
            

            //laythongtin
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    connection.Open();

                    // Tạo câu truy vấn SQL
                    string query = "SELECT NgaySinh FROM NhanVien WHERE TaiKhoan = @TaiKhoan";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Đặt giá trị tham số @UserID tại đây (chẳng hạn là ID của người dùng cụ thể)
                        command.Parameters.AddWithValue("@TaiKhoan", TaiKhoanEmployeeDaDangNhap);

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
           
            //laythongtin
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    connection.Open();

                    // Tạo câu truy vấn SQL
                    string query = "SELECT QueQuan FROM NhanVien WHERE TaiKhoan = @TaiKhoan";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Đặt giá trị tham số @UserID tại đây (chẳng hạn là ID của người dùng cụ thể)
                        command.Parameters.AddWithValue("@TaiKhoan", TaiKhoanEmployeeDaDangNhap);

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
           

            //laythongtin
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    connection.Open();

                    // Tạo câu truy vấn SQL
                    string query = "SELECT SoDienThoai FROM NhanVien WHERE TaiKhoan = @TaiKhoan";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Đặt giá trị tham số @UserID tại đây (chẳng hạn là ID của người dùng cụ thể)
                        command.Parameters.AddWithValue("@TaiKhoan", TaiKhoanEmployeeDaDangNhap);

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
           
            //laythongtin
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    connection.Open();

                    // Tạo câu truy vấn SQL
                    string query = "SELECT Email FROM NhanVien WHERE TaiKhoan = @TaiKhoan";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Đặt giá trị tham số @UserID tại đây (chẳng hạn là ID của người dùng cụ thể)
                        command.Parameters.AddWithValue("@TaiKhoan", TaiKhoanEmployeeDaDangNhap);

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
    }
}
