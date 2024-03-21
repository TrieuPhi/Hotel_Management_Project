
CREATE TABLE Users (
    UserID INT PRIMARY KEY IDENTITY,
    Username NVARCHAR(50) NOT NULL,
    Password NVARCHAR(50) NOT NULL,
    UserType NVARCHAR(20) NOT NULL -- Loại người dùng: 'Normal' hoặc 'HotelOwner'
);

CREATE TABLE Hotels (
    HotelID INT PRIMARY KEY IDENTITY,
    HotelName NVARCHAR(100) NOT NULL,
    Address NVARCHAR(200) NOT NULL,
    OwnerID INT FOREIGN KEY REFERENCES Users(UserID) -- Tham chiếu đến người chủ khách sạn
);

CREATE TABLE Rooms (
    RoomID INT PRIMARY KEY IDENTITY,
    RoomNumber NVARCHAR(20) NOT NULL,
    Type NVARCHAR(50) NOT NULL, -- Loại phòng: Ví dụ: 'Standard', 'Deluxe', 'Suite'
    Price DECIMAL(10, 2) NOT NULL,
    HotelID INT FOREIGN KEY REFERENCES Hotels(HotelID) -- Tham chiếu đến khách sạn mà phòng thuộc về
);

CREATE TABLE Bookings (
    BookingID INT PRIMARY KEY IDENTITY,
    UserID INT FOREIGN KEY REFERENCES Users(UserID), -- Tham chiếu đến người dùng đặt phòng
    RoomID INT FOREIGN KEY REFERENCES Rooms(RoomID), -- Tham chiếu đến phòng đã đặt
    BookingDate DATETIME NOT NULL,
    CheckInDate DATE NOT NULL,
    CheckOutDate DATE NOT NULL,
    TotalAmount DECIMAL(10, 2) NOT NULL
);

CREATE TABLE Services (
    ServiceID INT PRIMARY KEY IDENTITY,
    ServiceName NVARCHAR(100) NOT NULL,
    Price DECIMAL(10, 2) NOT NULL
);

CREATE TABLE BookingServices (
    BookingServiceID INT PRIMARY KEY IDENTITY,
    BookingID INT FOREIGN KEY REFERENCES Bookings(BookingID), -- Tham chiếu đến đặt phòng
    ServiceID INT FOREIGN KEY REFERENCES Services(ServiceID), -- Tham chiếu đến dịch vụ đã đặt
    Quantity INT NOT NULL,
    TotalAmount DECIMAL(10, 2) NOT NULL
);


--------------------INSERT DATA----------------------
INSERT INTO Users (Username, Password, UserType)
VALUES ('user1', 'password1', 'Normal'),
       ('user2', 'password2', 'Normal'),
       ('owner1', 'ownerpassword1', 'HotelOwner'),
       ('owner2', 'ownerpassword2', 'HotelOwner');
INSERT INTO Hotels (HotelName, Address, OwnerID)
VALUES ('Hotel A', '123 ABC Street, City A', 3),
       ('Hotel B', '456 XYZ Street, City B', 4),
       ('Hotel C', '789 DEF Street, City C', 4),
       ('Hotel D', '101 GHI Street, City D', 3);
INSERT INTO Rooms (RoomNumber, Type, Price, HotelID)
VALUES ('101', 'Standard', 100, 1),
       ('201', 'Deluxe', 150, 1),
       ('102', 'Standard', 110, 2),
       ('202', 'Deluxe', 160, 2);
INSERT INTO Bookings (UserID, RoomID, BookingDate, CheckInDate, CheckOutDate, TotalAmount)
VALUES (1, 1, '2024-03-15', '2024-04-01', '2024-04-05', 400),
       (2, 3, '2024-03-16', '2024-04-02', '2024-04-06', 440),
       (1, 2, '2024-03-17', '2024-04-03', '2024-04-07', 600),
       (2, 4, '2024-03-18', '2024-04-04', '2024-04-08', 640);
INSERT INTO Services (ServiceName, Price)
VALUES ('Breakfast', 10),
       ('WiFi', 5),
       ('Room Cleaning', 20),
       ('Airport Transfer', 50);
INSERT INTO BookingServices (BookingID, ServiceID, Quantity, TotalAmount)
VALUES (1, 1, 2, 20),
       (1, 2, 1, 5),
       (2, 3, 1, 20),
       (3, 1, 2, 20),
       (3, 2, 2, 10),
       (4, 3, 2, 40),
       (4, 4, 1, 50);


select * from users

