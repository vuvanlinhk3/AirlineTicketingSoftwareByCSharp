
namespace banvemaybay
{
    partial class frmhuyve
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
            this.btnhuyve = new System.Windows.Forms.Button();
            this.boxcancel = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.lblchuenbaydadat = new System.Windows.Forms.Label();
            this.cbboxmachuyenbay = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnhuyve
            // 
            this.btnhuyve.Location = new System.Drawing.Point(674, 399);
            this.btnhuyve.Name = "btnhuyve";
            this.btnhuyve.Size = new System.Drawing.Size(94, 39);
            this.btnhuyve.TabIndex = 1;
            this.btnhuyve.Text = "Hủy Vé";
            this.btnhuyve.UseVisualStyleBackColor = true;
            this.btnhuyve.Click += new System.EventHandler(this.btnhuyve_Click);
            // 
            // boxcancel
            // 
            this.boxcancel.Location = new System.Drawing.Point(12, 416);
            this.boxcancel.Name = "boxcancel";
            this.boxcancel.Size = new System.Drawing.Size(78, 28);
            this.boxcancel.TabIndex = 2;
            this.boxcancel.Text = "<| Cancel";
            this.boxcancel.UseVisualStyleBackColor = true;
            this.boxcancel.Click += new System.EventHandler(this.boxcancel_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(16, 40);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(772, 264);
            this.dataGridView.TabIndex = 30;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // lblchuenbaydadat
            // 
            this.lblchuenbaydadat.AutoSize = true;
            this.lblchuenbaydadat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblchuenbaydadat.Location = new System.Drawing.Point(12, 9);
            this.lblchuenbaydadat.Name = "lblchuenbaydadat";
            this.lblchuenbaydadat.Size = new System.Drawing.Size(216, 20);
            this.lblchuenbaydadat.TabIndex = 29;
            this.lblchuenbaydadat.Text = "Chuyến Bay Bạn Đã Đặt Là : ";
            // 
            // cbboxmachuyenbay
            // 
            this.cbboxmachuyenbay.FormattingEnabled = true;
            this.cbboxmachuyenbay.Location = new System.Drawing.Point(661, 338);
            this.cbboxmachuyenbay.Name = "cbboxmachuyenbay";
            this.cbboxmachuyenbay.Size = new System.Drawing.Size(121, 21);
            this.cbboxmachuyenbay.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(652, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 16);
            this.label2.TabIndex = 34;
            this.label2.Text = "Chọn Mã Chuyến Bay";
            // 
            // frmhuyve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbboxmachuyenbay);
            this.Controls.Add(this.btnhuyve);
            this.Controls.Add(this.boxcancel);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.lblchuenbaydadat);
            this.Name = "frmhuyve";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Trang Hủy Vé";
            this.Load += new System.EventHandler(this.frmhuyve_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnhuyve;
        private System.Windows.Forms.Button boxcancel;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label lblchuenbaydadat;
        private System.Windows.Forms.ComboBox cbboxmachuyenbay;
        private System.Windows.Forms.Label label2;
    }
}