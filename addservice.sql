---select * from Rooms;
---select * from Service;

---select RoomNumber, Type, Price from Rooms;


CREATE TABLE Service (
    id INT IDENTITY(1,1) PRIMARY KEY,
    service_name VARCHAR(255),
    price DECIMAL(10, 2),
    service_type VARCHAR(50)
);


INSERT INTO Service (service_name, price, service_type) VALUES
('Trà', 2.5, 'Nước'),
('Nước ngọt', 1.5, 'Nước'),
('Cà phê', 3.0, 'Nước'),
('Bánh mì', 4.0, 'Đồ ăn'),
('Bánh tráng trộn', 5.0, 'Đồ ăn'),
('Nem chua rán', 6.0, 'Đồ ăn'),
('Dịch vụ khác', 0.0, 'Khác');

