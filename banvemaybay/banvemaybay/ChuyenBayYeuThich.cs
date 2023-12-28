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
    public partial class frmchuyenbaylike : Form
    {
        public frmchuyenbaylike()
        {
            InitializeComponent();
        }

        private void boxcancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void viewchuyenbaylike_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void frmchuyenbaylike_Load(object sender, EventArgs e)
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
                        viewchuyenbaylike.DataSource = dataTable;
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
