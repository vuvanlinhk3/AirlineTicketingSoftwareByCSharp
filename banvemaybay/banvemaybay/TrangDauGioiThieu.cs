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
    public partial class frmtrangdau : Form
    {
        public frmtrangdau()
        {
            InitializeComponent();
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            frmdangnhap frmdangnhap = new frmdangnhap();
            frmdangnhap.Show();
            this.Hide();
        }

        private void btndangky_Click(object sender, EventArgs e)
        {
            frmdangky frmdangky = new frmdangky();
            frmdangky.Show();
            this.Hide();
        }

        private void boxcancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tboxdatve_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hãy Đăng Nhập Để Sử Dụng !");
        }

        private void tboxchuyenbaylink_Click(object sender, EventArgs e)
        {
            frmchuyenbaylike frmchuyenbaylike = new frmchuyenbaylike();
            frmchuyenbaylike.Show();
        }

        private void tboxseach_Click(object sender, EventArgs e)
        {
            frmtimkiem frmtimkiem = new frmtimkiem();
            frmtimkiem.Show();
        }

        private void tboxchenbayhientai_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hãy Đăng Nhập Để Sử Dụng !");
        }

        private void btnttchuyenbay_Click(object sender, EventArgs e)
        {
            //frmcachuyenbaysaptoi frmcachuyenbaysaptoi = new frmcachuyenbaysaptoi();
            //frmcachuyenbaysaptoi.Show();
            MessageBox.Show("Hãy Đăng Nhập Để Sử Dụng !");
        }

        private void tboxhotrokachhang_Click(object sender, EventArgs e)
        {
            frmhotrokhachhang frmhotrokhachhang = new frmhotrokhachhang();
            frmhotrokhachhang.Show();
        }

        private void picturelinkhttp_Click(object sender, EventArgs e)
        {
            string websiteUrl = "https://www.vietnamairlines.com/vn/vi/home";

            // Sử dụng Process.Start để mở trình duyệt web mặc định và truy cập đường dẫn trang web
            System.Diagnostics.Process.Start(websiteUrl);
        }
    }
}
