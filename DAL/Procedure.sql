--Procedure Đăng Nhập kiểm tra có tồn tại tài khoản không *
CREATE OR ALTER PROCEDURE sp_ktrDangNhap
    @username NVARCHAR(50),
    @password NVARCHAR(50),
    @check INT OUTPUT
AS
BEGIN
    SELECT @check = COUNT(*) FROM Users
    WHERE Username = @username AND Password = @password
END
GO
