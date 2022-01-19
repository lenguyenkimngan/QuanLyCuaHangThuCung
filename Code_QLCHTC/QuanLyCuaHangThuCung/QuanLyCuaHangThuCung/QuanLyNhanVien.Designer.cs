namespace QuanLyCuaHangThuCung
{
    partial class QuanLyNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyNhanVien));
            this.lbDMNV = new System.Windows.Forms.Label();
            this.pnDMNV = new System.Windows.Forms.Panel();
            this.pBQuayLai = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gBChucNang = new System.Windows.Forms.GroupBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lbTimKiem = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.gBHTNV = new System.Windows.Forms.GroupBox();
            this.dGNhanVien = new System.Windows.Forms.DataGridView();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.gbTTNV = new System.Windows.Forms.GroupBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDC = new System.Windows.Forms.TextBox();
            this.txtDT = new System.Windows.Forms.TextBox();
            this.txtGioiTinh = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lbNgaySinh = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.lbSDT = new System.Windows.Forms.Label();
            this.lbGioiTinh = new System.Windows.Forms.Label();
            this.lbMaNV = new System.Windows.Forms.Label();
            this.pnDMNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBQuayLai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gBChucNang.SuspendLayout();
            this.gBHTNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGNhanVien)).BeginInit();
            this.gbTTNV.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbDMNV
            // 
            this.lbDMNV.AutoSize = true;
            this.lbDMNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(217)))), ((int)(((byte)(196)))));
            this.lbDMNV.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDMNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.lbDMNV.Location = new System.Drawing.Point(431, 11);
            this.lbDMNV.Name = "lbDMNV";
            this.lbDMNV.Size = new System.Drawing.Size(402, 43);
            this.lbDMNV.TabIndex = 0;
            this.lbDMNV.Text = "DANH MỤC NHÂN VIÊN";
            this.lbDMNV.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnDMNV
            // 
            this.pnDMNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(178)))), ((int)(((byte)(151)))));
            this.pnDMNV.Controls.Add(this.pBQuayLai);
            this.pnDMNV.Controls.Add(this.lbDMNV);
            this.pnDMNV.Controls.Add(this.pictureBox1);
            this.pnDMNV.Location = new System.Drawing.Point(1, 1);
            this.pnDMNV.Name = "pnDMNV";
            this.pnDMNV.Size = new System.Drawing.Size(1299, 60);
            this.pnDMNV.TabIndex = 1;
            // 
            // pBQuayLai
            // 
            this.pBQuayLai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(217)))), ((int)(((byte)(196)))));
            this.pBQuayLai.Image = global::QuanLyCuaHangThuCung.Properties.Resources.left;
            this.pBQuayLai.Location = new System.Drawing.Point(24, 11);
            this.pBQuayLai.Name = "pBQuayLai";
            this.pBQuayLai.Size = new System.Drawing.Size(57, 40);
            this.pBQuayLai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBQuayLai.TabIndex = 2;
            this.pBQuayLai.TabStop = false;
            this.pBQuayLai.Click += new System.EventHandler(this.pBQuayLai_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::QuanLyCuaHangThuCung.Properties.Resources.icon_petshop;
            this.pictureBox1.Location = new System.Drawing.Point(1191, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // gBChucNang
            // 
            this.gBChucNang.Controls.Add(this.btnSua);
            this.gBChucNang.Controls.Add(this.btnThoat);
            this.gBChucNang.Controls.Add(this.btnThem);
            this.gBChucNang.Controls.Add(this.btnXoa);
            this.gBChucNang.Controls.Add(this.lbTimKiem);
            this.gBChucNang.Controls.Add(this.txtTimKiem);
            this.gBChucNang.Font = new System.Drawing.Font("Open Sans SemiBold", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBChucNang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.gBChucNang.Location = new System.Drawing.Point(776, 91);
            this.gBChucNang.Name = "gBChucNang";
            this.gBChucNang.Size = new System.Drawing.Size(448, 334);
            this.gBChucNang.TabIndex = 3;
            this.gBChucNang.TabStop = false;
            this.gBChucNang.Text = "Chức năng";
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Roboto Medium", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.btnSua.Location = new System.Drawing.Point(257, 42);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(160, 65);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "SỬA";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Roboto Medium", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.btnThoat.Location = new System.Drawing.Point(257, 144);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(160, 65);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Roboto Medium", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.btnThem.Location = new System.Drawing.Point(62, 45);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(160, 65);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "THÊM";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Roboto Medium", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.btnXoa.Location = new System.Drawing.Point(62, 147);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(160, 65);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lbTimKiem
            // 
            this.lbTimKiem.AutoSize = true;
            this.lbTimKiem.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(87)))), ((int)(((byte)(91)))));
            this.lbTimKiem.Location = new System.Drawing.Point(27, 268);
            this.lbTimKiem.Name = "lbTimKiem";
            this.lbTimKiem.Size = new System.Drawing.Size(118, 27);
            this.lbTimKiem.TabIndex = 0;
            this.lbTimKiem.Text = "TÌM KIẾM :";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTimKiem.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.ForeColor = System.Drawing.Color.Teal;
            this.txtTimKiem.Location = new System.Drawing.Point(151, 267);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(281, 25);
            this.txtTimKiem.TabIndex = 1;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // gBHTNV
            // 
            this.gBHTNV.Controls.Add(this.dGNhanVien);
            this.gBHTNV.Font = new System.Drawing.Font("Open Sans SemiBold", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBHTNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.gBHTNV.Location = new System.Drawing.Point(25, 455);
            this.gBHTNV.Name = "gBHTNV";
            this.gBHTNV.Size = new System.Drawing.Size(1251, 469);
            this.gBHTNV.TabIndex = 4;
            this.gBHTNV.TabStop = false;
            this.gBHTNV.Text = "Hiển thị nhân viên";
            // 
            // dGNhanVien
            // 
            this.dGNhanVien.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dGNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGNhanVien.Location = new System.Drawing.Point(6, 42);
            this.dGNhanVien.Name = "dGNhanVien";
            this.dGNhanVien.RowTemplate.Height = 28;
            this.dGNhanVien.Size = new System.Drawing.Size(1239, 421);
            this.dGNhanVien.TabIndex = 0;
            this.dGNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dDNhanVien_CellClick);
            // 
            // lbHoTen
            // 
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(87)))), ((int)(((byte)(91)))));
            this.lbHoTen.Location = new System.Drawing.Point(22, 53);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(100, 27);
            this.lbHoTen.TabIndex = 0;
            this.lbHoTen.Text = "HỌ TÊN :";
            // 
            // txtHoTen
            // 
            this.txtHoTen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHoTen.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.ForeColor = System.Drawing.Color.Teal;
            this.txtHoTen.Location = new System.Drawing.Point(162, 52);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(281, 25);
            this.txtHoTen.TabIndex = 1;
            // 
            // gbTTNV
            // 
            this.gbTTNV.Controls.Add(this.dtpNgaySinh);
            this.gbTTNV.Controls.Add(this.txtEmail);
            this.gbTTNV.Controls.Add(this.txtDC);
            this.gbTTNV.Controls.Add(this.txtDT);
            this.gbTTNV.Controls.Add(this.txtGioiTinh);
            this.gbTTNV.Controls.Add(this.txtMaNV);
            this.gbTTNV.Controls.Add(this.txtHoTen);
            this.gbTTNV.Controls.Add(this.lbNgaySinh);
            this.gbTTNV.Controls.Add(this.lbEmail);
            this.gbTTNV.Controls.Add(this.lbDiaChi);
            this.gbTTNV.Controls.Add(this.lbSDT);
            this.gbTTNV.Controls.Add(this.lbGioiTinh);
            this.gbTTNV.Controls.Add(this.lbMaNV);
            this.gbTTNV.Controls.Add(this.lbHoTen);
            this.gbTTNV.Font = new System.Drawing.Font("Open Sans SemiBold", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTTNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.gbTTNV.Location = new System.Drawing.Point(25, 83);
            this.gbTTNV.Name = "gbTTNV";
            this.gbTTNV.Size = new System.Drawing.Size(717, 342);
            this.gbTTNV.TabIndex = 2;
            this.gbTTNV.TabStop = false;
            this.gbTTNV.Text = "Thông tin nhân viên";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CalendarForeColor = System.Drawing.Color.Teal;
            this.dtpNgaySinh.CalendarTitleBackColor = System.Drawing.Color.White;
            this.dtpNgaySinh.CalendarTitleForeColor = System.Drawing.Color.Teal;
            this.dtpNgaySinh.CalendarTrailingForeColor = System.Drawing.Color.Teal;
            this.dtpNgaySinh.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(207, 299);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(171, 27);
            this.dtpNgaySinh.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Teal;
            this.txtEmail.Location = new System.Drawing.Point(162, 252);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(435, 25);
            this.txtEmail.TabIndex = 4;
            // 
            // txtDC
            // 
            this.txtDC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDC.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDC.ForeColor = System.Drawing.Color.Teal;
            this.txtDC.Location = new System.Drawing.Point(162, 192);
            this.txtDC.Name = "txtDC";
            this.txtDC.Size = new System.Drawing.Size(435, 25);
            this.txtDC.TabIndex = 4;
            // 
            // txtDT
            // 
            this.txtDT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDT.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDT.ForeColor = System.Drawing.Color.Teal;
            this.txtDT.Location = new System.Drawing.Point(162, 148);
            this.txtDT.Name = "txtDT";
            this.txtDT.Size = new System.Drawing.Size(281, 25);
            this.txtDT.TabIndex = 3;
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGioiTinh.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGioiTinh.ForeColor = System.Drawing.Color.Teal;
            this.txtGioiTinh.Location = new System.Drawing.Point(162, 101);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Size = new System.Drawing.Size(281, 25);
            this.txtGioiTinh.TabIndex = 2;
            // 
            // txtMaNV
            // 
            this.txtMaNV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaNV.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.ForeColor = System.Drawing.Color.Teal;
            this.txtMaNV.Location = new System.Drawing.Point(590, 52);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(107, 25);
            this.txtMaNV.TabIndex = 1;
            // 
            // lbNgaySinh
            // 
            this.lbNgaySinh.AutoSize = true;
            this.lbNgaySinh.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgaySinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(87)))), ((int)(((byte)(91)))));
            this.lbNgaySinh.Location = new System.Drawing.Point(22, 300);
            this.lbNgaySinh.Name = "lbNgaySinh";
            this.lbNgaySinh.Size = new System.Drawing.Size(138, 27);
            this.lbNgaySinh.TabIndex = 0;
            this.lbNgaySinh.Text = "NGÀY SINH :";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(87)))), ((int)(((byte)(91)))));
            this.lbEmail.Location = new System.Drawing.Point(22, 250);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(87, 27);
            this.lbEmail.TabIndex = 0;
            this.lbEmail.Text = "EMAIL :";
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiaChi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(87)))), ((int)(((byte)(91)))));
            this.lbDiaChi.Location = new System.Drawing.Point(22, 193);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(100, 27);
            this.lbDiaChi.TabIndex = 0;
            this.lbDiaChi.Text = "ĐỊA CHỈ :";
            // 
            // lbSDT
            // 
            this.lbSDT.AutoSize = true;
            this.lbSDT.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSDT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(87)))), ((int)(((byte)(91)))));
            this.lbSDT.Location = new System.Drawing.Point(22, 149);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(64, 27);
            this.lbSDT.TabIndex = 0;
            this.lbSDT.Text = "SĐT :";
            // 
            // lbGioiTinh
            // 
            this.lbGioiTinh.AutoSize = true;
            this.lbGioiTinh.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGioiTinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(87)))), ((int)(((byte)(91)))));
            this.lbGioiTinh.Location = new System.Drawing.Point(22, 102);
            this.lbGioiTinh.Name = "lbGioiTinh";
            this.lbGioiTinh.Size = new System.Drawing.Size(121, 27);
            this.lbGioiTinh.TabIndex = 0;
            this.lbGioiTinh.Text = "GIỚI TÍNH :";
            // 
            // lbMaNV
            // 
            this.lbMaNV.AutoSize = true;
            this.lbMaNV.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(87)))), ((int)(((byte)(91)))));
            this.lbMaNV.Location = new System.Drawing.Point(495, 53);
            this.lbMaNV.Name = "lbMaNV";
            this.lbMaNV.Size = new System.Drawing.Size(89, 27);
            this.lbMaNV.TabIndex = 0;
            this.lbMaNV.Text = "Mã NV :";
            // 
            // QuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1288, 930);
            this.Controls.Add(this.gBHTNV);
            this.Controls.Add(this.gBChucNang);
            this.Controls.Add(this.gbTTNV);
            this.Controls.Add(this.pnDMNV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QuanLyNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanLyNhanVien";
            this.Load += new System.EventHandler(this.QuanLyNhanVien_Load);
            this.pnDMNV.ResumeLayout(false);
            this.pnDMNV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBQuayLai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gBChucNang.ResumeLayout(false);
            this.gBChucNang.PerformLayout();
            this.gBHTNV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGNhanVien)).EndInit();
            this.gbTTNV.ResumeLayout(false);
            this.gbTTNV.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbDMNV;
        private System.Windows.Forms.Panel pnDMNV;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pBQuayLai;
        private System.Windows.Forms.GroupBox gBChucNang;
        private System.Windows.Forms.GroupBox gBHTNV;
        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.GroupBox gbTTNV;
        private System.Windows.Forms.TextBox txtDC;
        private System.Windows.Forms.TextBox txtDT;
        private System.Windows.Forms.TextBox txtGioiTinh;
        private System.Windows.Forms.Label lbNgaySinh;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.Label lbSDT;
        private System.Windows.Forms.Label lbGioiTinh;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dGNhanVien;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label lbMaNV;
        private System.Windows.Forms.Label lbTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
    }
}