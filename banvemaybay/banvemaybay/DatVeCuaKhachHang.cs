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
    public partial class frmdatve : Form
    {
        public string TaiKhoanUserDaDangNhap { get; set; }
        public string taikhoanid { get; set; }

        public frmdatve()
        {
            InitializeComponent();
        }

        private void btndatve_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy các giá trị cần thiết từ người dùng hoặc các controls khác
                string selectedFlight = cbboxmachuyenbay.SelectedItem as string;
                string selectNote = tboxghichu.Text;
                string selectdatve = cboxsoghe.Text;

                if (string.IsNullOrEmpty(TaiKhoanUserDaDangNhap))
                {
                    MessageBox.Show("Lỗi! Vui lòng đăng nhập trước khi đặt vé.");
                }
                else
                {
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

                    // Lấy UserID từ bảng KhachHang dựa vào Tài khoản
                    string queryUserID = "SELECT UserID, TenKhachHang FROM KhachHang WHERE TaiKhoan = @TaiKhoan";

                    string selectedUserID = null;
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        // Lấy UserID từ bảng KhachHang
                        using (SqlCommand commandUserID = new SqlCommand(queryUserID, connection))
                        {
                            commandUserID.Parameters.AddWithValue("@TaiKhoan", TaiKhoanUserDaDangNhap);
                            SqlDataReader reader = commandUserID.ExecuteReader();

                            if (reader.Read())
                            {
                                selectedUserID = reader["UserID"].ToString();
                            }
                            reader.Close();
                        }

                        if (!string.IsNullOrEmpty(selectedUserID))
                        {
                            // Thực hiện câu truy vấn INSERT
                            string insertQuery = "INSERT INTO Ve (FlightID, UserID, SoGhe, NgayMuaVe, TrangThai, LoaiVe, GhiChu) " +
                                "VALUES (@FlightID, @UserID, @SoGhe, @NgayMuaVe, @TrangThai, @LoaiVe, @GhiChu)";

                            using (SqlCommand command = new SqlCommand(insertQuery, connection))
                            {
                                command.Parameters.AddWithValue("@FlightID", selectedFlight);
                                command.Parameters.AddWithValue("@UserID", selectedUserID);
                                command.Parameters.AddWithValue("@NgayMuaVe", ngayMuaVe);
                                command.Parameters.AddWithValue("@TrangThai", trangThai);
                                command.Parameters.AddWithValue("@LoaiVe", giaVe);
                                command.Parameters.AddWithValue("@GhiChu", selectNote);
                                command.Parameters.AddWithValue("@SoGhe", selectdatve);

                                int rowsAffected = command.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Đặt vé thành công!");
                                    LayVaHienThiMaVeDat(TaiKhoanUserDaDangNhap);
                                    //btnnhanmave.Visible = true;
                                }
                                else
                                {
                                    MessageBox.Show("Đặt vé thất bại!");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy thông tin tài khoản.");
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
        private void LayVaHienThiMaVeDat( string TaiKhoanUserDaDangNhap)
        {
            try
            {
                string selectedFlight = cbboxmachuyenbay.SelectedItem as string;
                string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Tìm mã vé (TicketID) của vé vừa được đặt
                    string getTicketIDQuery = "SELECT TicketID FROM Ve WHERE UserID = (SELECT UserID FROM KhachHang WHERE TaiKhoan = @TaiKhoan) AND FlightID = @FlightID";

                    using (SqlCommand ticketIDCommand = new SqlCommand(getTicketIDQuery, connection))
                    {
                        ticketIDCommand.Parameters.AddWithValue("@TaiKhoan", TaiKhoanUserDaDangNhap);
                        ticketIDCommand.Parameters.AddWithValue("@FlightID", selectedFlight);
                        //ticketIDCommand.Parameters.AddWithValue("@NgayMuaVe", DateTime.Now);

                        object result = ticketIDCommand.ExecuteScalar();

                        if (result != null)
                        {
                            int ticketID = Convert.ToInt32(result);
                            MessageBox.Show($"Mã vé của bạn là: {ticketID}");
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy mã vé.");
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


        private void boxcancel_Click(object sender, EventArgs e)
        {
            Close();
            string TaiKhoan = TaiKhoanUserDaDangNhap;
            frmkhachhanggiaodien frmkhachhanggiaodien = new frmkhachhanggiaodien();
            frmkhachhanggiaodien.TaiKhoanUserDaDangNhap = TaiKhoan;
            //frmkhachhanggiaodien frmkhachhanggiaodien = new frmkhachhanggiaodien();
            frmkhachhanggiaodien.Show();
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

        private void LoadDataIntoComboBox()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    connection.Open();

                    // Lấy thời gian hiện tại
                    DateTime currentTime = DateTime.Now;

                    // Tạo câu truy vấn SQL với điều kiện thời gian khởi hành lớn hơn thời gian hiện tại
                    string query = "SELECT FlightID FROM ChuyenBay WHERE GioKhoiHanh > @CurrentTime";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Thêm tham số thời gian hiện tại vào câu truy vấn
                        command.Parameters.AddWithValue("@CurrentTime", currentTime);

                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            // Lấy mã chuyến bay từ dữ liệu và thêm vào combobox
                            string flightID = reader["FlightID"].ToString();
                            cbboxmachuyenbay.Items.Add(flightID);
                        }

                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void frmdatve_Load(object sender, EventArgs e)
        {
            string TaiKhoan = TaiKhoanUserDaDangNhap;
            frmkhachhanggiaodien frmkhachhanggiaodien = new frmkhachhanggiaodien();
            frmkhachhanggiaodien.TaiKhoanUserDaDangNhap = TaiKhoan;
            LoadDataIntoGridView();
            LoadDataIntoComboBox();
            // loaive
            cbboxloaive.Items.Add("Thường");
            cbboxloaive.Items.Add("Thương Gia");

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



            //phuong thức thanh toán
            cbboxphuongthucthanhtoan.Items.Add("Tiền Mặt");
            //truy xuat sql

            // Kiểm tra xem đã có tài khoản đăng nhập hay chưa
            if (!string.IsNullOrEmpty(TaiKhoanUserDaDangNhap))
            {
                // Gọi hàm để lấy dữ liệu chuyến bay dựa trên tài khoản đã đăng nhập
                DataSet ttData = Data(TaiKhoanUserDaDangNhap);

                if (ttData != null && ttData.Tables.Count > 0)
                {
                    taikhoanid = ttData.Tables[0].Rows[0]["UserID"].ToString();
                   // MessageBox.Show(taikhoanid);
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu chuyến bay cho tài khoản này.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng đăng nhập trước khi sử dụng tính năng này.");
            }

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

        private void cbboxmachuyenbay_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Hiển thị tất cả các tùy chọn cho loại vé và số ghế
            cbboxloaive.Visible = true;
            cboxsoghe.Visible = true;
        }
        private void cbboxloaive_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFlight = cbboxmachuyenbay.SelectedItem.ToString();

            //if (string.IsNullOrEmpty(selectedFlight))
            //{
                //txtGiaTien.Text = string.Empty;
            //}
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
                connection.Close();
            }
        }

        private void btnnhanmave_Click(object sender, EventArgs e)
        {
            //LayVaHienThiMaVeDat(TaiKhoanUserDaDangNhap);

        }
    }
}
