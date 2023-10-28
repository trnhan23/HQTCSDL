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
insert into ChiNhanh values ('CN01','Chi Nhanh 1 PMP','34 Ho Thi Tu');

GO
CREATE TABLE NhanVien(
	MaNV nchar(10) CONSTRAINT PK_NhanVien PRIMARY KEY,
	HoTenNV nvarchar(50) NOT NULL,
	CCCD nchar(13) NOT NULL check (len(CCCD)=12),
	SoDT nchar(11) NOT NULL check (len(SoDT)=10),
	Luong float    NOT NULL check (Luong>0),
	MaCN nchar(10) CONSTRAINT FK_NhanVien_MaCN FOREIGN KEY REFERENCES ChiNhanh(MaCN) 
	on delete set null 
	on update cascade,
	MaQL nchar(10) CONSTRAINT FK_NhanVien_MaQL FOREIGN KEY REFERENCES NhanVien(MaNV),
	MaCV nchar(10) CONSTRAINT FK_NhanVien_MaCV FOREIGN KEY REFERENCES CongViec(MaCV)
	on delete set null 
	on update cascade
);
GO
/*
ALTER TABLE NhanVien ADD MaCV nchar(10)
ALTER TABLE NhanVien ADD CONSTRAINT  FK_NhanVien_MaCV FOREIGN KEY(MaCV) REFERENCES CongViec(MaCV)
*/
GO
INSERT INTO NhanVien VALUES ('NV01','Nguyen Thi A', '123456789101', '0123456789',300,'CN01');

GO
CREATE TABLE CongViec(
	MaCV nchar(10) CONSTRAINT PK_CongViec PRIMARY KEY,
	TenCV nvarchar(50) NOT NULL,
	
);
GO

ALTER TABLE CongViec drop column  MaNV

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
insert into HocVien values('HV02','Minh Tai', '2003-10-21', 'Nam','0326344***','so 1 VVN');

GO
CREATE TABLE ChiTietDK_TT(
	MaHV nchar(10) CONSTRAINT FK_DKTT_MaHV FOREIGN KEY REFERENCES HocVien(MaHV),
	MaTT nchar(10) CONSTRAINT FK_DKTT_MaTT FOREIGN KEY REFERENCES ThiThu(MaTT),
	NgayDK date NOT NULL check (DATEDIFF(day, NgayDK, GETDATE())>=0),
	CONSTRAINT PK_ChiTietDK_TT PRIMARY KEY (MaHV,MaTT)
);
GO
insert into ChiTietDK_TT values ('HV02','TT02','2023-10-11');


GO
<<<<<<< HEAD
/* Tạo bảng kết quả mới ===========================================*/
=======
>>>>>>> 0cb6c430346649b0ba3c4808d06686e1548880bf
CREATE TABLE KetQua (
	MaHV nchar(10) CONSTRAINT FK_KetQua_MaHV FOREIGN KEY REFERENCES HocVien(MaHV),
	MaTT nchar(10) CONSTRAINT FK_KetQua_MaTT FOREIGN KEY REFERENCES ThiThu(MaTT),
	SoCauDocDung int,
	SoCauNgheDung int,
	Diem int,
	CONSTRAINT PK_KetQua PRIMARY KEY (MaHV,MaTT)
);
GO
<<<<<<< HEAD
=======

>>>>>>> 0cb6c430346649b0ba3c4808d06686e1548880bf
CREATE TABLE GiangVien(
	MaGV nchar(10) CONSTRAINT PK_GiangVien PRIMARY KEY,
	HoTen nvarchar(50) NOT NULL,
	CCCD nchar(13) NOT NULL check (len(CCCD)=12),
	SoDT nchar(11) NOT NULL check (len(SoDT)=10),
	Luong float NOT NULL check(Luong>0)
);
GO
alter table GiangVien alter column Luong float null
insert into GiangVien values('GV01', 'Nguyen Van A', '07712345****','0123456789',1000);

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
CREATE TABLE ChiTiet_CaDay(
	MaLH nchar(10) CONSTRAINT FK_CaDay_MaLH FOREIGN KEY REFERENCES LopHoc(MaLH),
	MaGV nchar(10) CONSTRAINT FK_CaDay_MaGV FOREIGN KEY REFERENCES GiangVien(MaGV),
	NgayBatDau date NOT NULL,
	NgayKetThuc date NOT NULL,
	CaDay nchar(10) NOT NULL,
	CONSTRAINT PK_ChiTietCaDay PRIMARY KEY (MaGV)
);
GO
drop table ChiTiet_CaDay
insert into ChiTiet_CaDay values ('TCB02','GV01','2023-11-11','2024-01-10','357-ca3');


GO
CREATE TABLE TaoLopHoc(
	MaQL nchar(10) CONSTRAINT FK_TaoLopHoc_MaQL FOREIGN KEY REFERENCES NhanVien(MaNV),
	MaLH nchar(10) CONSTRAINT FK_TaoLopHoc_MaLH FOREIGN KEY REFERENCES LopHoc(MaLH),
	NgayTaoLH date,
	CONSTRAINT PK_TaoLopHoc PRIMARY KEY (MaQL)
);
drop table TaoLopHoc
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
insert into ChiTietDK_LH values ('HV02', 'TCB02','2023-07-10');

GO
CREATE TABLE HoaDon(
	MaHD nchar(10) CONSTRAINT PK_HoaDon PRIMARY KEY,
	NgayGD date NOT NULL check (DATEDIFF(day, NgayGD, GETDATE())>=0),
	SoTien float NOT NULL check (SoTien>0),
	MaHV nchar(10) CONSTRAINT FK_HoaDon_MaHV FOREIGN KEY REFERENCES HocVien(MaHV)
	on delete set null 
	on update cascade
);
GO
insert into HoaDon values('HD01','2023-07-15',250,'HV01');


GO
<<<<<<< HEAD

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



GO
=======
>>>>>>> 0cb6c430346649b0ba3c4808d06686e1548880bf
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

<<<<<<< HEAD
/*Trigger kiểm tra sau khi nhập học viên thì thông báo chỗ còn trống, hoặc thông báo chỗ đầy*/


=======
=======
/*Trigger kiểm tra sau khi học viên đăng kí lớp học thì thông báo chỗ còn trống, hoặc thông báo chỗ đầy*/
>>>>>>> 0cb6c430346649b0ba3c4808d06686e1548880bf
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

/*Trigger kiểm tra sau khi học viên đăng kí thi thử thì thông báo chỗ còn trống, hoặc thông báo chỗ đầy*/
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
CREATE OR ALTER TRIGGER set_LopHoc_TrangThai
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


=======

/* Trigger kiểm tra MaQl tạo lớp học phải giống với MaQL NhanVien*/

=======
/* Trigger kiểm tra MaQL tạo lớp học phải giống với MaQL NhanVien*/
>>>>>>> 0cb6c430346649b0ba3c4808d06686e1548880bf
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

-- Trigger kiểm tra ca dạy của giảng viên có bị trùng không

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
GO

-- Tạo View xem kết quả
create view v_KetQua
as
select * from KetQua

select * from v_KetQua
--Tao procedure select tung cai ket qua
CREATE OR ALTER PROCEDURE ThongTinKetQuaTTTheoMa
@MaHV nchar(10),
@MaTT nchar(10)
as
select * from KetQua where MaHV = @MaHV and MaTT = @MaTT

exec ThongTinKetQuaTTTheoMa 'HV01', 'TT01'
go
--Tạo procedure thêm kết quả
CREATE OR ALTER PROCEDURE ThemKetQuaTT
@MaHV nchar(10),
@MaTT nchar(10),
@SoCauDocDung int,
@SoCauNgheDung int
AS
INSERT INTO KetQua VALUES (@MaHV,@MaTT,@SoCauDocDung,@SoCauNgheDung,0);

exec ThemKetQuaTT 'HV02','TT01', 50,50;
 
go
--tạo procedure update Ket qua
	CREATE OR ALTER PROCEDURE SuaKetQuaTT
	@MaHV nchar(10),
	@MaTT nchar(10),
	@SoCauDocDung int,
	@SoCauNgheDung int,
	@Diem int
	AS
	begin
		update KetQua set MaTT = @MaTT, SoCauNgheDung = @SoCauNgheDung, SoCauDocDung = @SoCauDocDung, Diem=@Diem where MaHV = @MaHV;
	end
exec SuaKetQuaTT 'HV02', 'TT02',55,63

select * from KetQua

go
-- tạo function tính điểm thi
CREATE OR ALTER FUNCTION TinhDiemTT(/*@MaHV nchar(10), @MaTT nchar(10)*/ @SoCauNgheDung int, @SoCauDocDung int)
RETURNS INT
AS
BEGIN
	DECLARE @DiemnNghe int, @DiemDoc int, @DiemTong int/*, @SoCauNgheDung int, @SoCauDocDung int*/;
	--select @SoCauNgheDung = SoCauNgheDung, @SoCauDocDung = SoCauDocDung from KetQua where MaHV = @MaHV and MaTT = @MaTT*/
	--Tinh diem nghe
	if(@SoCauNgheDung = 0)
		set @DiemnNghe = 5;
	if(@SoCauNgheDung >=1 and @SoCauNgheDung <=75)
		set @DiemnNghe = (@SoCauNgheDung - 1)*5 +15;
	if(@SoCauNgheDung >=75 and @SoCauNgheDung <=96)
		set @DiemnNghe = (@SoCauNgheDung - 1)*5 +20;
	if(@SoCauNgheDung >=96) 
		set @DiemnNghe = 495;
	--Tinh diem doc
	if(@SoCauDocDung >= 0 and @SoCauDocDung <=2)
		set @DiemDoc = 5;
	if(@SoCauDocDung >=2 and @SoCauDocDung <=100)
		set @DiemDoc = (@SoCauDocDung - 2)*5 +5;
	set @DiemTong = @DiemnNghe + @DiemDoc;
	return @DiemTong;
END
select dbo.TinhDiemTT('55','60')
select * from KetQua
delete from KetQua where KetQua.MaHV='HV02'

 go
--Tao procedure gán điểm cho điểm từ function tính điểm
create or alter procedure GanDiem
@MaHV nchar(10), @MaTT nchar(10)
as
begin
	declare @Diem int;
	set @Diem = dbo.TinhDiemTT(@MaHV,@MaTT);
	update KetQua set Diem = @Diem where MaHV = @MaHV and MaTT = @MaTT;
end

exec GanDiem 'HV01','TT02';
select * from KetQua

go 

--Tạo procedure xoá KetQua
create or alter procedure XoaKetQuaTT
@MaHV nchar(10), @MaTT nchar(10)
as
delete from KetQua where MaHV = @MaHV and MaTT = @MaTT
go

--Tạo view thấy thông tin chi nhánh
create view v_ChiNhanh
as
select * from ChiNhanh


select * from v_ChiNhanh
go
-- Tạo procedure hiển thị chi nhánh theo mã
create or alter procedure ThongTinChiNhanhTheoMa
@MaCN nchar(10)
as 
select * from ChiNhanh where MaCN = @MaCN

exec ThongTinChiNhanhTheoMa 'CN01';

-- Tạo procedure thêm chi nhánh

create or alter procedure ThemChiNhanh
@MaCN nchar(10), 
@TenCN nvarchar(50), 
@DiaChiCN nvarchar(100)
as
insert into ChiNhanh values (@MaCN, @TenCN, @DiaChiCN);

exec ThemChiNhanh 'CN02','Chi nhánh 2', 'Lê Văn Việt';

go
-- Tạo procedure sửa chi nhánh
create or alter procedure SuaThongTinChiNhanh
@MaCN nchar(10), 
@TenCN nvarchar(50), 
@DiaChiCN nvarchar(100)
as
update ChiNhanh set TenCN = @TenCN, DiaChiCN = @DiaChiCN where MaCN = @MaCN

go
 
-- Tạo procedure xoá chi nhánh
create or alter procedure XoaChiNhanh
@MaCN nchar(10)
as
delete from ChiNhanh where MaCN = @MaCN
go

-- Tạo procedure hiển thị thông tin liên quan đến chi nhánh
create or alter view v_ThongTinLienQuanTheoMaCN
as
select cn.MaCN, nv.MaNV, nv.HoTenNV, nv.MaQL, TaoLopHoc.MaLH from ChiNhanh cn inner join NhanVien nv on cn.MaCN = nv.MaCN
		inner join TaoLopHoc on nv.MaNV = TaoLopHoc.MaQL 

select * from v_ThongTinLienQuanTheoMaCN
go
========================================================
-- tạo procedure lấy dữ liệu liên quan

create or alter procedure DemThongTinTheoMaCN
@MaCN nchar(10)
as
begin
    select
		max(nv.MaQL) as MaQL,
        max(nv.HoTenNV) as HoTenNV,
        count(nv.MaNV) as SoLuongNhanVien,
        count(MaLH) as SoLuongLopHoc
    from v_ThongTinLienQuanTheoMaCN nv
    where nv.MaCN = @MaCN
end

exec DemThongTinTheoMaCN 'CN02'

================================================================
-- Tạo view lấy thông tin lớp học

create or alter view v_LopHoc
as 
select * from LopHoc

select * from v_LopHoc

go 
-- tạo procedure lấy thông tin lớp học theo mã
create or alter procedure ThongTinLopHocTheoMa
@MaLH nchar(10)
as
select * from v_LopHoc where MaLH = @MaLH
go

--Tạo procedure thêm lớp học
create or alter procedure ThemLopHoc
@MaLH nchar (10), 
@TenLH nvarchar(50), 
@TenPhongHoc nvarchar(10), 
@HocPhi float,
@SoBuoiHoc int,
@SoLuongHV int
as
insert into LopHoc values (@MaLH, @TenLH, @TenPhongHoc,@HocPhi, @SoBuoiHoc, @SoLuongHV,'')

--Tạo procedure sửa lớp học

create or alter procedure SuaThongTinLopHoc
@MaLH nchar (10), 
@TenLH nvarchar(50), 
@TenPhongHoc nvarchar(10), 
@HocPhi float,
@SoBuoiHoc int,
@SoLuongHV int
as
update LopHoc 
set
TenLH = @TenLH,
TenPhongHoc = @TenPhongHoc,
HocPhi = @HocPhi,
SoBuoiHoc = @SoBuoiHoc,
SoLuongHV = @SoLuongHV
where MaLH = @MaLH

go
--Tạo procedure xoá lớp học 
create or alter procedure XoaLopHoc
@MaLH nchar(10)
as
delete from LopHoc where MaLH = @MaLH

-- Tạo view liệt kê học viên theo lớp

create or alter view v_danhSachHvTheoLop
as
select ctdk.MaLH,hv.MaHV, hv.HoTenHV, hv.NgaySinh, hv.GioiTinh, hv.SoDT, hv.DiaChiHV 
from HocVien hv inner join ChiTietDK_LH ctdk on hv.MaHV = ctdk.MaHV

select * from v_danhSachHvTheoLop
--Tạo procedure danh sach học viên theo mã lớp
create or alter procedure HocVienTheoMaLop
@MaLH nchar(10)
as
select * from v_danhSachHvTheoLop v where v.MaLH = @MaLH
exec HocVienTheoMaLop 'TCB02'

-- Tạo procedure cập nhật trạng thái
create or alter procedure UpdateTrangThai
@MaLH nchar(10)
as 
select TrangThai from v_LopHoc where MaLH =@MaLH

-- Tạo trigger  cập nhật trạng thái
CREATE OR ALTER TRIGGER trg_UpdateTrangThai
ON LopHoc
AFTER UPDATE
AS 
BEGIN
	DECLARE @TongSoCho int;
	DECLARE @SoChoDaDK int;
	DECLARE @MaLH nchar(10);
	set @SoChoDaDK = 0;
	SELECT @MaLH = i.MaLH FROM inserted i;
	SELECT @SoChoDaDK=COUNT(DKLH.MaHV) FROM ChiTietDK_LH DKLH  GROUP BY DKLH.MaLH 
	HAVING DKLH.MaLH=@MaLH;
	SELECT @TongSoCho = Lh.SoLuongHV FROM LopHoc LH WHERE LH.MaLH = @MaLH;

	IF(@TongSoCho - @SoChoDaDK >= 0)
		BEGIN 
			DECLARE @SoChoDu int;
			SET @SoChoDu = @TongSoCho - @SoChoDaDK;
			DECLARE @TrangThai NVARCHAR(100);
			SET @TrangThai = 'Du '+ CAST(@SoChoDu AS NVARCHAR);
			UPDATE LopHoc SET TrangThai = @TrangThai where LopHoc.MaLH=@MaLH;
			insert into triggerLog(messageLog) values(@TrangThai)
		END;
	ELSE
		BEGIN
			RAISERROR('Vui lòng nhập đủ SL HV với SL HV đã đăng ký!!',16,0);
			ROLLBACK;
		END
END

update LopHoc set SoLuongHV = 34 where MaLH = 'TCB01'
insert into ChiTietDK_LH values ('HV01','TCB01','')

create table triggerLog(
	ID int IDENTITY(1,1) primary key,
	messageLog nvarchar(1000)
);
select messageLog from triggerLog

delete from triggerLog
