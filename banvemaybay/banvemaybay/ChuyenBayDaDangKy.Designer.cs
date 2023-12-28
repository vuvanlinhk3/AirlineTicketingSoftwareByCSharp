
namespace banvemaybay
{
    partial class frmchuyenbaydadangky
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.boxcancel = new System.Windows.Forms.Button();
            this.btnlaydulieu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chuyến Bay Bạn Đã Đặt Là : ";
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(16, 40);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(772, 370);
            this.dataGridView.TabIndex = 1;
            // 
            // boxcancel
            // 
            this.boxcancel.Location = new System.Drawing.Point(12, 416);
            this.boxcancel.Name = "boxcancel";
            this.boxcancel.Size = new System.Drawing.Size(78, 28);
            this.boxcancel.TabIndex = 27;
            this.boxcancel.Text = "<| Cancel";
            this.boxcancel.UseVisualStyleBackColor = true;
            this.boxcancel.Click += new System.EventHandler(this.boxcancel_Click);
            // 
            // btnlaydulieu
            // 
            this.btnlaydulieu.Location = new System.Drawing.Point(234, 7);
            this.btnlaydulieu.Name = "btnlaydulieu";
            this.btnlaydulieu.Size = new System.Drawing.Size(94, 25);
            this.btnlaydulieu.TabIndex = 28;
            this.btnlaydulieu.Text = "Click Vao Đây";
            this.btnlaydulieu.UseVisualStyleBackColor = true;
            this.btnlaydulieu.Click += new System.EventHandler(this.btnlaydulieu_Click);
            // 
            // frmchuyenbaydadangky
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnlaydulieu);
            this.Controls.Add(this.boxcancel);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label1);
            this.Name = "frmchuyenbaydadangky";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách chuyến bay đã đăng ký";
            this.Load += new System.EventHandler(this.frmchuyenbaydadangky_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button boxcancel;
        private System.Windows.Forms.Button btnlaydulieu;
    }
}