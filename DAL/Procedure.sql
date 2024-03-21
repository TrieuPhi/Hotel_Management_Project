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

--ProcLogin. 
CREATE OR ALTER PROCEDURE sp_Role_Login
    @username NVARCHAR(50),
    @password NVARCHAR(50)
AS
BEGIN 
    SELECT * FROM Users  WHERE Username = @username AND [Password] = @password
END


CREATE TABLE Users (
    UserID INT PRIMARY KEY IDENTITY,
    Username NVARCHAR(50) NOT NULL,
    Password NVARCHAR(50) NOT NULL,
    UserType NVARCHAR(20) NOT NULL -- Loại người dùng: 'Normal' hoặc 'HotelOwner'
);