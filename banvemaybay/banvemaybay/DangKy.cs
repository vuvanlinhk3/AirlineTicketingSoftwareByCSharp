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
    public partial class frmdangky : Form
    {
        public frmdangky()
        {
            InitializeComponent();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Close();
            frmtrangdau frmtrangdau = new frmtrangdau();
            frmtrangdau.Show();
            //frmdangnhap frmdangnhap = new frmdangnhap();
            //frmdangnhap.Show();
        }

        private void frmdangky_Load(object sender, EventArgs e)
        {
           
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        private bool IsPhoneNumberExists(string phoneNumber)
        {
            // Tạo chuỗi kết nối SQL từ chuỗi kết nối trong file App.config (hoặc thay thế bằng chuỗi kết nối cụ thể của bạn)
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

            // Tạo câu truy vấn SQL để kiểm tra xem số điện thoại đã tồn tại trong bảng KhachHang chưa
            string query = "SELECT COUNT(*) FROM KhachHang WHERE SoDienThoai = @SoDienThoai";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Tạo đối tượng SqlCommand để thực hiện truy vấn SELECT
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Thêm tham số để tránh tấn công SQL Injection
                    command.Parameters.AddWithValue("@SoDienThoai", phoneNumber);

                    // Thực hiện truy vấn SELECT
                    int count = Convert.ToInt32(command.ExecuteScalar());

                    // Nếu số điện thoại đã tồn tại (count > 0), trả về true
                    return count > 0;
                }
            }
        }
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        private bool IsTaiKhoanExists(string taiKhoan)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            string query = "SELECT COUNT(*) FROM KhachHang WHERE TaiKhoan = @TaiKhoan";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TaiKhoan", taiKhoan);

                    int count = (int)command.ExecuteScalar();

                    // Nếu count > 0, tài khoản đã tồn tại
                    return count > 0;
                }
            }
        }
        private void btndangky_Click(object sender, EventArgs e)
        {
            // Đọc thông tin từ các TextBox
            string hoTen = tboxnameuser.Text;
            string ngaysinh = datetimeuser.Value.ToString("yyyy-MM-dd"); // Chuyển đổi ngày sinh sang chuỗi có định dạng "yyyy-MM-dd"
            string quequan = tboxquequan.Text;
            string soDienThoai = tboxsdt.Text;
            string email = tboxemail.Text;
            string matKhau = tboxmatkhau.Text;
            string taiKhoan = tboxuser.Text;
            string xacnhanmatkhau = tboxxacnhanmatkhau.Text;
            if(string.IsNullOrEmpty(hoTen))
            {
                MessageBox.Show("Vui lòng nhập họ tên !");
                return;
            }
            if (string.IsNullOrEmpty(soDienThoai))
            {
                MessageBox.Show("Vui lòng nhập Số Điện Thoại !");
                return;
            }
            if (IsPhoneNumberExists(soDienThoai))
            {
                MessageBox.Show("Số điện thoại này đã được đăng ký.");
                return; // Ngừng xử lý tiếp và không đăng ký
            }
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Vui lòng nhập một địa chỉ email hợp lệ.");
                return; // Dừng việc thực hiện tiếp theo nếu email không hợp lệ
            }
            if (IsTaiKhoanExists(taiKhoan))
            {
                MessageBox.Show("Tên tài khoản đã tồn tại. Vui lòng nhập tên tài khoản khác.");
                return;
            }
            if (string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Mật khẩu không được bỏ trống !");
                return;
            }
            if (matKhau != xacnhanmatkhau)
            {
                MessageBox.Show("Mật khẩu và xác nhận mật khẩu không trùng khớp. Vui lòng nhập lại.");
                return; // Ngừng xử lý tiếp và không đăng ký
            }

            // Tạo chuỗi kết nối SQL từ chuỗi kết nối trong file App.config.
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

            // Tạo câu truy vấn SQL để chèn dữ liệu mới vào bảng KhachHang
            string query = "INSERT INTO KhachHang (TenKhachHang,NgaySinh, QueQuan, SoDienThoai, Email, MatKhau, TaiKhoan) VALUES (@TenKhachHang, @NgaySinh, @QueQuan, @SoDienThoai, @Email, @MatKhau, @TaiKhoan)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Tạo đối tượng SqlCommand để thực hiện truy vấn
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Thêm các tham số để tránh tấn công SQL Injection
                    command.Parameters.AddWithValue("@TenKhachHang", hoTen);
                    command.Parameters.AddWithValue("@NgaySinh", ngaysinh);
                    command.Parameters.AddWithValue("@QueQuan", quequan);
                    command.Parameters.AddWithValue("@SoDienThoai", soDienThoai);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@MatKhau", matKhau);
                    command.Parameters.AddWithValue("@TaiKhoan", taiKhoan);

                    // Thực hiện truy vấn Insert
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        // Đăng ký thành công
                        MessageBox.Show("Đăng ký thành công!");
                        // Đóng form đăng ký
                        this.Close();
                        frmdangnhap frmdangnhap = new frmdangnhap();
                        frmdangnhap.Show();
                    }
                    else
                    {
                        // Đăng ký thất bại
                        MessageBox.Show("Đăng ký thất bại!");
                    }
                }
            }
        }

        private void pictureBoxBackground_Click(object sender, EventArgs e)
        {

        }
    }
}
