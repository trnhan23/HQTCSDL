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