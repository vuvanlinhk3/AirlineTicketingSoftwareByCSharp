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
    public partial class frmkhachhanggiaodien : Form
    {
        public string TaiKhoanUserDaDangNhap { get; set; }

        public frmkhachhanggiaodien()
        {
            InitializeComponent();
        }

        private void tboxdatve_Click(object sender, EventArgs e)
        {
            Close();
            string TaiKhoan = TaiKhoanUserDaDangNhap;
            frmdatve frmdatve = new frmdatve();
            frmdatve.TaiKhoanUserDaDangNhap = TaiKhoan;
            frmdatve.Show();
        }

        private void tboxqlttcn_Click(object sender, EventArgs e)
        {
            Close();
            string TaiKhoan = TaiKhoanUserDaDangNhap;
            frmttkhachhang frmttkhachhang = new frmttkhachhang();
            frmttkhachhang.TaiKhoanUserDaDangNhap = TaiKhoan;
            frmttkhachhang.ShowDialog();
        }

        private void tboxdangxuat_Click(object sender, EventArgs e)
        {
            Close();
            frmdangnhap frmdangnhap = new frmdangnhap();
            frmdangnhap.TaiKhoanUserDaDangNhap = null;
            frmdangnhap.Show();
        }

        private void tboxseach_Click(object sender, EventArgs e)
        {
            frmtimkiem frmtimkiem = new frmtimkiem();
            frmtimkiem.Show();
            //this.Hide();
        }

        private void btnttchuyenbay_Click(object sender, EventArgs e)
        {
            string TaiKhoan = TaiKhoanUserDaDangNhap;
            frmchuyenbaydadangky frmchuyenbaydadangky = new frmchuyenbaydadangky();
            frmchuyenbaydadangky.TaiKhoanUserDaDangNhap = TaiKhoan;
            //frmchuyenbaydadangky frmchuyenbaydadangky = new frmchuyenbaydadangky();
            frmchuyenbaydadangky.Show();
        }

        private void frmkhachhanggiaodien_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(TaiKhoanUserDaDangNhap);
            string TaiKhoan = TaiKhoanUserDaDangNhap;
            TaiKhoanUserDaDangNhap = TaiKhoan;
            frmdangnhap frmdangnhap = new frmdangnhap();
        }

        private void tboxchuyenbaylink_Click(object sender, EventArgs e)
        {
            frmchuyenbaylike frmchuyenbaylike = new frmchuyenbaylike();
            frmchuyenbaylike.Show();
        }

        private void picturelinkhttp_Click(object sender, EventArgs e)
        {
            string websiteUrl = "https://www.vietnamairlines.com/vn/vi/home";

            // Sử dụng Process.Start để mở trình duyệt web mặc định và truy cập đường dẫn trang web
            System.Diagnostics.Process.Start(websiteUrl);
        }

        private void btnhuyve_Click(object sender, EventArgs e)
        {
            string taikhoan = TaiKhoanUserDaDangNhap;
            frmhuyve frmhuyve = new frmhuyve();
            frmhuyve.TaiKhoanUserDaDangNhap = taikhoan;
            frmhuyve.Show();
        }

        private void tboxchenbayhientai_Click(object sender, EventArgs e)
        {
            frmcachuyenbaysaptoi frmcachuyenbaysaptoi = new frmcachuyenbaysaptoi();
            frmcachuyenbaysaptoi.Show();
        }

        private void tboxlichsu_Click(object sender, EventArgs e)
        {
            string taikhoan = TaiKhoanUserDaDangNhap;
            frmchuyenbaydadangky frmchuyenbaydadangky = new frmchuyenbaydadangky();
            frmchuyenbaydadangky.TaiKhoanUserDaDangNhap = taikhoan;
            frmchuyenbaydadangky.Show();
        }
    }
}
