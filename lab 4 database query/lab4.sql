create database Lab4
use Lab4

CREATE TABLE KhachHang (
    MaKH INT PRIMARY KEY,
    TenKH NVARCHAR(255),
    DiaChi NVARCHAR(255),
    SoDienThoai NVARCHAR(15),
    Email NVARCHAR(255)
);

CREATE TABLE NhanVienBanHang (
    MaNV INT PRIMARY KEY,
    TenNV NVARCHAR(255),
    ChucVu NVARCHAR(255)
);

CREATE TABLE SanPham (
    MaSP INT PRIMARY KEY,
    TenSP NVARCHAR(255),
    GiaBan DECIMAL(10, 2),
    SoLuongTonKho INT
);

CREATE TABLE DonDatHang (
    MaĐH INT PRIMARY KEY,
    NgayĐH DATE,
    TrangThai NVARCHAR(255),
    MaKH INT,
    MaNV INT,
    FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH) ON DELETE CASCADE,
    FOREIGN KEY (MaNV) REFERENCES NhanVienBanHang(MaNV)
);


CREATE TABLE ChiTiet (
    MaĐH INT,
    MaSP INT,
    SoLuong INT,
    DonGia DECIMAL(10, 2),
    ThanhTien DECIMAL(10, 2),
    PRIMARY KEY (MaĐH, MaSP),
    FOREIGN KEY (MaĐH) REFERENCES DonDatHang(MaĐH),
    FOREIGN KEY (MaSP) REFERENCES SanPham(MaSP)
);

-- Thêm dữ liệu vào bảng KhachHang
INSERT INTO KhachHang (MaKH, TenKH, DiaChi, SoDienThoai, Email)
VALUES (1, N'Nguyễn Văn Hưng', N'123 Đường 1, Quận 1, TP.HCM', '0123456789', 'nvh@gmail.com'),
       (2, N'Trần Thị Lan', N'456 Đường 2, Quận 2, TP.HCM', '0987654321', 'ttl@gmail.com'),
	   (3, N'Phạm Văn Cần', N'789 Đường 3, Quận 3, TP.HCM', '0123456780', 'pvc@gmail.com'),
       (4, N'Lê Thị Trúc Nhi', N'012 Đường 4, Quận 4, TP.HCM', '0987654320', 'ltn@gmail.com');
-- Thêm dữ liệu vào bảng NhanVienBanHang
INSERT INTO NhanVienBanHang (MaNV, TenNV, ChucVu)
VALUES (1, N'Lê Văn Thương', N'Nhân viên bán hàng'),
       (2, N'Phạm Thị Dư', N'Quản lý'),
	   (3, N'Nguyễn Văn Minh', N'Nhân viên bán hàng'),
       (4, N'Trần Thị Trúc Nhi', N'Quản lý');

-- Thêm dữ liệu vào bảng SanPham
INSERT INTO SanPham (MaSP, TenSP, GiaBan, SoLuongTonKho)
VALUES (1, N'Sản phẩm 1', 10000.00, 50),
       (2, N'Sản phẩm 2', 20000.00, 100),
	   (3, N'Sản phẩm 3', 30000.00, 150),
       (4, N'Sản phẩm 4', 40000.00, 200);
-- Thêm dữ liệu vào bảng DonDatHang
INSERT INTO DonDatHang (MaĐH, NgayĐH, TrangThai, MaKH, MaNV)
VALUES (1, '2024-05-01', N'Đang xử lý', 1, 1),
       (2, '2024-05-02', N'Đã giao hàng', 2, 2),
	   (3, '2024-05-03', N'Đang xử lý', 3, 3),
       (4, '2024-05-04', N'Đã giao hàng', 4, 4);
-- Thêm dữ liệu vào bảng ChiTiet
INSERT INTO ChiTiet (MaĐH, MaSP, SoLuong, DonGia, ThanhTien)
VALUES (1, 1, 5, 10000.00, 50000.00),
       (1, 2, 10, 20000.00, 200000.00),
       (2, 1, 3, 10000.00, 30000.00),
       (2, 2, 2, 20000.00, 40000.00),
	   (3, 3, 7, 30000.00, 210000.00),
       (3, 4, 8, 40000.00, 320000.00),
       (4, 3, 9, 30000.00, 270000.00),
       (4, 4, 10, 40000.00, 400000.00);

select * from ChiTiet
select * from DonDatHang
select * from KhachHang
select * from NhanVienBanHang
select * from SanPham