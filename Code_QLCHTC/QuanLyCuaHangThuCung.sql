use master
CREATE DATABASE QuanLyCuaHangThuCung
GO

CREATE TABLE TaiKhoan
(
	MaTK INT IDENTITY PRIMARY KEY,
	TenDangNhap NVARCHAR(100) NOT NULL,
	MatKhau NVARCHAR(1000) NOT NULL, 
	LoaiTK NVARCHAR(100) NOT NULL
)
GO

CREATE TABLE NhanVien
(
	MaNV INT IDENTITY PRIMARY KEY,
	MaTK INT NOT NULL,
	HoTenNV NVARCHAR(100) NOT NULL,
	NgaySinh DATE NOT NULL, 
	GioiTinh NVARCHAR(10) NOT NULL,
	SDT VARCHAR(50) NOT NULL,
	EMAIL NVARCHAR(100) NOT NULL,
	constraint fk_nv_MaTK
	foreign key(MaTK) references TaiKhoan(MaTK)
)
GO

CREATE TABLE KhachHang
(
	MaKH INT IDENTITY PRIMARY KEY,
	HoTenKH NVARCHAR(100) NOT NULL,
	NgaySinh DATE NOT NULL, 
	GioiTinh NVARCHAR(10) NOT NULL,
	SDT VARCHAR(50) NOT NULL,
	EMAIL NVARCHAR(100) NOT NULL,
	DiaChi NVARCHAR(200) NOT NULL
)
GO

CREATE TABLE SanPham
(
	MaSP INT IDENTITY PRIMARY KEY,
	TenSP NVARCHAR(100) NOT NULL,
	GiaSP FLOAT NOT NULL,
	KichThuocSP FLOAT,
	MoTaSP NVARCHAR(1000),
	MaLoaiSP INT NOT NULL,
	constraint fk_loaisp_MaLoaiSP
	foreign key(MaLoaiSP) references LoaiSP(MaLoaiSP)
)
GO

CREATE TABLE HinhSanPham
(
	MaHinh INT IDENTITY PRIMARY KEY,
	MoTaHinh NVARCHAR(100),
	MaSP INT NOT NULL,
	constraint fk_hsp_MaSP
	foreign key(MaSP) references SanPham(MaSP)
)
GO

CREATE TABLE LoaiSP
(
	MaLoaiSP INT IDENTITY PRIMARY KEY,
	TenLoaiSP NVARCHAR(200) NOT NULL
)
GO

CREATE TABLE HoaDonBan
(
	MaHD INT IDENTITY PRIMARY KEY,
	NgayGioMua DATE NOT NULL,
	MaNV INT NOT NULL,
	MaKH INT NOT NULL,
	constraint fk_hdb_MaNV
	foreign key(MaNV) references NhanVien(MaNV),
	constraint fk_hdb_MaKH
	foreign key(MaKH) references KhachHang(MaKH)
)
GO

CREATE TABLE ChiTietHDBan
(
	SoLuong INT NOT NULL,
	DonGia MONEY NOT NULL,
	TyLeGiamGia FLOAT,
	MaHD INT NOT NULL,MaSP INT NOT NULL,
	PRIMARY KEY(MaSP,MaHD),
	constraint fk_cthdb_MaSP
	foreign key(MaSP) references SanPham(MaSP),
	constraint fk_cthdb_MaHD
	foreign key(MaHD) references HoaDonBan(MaHD)
)
GO



