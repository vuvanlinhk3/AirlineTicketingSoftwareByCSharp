CREATE TABLE KhachHang (
    UserID INT PRIMARY KEY,
    TenKhachHang NVARCHAR(255),
    NgaySinh DATE,
    QueQuan NVARCHAR(255),
    SoDienThoai NVARCHAR(15),
    Email NVARCHAR(255),
    MatKhau NVARCHAR(255),
    TaiKhoan NVARCHAR(255)
);
INSERT INTO KhachHang (UserID, TenKhachHang, NgaySinh, QueQuan, SoDienThoai, Email, MatKhau, TaiKhoan)
VALUES
 (0, N'Nhân Viên', null, null, null, null, 'nhanvien', 'nhanvien'),
    (1, N'Nguyễn Văn A', '1990-01-15', N'Hà Nội', '0123456789', 'nguyenvana@example.com', 'matkhau1', 'taikhoan1'),
    (2, N'Trần Thị B', '1985-05-20', N'Hồ Chí Minh', '0987654321', 'tranthib@example.com', 'matkhau2', 'taikhoan2'),
    (3, N'Lê Văn C', '1992-03-10', N'Đà Nẵng', '0345678901', 'levanc@example.com', 'matkhau3', 'taikhoan3'),
    (4, N'Phạm Thị D', '1988-12-05', N'Nha Trang', '0765432109', 'phamthid@example.com', 'matkhau4', 'taikhoan4'),
    (5, N'Hoàng Văn E', '1995-08-25', N'Huế', '0456789012', 'hoangve@example.com', 'matkhau5', 'taikhoan5'),
    (6, N'Ngọc Thị F', '1993-06-18', N'Quy Nhơn', '0567890123', 'ngocthif@example.com', 'matkhau6', 'taikhoan6'),
    (7, N'Mai Văn G', '1997-04-30', N'Cần Thơ', '0678901234', 'maivang@example.com', 'matkhau7', 'taikhoan7'),
    (8, N'Trung Văn H', '1994-09-12', N'Hà Tĩnh', '0789012345', 'trungvanh@example.com', 'matkhau8', 'taikhoan8'),
    (9, N'Linh Thị I', '1991-07-07', N'Hải Phòng', '0890123456', 'linht@example.com', 'matkhau9', 'taikhoan9'),
    (10, N'Hồng Văn K', '1989-11-28', N'Vũng Tàu', '0901234567', 'hongvank@example.com', 'matkhau10', 'taikhoan10');
