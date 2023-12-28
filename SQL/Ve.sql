CREATE TABLE Ve
(
    TicketID INT PRIMARY KEY IDENTITY(1,1),
    FlightID INT,
    UserID INT,
    SoGhe VARCHAR(50),
    NgayMuaVe DATE,
    TrangThai BIT, -- Sử dụng kiểu BIT cho TrangThai (0: chưa thanh toán, 1: đã thanh toán)
    LoaiVe VARCHAR(50), -- Sử dụng VARCHAR cho LoaiVe
    GhiChu NVARCHAR(MAX) null, -- Sử dụng NVARCHAR cho GhiChu
    FOREIGN KEY (FlightID) REFERENCES ChuyenBay(FlightID), -- Flight là tên bảng khóa ngoại FlightID
    FOREIGN KEY (UserID) REFERENCES KhachHang(UserID), -- Users là tên bảng khóa ngoại UserID
);
INSERT INTO Ve (TicketID, FlightID, UserID, SoGhe, NgayMuaVe, LoaiVe, TrangThai,GhiChu)
VALUES 
  (1, 101, 1,  1, '2023-09-24','GiaVeThuong','0',''),
  (2, 102, 2,  2, '2023-09-25','GiaVeThuongGia','0',''),
  (3, 103, 3,  4, '2023-09-26','GiaVeThuong','1',''),
  (4, 104, 4,  7, '2023-09-27','GiaVeThuong','1','');
