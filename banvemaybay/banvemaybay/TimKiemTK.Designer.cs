
namespace banvemaybay
{
    partial class frmquenmatkhau
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
            this.label1 = new System.Windows.Forms.Label();
            this.tboxsdt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.boxcancel = new System.Windows.Forms.Button();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.dtquenmatkhau = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtquenmatkhau)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vui lòng nhập số điện thoại để tìm kiếm";
            // 
            // tboxsdt
            // 
            this.tboxsdt.Location = new System.Drawing.Point(154, 84);
            this.tboxsdt.Name = "tboxsdt";
            this.tboxsdt.Size = new System.Drawing.Size(690, 20);
            this.tboxsdt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(364, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "QUÊN MẬT KHẨU";
            // 
            // boxcancel
            // 
            this.boxcancel.Location = new System.Drawing.Point(12, 12);
            this.boxcancel.Name = "boxcancel";
            this.boxcancel.Size = new System.Drawing.Size(78, 28);
            this.boxcancel.TabIndex = 28;
            this.boxcancel.Text = "<| Cancel";
            this.boxcancel.UseVisualStyleBackColor = true;
            this.boxcancel.Click += new System.EventHandler(this.boxcancel_Click);
            // 
            // btntimkiem
            // 
            this.btntimkiem.Location = new System.Drawing.Point(757, 110);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(87, 32);
            this.btntimkiem.TabIndex = 29;
            this.btntimkiem.Text = "Tìm Kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // dtquenmatkhau
            // 
            this.dtquenmatkhau.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtquenmatkhau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtquenmatkhau.Location = new System.Drawing.Point(154, 148);
            this.dtquenmatkhau.Name = "dtquenmatkhau";
            this.dtquenmatkhau.Size = new System.Drawing.Size(690, 229);
            this.dtquenmatkhau.TabIndex = 30;
            this.dtquenmatkhau.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtquenmatkhau_CellClick);
            // 
            // frmquenmatkhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 488);
            this.Controls.Add(this.dtquenmatkhau);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.boxcancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tboxsdt);
            this.Controls.Add(this.label1);
            this.Name = "frmquenmatkhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quên Mật Khẩu";
            this.Load += new System.EventHandler(this.frmquenmatkhau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtquenmatkhau)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxsdt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button boxcancel;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.DataGridView dtquenmatkhau;
    }
}