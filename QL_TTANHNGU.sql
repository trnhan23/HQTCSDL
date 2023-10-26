
CREATE DATABASE QL_TTANHNGU
GO
DROP Database QL_TTANHNGU
USE QL_TTANHNGU
GO

CREATE TABLE ChiNhanh(
	MaCN nchar(10) CONSTRAINT PK_ChiNhanh PRIMARY KEY,
	TenCN nvarchar(50) NOT NULL,
	DiaChiCN nvarchar(100) NOT NULL
);
GO
INSERT INTO ChiNhanh VALUES('CN01', 'Chi Nhanh 1', 'Ho Thi Tu')
INSERT INTO ChiNhanh VALUES('CN02', 'Chi Nhanh 2', 'Dan Chu')

<<<<<<< Updated upstream
=======
CREATE TABLE CongViec(
	MaCV nchar(10) CONSTRAINT PK_CongViec PRIMARY KEY,
	TenCV nvarchar(50) NOT NULL,
);
GO
INSERT INTO CongViec VALUES('CV01', 'Cong Viec 1')
INSERT INTO CongViec VALUES('CV02', 'Cong Viec 2')

>>>>>>> Stashed changes
CREATE TABLE NhanVien(
	MaNV nchar(10) CONSTRAINT PK_NhanVien PRIMARY KEY,
	HoTenNV nvarchar(50) NOT NULL,
	CCCD nchar(13) NOT NULL check (len(CCCD)=12),
	SoDT nchar(11) NOT NULL check (len(SoDT)=10),
<<<<<<< Updated upstream
	Luong float    NOT NULL check (Luong>0),
	MaCN nchar(10) CONSTRAINT FK_NhanVien_MaCN FOREIGN KEY REFERENCES ChiNhanh(MaCN)
);
=======
	Luong float check (Luong>0),
	MaCN nchar(10) CONSTRAINT FK_NhanVien_MaCN FOREIGN KEY REFERENCES ChiNhanh(MaCN) 
	on delete set null 
	on update cascade,
	MaCV nchar(10) CONSTRAINT FK_NhanVien_MaCV FOREIGN KEY REFERENCES CongViec(MaCV) 
	on delete set null 
	on update cascade,
	MaQL nchar(10) CONSTRAINT FK_NhanVien_MaQL FOREIGN KEY REFERENCES NhanVien(MaNV)
);
GO
alter table NhanVien 
drop constraint FK_NhanVien_MaQL
GO
alter table NhanVien 
add constraint FK_NhanVien_MaQL
foreign key (MaQL) references NhanVien(MaNV)
GO
INSERT INTO NhanVien VALUES('NV01', 'Nguyen Van A', '82456157****', '0915161616', 150, 'CN01', 'CV01', null)
INSERT INTO NhanVien VALUES('NV02', 'Tran Thi B',   '82455557****', '0915797979', 250, 'CN01', 'CV01', 'NV01')
INSERT INTO NhanVien VALUES('NV03', 'Mai Ngoc C',   '82445181****', '0965656565', 100, 'CN02', 'CV02', null)
INSERT INTO NhanVien VALUES('NV04', 'Nguyen Van D', '82623312****', '0945454545', 200, 'CN02', 'CV02', 'NV03')

>>>>>>> Stashed changes
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
INSERT INTO ThiThu VALUES('TT01', 'A101', '2023-10-29', '13:00', 50, 'NV01')
INSERT INTO ThiThu VALUES('TT02', 'B303', '2023-10-27', '7:00', 50, 'NV03')
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
<<<<<<< Updated upstream
=======
insert into HocVien values('HV01','Trong Nhan', '2003-06-06', 'Nam','0789147***','Tien Giang');
insert into HocVien values('HV02','Minh Tai', '2003-10-21', 'Nam','0326344***','so 1 VVN');
insert into HocVien values('HV03','Thu Lai', '2003-12-12', 'Nữ','1456283***','Bến Tre');
GO
CREATE TABLE ChiTietDK_TT(
	MaHV nchar(10) CONSTRAINT FK_DKTT_MaHV FOREIGN KEY REFERENCES HocVien(MaHV),
	MaTT nchar(10) CONSTRAINT FK_DKTT_MaTT FOREIGN KEY REFERENCES ThiThu(MaTT),
	NgayDK date check (DATEDIFF(day, NgayDK, GETDATE())>=0),
	CONSTRAINT PK_ChiTietDK_TT PRIMARY KEY (MaHV,MaTT)
);
GO
insert into ChiTietDK_TT values ('HV02','TT02','2023-10-11');
insert into ChiTietDK_TT values ('HV01','TT01','2023-10-23');
insert into ChiTietDK_TT values ('HV01','TT02','2023-10-15');
insert into ChiTietDK_TT values ('HV03','TT01','2023-09-17');
insert into ChiTietDK_TT values ('HV03','TT02','2023-10-20');
GO
--Giảng viên
--Hien thi thong tin Giang Vien
CREATE PROC HienThiTheoMaHV_TT @MaHV nchar(10), @MaTT nchar(10)
AS
	SELECT *
	FROM ChiTietDK_TT
	WHERE @MaHV = MaHV and @MaTT = MaTT
GO
EXEC HienThiTheoMaHV_TT 'HV02', 'TT02'
GO
--Them thong tin ChiTietDK_TT
CREATE PROC ThemChiTietDK_TT
@MaHV nchar(10),
@MaTT nchar(10),
@NgayDK date
AS
	INSERT INTO dbo.ChiTietDK_TT VALUES(@MaHV, @MaTT, @NgayDK)
GO
--Cap nhat thong tin ChiTietDK_TT
CREATE PROC CapNhatChiTietDK_TT
@MaHV nchar(10),
@MaTT nchar(10),
@NgayDK date
AS
	UPDATE dbo.ChiTietDK_TT
	SET NgayDK = @NgayDK
	WHERE @MaHV = MaHV and @MaTT = MaTT
GO
--Xoa thong tin ChiTietDK_TT
CREATE PROC XoaChiTietDK_TT @MaHV nchar(10), @MaTT nchar(10)
AS
	DELETE FROM ChiTietDK_TT
	WHERE @MaHV = MaHV and @MaTT = MaTT
GO

GO
CREATE TABLE KetQua (
	MaHV nchar(10) CONSTRAINT FK_KetQua_MaHV FOREIGN KEY REFERENCES HocVien(MaHV),
	MaTT nchar(10) CONSTRAINT FK_KetQua_MaTT FOREIGN KEY REFERENCES ThiThu(MaTT),
	SoCauDocDung int check(SoCauDocDung>=0),
	SoCauNgheDung int check(SoCauNgheDung>=0),
	Diem int check(Diem>=0),
	CONSTRAINT PK_KetQua PRIMARY KEY (MaHV,MaTT)
);
GO
>>>>>>> Stashed changes

GO
CREATE TABLE GiangVien(
	MaGV nchar(10) CONSTRAINT PK_GiangVien PRIMARY KEY,
	HoTen nvarchar(50) NOT NULL,
	CCCD nchar(13) NOT NULL check (len(CCCD)=12),
	SoDT nchar(11) NOT NULL check (len(SoDT)=10)
);
GO
<<<<<<< Updated upstream
=======
insert into GiangVien values('GV01', 'Nguyen Van A', '07712345****','0123456789');
insert into GiangVien values('GV02', 'Nguyen Quoc B','08724166****','0987654321');
>>>>>>> Stashed changes

CREATE TABLE LopHoc(
	MaLH nchar(10) CONSTRAINT PK_LopHoc PRIMARY KEY,
	TenLH nvarchar(50) NOT NULL,
	TenPhongHoc nvarchar(10) NOT NULL,
	HocPhi float NOT NULL check (HocPhi>0),
	SoBuoiHoc int NOT NULL check (SoBuoiHoc>0),
<<<<<<< Updated upstream
	SoLuongHV int NOT NULL check (SoLuongHV>0),
	MaGV nchar(10) CONSTRAINT FK_LopHoc_MaGV FOREIGN KEY REFERENCES GiangVien(MaGV)
);
GO

=======
	SoLuongHV int check (SoLuongHV>0),
	TrangThai nchar(10)
);
GO
--Funtion tinh luong giang vien
CREATE FUNCTION TinhLuongGiangVien (@MaGV nchar(10))
RETURNS float
AS
BEGIN
	DECLARE @TongLuong float
	
	SELECT @TongLuong = gv.Luong*(
		SELECT lh.SoBuoiHoc
		FROM GiangVien gv inner join ChiTiet_CaDay ctcd on gv.MaGV = ctcd.MaGV
		inner join LopHoc lh on ctcd.MaLH = lh.MaLH
		WHERE @MaGV = gv.MaGV)
	FROM GiangVien gv
	WHERE gv.MaGV  = @MaGV
	RETURN @TongLuong
END
GO
GO
CREATE TABLE ChiTiet_CaDay(
	MaLH nchar(10) CONSTRAINT FK_CaDay_MaLH FOREIGN KEY REFERENCES LopHoc(MaLH),
	MaGV nchar(10) CONSTRAINT FK_CaDay_MaGV FOREIGN KEY REFERENCES GiangVien(MaGV),
	NgayBatDau date,
	NgayKetThuc date,
	CaDay nchar(10),
	Luong float check(Luong>0)
	CONSTRAINT PK_ChiTietCaDay PRIMARY KEY (MaLH,MaGV)
);
GO


CREATE TABLE TaoLopHoc(
	MaQL nchar(10) CONSTRAINT FK_TaoLopHoc_MaQL FOREIGN KEY REFERENCES NhanVien(MaNV),
	MaLH nchar(10) CONSTRAINT FK_TaoLopHoc_MaLH FOREIGN KEY REFERENCES LopHoc(MaLH),
	NgayTaoLH date,
	CONSTRAINT PK_TaoLopHoc PRIMARY KEY (MaQL,MaLH)
);
GO

GO
CREATE TABLE ChiTietDK_LH(
	MaHV nchar(10) CONSTRAINT FK_DKLH_MaHV FOREIGN KEY REFERENCES HocVien(MaHV),
	MaLH nchar(10) CONSTRAINT FK_DKLH_MaLH FOREIGN KEY REFERENCES LopHoc(MaLH),
	NgayDK date check (DATEDIFF(day, NgayDK, GETDATE())>=0),
	CONSTRAINT PK_ChiTietDK_LH PRIMARY KEY (MaHV,MaLH)
);
GO

GO
>>>>>>> Stashed changes
CREATE TABLE HoaDon(
	MaHD nchar(10) CONSTRAINT PK_HoaDon PRIMARY KEY,
	NgayGD date check (DATEDIFF(day, NgayGD, GETDATE())>=0),
	SoTien float check (SoTien>0),
	MaHV nchar(10) CONSTRAINT FK_HoaDon_MaHV FOREIGN KEY REFERENCES HocVien(MaHV)
);
GO
--PROCEDURE
--Giảng viên
--Hien thi thong tin Giang Vien
CREATE PROC HienThiTheoMaGV @MaGV nchar(10)
AS
	SELECT *
	FROM GiangVien
	WHERE @MaGV = MaGV
GO
EXEC HienThiTheoMaGV 'GV01'
GO
--Them thong tin Giang Vien
CREATE PROC ThemGiangVien
@MaGV nchar(10),
@HoTen nvarchar(50),
@CCCD nchar(13),
@SoDT nchar(11),
@Luong float
AS
	INSERT INTO dbo.GiangVien VALUES(@MaGV, @HoTen, @CCCD, @SoDT, @Luong)
GO
--Cap nhat thong tin Giang Vien
CREATE PROC CapNhatGiangVien
@MaGV nchar(10),
@HoTen nvarchar(50),
@CCCD nchar(13),
@SoDT nchar(11)
AS
	UPDATE dbo.GiangVien
	SET HoTen = @HoTen, CCCD = @CCCD, SoDT = @SoDT
	WHERE MaGV = @MaGV
GO
--Xoa thong tin Giang Vien
CREATE PROC XoaGiangVien @MaGV nchar(10)
AS
	DELETE FROM GiangVien
	WHERE @MaGV = MaGV
GO

<<<<<<< Updated upstream
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
=======
--Thi Thử
--Hien thi thong tin Thi Thu
CREATE PROC HienThiTheoMaTT @MaTT nchar(10)
AS
	SELECT *
	FROM ThiThu
	WHERE @MaTT = MaTT
GO

GO
--Them thong tin Thi Thu
CREATE PROC ThemThiThu
@MaTT nchar(10),
@PhongThi nchar(10),
@NgayThi date,
@GioThi time,
@GioiHan int,
@MaNV nchar(10)
AS
	INSERT INTO dbo.ThiThu VALUES(@MaTT, @PhongThi, @NgayThi, @GioThi, @GioiHan, @MaNV)
GO
--Cap nhat thong tin Thi Thu
CREATE PROC CapNhatThiThu
@MaTT nchar(10),
@PhongThi nchar(10),
@NgayThi date,
@GioThi time,
@GioiHan int,
@MaNV nchar(10)
AS
	UPDATE dbo.ThiThu
	SET PhongThi = @PhongThi,
	NgayThi = @NgayThi,
	GioThi = @GioThi,
	GioiHan = @GioiHan,
	MaNV = @MaNV
	WHERE MaTT = @MaTT
GO
--Xoa thong tin Thi Thu
CREATE PROC XoaThiThu @MaTT nchar(10)
AS
	DELETE FROM ThiThu
	WHERE @MaTT = MaTT
GO

GO
--TRIGGER
--1. Kiểm tra lúc nhân viên sai sót nhập tiền thiếu hoặc dư
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

--2. Trigger kiểm tra sau khi học viên đăng kí lớp học thì thông báo chỗ còn trống, hoặc thông báo chỗ đầy
CREATE TRIGGER TinhSoCho_ConDu
ON ChiTietDK_LH
AFTER INSERT
AS 
BEGIN
	DECLARE @TongSoCho int;
	DECLARE @SoChoDaDK int;
	DECLARE @MaLH nchar(10);

	SELECT @MaLH = i.MaLH FROM inserted i;
	SELECT @SoChoDaDK=COUNT(DKLH.MaHV) FROM ChiTietDK_LH DKLH  GROUP BY DKLH.MaLH 
	HAVING DKLH.MaLH=@MaLH;
	SELECT @TongSoCho = Lh.SoLuongHV FROM LopHoc LH WHERE LH.MaLH = @MaLH;

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

--3. Trigger kiểm tra sau khi học viên đăng kí thi thử thì thông báo chỗ còn trống, hoặc thông báo chỗ đầy
CREATE TRIGGER TinhSoChoDuDK_TT
ON ChiTietDK_TT
AFTER INSERT
AS 
BEGIN
	DECLARE @TongSoCho int;
	DECLARE @SoChoDaDK int;
	DECLARE @MaTT nchar(10);

	SELECT @MaTT = i.MaTT FROM inserted i;
	SELECT @SoChoDaDK=COUNT(DKTT.MaHV) FROM ChiTietDK_TT DKTT GROUP BY DKTT.MaTT
	HAVING DKTT.MaTT=@MaTT
	SELECT @TongSoCho = TT.GioiHan FROM ThiThu TT WHERE TT.MaTT = @MaTT;

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

--4. Trigger tính lại số lượng chỗ còn trống khi xoá học viên đăng ký
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
GO

--5. Trigger kiểm tra tổng số lượng học viên đăng ký thi thử
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

--6. Trigger đặt trạng thái cho lớp học
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

--7. Trigger kiểm tra MaQL tạo lớp học phải giống với MaQL NhanVien
CREATE TRIGGER KiemTra_TaoLH_MaQL
ON TaoLopHoc
AFTER INSERT
AS
BEGIN
	DECLARE @MaQL_NV nchar(10);
	DECLARE @MaQL_TaoLH nchar(10);

	SELECT @MaQL_TaoLH = i.MaQL FROM inserted i;
	SELECT @MaQL_NV = nv.MaQL FROM NhanVien nv ;
	
	IF (@MaQL_TaoLH = @MaQL_NV)
		PRINT('Tao Lop Hoc Thanh Cong');
	ELSE
		BEGIN
		PRINT ('Vui Long Nhap Dung Ma Quan Ly');
		ROLLBACK;
		END;
END
GO

--8. Trigger kiểm tra ca dạy của giảng viên có bị trùng không
CREATE TRIGGER TrungCaDay
ON ChiTiet_CaDay
FOR INSERT
AS
BEGIN
	IF EXISTS (SELECT * FROM inserted i WHERE EXISTS ( 
		SELECT * FROM ChiTiet_CaDay ctcd 
		WHERE ctcd.CaDay = i.CaDay AND ctcd.MaLH <> i.MaLH AND ctcd.NgayKetThuc >= i.NgayBatDau) 
	)
	BEGIN 
		PRINT('Trùng ca dạy');
		ROLLBACK;
	END;
END
GO

--VIEW
--Xem danh sách học viên của các lớp học đã full
CREATE VIEW DanhSachHocVienLopHocFull AS
SELECT LH.MaLH, LH.TenLH, HV.MaHV, HV.HoTenHV, HV.NgaySinh, HV.GioiTinh, HV.SoDT, HV.DiaChiHV
FROM LopHoc LH
INNER JOIN ChiTietDK_LH DKLH ON LH.MaLH = DKLH.MaLH
INNER JOIN HocVien HV ON DKLH.MaHV = HV.MaHV
WHERE LH.TrangThai = 'Du'
GO

--Xem danh sách các lớp học còn trống
CREATE VIEW LopHocConTrong AS
SELECT MaLH, TenLH, TenPhongHoc, HocPhi, SoBuoiHoc, SoLuongHV
FROM LopHoc
WHERE TrangThai != 'Du'
GO

--Thống kê danh sách hóa đơn
CREATE VIEW ThongKeHoaDon AS
SELECT HV.MaHV, HV.HoTenHV, HV.NgaySinh, HV.GioiTinh, HV.SoDT, HV.DiaChiHV, HD.MaHD, HD.NgayGD, HD.SoTien
FROM HocVien HV
LEFT JOIN HoaDon HD ON HV.MaHV = HD.MaHV
GO

--Thống kê danh sách lớp học và số lượng HV đã đăng ký
CREATE VIEW LopHoc_SoLuongHocVien AS
SELECT LH.MaLH,LH.TenLH, COUNT(DKLH.MaHV) AS SoLuongHocVien
FROM LopHoc LH
LEFT JOIN ChiTietDK_LH DKLH ON LH.MaLH = DKLH.MaLH
GROUP BY LH.MaLH, LH.TenLH
GO

--Thống kê ca dạy
CREATE VIEW ViewThongKeCaDay AS
SELECT GV.MaGV, GV.HoTen AS TenGiangVien, LH.TenLH, CD.NgayBatDau, CD.NgayKetThuc
FROM GiangVien GV
INNER JOIN ChiTiet_CaDay CD ON GV.MaGV = CD.MaGV
INNER JOIN LopHoc LH ON CD.MaLH = LH.MaLH
GO

--Thống kê số lượng học viên đăng ký lớp học theo từng tháng
CREATE VIEW SoLuongHocVienDangKyLopHocTheoThang AS
SELECT 
  YEAR(NgayDK) AS Nam, 
  MONTH(NgayDK) AS Thang, 
  COUNT(MaHV) AS SoLuongHocVienDangKy
FROM ChiTietDK_LH
GROUP BY YEAR(NgayDK), MONTH(NgayDK)
GO

--Thống kê nhân viên theo từng chi nhánh
CREATE VIEW NhanVienTungChiNhanh AS
SELECT CN.TenCN, NV.HoTenNV, NV.SoDT, NV.Luong
FROM ChiNhanh CN INNER JOIN NhanVien NV ON CN.MaCN = NV.MaCN
GO

--Thống kê điểm số của từng học viên trong từng lớp thi thử
CREATE VIEW DiemTungHVTrongThiThu AS
SELECT DKTT.MaTT, HV.HoTenHV, HV.NgaySinh, DKTT.NgayDK, KQ.SoCauNgheDung, KQ.SoCauDocDung, KQ.Diem
FROM HocVien HV INNER JOIN ChiTietDK_TT DKTT ON HV.MaHV=DKTT.MaHV
			INNER JOIN KetQua KQ ON DKTT.MaTT=KQ.MaTT
GO

--Danh sách học viên đã đăng kí thi thử
CREATE VIEW DanhSachHV_DKThiThu AS
SELECT TT.MaTT, HV.HoTenHV, HV.NgaySinh, TT.NgayThi
FROM HocVien HV INNER JOIN ChiTietDK_TT DKTT ON HV.MaHV=DKTT.MaHV
			INNER JOIN ThiThu TT ON DKTT.MaTT=TT.MaTT
>>>>>>> Stashed changes
GO

--Xem thông tin thi thử
CREATE VIEW ThongTinThiThu AS
SELECT *
FROM ThiThu
GO
--Xem thông tin giảng viên
CREATE VIEW ThongTinGiangVien AS
SELECT *
FROM GiangVien

GO
--Xem thông tin giảng viên
CREATE VIEW ThongTinChiTietDK_TT AS
SELECT *
FROM ChiTietDK_TT

