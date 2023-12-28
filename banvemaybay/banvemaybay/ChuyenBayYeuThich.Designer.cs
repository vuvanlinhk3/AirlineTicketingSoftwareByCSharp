
namespace banvemaybay
{
    partial class frmchuyenbaylike
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmchuyenbaylike));
            this.viewchuyenbaylike = new System.Windows.Forms.DataGridView();
            this.pictureBoxBackground = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.boxcancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.viewchuyenbaylike)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // viewchuyenbaylike
            // 
            this.viewchuyenbaylike.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewchuyenbaylike.Location = new System.Drawing.Point(58, 100);
            this.viewchuyenbaylike.Name = "viewchuyenbaylike";
            this.viewchuyenbaylike.Size = new System.Drawing.Size(676, 278);
            this.viewchuyenbaylike.TabIndex = 0;
            this.viewchuyenbaylike.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewchuyenbaylike_CellContentClick);
            // 
            // pictureBoxBackground
            // 
            this.pictureBoxBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxBackground.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBackground.Image")));
            this.pictureBoxBackground.Location = new System.Drawing.Point(-3, 51);
            this.pictureBoxBackground.Name = "pictureBoxBackground";
            this.pictureBoxBackground.Size = new System.Drawing.Size(806, 399);
            this.pictureBoxBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBackground.TabIndex = 94;
            this.pictureBoxBackground.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 24);
            this.label1.TabIndex = 95;
            this.label1.Text = "Các chuyến bay được đánh giá 5 sao";
            // 
            // boxcancel
            // 
            this.boxcancel.Location = new System.Drawing.Point(12, 9);
            this.boxcancel.Name = "boxcancel";
            this.boxcancel.Size = new System.Drawing.Size(78, 28);
            this.boxcancel.TabIndex = 96;
            this.boxcancel.Text = "<| Cancel";
            this.boxcancel.UseVisualStyleBackColor = true;
            this.boxcancel.Click += new System.EventHandler(this.boxcancel_Click);
            // 
            // frmchuyenbaylike
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.boxcancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewchuyenbaylike);
            this.Controls.Add(this.pictureBoxBackground);
            this.Name = "frmchuyenbaylike";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chuyến Bay Yêu Thích";
            this.Load += new System.EventHandler(this.frmchuyenbaylike_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewchuyenbaylike)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView viewchuyenbaylike;
        private System.Windows.Forms.PictureBox pictureBoxBackground;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button boxcancel;
    }
}