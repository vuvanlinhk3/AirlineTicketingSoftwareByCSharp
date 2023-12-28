
namespace banvemaybay
{
    partial class frmcachuyenbaysaptoi
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
            this.btnlaydulieu = new System.Windows.Forms.Button();
            this.boxcancel = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnlaydulieu
            // 
            this.btnlaydulieu.Location = new System.Drawing.Point(198, 7);
            this.btnlaydulieu.Name = "btnlaydulieu";
            this.btnlaydulieu.Size = new System.Drawing.Size(94, 25);
            this.btnlaydulieu.TabIndex = 32;
            this.btnlaydulieu.Text = "Cập nhật";
            this.btnlaydulieu.UseVisualStyleBackColor = true;
            // 
            // boxcancel
            // 
            this.boxcancel.Location = new System.Drawing.Point(12, 416);
            this.boxcancel.Name = "boxcancel";
            this.boxcancel.Size = new System.Drawing.Size(78, 28);
            this.boxcancel.TabIndex = 31;
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
            this.dataGridView.Size = new System.Drawing.Size(772, 370);
            this.dataGridView.TabIndex = 30;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Các chuyến bay sắp tới :";
            // 
            // frmcachuyenbaysaptoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnlaydulieu);
            this.Controls.Add(this.boxcancel);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label1);
            this.Name = "frmcachuyenbaysaptoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chuyến Bay Sắp Tới";
            this.Load += new System.EventHandler(this.CacChuyenBaySapToi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnlaydulieu;
        private System.Windows.Forms.Button boxcancel;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label1;
    }
}