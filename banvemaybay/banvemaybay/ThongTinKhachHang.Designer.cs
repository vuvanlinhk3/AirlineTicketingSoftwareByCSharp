
namespace banvemaybay
{
    partial class frmttkhachhang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.boxcancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sQLquanlyDataSet = new banvemaybay.SQLquanlyDataSet();
            this.sQLquanlyDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblthongtinkhachhang = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lblbirthday = new System.Windows.Forms.Label();
            this.lblhotline = new System.Windows.Forms.Label();
            this.lbladress = new System.Windows.Forms.Label();
            this.lblmail = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQLquanlyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQLquanlyDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // boxcancel
            // 
            this.boxcancel.Location = new System.Drawing.Point(12, 12);
            this.boxcancel.Name = "boxcancel";
            this.boxcancel.Size = new System.Drawing.Size(78, 28);
            this.boxcancel.TabIndex = 26;
            this.boxcancel.Text = "<| Cancel";
            this.boxcancel.UseVisualStyleBackColor = true;
            this.boxcancel.Click += new System.EventHandler(this.boxcancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(434, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Trang Thông Tin Cá Nhân";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::banvemaybay.Properties.Resources.background;
            this.pictureBox1.Location = new System.Drawing.Point(1, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1118, 218);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // sQLquanlyDataSet
            // 
            this.sQLquanlyDataSet.DataSetName = "SQLquanlyDataSet";
            this.sQLquanlyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sQLquanlyDataSetBindingSource
            // 
            this.sQLquanlyDataSetBindingSource.DataSource = this.sQLquanlyDataSet;
            this.sQLquanlyDataSetBindingSource.Position = 0;
            // 
            // lblthongtinkhachhang
            // 
            this.lblthongtinkhachhang.BackColor = System.Drawing.Color.White;
            this.lblthongtinkhachhang.Location = new System.Drawing.Point(270, 264);
            this.lblthongtinkhachhang.Name = "lblthongtinkhachhang";
            this.lblthongtinkhachhang.Size = new System.Drawing.Size(585, 364);
            this.lblthongtinkhachhang.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(379, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Họ Và tên : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(379, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Ngày Sinh : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(379, 430);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "Số Điện Thoại : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(378, 482);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 32;
            this.label5.Text = "Quê Quán : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(379, 536);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 33;
            this.label6.Text = "Email : ";
            // 
            // lblname
            // 
            this.lblname.BackColor = System.Drawing.Color.White;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(538, 319);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(268, 23);
            this.lblname.TabIndex = 34;
            this.lblname.Text = "name";
            // 
            // lblbirthday
            // 
            this.lblbirthday.BackColor = System.Drawing.Color.White;
            this.lblbirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbirthday.Location = new System.Drawing.Point(538, 372);
            this.lblbirthday.Name = "lblbirthday";
            this.lblbirthday.Size = new System.Drawing.Size(90, 23);
            this.lblbirthday.TabIndex = 35;
            this.lblbirthday.Text = "birthday";
            // 
            // lblhotline
            // 
            this.lblhotline.BackColor = System.Drawing.Color.White;
            this.lblhotline.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhotline.Location = new System.Drawing.Point(538, 430);
            this.lblhotline.Name = "lblhotline";
            this.lblhotline.Size = new System.Drawing.Size(256, 23);
            this.lblhotline.TabIndex = 36;
            this.lblhotline.Text = "hotline";
            // 
            // lbladress
            // 
            this.lbladress.BackColor = System.Drawing.Color.White;
            this.lbladress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladress.Location = new System.Drawing.Point(537, 482);
            this.lbladress.Name = "lbladress";
            this.lbladress.Size = new System.Drawing.Size(257, 23);
            this.lbladress.TabIndex = 37;
            this.lbladress.Text = "adress";
            // 
            // lblmail
            // 
            this.lblmail.BackColor = System.Drawing.Color.White;
            this.lblmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmail.Location = new System.Drawing.Point(538, 536);
            this.lblmail.Name = "lblmail";
            this.lblmail.Size = new System.Drawing.Size(256, 23);
            this.lblmail.TabIndex = 38;
            this.lblmail.Text = "gmail";
            // 
            // frmttkhachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 637);
            this.Controls.Add(this.lblmail);
            this.Controls.Add(this.lbladress);
            this.Controls.Add(this.lblhotline);
            this.Controls.Add(this.lblbirthday);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblthongtinkhachhang);
            this.Controls.Add(this.boxcancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "frmttkhachhang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Thông Tin";
            this.Load += new System.EventHandler(this.frmttkhachhang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQLquanlyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQLquanlyDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button boxcancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private SQLquanlyDataSet sQLquanlyDataSet;
        private System.Windows.Forms.BindingSource sQLquanlyDataSetBindingSource;
        private System.Windows.Forms.Label lblthongtinkhachhang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblbirthday;
        private System.Windows.Forms.Label lblhotline;
        private System.Windows.Forms.Label lbladress;
        private System.Windows.Forms.Label lblmail;
    }
}