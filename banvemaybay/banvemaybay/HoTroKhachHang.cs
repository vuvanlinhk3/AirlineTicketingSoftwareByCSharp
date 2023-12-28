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
    public partial class frmhotrokhachhang : Form
    {
        public frmhotrokhachhang()
        {
            InitializeComponent();
        }

        private void pictureBoxBackground_Click(object sender, EventArgs e)
        {

        }

        private void lblthongtin_Click(object sender, EventArgs e)
        {

        }

        private void frmhotrokhachhang_Load(object sender, EventArgs e)
        {
            
        }

        private void btnhow_Click(object sender, EventArgs e)
        {
            string query = "SELECT Answer FROM ANSWER WHERE AnswerID = 1";

            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Sử dụng ExecuteScalar để lấy giá trị đơn giản từ cơ sở dữ liệu
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        // Chuyển đổi kết quả thành chuỗi và hiển thị trên Label
                        tboxthongtin.Text = result.ToString();
                        tboxthongtin.Multiline = true;
                        tboxthongtin.ScrollBars = ScrollBars.Both;

                    }
                    else
                    {
                        // Xử lý trường hợp không tìm thấy dữ liệu
                        tboxthongtin.Text = "Không tìm thấy dữ liệu";
                    }
                }
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnvande_Click(object sender, EventArgs e)
        {
            string query = "SELECT Answer FROM ANSWER WHERE AnswerID = 2";

            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Sử dụng ExecuteScalar để lấy giá trị đơn giản từ cơ sở dữ liệu
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        // Chuyển đổi kết quả thành chuỗi và hiển thị trên Label
                        tboxthongtin.Text = result.ToString();
                        tboxthongtin.Multiline = true;
                        tboxthongtin.ScrollBars = ScrollBars.Both;
                    }
                    else
                    {
                        // Xử lý trường hợp không tìm thấy dữ liệu
                        tboxthongtin.Text = "Không tìm thấy dữ liệu";
                    }
                }
            }
        }

        private void tboxthongtin_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncantranh_Click(object sender, EventArgs e)
        {
            string query = "SELECT Answer FROM ANSWER WHERE AnswerID = 3";

            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Sử dụng ExecuteScalar để lấy giá trị đơn giản từ cơ sở dữ liệu
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        // Chuyển đổi kết quả thành chuỗi và hiển thị trên Label
                        tboxthongtin.Text = result.ToString();
                        tboxthongtin.Multiline = true;
                        tboxthongtin.ScrollBars = ScrollBars.Both;
                    }
                    else
                    {
                        // Xử lý trường hợp không tìm thấy dữ liệu
                        tboxthongtin.Text = "Không tìm thấy dữ liệu";
                    }
                }
            }
        }

        private void btncacthutuc_Click(object sender, EventArgs e)
        {
            string query = "SELECT Answer FROM ANSWER WHERE AnswerID = 4";

            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Sử dụng ExecuteScalar để lấy giá trị đơn giản từ cơ sở dữ liệu
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        // Chuyển đổi kết quả thành chuỗi và hiển thị trên Label
                        tboxthongtin.Text = result.ToString();
                        tboxthongtin.Multiline = true;
                        tboxthongtin.ScrollBars = ScrollBars.Both;
                    }
                    else
                    {
                        // Xử lý trường hợp không tìm thấy dữ liệu
                        tboxthongtin.Text = "Không tìm thấy dữ liệu";
                    }
                }
            }
        }

        private void btnkhac_Click(object sender, EventArgs e)
        {
            // Đường dẫn trang web bạn muốn mở
            string websiteUrl = "https://vietjet.net/tin-tong-hop/nhung-cau-hoi-thuong-gap-khi-di-may-bay.html#:~:text=Nh%E1%BB%AFng%20c%C3%A2u%20h%E1%BB%8Fi%20th%C6%B0%E1%BB%9Dng%20g%E1%BA%B7p%20khi%20%C4%91i%20m%C3%A1y,tr%C6%B0%E1%BB%9Bc%20gi%E1%BB%9D%20bay%20bao%20l%C3%A2u%3F%20...%20More%20items";

            // Sử dụng Process.Start để mở trình duyệt web mặc định và truy cập đường dẫn trang web
            System.Diagnostics.Process.Start(websiteUrl);
        }

        private void btnlienhe_Click(object sender, EventArgs e)
        {
            string websiteUrl = "https://www.vietnamairlines.com/vn/vi/home";

            // Sử dụng Process.Start để mở trình duyệt web mặc định và truy cập đường dẫn trang web
            System.Diagnostics.Process.Start(websiteUrl);
        }
    }
}
