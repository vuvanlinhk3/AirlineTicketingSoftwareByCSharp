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

    public partial class frmdangnhap : Form
    {
        public string TaiKhoanUserDaDangNhap { get; set; }
        public string TaiKhoanEmployeeDaDangNhap { get; set; }
        public frmdangnhap()
        {
            InitializeComponent();
            cbboxluachon.Items.Add("Khách Hàng");
            cbboxluachon.Items.Add("Nhân Viên");
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            string luachon = cbboxluachon.SelectedItem as string; // Đảm bảo ép kiểu về string

            if (luachon != null)
            {
                // Tiếp tục xử lý dựa trên giá trị luachon
                string username = txtuser.Text;
                string password = txtmatkhau.Text;

                // Tạo chuỗi kết nối SQL
                string connectionString = @"Data Source=DESKTOP-ISILHCP;Initial Catalog=SQLquanly;Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Xác định bảng dữ liệu cần truy vấn dựa trên lựa chọn của người dùng
                    string tableName = (luachon == "Khách Hàng") ? "KhachHang" : "NhanVien";

                    // Kiểm tra thông tin đăng nhập
                    string query = $"SELECT * FROM {tableName} WHERE TaiKhoan = @Username AND MatKhau = @Password";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {

                        if (luachon == "Khách Hàng")
                        {
                            frmkhachhanggiaodien frmkhachhanggiaodien = new frmkhachhanggiaodien();
                            frmkhachhanggiaodien.TaiKhoanUserDaDangNhap = username;
                            TaiKhoanUserDaDangNhap = username;
                            frmchuyenbaydadangky frmchuyenbaydadangky = new frmchuyenbaydadangky();
                            frmchuyenbaydadangky.TaiKhoanUserDaDangNhap = username;
                            frmttkhachhang frmttkhachhang = new frmttkhachhang();
                            frmttkhachhang.TaiKhoanUserDaDangNhap = username;
                            frmdatve frmdatve = new frmdatve();
                            frmdatve.TaiKhoanUserDaDangNhap = username;
                            frmtimkiem frmtimkiem = new frmtimkiem();
                            frmtimkiem.TaiKhoanUserDaDangNhap = username;
                            frmkhachhanggiaodien.Show();
                            
                            
                        }
                        else
                        {
                           frmnhanviengiaodien frmnhanviengiaodien =new frmnhanviengiaodien();
                            TaiKhoanEmployeeDaDangNhap = username;
                            frmnhanviengiaodien.TaiKhoanEmployeeDaDangNhap = username;
                            frmnhanviengiaodien.Show();
                        }
                        // Đóng form đăng nhập
                        this.Hide();
                    }
                    else
                    {
                        // Đăng nhập thất bại
                        MessageBox.Show("Bạn đã nhập sai Tài Khoản Hoặc Mật Khẩu\nVui lòng bạn nhập lại !");
                    }
                   
                    reader.Close();
                }
            }
            else
            {
                // Xử lý khi không có mục nào được chọn
                MessageBox.Show("Vui lòng chọn loại người dùng !");
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Close();
            frmtrangdau frmtrangdau = new frmtrangdau();
            frmtrangdau.Show();
        }

        private void lblldangki_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            frmdangky frmdangky = new frmdangky();
            frmdangky.Show();
            this.Hide();
        }

        private void lbllquenmatkhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmquenmatkhau frmquenmatkhau = new frmquenmatkhau();
            frmquenmatkhau.Show();
            this.Hide();
        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmdangnhap_Load(object sender, EventArgs e)
        {

        }
    }
}
