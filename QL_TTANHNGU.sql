
CREATE DATABASE QL_TTANHNGU
GO

USE QL_TTANHNGU
GO

CREATE TABLE ChiNhanh(
	MaCN nchar(10) CONSTRAINT PK_ChiNhanh PRIMARY KEY,
	TenCN nvarchar(50) NOT NULL,
	DiaChiCN nvarchar(100) NOT NULL
);
GO

CREATE TABLE NhanVien(
	MaNV nchar(10) CONSTRAINT PK_NhanVien PRIMARY KEY,
	HoTenNV nvarchar(50) NOT NULL,
	CCCD nchar(13) NOT NULL check (len(CCCD)=12),
	SoDT nchar(11) NOT NULL check (len(SoDT)=10),
	Luong float    NOT NULL check (Luong>0),
	MaCN nchar(10) CONSTRAINT FK_NhanVien_MaCN FOREIGN KEY REFERENCES ChiNhanh(MaCN)
);
GO

CREATE TABLE CongViec(
	MaCV nchar(10) CONSTRAINT PK_CongViec PRIMARY KEY,
	TenCV nvarchar(50) NOT NULL,
	MaNV nchar(10) CONSTRAINT FK_CongViec_MaNV FOREIGN KEY REFERENCES NhanVien(MaNV),
);
GO

CREATE TABLE ThiThu(
	MaTT nchar(10) CONSTRAINT PK_ThiThu PRIMARY KEY,
	PhongThi nchar(10) NOT NULL,
	NgayThi date NOT NULL check (DATEDIFF(day, NgayThi, GETDATE())<0),
	GioThi time NOT NULL,
	MaNV nchar(10) CONSTRAINT FK_ThiThu_MaNV FOREIGN KEY REFERENCES NhanVien(MaNV)
);
GO

CREATE TABLE HocVien(
	MaHV nchar(10) CONSTRAINT PK_HocVien PRIMARY KEY,
	HoTenHV nvarchar(50) NOT NULL,
	NgaySinh date NOT NULL check (DATEDIFF(year, NgaySinh, GETDATE())>=10),
	GioiTinh nvarchar(3),
	SoDT nchar(11) check (len(SoDT)=10),
	DiaChiHV nvarchar(100)
);
GO

CREATE TABLE GiangVien(
	MaGV nchar(10) CONSTRAINT PK_GiangVien PRIMARY KEY,
	HoTen nvarchar(50) NOT NULL,
	CCCD nchar(13) NOT NULL check (len(CCCD)=12),
	SoDT nchar(11) NOT NULL check (len(SoDT)=10),
	Luong float NOT NULL check(Luong>0)
);
GO

CREATE TABLE LopHoc(
	MaLH nchar(10) CONSTRAINT PK_LopHoc PRIMARY KEY,
	TenLH nvarchar(50) NOT NULL,
	TenPhongHoc nvarchar(10) NOT NULL,
	HocPhi float NOT NULL check (HocPhi>0),
	SoBuoiHoc int NOT NULL check (SoBuoiHoc>0),
	SoLuongHV int NOT NULL check (SoLuongHV>0),
	MaGV nchar(10) CONSTRAINT FK_LopHoc_MaGV FOREIGN KEY REFERENCES GiangVien(MaGV)
);
GO

CREATE TABLE HoaDon(
	MaHD nchar(10) CONSTRAINT PK_HoaDon PRIMARY KEY,
	NgayGD date NOT NULL check (DATEDIFF(day, NgayGD, GETDATE())>=0),
	SoTien float NOT NULL check (SoTien>0),
	MaHV nchar(10) CONSTRAINT FK_HoaDon_MaHV FOREIGN KEY REFERENCES HocVien(MaHV)
);
GO

CREATE TABLE ChiTietDK_TT(
	MaHV nchar(10) ,
	MaTT nchar(10),
	NgayDK date NOT NULL check (DATEDIFF(day, NgayDK, GETDATE())>=0),
	CONSTRAINT PK_ChiTietDK_TT PRIMARY KEY (MaHV,MaTT)
);
GO

CREATE TABLE ChiTietDK_LH(
	MaHV nchar(10),
	MaLH nchar(10),
	NgayDK date NOT NULL check (DATEDIFF(day, NgayDK, GETDATE())>=0),
	CONSTRAINT PK_ChiTietDK_LH PRIMARY KEY (MaHV,MaLH)
);
GO

