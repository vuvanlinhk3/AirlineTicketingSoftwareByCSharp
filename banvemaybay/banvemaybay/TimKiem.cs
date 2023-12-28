using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace banvemaybay
{
    public partial class frmtimkiem : Form
    {

        public string TaiKhoanUserDaDangNhap { get; set; }
        public frmtimkiem()
        {
            InitializeComponent();
            
        }

        private void boxcancel_Click(object sender, EventArgs e)
        {
            Close();
            
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            // Lấy giá trị từ TextBox SanBayDi và SanBayDen
            string sanBayDi = txtSanBayDi.Text.Trim();
            string sanBayDen = txtSanBayDen.Text.Trim();

            if (!string.IsNullOrEmpty(sanBayDi) && !string.IsNullOrEmpty(sanBayDen))
            {
                // Tạo câu truy vấn SQL để truy xuất dữ liệu
                string query = "SELECT * FROM ChuyenBay WHERE SanBayDi = @SanBayDi AND SanBayDen = @SanBayDen";

                // Kết nối đến cơ sở dữ liệu
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    connection.Open();

                    // Tạo SqlCommand và thêm các tham số
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SanBayDi", sanBayDi);
                        command.Parameters.AddWithValue("@SanBayDen", sanBayDen);

                        // Sử dụng SqlDataAdapter để lấy dữ liệu từ SQL Server
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Kiểm tra xem có bản ghi nào được tìm thấy
                        if (dataTable.Rows.Count > 0)
                        {
                            // Hiển thị dữ liệu lên DataGridView
                            dtttchuyenbay.DataSource = dataTable;
                            MessageBox.Show("Đã xuất dữ liệu.");
                        }
                        else
                        {
                            // Không tìm thấy chuyến bay, hiển thị thông báo
                            MessageBox.Show("Không tìm thấy chuyến bay.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập cả sân bay đi và sân bay đến trước khi tìm kiếm.");
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtSanBayDi.Text = "";
            txtSanBayDen.Text = "";

            // Gán cho DataGridView một DataTable trống
            dtttchuyenbay.DataSource = new DataTable();
        }

        private void dtttchuyenbay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmtimkiem_Load(object sender, EventArgs e)
        {

        }

        private void txtSanBayDi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
