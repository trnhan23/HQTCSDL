

create view v_HocVien
as
select * from HocVien;


CREATE PROCEDURE ThemHocVien
@MaHV nchar(10), 
@HoTenHV nvarchar(50), 
@NgaySinh date, 
@GioiTinh nvarchar(3),
@SoDT nchar(11),
@DiaChiHV nvarchar(100)
as

insert into HocVien values (@MaHV, @HoTenHV, @NgaySinh, @GioiTinh, @SoDT, @DiaChiHV);


create or alter procedure XoaHocVien
@MaHV nchar(10)
as
delete from HocVien where MaHV = @MaHV; 


CREATE OR ALTER PROCEDURE SuaHocVien
@MaHV nchar(10), 
@HoTenHV nvarchar(50), 
@NgaySinh date, 
@GioiTinh nvarchar(3),
@SoDT nchar(11),
@DiaChiHV nvarchar(100)

AS
update HocVien set HoTenHV = @HoTenHV, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh, SoDT = @SoDT, DiaChiHV = @DiaChiHV where MaHV = @MaHV;



CREATE PROCEDURE HienThiTTTheoMaHV 
@MaHV nchar(10)

AS
SELECT * FROM HocVien WHERE MaHV = @MaHV


create view v_HoaDon
as
select * from HoaDon;

CREATE PROCEDURE ThemHoaDon
@MaHD nchar(10), 
@NgayGioGD date, 
@SoTien float,
@MaHV nchar(10),
@MaLH nchar(10)

as
insert into HoaDon values (@MaHD, @NgayGioGD, @SoTien, @MaHV, @MaLH);


create procedure XoaHoaDon
@MaHD nchar(10)
as
delete from HoaDon where MaHD = @MaHD; 


CREATE PROCEDURE SuaHoaDon
@MaHD nchar(10), 
@NgayGD date, 
@SoTien float,
@MaHV nchar(10), 
@MaLH nchar(10)
	
AS
update HoaDon set NgayGD = @NgayGD, SoTien = @SoTien, MaHV = @MaHV, MaLH = @MaLH where MaHD = @MaHD;


CREATE PROCEDURE HienThiTTTheoMaHD 
@MaHD nchar(10)

AS
SELECT * FROM HoaDon WHERE MaHD = @MaHD





create view v_ChiTietDK_LH
as
select * from ChiTietDK_LH;


CREATE PROCEDURE ThemChiTietDK_LH 
@MaHV nchar(10),
@MaLH nchar(10),
@NgayDK date 

as
insert into ChiTietDK_LH values (@MaHV, @MaLH, @NgayDK);


create or alter procedure XoaChiTietDK_LH
@MaHV nchar(10),
@MaLH nchar(10)

as
delete from ChiTietDK_LH where MaHV = @MaHV and MaLH = @MaLH; 


CREATE OR ALTER PROCEDURE SuaChiTietDK_LH
@MaHV nchar(10), 
@MaLH nchar(10),
@NgayDK date

AS
update ChiTietDK_LH set NgayDK = @NgayDK where MaHV = @MaHV and MaLH = @MaLH;


CREATE PROCEDURE HienThiTTTheoMaHVandMaLH
@MaHV nchar(10),
@MaLH nchar(10)

AS
SELECT * FROM ChiTietDK_LH WHERE MaHV = @MaHV and MaLH = @MaLH;


CREATE or ALTER PROCEDURE TimKiemHocVien
@MaHV nchar(10) = NULL,
@HoTenHV nvarchar(50) = NULL
AS
BEGIN
    SELECT *
    FROM HocVien
    WHERE (@MaHV IS NULL OR MaHV = @MaHV)
        AND (@HoTenHV IS NULL OR HoTenHV LIKE '%' + @HoTenHV + '%');
END;

CREATE or ALTER PROCEDURE TimKiemHoaDon
@MaHD nchar(10) = NULL,
@MaHV nchar(10) = NULL
AS
BEGIN
    SELECT *
    FROM HoaDon
    WHERE (@MaHD IS NULL OR MaHD = @MaHD)
        AND (@MaHV IS NULL OR MaHV LIKE '%' + @MaHV + '%');
END;


CREATE or ALTER PROCEDURE TimKiemChiTietDK_LH
@MaHV nchar(10) = NULL,
@MaLH nchar(10) = NULL
AS
BEGIN
    SELECT *
    FROM ChiTietDK_LH
    WHERE (@MaHV IS NULL OR MaHV = @MaHV)
        AND (@MaLH IS NULL OR MaLH LIKE '%' + @MaLH + '%');
END;

CREATE FUNCTION dbo.func_TimKiemHocVien (@MaHV nchar(10))
returns @HocVien table (MaHV nchar(10), HoTenHV nvarchar(50), NgaySinh date, GioiTinh nvarchar(3), SoDT nchar(11), DiaChiHV nvarchar(100))
as
begin
	Insert into @HocVien
	SELECT *
    FROM dbo.HocVien
    WHERE MaHV = @MaHV

	return
end;

Drop function dbo.func_TimKiemHocVien

CREATE FUNCTION dbo.func_TimKiemHoaDon (@MaHD nchar(10))
returns @HoaDon table (MaHD nchar(10), NgayGD date, SoTien float, MaHV nchar(10), MaLH nchar(10))
as
begin
	Insert into @HoaDon
	SELECT *
    FROM dbo.HoaDon
    WHERE MaHD = @MaHD

	return
end;

CREATE FUNCTION dbo.func_TimKiemChiTietDK_LH (@MaHV nchar(10), @MaLH nchar(10))
returns @ChiTietDK_LH table (MaHV nchar(10), MaLH nchar(10), NgayDK date)
as
begin
	Insert into @ChiTietDK_LH
	SELECT *
    FROM dbo.ChiTietDK_LH
    WHERE (@MaHV IS NULL OR MaHV = @MaHV)
        AND (@MaLH IS NULL OR MaLH = @MaLH);

	return
end;