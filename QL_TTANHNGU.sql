
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
	on delete set null 
	on update cascade
);
GO

CREATE TABLE CongViec(
	MaCV nchar(10) CONSTRAINT PK_CongViec PRIMARY KEY,
	TenCV nvarchar(50) NOT NULL,
	MaNV nchar(10) CONSTRAINT FK_CongViec_MaNV FOREIGN KEY REFERENCES NhanVien(MaNV)
	on delete set null 
	on update cascade
);

GO

CREATE TABLE ThiThu(
	MaTT nchar(10) CONSTRAINT PK_ThiThu PRIMARY KEY,
	PhongThi nchar(10) NOT NULL,
	NgayThi date NOT NULL check (DATEDIFF(day, NgayThi, GETDATE())<0),
	GioThi time NOT NULL,
	MaNV nchar(10) CONSTRAINT FK_ThiThu_MaNV FOREIGN KEY REFERENCES NhanVien(MaNV)
	on delete set null 
	on update cascade
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

insert into HocVien values('HV01','Minh Tai', '2003-10-21', 'Nam','0326344***','so 1 VVN');

CREATE TABLE GiangVien(
	MaGV nchar(10) CONSTRAINT PK_GiangVien PRIMARY KEY,
	HoTen nvarchar(50) NOT NULL,
	CCCD nchar(13) NOT NULL check (len(CCCD)=12),
	SoDT nchar(11) NOT NULL check (len(SoDT)=10),
	Luong float NOT NULL check(Luong>0)
);
GO

insert into GiangVien values('GV01', 'Nguyen Van A', '07712345****','0123456789',1000);

CREATE TABLE LopHoc(
	MaLH nchar(10) CONSTRAINT PK_LopHoc PRIMARY KEY,
	TenLH nvarchar(50) NOT NULL,
	TenPhongHoc nvarchar(10) NOT NULL,
	HocPhi float NOT NULL check (HocPhi>0),
	SoBuoiHoc int NOT NULL check (SoBuoiHoc>0),
	SoLuongHV int NOT NULL check (SoLuongHV>0),
	MaGV nchar(10) CONSTRAINT FK_LopHoc_MaGV FOREIGN KEY REFERENCES GiangVien(MaGV)
	/*on delete set null 
	on update cascade*/
);
GO
insert into LopHoc values ('TCB01','Nang cao','P01',200,42,30,'GV01');


/*Dự định thêm 1 bảng ChiTietCaDay*/

/*========================================================================================================*/
/*
CREATE TABLE ChiTiet_CaDay(
	MaLH nchar(10) CONSTRAINT FK_CaDay_MaLH FOREIGN KEY REFERENCES LopHoc(MaLH),
	MaGV nchar(10) CONSTRAINT FK_CaDay_MaGV FOREIGN KEY REFERENCES GiangVien(MaGV),
	NgayBatDau date,
	NgayKetThuc date,
	CaDay nchar(5),
	CONSTRAINT PK_ChiTietCaDay PRIMARY KEY (MaLH,MaGV)
);

===========================================================================================================
*/

CREATE TABLE HoaDon(
	MaHD nchar(10) CONSTRAINT PK_HoaDon PRIMARY KEY,
	NgayGioGD date NOT NULL check (DATEDIFF(day, NgayGioGD, GETDATE())>=0),
	SoTien float NOT NULL check (SoTien>0),
	MaHV nchar(10) CONSTRAINT FK_HoaDon_MaHV FOREIGN KEY REFERENCES HocVien(MaHV)
	on delete set null 
	on update cascade
);
GO
/*
alter table HoaDon drop constraint FK_HoaDon_MaHV
alter table HoaDon add constraint FK_HoaDon_MaHV FOREIGN KEY (MaHV) REFERENCES  HocVien(MaHV) 
	on delete set null 
	on update cascade;
*/

insert into HoaDon values('HD01','2023-07-15',250,'HV01');

CREATE TABLE ChiTietDK_TT(
	MaHV nchar(10) CONSTRAINT FK_DKTT_MaHV FOREIGN KEY REFERENCES HocVien(MaHV),
	MaTT nchar(10),
	NgayDK date NOT NULL check (DATEDIFF(day, NgayDK, GETDATE())>=0),
	CONSTRAINT PK_ChiTietDK_TT PRIMARY KEY (MaHV,MaTT)
);
/*Thêm khoá ngoại cho bảng ChiTietDK_TT*/
/*
ALTER TABLE ChiTietDK_TT 
ADD CONSTRAINT FK_DKTT_MaHV FOREIGN KEY(MaHV)  REFERENCES HocVien(MaHV); 
*/

GO

CREATE TABLE ChiTietDK_LH(
	MaHV nchar(10) CONSTRAINT FK_DKLH_MaHV FOREIGN KEY REFERENCES HocVien(MaHV),
	MaLH nchar(10) CONSTRAINT FK_DKLH_MaLH FOREIGN KEY REFERENCES LopHoc(MaLH),
	NgayDK date NOT NULL check (DATEDIFF(day, NgayDK, GETDATE())>=0),
	CONSTRAINT PK_ChiTietDK_LH PRIMARY KEY (MaHV,MaLH)
);

/*Thêm khoá ngoại cho bảng ChiTietDK_LH*/
/*
ALTER TABLE ChiTietDK_LH ADD CONSTRAINT FK_DKLH_MaHV FOREIGN KEY(MaHV)  REFERENCES HocVien(MaHV);
ALTER TABLE ChiTietDK_LH ADD CONSTRAINT FK_DKLH_MaLH FOREIGN KEY(MaLH)  REFERENCES LopHoc(MaLH);
*/

GO
insert into ChiTietDK_LH values ('HV03', 'TCB01','2023-07-10');

/*Kiểm tra lúc nhân viên sai sót nhập tiền thiếu hoặc dư*/

CREATE TRIGGER KiemTraTienHD
ON HoaDon
AFTER INSERT
AS
BEGIN
    DECLARE @MaHD nchar(10);
    DECLARE @MaLH nchar(10);
    DECLARE @SoTien float;
    DECLARE @HocPhi float;
	DECLARE @MaHV nchar(10);

    SELECT @MaHD = i.MaHD, @MaLH = c.MaLH, @SoTien = i.SoTien, @HocPhi = l.HocPhi, @MaHV= c.MaHV
    FROM inserted i
    INNER JOIN ChiTietDK_LH c ON i.MaHV = c.MaHV
    INNER JOIN LopHoc l ON c.MaLH = l.MaLH;

    IF (@SoTien < @HocPhi)
    BEGIN
        DECLARE @ErrorMessage NVARCHAR(1000);
        SET @ErrorMessage = 'Phai dong du ' + CAST(@SoTien AS NVARCHAR) + ' moi duoc in hoa don cho hoc vien ' + @MaHV + 'lop '+@MaLH;
        PRINT(@ErrorMessage);
        ROLLBACK TRANSACTION;
    END;
	 IF (@SoTien > @HocPhi)
    BEGIN
        DECLARE @ErrorMessage1 NVARCHAR(1000);
		DECLARE @TienDu float;
		
		SET @TienDu = @SoTien-@HocPhi;
		SET @ErrorMessage1 = 'Hoc vien '+@MaHV + 'lop '+@MaLH+' dong du ' + CAST(@TienDu AS NVARCHAR);
        PRINT(@ErrorMessage1);
        ROLLBACK TRANSACTION;
    END;
END;
 
/*Trigger kiểm tra sau khi nhập học viên thì thông báo chỗ còn trống, hoặc thông báo chỗ đầy*/

CREATE TRIGGER TinhSoCho_ConDu
ON ChiTietDK_LH
AFTER INSERT
AS 
BEGIN
	
	DECLARE @TongSoCho int;
	DECLARE @SoChoDaDK int;
	DECLARE @MaLH nchar(10);

	SELECT @TongSoCho = Lh.SoLuongHV from LopHoc LH;
	SELECT @MaLH=DKLH.MaLH,@SoChoDaDK=COUNT(DKLH.MaHV) from ChiTietDK_LH DKLH  group by DKLH.MaLH;

	IF(@SoChoDaDK < @TongSoCho)
		BEGIN 
			DECLARE @SoChoDu int;
			SET @SoChoDu = @TongSoCho - @SoChoDaDK;
			DECLARE @ThongBao NVARCHAR(1000);
			SET @ThongBao = 'Lớp '+ @MaLH +' còn dư '+CAST(@SoChoDu AS NVARCHAR)+' chỗ trống';
			PRINT(@ThongBao);
		END;
	IF(@SoChoDaDK = @TongSoCho)
		BEGIN 
			DECLARE @ThongBao1 NVARCHAR(1000);
			SET @ThongBao1 = 'Lớp '+ @MaLH +' đã đủ học viên';
			PRINT(@ThongBao1);
		END;
	IF(@SoChoDaDK > @TongSoCho)
		BEGIN 
			DECLARE @ThongBao2 NVARCHAR(1000);
			SET @ThongBao2 = 'Lớp '+ @MaLH +' đã đủ học viên vui lòng xếp học viên vào lớp khác';
			PRINT(@ThongBao2);
		END;
END
