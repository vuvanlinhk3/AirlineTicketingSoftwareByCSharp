create database SQLquanly
go
use SQLquanly
go
CREATE TABLE NhanVien (
    ID INT PRIMARY KEY IDENTITY(1,1),
    TenNhanVien NVARCHAR(255),
    QueQuan NVARCHAR(255),
    SoDienThoai NVARCHAR(20),
    Email NVARCHAR(255),
    MatKhau NVARCHAR(255),
	TaiKhoan NVARCHAR(255)
);

INSERT INTO NhanVien (TenNhanVien, QueQuan, SoDienThoai, Email, MatKhau, TaiKhoan)
VALUES
(N'Nguyễn Văn A', N'Hà Nội', '0123456789', 'nguyenvana@example.com', 'mk1','tk1'),
(N'Trần Thị B', N'Hồ Chí Minh', '0987654321', 'tranthib@example.com', 'mk2','tk2'),
(N'Lê Văn C', N'Đà Nẵng', '0345678901', 'levanc@example.com', 'mk3','tk3'),
(N'Phạm Thị D', N'Nha Trang', '0765432109', 'phamthid@example.com', 'mk4','tk4'),
(N'Hoàng Văn E', N'Huế', '0456789012', 'hoangve@example.com', 'mk5','tk5'),
(N'Ngọc Thị F', N'Quy Nhơn', '0567890123', 'ngocthif@example.com', 'mk6','tk6'),
(N'Mai Văn G', N'Cần Thơ', '0678901234', 'maivang@example.com', 'mk7','tk7'),
(N'Trung Văn H', N'Hà Tĩnh', '0789012345', 'trungvanh@example.com', 'mk8','tk8'),
(N'Linh Thị I', N'Hải Phòng', '0890123456', 'linht@example.com', 'mk9','tk9'),
(N'Hồng Văn K', N'Vũng Tàu', '0901234567', 'hongvank@example.com', 'mk10','tk10');