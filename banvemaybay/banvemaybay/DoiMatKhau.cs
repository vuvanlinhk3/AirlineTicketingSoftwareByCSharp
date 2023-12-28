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
using System.Net;
using System.Net.Mail;

namespace banvemaybay
{
    public partial class frmdoimatkhau : Form
    {
        private string phoneNumber;
        private string maXacThuc;
        private string emailprivate;
        private bool daXacThuc = false;
        public frmdoimatkhau()
        {
            InitializeComponent();
        }
        public frmdoimatkhau(string phoneNumber) : this()
        {
            // Lưu số điện thoại vào biến thành viên phoneNumber
            this.phoneNumber = phoneNumber;
        }
       
        private void frmdoimatkhau_Load(object sender, EventArgs e)
        {
            tentaikhoan();
            sodienthoai();
            email();
        }

        private void boxcancel_Click(object sender, EventArgs e)
        {
            Close();
            frmquenmatkhau frmquenmatkhau = new frmquenmatkhau();
            frmquenmatkhau.Show();

        }
        private void tentaikhoan()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    connection.Open();

                    // Tạo câu truy vấn SQL
                    string query = "SELECT TenKhachHang FROM KhachHang WHERE SoDienThoai = @SoDienThoai";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Đặt giá trị tham số @UserID tại đây (chẳng hạn là ID của người dùng cụ thể)
                        command.Parameters.AddWithValue("@SoDienThoai", phoneNumber);

                        string tenKhachHang = command.ExecuteScalar()?.ToString();

                        // Gán tên người dùng vào Label
                        lbltaikhoan.Text = tenKhachHang;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void sodienthoai()
        {
            try
            {
                lblsodienthoai.Text = phoneNumber;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void email()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    connection.Open();

                    // Tạo câu truy vấn SQL
                    string query = "SELECT Email FROM KhachHang WHERE SoDienThoai = @SoDienThoai";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Đặt giá trị tham số @UserID tại đây (chẳng hạn là ID của người dùng cụ thể)
                        command.Parameters.AddWithValue("@SoDienThoai", phoneNumber);

                        string tenKhachHang = command.ExecuteScalar()?.ToString();

                        // Gán tên người dùng vào Label
                        lblemail.Text = tenKhachHang;
                        emailprivate = lblemail.Text;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void GuiEmailXacThuc(string diaChiEmail, string maXacThuc)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com");
                client.Port = 587;
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential("Nhap ten email cua ban", "Nhap mat khau cua ban"); // Điền email và mật khẩu của bạn ở đây

                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress("shutupxpts@gmail.com");
                mailMessage.To.Add(diaChiEmail);
                mailMessage.Subject = "Mã Xác Thực";
                mailMessage.Body = "Mã xác thực email của bạn là: " + maXacThuc;

                client.Send(mailMessage);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi gửi email: " + ex.Message);
                Console.WriteLine(ex.Message);
            }
        }
        private void btnxacthuc_Click(object sender, EventArgs e)
        {
            // Lấy mã xác thực mà người dùng nhập
            string maXacThucNhap = tboxxacthucemail.Text.Trim();

            // So sánh mã xác thực nhập với mã xác thực đã gửi
            if (maXacThucNhap == maXacThuc)
            {
                MessageBox.Show("Xác thực thành công.");
                daXacThuc = true;
            }
            else
            {
                MessageBox.Show("Mã xác thực không đúng. Vui lòng thử lại.");
            }
        }
        // Thêm sự kiện Click cho lblguima
        private void lblguima_Click(object sender, EventArgs e)
        {
            string diaChiEmail = emailprivate.Trim();
            //MessageBox.Show(diaChiEmail);

            if (string.IsNullOrWhiteSpace(diaChiEmail))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ email.");
                return;
            }

            // Tạo mã xác thực ngẫu nhiên (ví dụ: chuỗi 6 ký tự)
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            maXacThuc = new string(Enumerable.Repeat(chars, 6)
                .Select(s => s[random.Next(s.Length)]).ToArray());

            // Lưu mã xác thực để so sánh sau này
            maXacThuc = maXacThuc.ToUpper(); // Đảm bảo mã xác thực in hoa

            // Gửi mã xác thực qua email
            GuiEmailXacThuc(diaChiEmail, maXacThuc);

            // Thông báo cho người dùng biết rằng mã xác thực đã được gửi
            MessageBox.Show("Mã xác thực đã được gửi qua email. Vui lòng kiểm tra hộp thư đến của bạn.");
        }

        private void btndoimatkhau_Click(object sender, EventArgs e)
        {
            // Lấy mật khẩu mới và xác nhận mật khẩu mới
            string matKhauMoi = txtmatkhaumoi.Text.Trim();
            string xacNhanMatKhauMoi = txtxacnhanmatkhaumoi.Text.Trim();

            if (daXacThuc)
            {
                // Kiểm tra xem hai mật khẩu mới có khớp nhau không
                if (matKhauMoi == xacNhanMatKhauMoi && !string.IsNullOrEmpty(matKhauMoi))
                {
                    // Kết nối đến cơ sở dữ liệu và thực hiện truy vấn
                    using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                    {
                        connection.Open();

                        // Thực hiện câu truy vấn để cập nhật mật khẩu dựa trên số điện thoại và điều kiện xác thực
                        string query = "UPDATE KhachHang SET MatKhau = @MatKhau WHERE SoDienThoai = @SoDienThoai";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@MatKhau", matKhauMoi);
                            command.Parameters.AddWithValue("@SoDienThoai", phoneNumber); // Thay thế phoneNumber bằng số điện thoại từ người dùng

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Đổi mật khẩu thành công.");
                                frmdangnhap frmdangnhap = new frmdangnhap();
                                frmdangnhap.Show();
                                Close();
                            }
                            else
                            {
                                MessageBox.Show("Đổi mật khẩu thất bại hoặc tài khoản chưa được xác thực.");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Xác nhận mật khẩu không khớp hoặc mật khẩu mới rỗng. Vui lòng thử lại.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng xác thực gmail trước khi đổi mật khẩu.");
            }

        }
    }
}
