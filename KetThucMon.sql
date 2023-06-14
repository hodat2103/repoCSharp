Create database KetThucMon
go
Use KetThucMon
go
Create table lichthidau
(
DoiThu nvarchar(30),
SanVanDong nvarchar(30) ,
NgayThiDau nvarchar(30) primary key,
GiaiDau nvarchar(30),
Sove int,
GiaVe float


)
go
alter table lichthidau add anhthe nvarchar(100)
go
Create table ketquathidau
(
DoiThu nvarchar(30),
SanVanDong nvarchar(30) ,
NgayThiDau nvarchar(30) primary key,
GiaiDau nvarchar(30),
TySo nvarchar(10),
CauThuXuatSac nvarchar(30),
linkvideo nvarchar(100)
)
go
create table hayhay
(
MaTBBT nvarchar(30) primary key,
TrangThietBiCanBaoTri nvarchar(30),
ThoiGianBaoTri datetime,
SoLuongThietBi float,
NganSachBaoTri float,
ThanhTienTrangThietBi float,
TenCongTyBaoTri nvarchar(40),
SoLuongNhanVien float,
NganSachNhanVien float,
ThanhTienChoNhanVien float
)
go





