USE [master]
GO
/****** Object:  Database [Nhom6_QLyTiemBanh]    Script Date: 8/21/2021 4:28:02 PM ******/
CREATE DATABASE [Nhom6_QLyTiemBanh]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Nhom6_QLyTiemBanh', FILENAME = N'D:\ung dung\Microsoft Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Nhom6_QLyTiemBanh.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Nhom6_QLyTiemBanh_log', FILENAME = N'D:\ung dung\Microsoft Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Nhom6_QLyTiemBanh_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Nhom6_QLyTiemBanh] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Nhom6_QLyTiemBanh].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Nhom6_QLyTiemBanh] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Nhom6_QLyTiemBanh] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Nhom6_QLyTiemBanh] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Nhom6_QLyTiemBanh] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Nhom6_QLyTiemBanh] SET ARITHABORT OFF 
GO
ALTER DATABASE [Nhom6_QLyTiemBanh] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Nhom6_QLyTiemBanh] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Nhom6_QLyTiemBanh] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Nhom6_QLyTiemBanh] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Nhom6_QLyTiemBanh] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Nhom6_QLyTiemBanh] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Nhom6_QLyTiemBanh] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Nhom6_QLyTiemBanh] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Nhom6_QLyTiemBanh] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Nhom6_QLyTiemBanh] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Nhom6_QLyTiemBanh] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Nhom6_QLyTiemBanh] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Nhom6_QLyTiemBanh] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Nhom6_QLyTiemBanh] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Nhom6_QLyTiemBanh] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Nhom6_QLyTiemBanh] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Nhom6_QLyTiemBanh] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Nhom6_QLyTiemBanh] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Nhom6_QLyTiemBanh] SET  MULTI_USER 
GO
ALTER DATABASE [Nhom6_QLyTiemBanh] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Nhom6_QLyTiemBanh] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Nhom6_QLyTiemBanh] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Nhom6_QLyTiemBanh] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Nhom6_QLyTiemBanh] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Nhom6_QLyTiemBanh] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Nhom6_QLyTiemBanh] SET QUERY_STORE = OFF
GO
USE [Nhom6_QLyTiemBanh]
GO
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 8/21/2021 4:28:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[MaHD] [int] NOT NULL,
	[MaSP] [int] NOT NULL,
	[SoLuongBan] [int] NULL,
	[TongTien] [money] NULL,
 CONSTRAINT [PK_ChiTietHoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC,
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietHoaDonNhap]    Script Date: 8/21/2021 4:28:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDonNhap](
	[SoPN] [int] NOT NULL,
	[MaSP] [int] NOT NULL,
	[SoLuongNhap] [int] NULL,
	[GiaNhap] [money] NULL,
	[TongTienNhap] [money] NULL,
 CONSTRAINT [PK_ChiTietHoaDonNhap] PRIMARY KEY CLUSTERED 
(
	[SoPN] ASC,
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 8/21/2021 4:28:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHD] [int] IDENTITY(1,1) NOT NULL,
	[MaKh] [int] NULL,
	[NgayLap] [date] NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDonNhap]    Script Date: 8/21/2021 4:28:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDonNhap](
	[SoPN] [int] IDENTITY(1,1) NOT NULL,
	[MaNCC] [int] NULL,
	[MaTk] [int] NULL,
	[NgayNhap] [date] NULL,
 CONSTRAINT [PK_HoaDonNhap] PRIMARY KEY CLUSTERED 
(
	[SoPN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 8/21/2021 4:28:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKh] [int] IDENTITY(1,1) NOT NULL,
	[TenKh] [nvarchar](50) NULL,
	[DiaChiKH] [nvarchar](50) NULL,
	[SDTKh] [varchar](20) NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 8/21/2021 4:28:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[MaNCC] [int] IDENTITY(1,1) NOT NULL,
	[TenNcc] [nvarchar](50) NULL,
	[DiaChi_NCC] [nvarchar](50) NULL,
	[SoDT] [varchar](20) NULL,
 CONSTRAINT [PK_NhaCungCap] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 8/21/2021 4:28:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[MaSP] [int] IDENTITY(1,1) NOT NULL,
	[TenSp] [nvarchar](50) NULL,
	[Slco] [int] NULL,
	[Gia] [money] NULL,
 CONSTRAINT [PK_SanPham] PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 8/21/2021 4:28:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[MaTk] [int] IDENTITY(1,1) NOT NULL,
	[TenDangNhap] [varchar](20) NOT NULL,
	[MatKhau] [varchar](20) NOT NULL,
	[TinhTrang] [bit] NULL,
	[HoTen] [nvarchar](50) NULL,
	[DiaChi_nv] [nvarchar](50) NULL,
	[SoDT_nv] [varchar](20) NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[MaTk] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[NhaCungCap] ON 

INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNcc], [DiaChi_NCC], [SoDT]) VALUES (1, N'Bánh kẹo Nga', N'Thái Nguyên', N'0961362470')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNcc], [DiaChi_NCC], [SoDT]) VALUES (2, N'Bánh Ngọt Phượng Béo', N'Hưng Yên', N'0961362541')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNcc], [DiaChi_NCC], [SoDT]) VALUES (3, N'Bánh Ngọt Mỹ', N'Hà Nội ', N'0967231526')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNcc], [DiaChi_NCC], [SoDT]) VALUES (4, N'Bánh Nhật Bản', N'Hải Dương', N'0964531256')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNcc], [DiaChi_NCC], [SoDT]) VALUES (5, N'Bánh Của Đức', N'Thái Nguyên', N'0961543275')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNcc], [DiaChi_NCC], [SoDT]) VALUES (6, N'Bánh Của Pháp', N'Hà Nội', N'0979426135')
SET IDENTITY_INSERT [dbo].[NhaCungCap] OFF
GO
SET IDENTITY_INSERT [dbo].[SanPham] ON 

INSERT [dbo].[SanPham] ([MaSP], [TenSp], [Slco], [Gia]) VALUES (1, N'Bánh Ngọt', 150, 150.0000)
INSERT [dbo].[SanPham] ([MaSP], [TenSp], [Slco], [Gia]) VALUES (2, N'Bánh Mochi Nhật Bản', 450, 120.0000)
INSERT [dbo].[SanPham] ([MaSP], [TenSp], [Slco], [Gia]) VALUES (3, N'Bánh Tiramisu Ý', 520, 250.0000)
INSERT [dbo].[SanPham] ([MaSP], [TenSp], [Slco], [Gia]) VALUES (4, N'Bánh Macaron Pháp', 410, 125.0000)
INSERT [dbo].[SanPham] ([MaSP], [TenSp], [Slco], [Gia]) VALUES (5, N'Bánh Tapioca Brazil', 85, 85.0000)
INSERT [dbo].[SanPham] ([MaSP], [TenSp], [Slco], [Gia]) VALUES (6, N'Bánh Sachertorte Áo', 741, 65.0000)
INSERT [dbo].[SanPham] ([MaSP], [TenSp], [Slco], [Gia]) VALUES (7, N'Bánh Pavlova Úc', 521, 152.0000)
INSERT [dbo].[SanPham] ([MaSP], [TenSp], [Slco], [Gia]) VALUES (8, N'Bánh Black Forest Đức', 412, 135.0000)
INSERT [dbo].[SanPham] ([MaSP], [TenSp], [Slco], [Gia]) VALUES (9, N'Bánh Táo Mỹ', 51, 123.0000)
INSERT [dbo].[SanPham] ([MaSP], [TenSp], [Slco], [Gia]) VALUES (10, N'ánh Limburg Pie Hà Lan', 78, 184.0000)
INSERT [dbo].[SanPham] ([MaSP], [TenSp], [Slco], [Gia]) VALUES (11, N'Bánh Gateau St.Honore', 54, 45.0000)
INSERT [dbo].[SanPham] ([MaSP], [TenSp], [Slco], [Gia]) VALUES (12, N'Bánh trifle Anh Quốc', 46, 61.0000)
INSERT [dbo].[SanPham] ([MaSP], [TenSp], [Slco], [Gia]) VALUES (13, N'Bánh Donut Mỹ', 79, 300.0000)
SET IDENTITY_INSERT [dbo].[SanPham] OFF
GO
SET IDENTITY_INSERT [dbo].[TaiKhoan] ON 

INSERT [dbo].[TaiKhoan] ([MaTk], [TenDangNhap], [MatKhau], [TinhTrang], [HoTen], [DiaChi_nv], [SoDT_nv]) VALUES (1, N'nga', N'123456', 1, N'Trần Thúy Nga', N'Thái Nguyên', N'0961362470')
INSERT [dbo].[TaiKhoan] ([MaTk], [TenDangNhap], [MatKhau], [TinhTrang], [HoTen], [DiaChi_nv], [SoDT_nv]) VALUES (2, N'phuong', N'123456', 1, N'Vũ Thị Phượng', N'Hưng Yên', N'0961365427')
INSERT [dbo].[TaiKhoan] ([MaTk], [TenDangNhap], [MatKhau], [TinhTrang], [HoTen], [DiaChi_nv], [SoDT_nv]) VALUES (3, N'don', N'123456', 1, N'Nguyễn Văn Đôn', N'Thái Nguyên', N'0965979655')
INSERT [dbo].[TaiKhoan] ([MaTk], [TenDangNhap], [MatKhau], [TinhTrang], [HoTen], [DiaChi_nv], [SoDT_nv]) VALUES (4, N'thu', N'123456', 0, N'Hoàng Thư', N'Hải Dương', N'0316756123')
INSERT [dbo].[TaiKhoan] ([MaTk], [TenDangNhap], [MatKhau], [TinhTrang], [HoTen], [DiaChi_nv], [SoDT_nv]) VALUES (5, N'nguyena', N'123456', 0, N'Nguyễn Văn A', N'Hà Nội', N'0961452346')
SET IDENTITY_INSERT [dbo].[TaiKhoan] OFF
GO
/****** Object:  Index [IX_TaiKhoan]    Script Date: 8/21/2021 4:28:02 PM ******/
CREATE NONCLUSTERED INDEX [IX_TaiKhoan] ON [dbo].[TaiKhoan]
(
	[MaTk] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_HoaDon] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HoaDon] ([MaHD])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_HoaDon]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_SanPham] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_SanPham]
GO
ALTER TABLE [dbo].[ChiTietHoaDonNhap]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDonNhap_HoaDonNhap] FOREIGN KEY([SoPN])
REFERENCES [dbo].[HoaDonNhap] ([SoPN])
GO
ALTER TABLE [dbo].[ChiTietHoaDonNhap] CHECK CONSTRAINT [FK_ChiTietHoaDonNhap_HoaDonNhap]
GO
ALTER TABLE [dbo].[ChiTietHoaDonNhap]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDonNhap_SanPham] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[ChiTietHoaDonNhap] CHECK CONSTRAINT [FK_ChiTietHoaDonNhap_SanPham]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_KhachHang] FOREIGN KEY([MaKh])
REFERENCES [dbo].[KhachHang] ([MaKh])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_KhachHang]
GO
ALTER TABLE [dbo].[HoaDonNhap]  WITH CHECK ADD  CONSTRAINT [FK_HoaDonNhap_NhaCungCap] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCungCap] ([MaNCC])
GO
ALTER TABLE [dbo].[HoaDonNhap] CHECK CONSTRAINT [FK_HoaDonNhap_NhaCungCap]
GO
ALTER TABLE [dbo].[HoaDonNhap]  WITH CHECK ADD  CONSTRAINT [FK_HoaDonNhap_TaiKhoan] FOREIGN KEY([MaTk])
REFERENCES [dbo].[TaiKhoan] ([MaTk])
GO
ALTER TABLE [dbo].[HoaDonNhap] CHECK CONSTRAINT [FK_HoaDonNhap_TaiKhoan]
GO
USE [master]
GO
ALTER DATABASE [Nhom6_QLyTiemBanh] SET  READ_WRITE 
GO
