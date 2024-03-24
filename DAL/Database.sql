CREATE TABLE Users (
    UserID INT PRIMARY KEY IDENTITY,
    Username NVARCHAR(50) NOT NULL,
    Password NVARCHAR(50) NOT NULL,
    UserType NVARCHAR(20) NOT NULL -- Loại người dùng: 'Normal' hoặc 'HotelOwner'
);

CREATE TABLE Hotels (
    HotelID INT PRIMARY KEY IDENTITY,
    HotelName NVARCHAR(100) NOT NULL,
    City NVARCHAR(100) NOT NULL, -- Thành Phố
    District NVARCHAR(100) NOT NULL, -- Quận
    OwnerID INT FOREIGN KEY REFERENCES Users(UserID) -- Tham chiếu đến người chủ khách sạn
);

CREATE TABLE Rooms (
    RoomID INT PRIMARY KEY IDENTITY,
    RoomNumber NVARCHAR(20) NOT NULL,
    Type NVARCHAR(50) NOT NULL, -- Loại phòng: Ví dụ: 'Standard', 'Deluxe', 'Suite'
    Price DECIMAL(10, 2) NOT NULL,
    HotelID INT FOREIGN KEY REFERENCES Hotels(HotelID) -- Tham chiếu đến khách sạn mà phòng thuộc về
);

INSERT INTO Users (Username, Password, UserType) 
VALUES 
    ('user1', 'user1', 'Normal'),
    ('user2', 'user2', 'Normal'),
    ('owner1', 'owner1', 'HotelOwner'),
    ('owner2', 'owner2', 'HotelOwner');

-- Chèn dữ liệu vào bảng Hotels
INSERT INTO Hotels (HotelName, City, District, OwnerID)
VALUES 
    ('Hotel A', 'TPHCM', 'Quận 1', 3), -- Hotel A thuộc thành phố HCM, quận 1, chủ sở hữu có ID là 3
    ('Hotel B', 'Hà Nội', 'Quận Hai Bà Trưng', 4), -- Hotel B thuộc thành phố Hà Nội, quận Hai Bà Trưng, chủ sở hữu có ID là 4
    ('Hotel C', 'TPHCM', 'Quận Bình Thạnh', 3),
    ('Hotel D', 'Hà Nội', 'Quận Ba Đình', 4),
    ('Hotel E', 'TPHCM', 'Quận Gò Vấp', 4),
    ('Hotel F', 'Hà Nội', 'Quận Hoàn Kiếm', 3),
    ('Hotel G', 'TPHCM', 'Quận Tân Bình', 4),
    ('Hotel H', 'Hà Nội', 'Quận Cầu Giấy', 3);

-- Chèn dữ liệu vào bảng Rooms
INSERT INTO Rooms (RoomNumber, Type, Price, HotelID)
VALUES 
    ('101', 'Standard', 50.00, 1), -- Phòng số 101, loại phòng Standard, giá 50.00, thuộc khách sạn có ID là 1
    ('102', 'Standard', 50.00, 1),
    ('201', 'Deluxe', 80.00, 2),
    ('202', 'Deluxe', 80.00, 2),
    ('301', 'Suite', 120.00, 3),
    ('302', 'Suite', 120.00, 3),
    ('401', 'Standard', 50.00, 4),
    ('402', 'Standard', 50.00, 4);