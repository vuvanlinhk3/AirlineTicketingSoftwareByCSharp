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
    public partial class frmquenmatkhau : Form
    {
        private bool isAccountFound = false;
        private string selectedPhoneNumber = "";
        public frmquenmatkhau()
        {
            InitializeComponent();
        }

        private void boxcancel_Click(object sender, EventArgs e)
        {
            Close();
            frmdangnhap frmdangnhap = new frmdangnhap();
            frmdangnhap.Show();
        }
        private void btntimkiem_Click(object sender, EventArgs e)
        {
            // Đọc số điện thoại từ TextBox
            string soDienThoai = tboxsdt.Text.Trim();

            if (!string.IsNullOrEmpty(soDienThoai))
            {
                // Tạo câu truy vấn SQL để lấy thông tin từ số điện thoại
                string query = "SELECT TenKhachHang, SoDienThoai, Email " +
        "FROM KhachHang WHERE SoDienThoai LIKE @SoDienThoai";

                // Kết nối đến cơ sở dữ liệu
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    connection.Open();

                    // Tạo SqlCommand và thêm tham số
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Thêm tham số với giá trị "LIKE" để tìm kiếm các số điện thoại chứa phần chuỗi được nhập
                        command.Parameters.AddWithValue("@SoDienThoai", "%" + soDienThoai + "%");

                        // Sử dụng SqlDataAdapter để lấy dữ liệu từ SQL Server
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Kiểm tra xem có tài khoản nào được tìm thấy không
                        isAccountFound = dataTable.Rows.Count > 0;
                        if (!isAccountFound)
                        {
                            //selectedPhoneNumber = dataTable.Rows[0]["SoDienThoai"].ToString();
                            MessageBox.Show("Không Tìm Thấy Tài Khoản !");
                        }
                        // Hiển thị dữ liệu lên DataGridView hoặc các điều kiện hiển thị khác
                        dtquenmatkhau.DataSource = dataTable;
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số điện thoại trước khi tìm kiếm.");
            }
        }

        private void dtquenmatkhau_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && isAccountFound)
            {

                if (e.ColumnIndex == dtquenmatkhau.Columns["ChonTaiKhoan"].Index)
                {

                    // Tạo ô dạng nút "Chọn Tài Khoản" cho các hàng
                    DataGridViewButtonCell selectAccountButton = new DataGridViewButtonCell();
                    selectAccountButton.Value = "Chọn Tài Khoản";
                    dtquenmatkhau.Rows[e.RowIndex].Cells[e.ColumnIndex] = selectAccountButton;
                }
            }
        }
        private void dtquenmatkhau_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dtquenmatkhau.Columns["ChonTaiKhoan"].Index)
            {
                // Lấy số điện thoại từ hàng được chọn
                selectedPhoneNumber = dtquenmatkhau.Rows[e.RowIndex].Cells["SoDienThoai"].Value.ToString();

                // Chuyển sang form DoiMatKhau và truyền số điện thoại đã chọn
                frmdoimatkhau frmdoimatkhau = new frmdoimatkhau(selectedPhoneNumber);
                frmdoimatkhau.ShowDialog();
                this.Hide();
            }
        }

        private void frmquenmatkhau_Load(object sender, EventArgs e)
        {
            // Tạo cột nút "Chọn Tài Khoản"
            DataGridViewButtonColumn selectAccountColumn = new DataGridViewButtonColumn();
            selectAccountColumn.Name = "ChonTaiKhoan";
            selectAccountColumn.Text = "Chọn Tài Khoản";
            selectAccountColumn.UseColumnTextForButtonValue = true; // Đặt giá trị cột là văn bản của nút

            // Thêm cột nút vào DataGridView
            dtquenmatkhau.Columns.Add(selectAccountColumn);

            // selectAccountColumn.DefaultCellStyle.BackColor = Color.Green; // Đặt màu nền của cột nút
            // selectAccountColumn.DefaultCellStyle.ForeColor = Color.White; // Đặt màu văn bản của cột nút
        }
    }
}
