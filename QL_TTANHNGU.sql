﻿CREATE DATABASE QL_TTANHNGU
GO

USE QL_TTANHNGU
GO

CREATE TABLE ChiNhanh(
	MaCN nchar(10) CONSTRAINT PK_ChiNhanh PRIMARY KEY,
	TenCN nvarchar(50) NOT NULL,
	DiaChiCN nvarchar(100) NOT NULL
);
GO

insert into ChiNhanh values ('CN01','Chi Nhanh 1 PMP','34 Ho Thi Tu');
go

CREATE TABLE NhanVien(
	MaNV nchar(10) CONSTRAINT PK_NhanVien PRIMARY KEY,
	HoTenNV nvarchar(50) NOT NULL,
	CCCD nchar(13) NOT NULL check (len(CCCD)=12),
	SoDT nchar(11) NOT NULL check (len(SoDT)=10),
	Luong float    NOT NULL check (Luong>0),
	MaCN nchar(10) CONSTRAINT FK_NhanVien_MaCN FOREIGN KEY REFERENCES ChiNhanh(MaCN) 
	on delete set null 
	on update cascade,
	MaQL nchar(10) CONSTRAINT FK_NhanVien_MaQL FOREIGN KEY REFERENCES NhanVien(MaNV)
);
GO

INSERT INTO NhanVien VALUES ('NV01','Nguyen Thi A', '123456789101', '0123456789',300,'CN01');
go

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
	GioiHan int NOT NULL,
	MaNV nchar(10) CONSTRAINT FK_ThiThu_MaNV FOREIGN KEY REFERENCES NhanVien(MaNV)
	on delete set null 
	on update cascade
);

GO

INSERT INTO ThiThu VALUES ('TT02','P01','2023-10-15','08:30','NV01');
go 

CREATE TABLE HocVien(
	MaHV nchar(10) CONSTRAINT PK_HocVien PRIMARY KEY,
	HoTenHV nvarchar(50) NOT NULL,
	NgaySinh date NOT NULL check (DATEDIFF(year, NgaySinh, GETDATE())>=10),
	GioiTinh nvarchar(3),
	SoDT nchar(11) check (len(SoDT)=10),
	DiaChiHV nvarchar(100)
);
GO
CREATE TABLE ChiTietDK_TT(
	MaHV nchar(10) CONSTRAINT FK_DKTT_MaHV FOREIGN KEY REFERENCES HocVien(MaHV),
	MaTT nchar(10) CONSTRAINT FK_DKTT_MaTT FOREIGN KEY REFERENCES ThiThu(MaTT),
	NgayDK date NOT NULL check (DATEDIFF(day, NgayDK, GETDATE())>=0),
	CONSTRAINT PK_ChiTietDK_TT PRIMARY KEY (MaHV,MaTT)
);
GO

insert into HocVien values('HV02','Minh Tai', '2003-10-21', 'Nam','0326344***','so 1 VVN');

GO

CREATE TABLE GiangVien(
	MaGV nchar(10) CONSTRAINT PK_GiangVien PRIMARY KEY,
	HoTen nvarchar(50) NOT NULL,
	CCCD nchar(13) NOT NULL check (len(CCCD)=12),
	SoDT nchar(11) NOT NULL check (len(SoDT)=10),
	Luong float NOT NULL check(Luong>0)
);
GO

insert into GiangVien values('GV01', 'Nguyen Van A', '07712345****','0123456789',1000);
GO

CREATE TABLE ChiTiet_CaDay(
	MaLH nchar(10) CONSTRAINT FK_CaDay_MaLH FOREIGN KEY REFERENCES LopHoc(MaLH),
	MaGV nchar(10) CONSTRAINT FK_CaDay_MaGV FOREIGN KEY REFERENCES GiangVien(MaGV),
	NgayBatDau date NOT NULL,
	NgayKetThuc date NOT NULL,
	CaDay nchar(10) NOT NULL,
	CONSTRAINT PK_ChiTietCaDay PRIMARY KEY (MaLH,MaGV)
);
GO

CREATE TABLE LopHoc(
	MaLH nchar(10) CONSTRAINT PK_LopHoc PRIMARY KEY,
	TenLH nvarchar(50) NOT NULL,
	TenPhongHoc nvarchar(10) NOT NULL,
	HocPhi float NOT NULL check (HocPhi>0),
	SoBuoiHoc int NOT NULL check (SoBuoiHoc>0),
	SoLuongHV int NOT NULL check (SoLuongHV>0),
	TrangThai nchar(10)
);
GO

insert into LopHoc values ('TCB02','Nang Cao','P01',200,42,20,'');
GO

CREATE TABLE TaoLopHoc(
	MaQL nchar(10) CONSTRAINT FK_TaoLopHoc_MaQL FOREIGN KEY REFERENCES NhanVien(MaNV),
	MaLH nchar(10) CONSTRAINT FK_TaoLopHoc_MaLH FOREIGN KEY REFERENCES LopHoc(MaLH),
	NgayTaoLH date,
	CONSTRAINT PK_TaoLopHoc PRIMARY KEY (MaQL,MaLH)
);
GO

INSERT INTO TaoLopHoc VALUES ('NV01', 'TCB01','2023-06-15')
GO

CREATE TABLE ChiTietDK_LH(
	MaHV nchar(10) CONSTRAINT FK_DKLH_MaHV FOREIGN KEY REFERENCES HocVien(MaHV),
	MaLH nchar(10) CONSTRAINT FK_DKLH_MaLH FOREIGN KEY REFERENCES LopHoc(MaLH),
	NgayDK date NOT NULL check (DATEDIFF(day, NgayDK, GETDATE())>=0),
	CONSTRAINT PK_ChiTietDK_LH PRIMARY KEY (MaHV,MaLH)
);
GO

CREATE TABLE HoaDon(
	MaHD nchar(10) CONSTRAINT PK_HoaDon PRIMARY KEY,
	NgayGioGD date NOT NULL check (DATEDIFF(day, NgayGioGD, GETDATE())>=0),
	SoTien float NOT NULL check (SoTien>0),
	MaHV nchar(10) CONSTRAINT FK_HoaDon_MaHV FOREIGN KEY REFERENCES HocVien(MaHV)
	on delete set null 
	on update cascade
);
GO

insert into HoaDon values('HD01','2023-07-15',250,'HV01');
GO

insert into ChiTietDK_TT values ('HV02','TT02','2023-10-11');
GO

<<<<<<< HEAD
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
insert into ChiTietDK_LH values ('HV01', 'TCB01','2023-07-10');
delete from ChiTietDK_LH where MaHV ='HV01' AND MaLH = 'TCB01'*/


/*Kiểm tra lúc nhân viên sai sót nhập tiền thiếu hoặc dư*/
=======
insert into ChiTietDK_LH values ('HV02', 'TCB02','2023-07-10');
>>>>>>> 2f10f90a068e3466806d806ca09fb89609727ef0
GO


--TRIGGER
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
 
GO

/*Trigger kiểm tra sau khi nhập học viên thì thông báo chỗ còn trống, hoặc thông báo chỗ đầy*/
<<<<<<< HEAD
ALTER TRIGGER TinhSoCho_ConDu
=======
CREATE TRIGGER TinhSoCho_ConDu
>>>>>>> 2f10f90a068e3466806d806ca09fb89609727ef0
ON ChiTietDK_LH
AFTER INSERT
AS 
BEGIN
	
	DECLARE @TongSoCho int;
	DECLARE @SoChoDaDK int;
	DECLARE @MaLH nchar(10);

	SELECT @MaLH = i.MaLH from inserted i;
	SELECT @SoChoDaDK=COUNT(DKLH.MaHV) from ChiTietDK_LH DKLH  group by DKLH.MaLH 
	having DKLH.MaLH=@MaLH;
	SELECT @TongSoCho = Lh.SoLuongHV from LopHoc LH where LH.MaLH = @MaLH;

	IF(@SoChoDaDK < @TongSoCho)
		BEGIN 
			DECLARE @SoChoDu int;
			SET @SoChoDu = @TongSoCho - @SoChoDaDK;
			DECLARE @ThongBao NVARCHAR(1000);
			DECLARE @TrangThai NVARCHAR(1000);
			SET @ThongBao = 'Lop '+ @MaLH +' con du '+CAST(@SoChoDu AS NVARCHAR)+' cho trong';
			PRINT(@ThongBao);
			SET @TrangThai = 'Du '+ CAST(@SoChoDu AS NVARCHAR);
			UPDATE LopHoc SET TrangThai = @TrangThai where LopHoc.MaLH=@MaLH
		END;
	IF(@SoChoDaDK = @TongSoCho)
		BEGIN 
			DECLARE @ThongBao1 NVARCHAR(1000);
			SET @ThongBao1 = 'Lop '+ @MaLH +' da du hoc vien';
			PRINT(@ThongBao1);
			UPDATE LopHoc SET TrangThai = 'Du' where LopHoc.MaLH=@MaLH
		END;
	IF(@SoChoDaDK > @TongSoCho)
		BEGIN 
			DECLARE @ThongBao2 NVARCHAR(1000);
			SET @ThongBao2 = 'Lop '+ @MaLH +' da du hoc vien, vui long xep hoc vien vao lop khac.';
			PRINT(@ThongBao2);
			ROLLBACK;
		END;
END
GO
/*Trigger kiểm tra sau khi học viên đăng kí thi thử thì thông báo chỗ còn trống, hoặc thông báo chỗ đầy*/
CREATE TRIGGER TinhSoChoDK_TT
ON ChiTietDK_TT
AFTER INSERT
AS 
BEGIN
	
	DECLARE @TongSoCho int;
	DECLARE @SoChoDaDK int;
	DECLARE @MaTT nchar(10);

	SELECT @MaTT = i.MaTT from inserted i;
	SELECT @SoChoDaDK=COUNT(DKTT.MaHV) FROM ChiTietDK_TT DKTT group by DKTT.MaTT
	HAVING DKTT.MaTT=@MaTT

	SELECT @TongSoCho = TT.GioiHan FROM ThiThu TT where TT.MaTT = @MaTT;

	IF(@SoChoDaDK < @TongSoCho)
		BEGIN 
			DECLARE @SoChoDu int;
			SET @SoChoDu = @TongSoCho - @SoChoDaDK;
			DECLARE @ThongBao NVARCHAR(1000);
			SET @ThongBao = 'Phong thi thu co ma '+ @MaTT +' con du '+ CAST(@SoChoDu AS NVARCHAR)+' cho trong';
			PRINT(@ThongBao);
		END;
	IF(@SoChoDaDK = @TongSoCho)
		BEGIN 
			DECLARE @ThongBao1 NVARCHAR(1000);
			SET @ThongBao1 = 'Phong thi thu co ma '+ @MaTT +' da dang ki thu';
			PRINT(@ThongBao1);
		END;
	IF(@SoChoDaDK > @TongSoCho)
		BEGIN 
			DECLARE @ThongBao2 NVARCHAR(1000);
			SET @ThongBao2 = 'Phong thi thu co ma '+ @MaTT +' da dang ki du hoc vien, vui long dang ki vao lop khac.';
			PRINT(@ThongBao2);
			ROLLBACK;
		END;
END
GO


/*Trigger tính lại số lượng chỗ còn trống khi xoá học viên đăng ký*/
CREATE TRIGGER TinhSoCho_ConDu_SauXoa
ON ChiTietDK_LH
AFTER DELETE
AS 
BEGIN
	
	DECLARE @TongSoCho int;
	DECLARE @SoChoDaDK int;
	DECLARE @MaLH nchar(10);

	SELECT @MaLH = d.MaLH from deleted d;
	SELECT @SoChoDaDK=COUNT(DKLH.MaHV) from ChiTietDK_LH DKLH  group by DKLH.MaLH 
	having DKLH.MaLH=@MaLH;
	SELECT @TongSoCho = Lh.SoLuongHV from LopHoc LH where LH.MaLH = @MaLH;

	IF(@SoChoDaDK < @TongSoCho)
		BEGIN 
			DECLARE @SoChoDu int;
			SET @SoChoDu = @TongSoCho - @SoChoDaDK;
			DECLARE @ThongBao NVARCHAR(1000);
			DECLARE @TrangThai NVARCHAR(1000);
			SET @ThongBao = 'Lớp '+ @MaLH +' còn dư '+CAST(@SoChoDu AS NVARCHAR)+' chỗ trống';
			PRINT(@ThongBao);
			SET @TrangThai = 'Du '+ CAST(@SoChoDu AS NVARCHAR);
			UPDATE LopHoc SET TrangThai = @TrangThai where LopHoc.MaLH=@MaLH
		END;
END
/* Trigger kiểm tra tổng số lượng học viên đăng ký thi thử*/
CREATE TRIGGER TinhTongSL_TT
ON ChiTietDK_TT
AFTER INSERT
AS 
BEGIN
	DECLARE @TongHV_DKTT int;
	DECLARE @MaTT nchar(10);
	SELECT @MaTT = i.MaTT from inserted i;
	SELECT @TongHV_DKTT = COUNT(MaHV) FROM ChiTietDK_TT GROUP BY MaTT HAVING MaTT = @MaTT;
	DECLARE @ThongBao NVARCHAR(1000);
	SET @ThongBao= 'Tong so hoc vien dang ky ca thi ma '+@MaTT+' la: '+ CAST(@TongHV_DKTT AS NVARCHAR);
	PRINT(@ThongBao);
END
GO

/* Trigger đặt trạng thái cho lớp học*/
CREATE TRIGGER set_LopHoc_TrangThai
ON LopHoc
FOR INSERT
AS
BEGIN
	DECLARE @TrangThai NVARCHAR(1000);
	DECLARE @MaLH nchar(10);
	DECLARE @TongSoCho int;

	SELECT @MaLH = i.MaLH from inserted i;
	SELECT @TongSoCho = LH.SoLuongHV from LopHoc LH where LH.MaLH = @MaLH;

	SET @TrangThai = 'Du ' + CAST(@TongSoCho AS NVARCHAR);
	UPDATE LopHoc
	SET TrangThai = @TrangThai
	WHERE LopHoc.MaLH=@MaLH
END
GO
<<<<<<< HEAD
/* Trigger kiểm tra MaQl quản lý lớp học phải là MaQL của NhanVien*/

=======

/* Trigger kiểm tra MaQl tạo lớp học phải giống với MaQL NhanVien*/
>>>>>>> 2f10f90a068e3466806d806ca09fb89609727ef0
CREATE TRIGGER KiemTra_TaoLH_MaQL
ON TaoLopHoc
AFTER INSERT
AS
BEGIN
	DECLARE @MaQL_NV nchar(10);
	DECLARE @MaQL_TaoLH nchar(10);

	SELECT @MaQL_TaoLH = i.MaQL FROM inserted i;
	SELECT @MaQL_NV = nv.MaQL FROM NhanVien nv ;
	
	IF (@MaQL_TaoLH =@MaQL_NV)
		PRINT('Tao Lop Hoc Thanh Cong');
	ELSE
		BEGIN
		PRINT ('Vui Long Nhap Dung Ma Quan Ly');
		ROLLBACK;
		END;
END