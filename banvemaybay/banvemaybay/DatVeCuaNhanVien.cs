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
    public partial class frmdatvenhanvien : Form
    {
        public string TaiKhoanEmployeeDaDangNhap { get; set; }

        public frmdatvenhanvien()
        {
            InitializeComponent();
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
                        ttcachuyenbayhientai.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void frmdatvenhanvien_Load(object sender, EventArgs e)
        {

            string TaiKhoan = txttenkhachhang.Text;
            frmkhachhanggiaodien frmkhachhanggiaodien = new frmkhachhanggiaodien();
            frmkhachhanggiaodien.TaiKhoanUserDaDangNhap = TaiKhoan;
            LoadDataIntoGridView();
            cbboxmachuyenbay.Items.Add("101");
            cbboxmachuyenbay.Items.Add("102");
            cbboxmachuyenbay.Items.Add("103");
            cbboxmachuyenbay.Items.Add("104");
            cbboxmachuyenbay.Items.Add("105");
            cbboxmachuyenbay.Items.Add("106");
            cbboxmachuyenbay.Items.Add("107");
            cbboxmachuyenbay.Items.Add("108");
            cbboxmachuyenbay.Items.Add("109");
            cbboxmachuyenbay.Items.Add("110");
            cbboxmachuyenbay.Items.Add("111");
            cbboxmachuyenbay.Items.Add("112");
            cbboxmachuyenbay.Items.Add("113");
            // loaive
            cbboxloaive.Items.Add("Thường");
            cbboxloaive.Items.Add("Thương Gia");
            //phuong thức thanh toán
            cboxsoghe.Items.Add("1");
            cboxsoghe.Items.Add("2");
            cboxsoghe.Items.Add("3");
            cboxsoghe.Items.Add("4");
            cboxsoghe.Items.Add("5");
            cboxsoghe.Items.Add("6");
            cboxsoghe.Items.Add("7");
            cboxsoghe.Items.Add("8");
            cboxsoghe.Items.Add("9");
            cboxsoghe.Items.Add("10");
            cboxsoghe.Items.Add("11");
            cboxsoghe.Items.Add("12");
            cboxsoghe.Items.Add("13");
            cboxsoghe.Items.Add("14");
            cboxsoghe.Items.Add("15");
            cboxsoghe.Items.Add("16");
            cboxsoghe.Items.Add("17");
            cboxsoghe.Items.Add("18");
            cboxsoghe.Items.Add("19");
            cboxsoghe.Items.Add("20");
            cboxsoghe.Items.Add("21");
            cboxsoghe.Items.Add("22");
            cboxsoghe.Items.Add("23");
            cbboxphuongthucthanhtoan.Items.Add("Tiền Mặt");
            //truy xuat sql

            // Kiểm tra xem đã có tài khoản đăng nhập hay chưa
            
        }
        private DataSet Data(string taiKhoan)
        {
            try
            {
                DataSet data = new DataSet();

                string query = @"SELECT UserID FROM KhachHang WHERE TaiKhoan = @TaiKhoan";

                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TaiKhoan", taiKhoan);

                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(data);
                }

                return data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return null;
            }
        }

        private void btndatve_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy các giá trị cần thiết từ người dùng hoặc các controls khác
                string selectedFlight = cbboxmachuyenbay.SelectedItem as string;
                string selectNote = tboxghichu.Text;
                string selectdatve = cboxsoghe.Text;

                    DateTime ngayMuaVe = DateTime.Now; // Ngày thực tế lúc đặt vé
                    string trangThai = "0";
                    string loaiVe = cbboxloaive.SelectedItem as string;
                    string giaVe = "0";
                    if (loaiVe != null)
                    {
                        if (loaiVe == "Thường")
                        {
                            giaVe = "GiaVeThuong";
                        }
                        else if (loaiVe == "Thương Gia")
                        {
                            giaVe = "GiaVeThuongGia";
                        }
                        // Thêm các điều kiện xác định giá vé cho các loại vé khác nếu cần
                    }
                    string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

                    int selectedUserID = 0;
                    string tenKhachHang = txttenkhachhang.Text;
                    

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        
                            // Thực hiện câu truy vấn INSERT
                            string query = "INSERT INTO Ve (FlightID, UserID,SoGhe, NgayMuaVe, TrangThai, LoaiVe, GhiChu) " +
                           "VALUES (@FlightID, @UserID,@SoGhe, @NgayMuaVe, @TrangThai, @LoaiVe, @GhiChu)";

                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@FlightID", selectedFlight);
                                command.Parameters.AddWithValue("@UserID", selectedUserID);
                                command.Parameters.AddWithValue("@NgayMuaVe", ngayMuaVe);
                                command.Parameters.AddWithValue("@TrangThai", trangThai);
                                command.Parameters.AddWithValue("@LoaiVe", giaVe);
                                command.Parameters.AddWithValue("@GhiChu","Tên Khách Hàng : " + tenKhachHang + "|"+ selectNote);
                                command.Parameters.AddWithValue("@SoGhe", selectdatve);

                                int rowsAffected = command.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show($"Đặt vé thành công cho khách hàng: {tenKhachHang}");
                                }
                                else
                                {
                                    MessageBox.Show("Đặt vé thất bại!");
                                }
                            }
                        
                    }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                Console.WriteLine(ex.Message);
            }
        }

        private void cbboxloaive_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFlight = cbboxmachuyenbay.SelectedItem.ToString();
            string selectedLoaiVe = cbboxloaive.SelectedItem.ToString();

            string query = "SELECT GiaVeThuongGia, GiaVeThuong FROM ChuyenBay WHERE FlightID = @FlightID";

            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@FlightID", selectedFlight);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    decimal giaVeThuongGia = reader.GetDecimal(0);
                    decimal giaVeThuong = reader.GetDecimal(1);

                    decimal giaTien = selectedLoaiVe == "Thường" ? giaVeThuong : giaVeThuongGia;

                    txtGiaTien.Text = giaTien.ToString("N2");
                }
                else
                {
                    // Xử lý khi không tìm thấy thông tin chuyến bay
                    MessageBox.Show("Không tìm thấy thông tin chuyến bay.");
                }
            }
        }

        private void boxcancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
