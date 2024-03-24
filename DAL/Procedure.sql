

--ProcLogin. 
CREATE OR ALTER PROCEDURE sp_Role_Login
    @username NVARCHAR(50),
    @password NVARCHAR(50)
AS
BEGIN 
    SELECT * FROM Users  WHERE Username = @username AND [Password] = @password
END
