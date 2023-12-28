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
    public partial class frmcachuyenbaysaptoi : Form
    {
        public frmcachuyenbaysaptoi()
        {
            InitializeComponent();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadDataIntoGridView()
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
                        dataGridView.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void CacChuyenBaySapToi_Load(object sender, EventArgs e)
        {
            LoadDataIntoGridView();

        }

        private void boxcancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
