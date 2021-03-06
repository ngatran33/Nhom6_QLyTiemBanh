USE [master]
GO
/****** Object:  Database [Nhom6_QLyTiemBanh]    Script Date: 9/3/2021 5:16:15 PM ******/
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
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 9/3/2021 5:16:16 PM ******/
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
/****** Object:  Table [dbo].[ChiTietHoaDonNhap]    Script Date: 9/3/2021 5:16:16 PM ******/
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
/****** Object:  Table [dbo].[HoaDon]    Script Date: 9/3/2021 5:16:16 PM ******/
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
/****** Object:  Table [dbo].[HoaDonNhap]    Script Date: 9/3/2021 5:16:16 PM ******/
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
/****** Object:  Table [dbo].[KhachHang]    Script Date: 9/3/2021 5:16:16 PM ******/
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
/****** Object:  Table [dbo].[LoaiSanPham]    Script Date: 9/3/2021 5:16:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiSanPham](
	[MaLoaiSP] [int] NOT NULL,
	[TenLoaiSP] [nvarchar](50) NULL,
 CONSTRAINT [PK_LoaiSanPham] PRIMARY KEY CLUSTERED 
(
	[MaLoaiSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 9/3/2021 5:16:16 PM ******/
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
/****** Object:  Table [dbo].[SanPham]    Script Date: 9/3/2021 5:16:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[MaSP] [int] IDENTITY(1,1) NOT NULL,
	[TenSp] [nvarchar](50) NULL,
	[Slco] [int] NULL,
	[Gia] [money] NULL,
	[MaLoaiSP] [int] NULL,
	[NgaySX] [date] NULL,
	[HSD] [date] NULL,
 CONSTRAINT [PK_SanPham] PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 9/3/2021 5:16:16 PM ******/
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
	[GioiTinh] [nvarchar](50) NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[MaTk] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [SoLuongBan], [TongTien]) VALUES (2, 3, 12, 3000000.0000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [SoLuongBan], [TongTien]) VALUES (2, 6, 12, 780000.0000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [SoLuongBan], [TongTien]) VALUES (2, 9, 42, 5166000.0000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [SoLuongBan], [TongTien]) VALUES (3, 2, 12, 1440000.0000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [SoLuongBan], [TongTien]) VALUES (3, 3, 10, 2500000.0000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [SoLuongBan], [TongTien]) VALUES (5, 4, 2, 250000.0000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [SoLuongBan], [TongTien]) VALUES (5, 8, 1, 135000.0000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [SoLuongBan], [TongTien]) VALUES (6, 2, 12, 1440000.0000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [SoLuongBan], [TongTien]) VALUES (6, 4, 2, 250000.0000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [SoLuongBan], [TongTien]) VALUES (7, 4, 12, 1500000.0000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [SoLuongBan], [TongTien]) VALUES (8, 1, 12, 1800000.0000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [SoLuongBan], [TongTien]) VALUES (8, 6, 12, 780000.0000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [SoLuongBan], [TongTien]) VALUES (8, 11, 30, 1350000.0000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [SoLuongBan], [TongTien]) VALUES (9, 4, 10, 1250000.0000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [SoLuongBan], [TongTien]) VALUES (9, 7, 20, 3040000.0000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [SoLuongBan], [TongTien]) VALUES (10, 3, 12, 3000000.0000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [SoLuongBan], [TongTien]) VALUES (10, 4, 12, 1500000.0000)
GO
INSERT [dbo].[ChiTietHoaDonNhap] ([SoPN], [MaSP], [SoLuongNhap], [GiaNhap], [TongTienNhap]) VALUES (1, 1, 10, 120000.0000, 1200000.0000)
INSERT [dbo].[ChiTietHoaDonNhap] ([SoPN], [MaSP], [SoLuongNhap], [GiaNhap], [TongTienNhap]) VALUES (1, 2, 12, 150000.0000, 1800000.0000)
INSERT [dbo].[ChiTietHoaDonNhap] ([SoPN], [MaSP], [SoLuongNhap], [GiaNhap], [TongTienNhap]) VALUES (2, 3, 5, 100000.0000, 500000.0000)
INSERT [dbo].[ChiTietHoaDonNhap] ([SoPN], [MaSP], [SoLuongNhap], [GiaNhap], [TongTienNhap]) VALUES (2, 4, 10, 150000.0000, 1500000.0000)
INSERT [dbo].[ChiTietHoaDonNhap] ([SoPN], [MaSP], [SoLuongNhap], [GiaNhap], [TongTienNhap]) VALUES (3, 4, 12, 90000.0000, 1080000.0000)
INSERT [dbo].[ChiTietHoaDonNhap] ([SoPN], [MaSP], [SoLuongNhap], [GiaNhap], [TongTienNhap]) VALUES (3, 8, 10, 130000.0000, 1300000.0000)
INSERT [dbo].[ChiTietHoaDonNhap] ([SoPN], [MaSP], [SoLuongNhap], [GiaNhap], [TongTienNhap]) VALUES (4, 5, 10, 120000.0000, 1200000.0000)
INSERT [dbo].[ChiTietHoaDonNhap] ([SoPN], [MaSP], [SoLuongNhap], [GiaNhap], [TongTienNhap]) VALUES (4, 7, 12, 150000.0000, 1800000.0000)
INSERT [dbo].[ChiTietHoaDonNhap] ([SoPN], [MaSP], [SoLuongNhap], [GiaNhap], [TongTienNhap]) VALUES (6, 1, 10, 120000.0000, 1200000.0000)
INSERT [dbo].[ChiTietHoaDonNhap] ([SoPN], [MaSP], [SoLuongNhap], [GiaNhap], [TongTienNhap]) VALUES (6, 6, 10, 135000.0000, 1350000.0000)
INSERT [dbo].[ChiTietHoaDonNhap] ([SoPN], [MaSP], [SoLuongNhap], [GiaNhap], [TongTienNhap]) VALUES (7, 1, 10, 150000.0000, 1500000.0000)
INSERT [dbo].[ChiTietHoaDonNhap] ([SoPN], [MaSP], [SoLuongNhap], [GiaNhap], [TongTienNhap]) VALUES (8, 1, 12, 120000.0000, 1440000.0000)
INSERT [dbo].[ChiTietHoaDonNhap] ([SoPN], [MaSP], [SoLuongNhap], [GiaNhap], [TongTienNhap]) VALUES (8, 6, 10, 120000.0000, 1200000.0000)
GO
SET IDENTITY_INSERT [dbo].[HoaDon] ON 

INSERT [dbo].[HoaDon] ([MaHD], [MaKh], [NgayLap]) VALUES (2, 1, CAST(N'2021-08-29' AS Date))
INSERT [dbo].[HoaDon] ([MaHD], [MaKh], [NgayLap]) VALUES (3, 2, CAST(N'2021-08-24' AS Date))
INSERT [dbo].[HoaDon] ([MaHD], [MaKh], [NgayLap]) VALUES (5, 3, CAST(N'2021-06-30' AS Date))
INSERT [dbo].[HoaDon] ([MaHD], [MaKh], [NgayLap]) VALUES (6, 1, CAST(N'2021-07-30' AS Date))
INSERT [dbo].[HoaDon] ([MaHD], [MaKh], [NgayLap]) VALUES (7, 1, CAST(N'2021-09-01' AS Date))
INSERT [dbo].[HoaDon] ([MaHD], [MaKh], [NgayLap]) VALUES (8, 3, CAST(N'2021-09-02' AS Date))
INSERT [dbo].[HoaDon] ([MaHD], [MaKh], [NgayLap]) VALUES (9, 4, CAST(N'2021-09-02' AS Date))
INSERT [dbo].[HoaDon] ([MaHD], [MaKh], [NgayLap]) VALUES (10, 1, CAST(N'2021-09-03' AS Date))
SET IDENTITY_INSERT [dbo].[HoaDon] OFF
GO
SET IDENTITY_INSERT [dbo].[HoaDonNhap] ON 

INSERT [dbo].[HoaDonNhap] ([SoPN], [MaNCC], [MaTk], [NgayNhap]) VALUES (1, 1, 2, CAST(N'2021-06-04' AS Date))
INSERT [dbo].[HoaDonNhap] ([SoPN], [MaNCC], [MaTk], [NgayNhap]) VALUES (2, 2, 1, CAST(N'2021-08-20' AS Date))
INSERT [dbo].[HoaDonNhap] ([SoPN], [MaNCC], [MaTk], [NgayNhap]) VALUES (3, 3, 4, CAST(N'2021-06-09' AS Date))
INSERT [dbo].[HoaDonNhap] ([SoPN], [MaNCC], [MaTk], [NgayNhap]) VALUES (4, 1, 1, CAST(N'2021-09-22' AS Date))
INSERT [dbo].[HoaDonNhap] ([SoPN], [MaNCC], [MaTk], [NgayNhap]) VALUES (5, 1, 1, CAST(N'2021-09-02' AS Date))
INSERT [dbo].[HoaDonNhap] ([SoPN], [MaNCC], [MaTk], [NgayNhap]) VALUES (6, 1, 1, CAST(N'2021-09-02' AS Date))
INSERT [dbo].[HoaDonNhap] ([SoPN], [MaNCC], [MaTk], [NgayNhap]) VALUES (7, 1, 1, CAST(N'2021-09-02' AS Date))
INSERT [dbo].[HoaDonNhap] ([SoPN], [MaNCC], [MaTk], [NgayNhap]) VALUES (8, 1, 1, CAST(N'2021-09-02' AS Date))
SET IDENTITY_INSERT [dbo].[HoaDonNhap] OFF
GO
SET IDENTITY_INSERT [dbo].[KhachHang] ON 

INSERT [dbo].[KhachHang] ([MaKh], [TenKh], [DiaChiKH], [SDTKh]) VALUES (1, N'Trần Thúy Nga', N'Thái nguyên', N'0961362470')
INSERT [dbo].[KhachHang] ([MaKh], [TenKh], [DiaChiKH], [SDTKh]) VALUES (2, N'Vũ Thị Phượng', N'Hưng Yên', N'0363120330')
INSERT [dbo].[KhachHang] ([MaKh], [TenKh], [DiaChiKH], [SDTKh]) VALUES (3, N'Nguyễn Văn Đôn', N'Thái Nguyên', N'0965979655')
INSERT [dbo].[KhachHang] ([MaKh], [TenKh], [DiaChiKH], [SDTKh]) VALUES (4, N'Hoàng Thị Thư', N'Hai Dương', N'0330652112')
INSERT [dbo].[KhachHang] ([MaKh], [TenKh], [DiaChiKH], [SDTKh]) VALUES (5, N'Ngyễn Văn A', N'Hà Nội', N'0919302101')
SET IDENTITY_INSERT [dbo].[KhachHang] OFF
GO
INSERT [dbo].[LoaiSanPham] ([MaLoaiSP], [TenLoaiSP]) VALUES (1, N'Bánh gato')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSP], [TenLoaiSP]) VALUES (2, N'Bánh su kem')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSP], [TenLoaiSP]) VALUES (3, N'Bánh sữa')
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

INSERT [dbo].[SanPham] ([MaSP], [TenSp], [Slco], [Gia], [MaLoaiSP], [NgaySX], [HSD]) VALUES (1, N'Bánh Ngọt', 100, 150000.0000, 1, CAST(N'2021-03-03' AS Date), CAST(N'2021-05-06' AS Date))
INSERT [dbo].[SanPham] ([MaSP], [TenSp], [Slco], [Gia], [MaLoaiSP], [NgaySX], [HSD]) VALUES (2, N'Bánh Mochi Nhật Bản', 120, 120000.0000, 1, CAST(N'2021-01-03' AS Date), CAST(N'2021-03-03' AS Date))
INSERT [dbo].[SanPham] ([MaSP], [TenSp], [Slco], [Gia], [MaLoaiSP], [NgaySX], [HSD]) VALUES (3, N'Bánh Tiramisu Ý', 90, 250000.0000, 1, CAST(N'2021-03-12' AS Date), CAST(N'2021-05-12' AS Date))
INSERT [dbo].[SanPham] ([MaSP], [TenSp], [Slco], [Gia], [MaLoaiSP], [NgaySX], [HSD]) VALUES (4, N'Bánh Macaron Pháp', 41, 125000.0000, 2, CAST(N'2021-04-05' AS Date), CAST(N'2021-06-05' AS Date))
INSERT [dbo].[SanPham] ([MaSP], [TenSp], [Slco], [Gia], [MaLoaiSP], [NgaySX], [HSD]) VALUES (5, N'Bánh Tapioca Brazil', 95, 85000.0000, 2, CAST(N'2021-03-03' AS Date), CAST(N'2021-05-03' AS Date))
INSERT [dbo].[SanPham] ([MaSP], [TenSp], [Slco], [Gia], [MaLoaiSP], [NgaySX], [HSD]) VALUES (6, N'Bánh Sachertorte Áo', 76, 65000.0000, 2, CAST(N'2021-01-03' AS Date), CAST(N'2021-03-03' AS Date))
INSERT [dbo].[SanPham] ([MaSP], [TenSp], [Slco], [Gia], [MaLoaiSP], [NgaySX], [HSD]) VALUES (7, N'Bánh Pavlova Úc', 53, 152000.0000, 2, CAST(N'2021-02-27' AS Date), CAST(N'2021-04-27' AS Date))
INSERT [dbo].[SanPham] ([MaSP], [TenSp], [Slco], [Gia], [MaLoaiSP], [NgaySX], [HSD]) VALUES (8, N'Bánh Black Forest Đức', 412, 135000.0000, 3, CAST(N'2021-05-15' AS Date), CAST(N'2021-07-15' AS Date))
INSERT [dbo].[SanPham] ([MaSP], [TenSp], [Slco], [Gia], [MaLoaiSP], [NgaySX], [HSD]) VALUES (9, N'Bánh Táo Mỹ', 51, 123000.0000, 3, CAST(N'2021-06-03' AS Date), CAST(N'2021-08-03' AS Date))
INSERT [dbo].[SanPham] ([MaSP], [TenSp], [Slco], [Gia], [MaLoaiSP], [NgaySX], [HSD]) VALUES (10, N'ánh Limburg Pie Hà Lan', 74, 184000.0000, 3, CAST(N'2021-01-31' AS Date), CAST(N'2021-03-31' AS Date))
INSERT [dbo].[SanPham] ([MaSP], [TenSp], [Slco], [Gia], [MaLoaiSP], [NgaySX], [HSD]) VALUES (11, N'Bánh Gateau St.Honore', 54, 45000.0000, 3, CAST(N'2021-02-12' AS Date), CAST(N'2021-04-12' AS Date))
INSERT [dbo].[SanPham] ([MaSP], [TenSp], [Slco], [Gia], [MaLoaiSP], [NgaySX], [HSD]) VALUES (12, N'Bánh trifle Anh Quốc', 22, 61000.0000, 3, CAST(N'2021-03-20' AS Date), CAST(N'2021-05-20' AS Date))
INSERT [dbo].[SanPham] ([MaSP], [TenSp], [Slco], [Gia], [MaLoaiSP], [NgaySX], [HSD]) VALUES (13, N'Bánh Donut Mỹ', 79, 300000.0000, 3, CAST(N'2021-02-15' AS Date), CAST(N'2021-04-15' AS Date))
INSERT [dbo].[SanPham] ([MaSP], [TenSp], [Slco], [Gia], [MaLoaiSP], [NgaySX], [HSD]) VALUES (14, N'Bánh Donut Anh', 120, 125000.0000, 2, CAST(N'2021-04-18' AS Date), CAST(N'2021-06-18' AS Date))
INSERT [dbo].[SanPham] ([MaSP], [TenSp], [Slco], [Gia], [MaLoaiSP], [NgaySX], [HSD]) VALUES (15, N'Bánh Ngọt Ngọt', 120, 120000.0000, 2, CAST(N'2021-05-23' AS Date), CAST(N'2021-09-02' AS Date))
SET IDENTITY_INSERT [dbo].[SanPham] OFF
GO
SET IDENTITY_INSERT [dbo].[TaiKhoan] ON 

INSERT [dbo].[TaiKhoan] ([MaTk], [TenDangNhap], [MatKhau], [TinhTrang], [HoTen], [DiaChi_nv], [SoDT_nv], [GioiTinh]) VALUES (1, N'nga', N'123456', 1, N'Trần Thúy Nga', N'Thái Nguyên', N'0961362470', N'Nữ')
INSERT [dbo].[TaiKhoan] ([MaTk], [TenDangNhap], [MatKhau], [TinhTrang], [HoTen], [DiaChi_nv], [SoDT_nv], [GioiTinh]) VALUES (2, N'phuong', N'123456', 1, N'Vũ Thị Phượng', N'Hưng Yên', N'0961365428', N'Nữ')
INSERT [dbo].[TaiKhoan] ([MaTk], [TenDangNhap], [MatKhau], [TinhTrang], [HoTen], [DiaChi_nv], [SoDT_nv], [GioiTinh]) VALUES (3, N'don', N'123456', 1, N'Nguyễn Văn Đôn', N'Thái Nguyên', N'0965979655', N'Nam')
INSERT [dbo].[TaiKhoan] ([MaTk], [TenDangNhap], [MatKhau], [TinhTrang], [HoTen], [DiaChi_nv], [SoDT_nv], [GioiTinh]) VALUES (4, N'thu', N'123456', 0, N'Hoàng Thư', N'Hải Dương', N'0316756129', N'Nữ')
INSERT [dbo].[TaiKhoan] ([MaTk], [TenDangNhap], [MatKhau], [TinhTrang], [HoTen], [DiaChi_nv], [SoDT_nv], [GioiTinh]) VALUES (5, N'nguyena', N'123456', 0, N'Nguyễn Văn A', N'Hà Nội', N'0961452346', N'Nam')
INSERT [dbo].[TaiKhoan] ([MaTk], [TenDangNhap], [MatKhau], [TinhTrang], [HoTen], [DiaChi_nv], [SoDT_nv], [GioiTinh]) VALUES (6, N'tien', N'123456', 1, N'Dương Thuỷ Tiên', N'Thái Nguyên', N'0987654321', N'Nữ')
SET IDENTITY_INSERT [dbo].[TaiKhoan] OFF
GO
/****** Object:  Index [IX_TaiKhoan]    Script Date: 9/3/2021 5:16:16 PM ******/
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
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_LoaiSanPham] FOREIGN KEY([MaLoaiSP])
REFERENCES [dbo].[LoaiSanPham] ([MaLoaiSP])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SanPham_LoaiSanPham]
GO
USE [master]
GO
ALTER DATABASE [Nhom6_QLyTiemBanh] SET  READ_WRITE 
GO
