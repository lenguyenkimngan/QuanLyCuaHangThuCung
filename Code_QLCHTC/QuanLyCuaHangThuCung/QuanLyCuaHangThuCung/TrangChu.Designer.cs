namespace QuanLyCuaHangThuCung
{
    partial class TrangChu
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
            this.lbTenPM = new System.Windows.Forms.Label();
            this.pBMuiTen = new System.Windows.Forms.PictureBox();
            this.btnTiepTuc = new System.Windows.Forms.Button();
            this.pBThongTin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBMuiTen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBThongTin)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTenPM
            // 
            this.lbTenPM.AutoSize = true;
            this.lbTenPM.BackColor = System.Drawing.Color.Transparent;
            this.lbTenPM.Font = new System.Drawing.Font("Courier New", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenPM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.lbTenPM.Location = new System.Drawing.Point(89, 262);
            this.lbTenPM.Name = "lbTenPM";
            this.lbTenPM.Size = new System.Drawing.Size(606, 128);
            this.lbTenPM.TabIndex = 0;
            this.lbTenPM.Text = "PHẦN MỀM QUẢN LÝ \r\nCỬA HÀNG THÚ CƯNG";
            // 
            // pBMuiTen
            // 
            this.pBMuiTen.BackColor = System.Drawing.Color.Transparent;
            this.pBMuiTen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pBMuiTen.Image = global::QuanLyCuaHangThuCung.Properties.Resources.right_arrow;
            this.pBMuiTen.Location = new System.Drawing.Point(231, 458);
            this.pBMuiTen.Name = "pBMuiTen";
            this.pBMuiTen.Size = new System.Drawing.Size(100, 50);
            this.pBMuiTen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBMuiTen.TabIndex = 1;
            this.pBMuiTen.TabStop = false;
            this.pBMuiTen.Click += new System.EventHandler(this.pBMuiTen_Click);
            // 
            // btnTiepTuc
            // 
            this.btnTiepTuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.btnTiepTuc.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTiepTuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.btnTiepTuc.Location = new System.Drawing.Point(353, 458);
            this.btnTiepTuc.Name = "btnTiepTuc";
            this.btnTiepTuc.Size = new System.Drawing.Size(164, 50);
            this.btnTiepTuc.TabIndex = 2;
            this.btnTiepTuc.Text = "TIẾP TỤC";
            this.btnTiepTuc.UseVisualStyleBackColor = false;
            this.btnTiepTuc.Click += new System.EventHandler(this.btnTiepTuc_Click);
            // 
            // pBThongTin
            // 
            this.pBThongTin.BackColor = System.Drawing.Color.Transparent;
            this.pBThongTin.Image = global::QuanLyCuaHangThuCung.Properties.Resources.thongtin;
            this.pBThongTin.Location = new System.Drawing.Point(578, 565);
            this.pBThongTin.Name = "pBThongTin";
            this.pBThongTin.Size = new System.Drawing.Size(45, 39);
            this.pBThongTin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBThongTin.TabIndex = 3;
            this.pBThongTin.TabStop = false;
            this.pBThongTin.Click += new System.EventHandler(this.pBThongTin_Click);
            // 
            // TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::QuanLyCuaHangThuCung.Properties.Resources.job562_nunoon_10_a;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(783, 783);
            this.Controls.Add(this.pBThongTin);
            this.Controls.Add(this.btnTiepTuc);
            this.Controls.Add(this.pBMuiTen);
            this.Controls.Add(this.lbTenPM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TrangChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrangChu";
            this.Load += new System.EventHandler(this.TrangChu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBMuiTen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBThongTin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTenPM;
        private System.Windows.Forms.PictureBox pBMuiTen;
        private System.Windows.Forms.Button btnTiepTuc;
        private System.Windows.Forms.PictureBox pBThongTin;
    }
}