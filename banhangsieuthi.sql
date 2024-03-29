USE [QuanLiBanHang]
GO
/****** Object:  UserDefinedFunction [dbo].[ThongKe]    Script Date: 10/7/2019 9:43:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[ThongKe](@StartTime DATE, @EndTime DATE)
RETURNS @BangThongKe TABLE
(
	ten NVARCHAR(50),
	soluong INT
)AS
BEGIN
	INSERT INTO @BangThongKe 
	SELECT TenHang,HANGHOA.SoLuong FROM dbo.NHAPHANG,dbo.HANGHOA
	WHERE dbo.NHAPHANG.MaHang = dbo.HANGHOA.MaHang
	AND ThoiGian>=@StartTime AND ThoiGian<=@EndTime
	RETURN
END
GO
/****** Object:  Table [dbo].[LAPHOADON]    Script Date: 10/7/2019 9:43:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LAPHOADON](
	[NgayLap] [date] NOT NULL,
	[MaKH] [nchar](10) NULL,
	[MaNV] [nchar](10) NULL,
	[MaHoaDon] [nchar](10) NULL,
	[ThoiGianLap] [time](7) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MUAHANG]    Script Date: 10/7/2019 9:43:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MUAHANG](
	[MaKH] [nchar](10) NOT NULL,
	[MaHang] [nchar](10) NOT NULL,
	[SoLuong] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 10/7/2019 9:43:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[MaKH] [nchar](10) NOT NULL,
	[GioiTinh] [nchar](10) NULL,
	[Tuoi] [smallint] NULL,
 CONSTRAINT [PK_KHACHHANG] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HANGHOA]    Script Date: 10/7/2019 9:43:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HANGHOA](
	[MaHang] [nchar](10) NOT NULL,
	[TenHang] [nvarchar](50) NULL,
	[LoaiHang] [nvarchar](50) NULL,
	[GiaTri] [smallint] NULL,
	[HanSuDung] [date] NULL,
	[SoLuong] [smallint] NOT NULL,
 CONSTRAINT [PK_HANGHOA] PRIMARY KEY CLUSTERED 
(
	[MaHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[XUATHANG]    Script Date: 10/7/2019 9:43:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[XUATHANG] AS
(SELECT NgayLap,TenHang,HANGHOA.SoLuong FROM dbo.LAPHOADON, dbo.KHACHHANG, dbo.MUAHANG,dbo.HANGHOA
WHERE dbo.LAPHOADON.MaKH = dbo.KHACHHANG.MaKH 
AND dbo.KHACHHANG.MaKH = dbo.MUAHANG.MaKH AND dbo.MUAHANG.MaHang = dbo.HANGHOA.MaHang)
GO
/****** Object:  Table [dbo].[ACOUNT]    Script Date: 10/7/2019 9:43:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ACOUNT](
	[UserName] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[MaNV] [nchar](10) NOT NULL,
 CONSTRAINT [PK_ACOUNT] PRIMARY KEY CLUSTERED 
(
	[UserName] ASC,
	[Password] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CHITIETHOADON]    Script Date: 10/7/2019 9:43:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETHOADON](
	[MaCTHD] [nchar](10) NOT NULL,
	[MaHang] [nchar](10) NULL,
	[GiaTri] [smallint] NULL,
	[MaHoaDon] [nchar](10) NOT NULL,
 CONSTRAINT [PK_CHITIETHOADON] PRIMARY KEY CLUSTERED 
(
	[MaCTHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 10/7/2019 9:43:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADON](
	[MaHoaDon] [nchar](10) NOT NULL,
	[TongTien] [smallint] NULL,
 CONSTRAINT [PK_HOADON] PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NGAYCONG]    Script Date: 10/7/2019 9:43:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NGAYCONG](
	[Ngay] [date] NOT NULL,
	[ThoiGianBD] [time](7) NOT NULL,
	[ThoiGianKT] [time](7) NOT NULL,
	[TraLuong] [nvarchar](50) NOT NULL,
	[MaNV] [nchar](10) NOT NULL,
 CONSTRAINT [PK_NGAYCONG] PRIMARY KEY CLUSTERED 
(
	[Ngay] ASC,
	[ThoiGianBD] ASC,
	[ThoiGianKT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 10/7/2019 9:43:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MaNV] [nchar](10) NOT NULL,
	[TenNV] [nvarchar](50) NULL,
	[ChucVu] [nvarchar](50) NULL,
 CONSTRAINT [PK_NHANVIEN] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHAPHANG]    Script Date: 10/7/2019 9:43:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHAPHANG](
	[ThoiGian] [date] NOT NULL,
	[MaHang] [nchar](10) NULL,
	[MaNV] [nchar](10) NULL,
	[SoLuong] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SUDUNGPM]    Script Date: 10/7/2019 9:43:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SUDUNGPM](
	[Ngay] [date] NULL,
	[GioBatDau] [time](7) NULL,
	[GioKetThuc] [time](7) NULL,
	[MaNV] [nchar](10) NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[ACOUNT] ([UserName], [Password], [MaNV]) VALUES (N'a', N'a', N'1         ')
GO
INSERT [dbo].[ACOUNT] ([UserName], [Password], [MaNV]) VALUES (N'dan', N'1', N'2         ')
GO
INSERT [dbo].[CHITIETHOADON] ([MaCTHD], [MaHang], [GiaTri], [MaHoaDon]) VALUES (N'SofpeYRVOr', N'1         ', 7, N'wH511ZHTPx')
GO
INSERT [dbo].[CHITIETHOADON] ([MaCTHD], [MaHang], [GiaTri], [MaHoaDon]) VALUES (N'tbvP2P7rbK', N'1         ', 7, N'tbvP2P7rbK')
GO
INSERT [dbo].[CHITIETHOADON] ([MaCTHD], [MaHang], [GiaTri], [MaHoaDon]) VALUES (N'tRn6MwvvtF', N'1         ', 7, N'DsTS1pMYB9')
GO
INSERT [dbo].[HANGHOA] ([MaHang], [TenHang], [LoaiHang], [GiaTri], [HanSuDung], [SoLuong]) VALUES (N'1         ', N'TH true milk', N'Sữa ', 7, CAST(N'2020-10-06' AS Date), 10)
GO
INSERT [dbo].[HANGHOA] ([MaHang], [TenHang], [LoaiHang], [GiaTri], [HanSuDung], [SoLuong]) VALUES (N'2         ', N'C2', N'Nước ngọt', 10, CAST(N'2019-10-20' AS Date), 40)
GO
INSERT [dbo].[HOADON] ([MaHoaDon], [TongTien]) VALUES (N'DsTS1pMYB9', 7)
GO
INSERT [dbo].[HOADON] ([MaHoaDon], [TongTien]) VALUES (N'tbvP2P7rbK', 7)
GO
INSERT [dbo].[HOADON] ([MaHoaDon], [TongTien]) VALUES (N'wH511ZHTPx', 7)
GO
INSERT [dbo].[KHACHHANG] ([MaKH], [GioiTinh], [Tuoi]) VALUES (N'2nqh09KtKC', N'Nu        ', 21)
GO
INSERT [dbo].[KHACHHANG] ([MaKH], [GioiTinh], [Tuoi]) VALUES (N'5qwX0VeuPB', N'Nam       ', 15)
GO
INSERT [dbo].[KHACHHANG] ([MaKH], [GioiTinh], [Tuoi]) VALUES (N'arTM7a845Y', N'nữ        ', 20)
GO
INSERT [dbo].[KHACHHANG] ([MaKH], [GioiTinh], [Tuoi]) VALUES (N'C1YoNQtvAF', N'Nam       ', 30)
GO
INSERT [dbo].[KHACHHANG] ([MaKH], [GioiTinh], [Tuoi]) VALUES (N'HGWsrhujXy', N'Nam       ', 15)
GO
INSERT [dbo].[KHACHHANG] ([MaKH], [GioiTinh], [Tuoi]) VALUES (N'KE1rI5uZ2y', N'Nam       ', 32)
GO
INSERT [dbo].[KHACHHANG] ([MaKH], [GioiTinh], [Tuoi]) VALUES (N'LDjPTMEe9Z', N'nam       ', 20)
GO
INSERT [dbo].[KHACHHANG] ([MaKH], [GioiTinh], [Tuoi]) VALUES (N'nutzDR21HA', N'Nam       ', 20)
GO
INSERT [dbo].[KHACHHANG] ([MaKH], [GioiTinh], [Tuoi]) VALUES (N'R1iSzlScnd', N'Nam       ', 20)
GO
INSERT [dbo].[KHACHHANG] ([MaKH], [GioiTinh], [Tuoi]) VALUES (N'Rl6kystT8g', N'Nam       ', 15)
GO
INSERT [dbo].[KHACHHANG] ([MaKH], [GioiTinh], [Tuoi]) VALUES (N'rzk05iJMr7', N'Nam       ', 15)
GO
INSERT [dbo].[LAPHOADON] ([NgayLap], [MaKH], [MaNV], [MaHoaDon], [ThoiGianLap]) VALUES (CAST(N'2019-10-06' AS Date), N'5qwX0VeuPB', N'1         ', N'wH511ZHTPx', CAST(N'23:13:00' AS Time))
GO
INSERT [dbo].[LAPHOADON] ([NgayLap], [MaKH], [MaNV], [MaHoaDon], [ThoiGianLap]) VALUES (CAST(N'2019-10-06' AS Date), N'2nqh09KtKC', N'1         ', N'DsTS1pMYB9', CAST(N'23:32:00' AS Time))
GO
INSERT [dbo].[LAPHOADON] ([NgayLap], [MaKH], [MaNV], [MaHoaDon], [ThoiGianLap]) VALUES (CAST(N'2019-10-06' AS Date), N'KE1rI5uZ2y', N'1         ', N'tbvP2P7rbK', CAST(N'23:33:00' AS Time))
GO
INSERT [dbo].[MUAHANG] ([MaKH], [MaHang], [SoLuong]) VALUES (N'rzk05iJMr7', N'1         ', 5)
GO
INSERT [dbo].[MUAHANG] ([MaKH], [MaHang], [SoLuong]) VALUES (N'R1iSzlScnd', N'1         ', 13)
GO
INSERT [dbo].[MUAHANG] ([MaKH], [MaHang], [SoLuong]) VALUES (N'HGWsrhujXy', N'1         ', 5)
GO
INSERT [dbo].[MUAHANG] ([MaKH], [MaHang], [SoLuong]) VALUES (N'Rl6kystT8g', N'1         ', 5)
GO
INSERT [dbo].[MUAHANG] ([MaKH], [MaHang], [SoLuong]) VALUES (N'nutzDR21HA', N'1         ', 5)
GO
INSERT [dbo].[MUAHANG] ([MaKH], [MaHang], [SoLuong]) VALUES (N'arTM7a845Y', N'1         ', 2)
GO
INSERT [dbo].[MUAHANG] ([MaKH], [MaHang], [SoLuong]) VALUES (N'LDjPTMEe9Z', N'1         ', 5)
GO
INSERT [dbo].[MUAHANG] ([MaKH], [MaHang], [SoLuong]) VALUES (N'5qwX0VeuPB', N'1         ', 5)
GO
INSERT [dbo].[MUAHANG] ([MaKH], [MaHang], [SoLuong]) VALUES (N'2nqh09KtKC', N'1         ', 4)
GO
INSERT [dbo].[MUAHANG] ([MaKH], [MaHang], [SoLuong]) VALUES (N'KE1rI5uZ2y', N'1         ', 4)
GO
INSERT [dbo].[NGAYCONG] ([Ngay], [ThoiGianBD], [ThoiGianKT], [TraLuong], [MaNV]) VALUES (CAST(N'2019-10-07' AS Date), CAST(N'09:00:00' AS Time), CAST(N'09:30:00' AS Time), N'Chưa trả', N'2         ')
GO
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [ChucVu]) VALUES (N'1         ', N'Nguyễn Thị Hà', N'Thu Ngân')
GO
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [ChucVu]) VALUES (N'2         ', N'Pham Dan', N'Admin')
GO
INSERT [dbo].[NHAPHANG] ([ThoiGian], [MaHang], [MaNV], [SoLuong]) VALUES (CAST(N'2019-10-06' AS Date), N'1         ', N'1         ', 15)
GO
INSERT [dbo].[NHAPHANG] ([ThoiGian], [MaHang], [MaNV], [SoLuong]) VALUES (CAST(N'2019-10-07' AS Date), N'2         ', N'1         ', 20)
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-06' AS Date), CAST(N'16:08:36' AS Time), CAST(N'16:08:39' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-06' AS Date), CAST(N'16:08:42' AS Time), CAST(N'16:08:45' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-06' AS Date), CAST(N'16:11:54' AS Time), CAST(N'16:11:59' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-06' AS Date), CAST(N'16:18:50' AS Time), CAST(N'16:18:55' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-06' AS Date), CAST(N'16:19:48' AS Time), CAST(N'16:19:54' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-06' AS Date), CAST(N'16:20:24' AS Time), CAST(N'16:20:39' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-06' AS Date), CAST(N'18:18:44' AS Time), CAST(N'18:18:56' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-06' AS Date), CAST(N'18:27:39' AS Time), CAST(N'18:27:56' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-06' AS Date), CAST(N'18:48:50' AS Time), CAST(N'18:49:51' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-06' AS Date), CAST(N'18:50:23' AS Time), CAST(N'18:51:07' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-06' AS Date), CAST(N'18:51:58' AS Time), CAST(N'18:52:02' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-06' AS Date), CAST(N'18:52:12' AS Time), CAST(N'18:52:20' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-06' AS Date), CAST(N'19:02:51' AS Time), CAST(N'19:02:54' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-06' AS Date), CAST(N'19:03:58' AS Time), CAST(N'19:04:04' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-06' AS Date), CAST(N'19:06:01' AS Time), CAST(N'19:06:05' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-06' AS Date), CAST(N'19:09:41' AS Time), CAST(N'19:09:47' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-06' AS Date), CAST(N'19:10:00' AS Time), CAST(N'19:10:05' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-06' AS Date), CAST(N'19:13:17' AS Time), CAST(N'19:13:23' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-06' AS Date), CAST(N'19:34:32' AS Time), CAST(N'19:34:52' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-06' AS Date), CAST(N'19:37:45' AS Time), CAST(N'19:38:07' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-06' AS Date), CAST(N'19:40:58' AS Time), CAST(N'19:41:11' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-06' AS Date), CAST(N'19:42:40' AS Time), CAST(N'19:42:55' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-06' AS Date), CAST(N'19:43:53' AS Time), CAST(N'19:44:00' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-06' AS Date), CAST(N'20:16:01' AS Time), CAST(N'20:16:31' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-06' AS Date), CAST(N'20:24:46' AS Time), CAST(N'20:25:04' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-06' AS Date), CAST(N'22:46:36' AS Time), CAST(N'22:47:07' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-06' AS Date), CAST(N'22:53:37' AS Time), CAST(N'22:54:40' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-06' AS Date), CAST(N'23:01:46' AS Time), CAST(N'23:02:10' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-06' AS Date), CAST(N'23:03:52' AS Time), CAST(N'23:04:14' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-06' AS Date), CAST(N'23:13:43' AS Time), CAST(N'23:14:25' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-06' AS Date), CAST(N'23:32:08' AS Time), CAST(N'23:32:26' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-06' AS Date), CAST(N'23:59:07' AS Time), CAST(N'23:59:11' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-07' AS Date), CAST(N'23:59:53' AS Time), CAST(N'00:00:19' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-07' AS Date), CAST(N'00:00:45' AS Time), CAST(N'00:01:02' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-07' AS Date), CAST(N'00:04:06' AS Time), CAST(N'00:04:42' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-07' AS Date), CAST(N'08:18:06' AS Time), CAST(N'08:19:12' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-07' AS Date), CAST(N'08:31:40' AS Time), CAST(N'08:31:48' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-07' AS Date), CAST(N'08:34:46' AS Time), CAST(N'08:34:53' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-07' AS Date), CAST(N'08:37:55' AS Time), CAST(N'08:38:11' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-07' AS Date), CAST(N'08:39:32' AS Time), CAST(N'08:39:44' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-07' AS Date), CAST(N'08:45:11' AS Time), CAST(N'08:45:35' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-07' AS Date), CAST(N'08:46:21' AS Time), CAST(N'08:46:42' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-07' AS Date), CAST(N'08:47:24' AS Time), CAST(N'08:47:43' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-07' AS Date), CAST(N'08:55:15' AS Time), CAST(N'08:55:33' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-07' AS Date), CAST(N'09:04:20' AS Time), CAST(N'09:04:53' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-07' AS Date), CAST(N'09:08:55' AS Time), CAST(N'09:09:03' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-07' AS Date), CAST(N'09:21:46' AS Time), CAST(N'09:21:57' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-07' AS Date), CAST(N'09:22:54' AS Time), CAST(N'09:23:16' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-07' AS Date), CAST(N'09:23:30' AS Time), CAST(N'09:23:37' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-07' AS Date), CAST(N'09:27:40' AS Time), CAST(N'09:27:57' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-07' AS Date), CAST(N'09:28:09' AS Time), CAST(N'09:28:16' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-07' AS Date), CAST(N'09:31:01' AS Time), CAST(N'09:31:05' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-07' AS Date), CAST(N'09:31:32' AS Time), CAST(N'09:31:43' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-07' AS Date), CAST(N'09:32:47' AS Time), CAST(N'09:33:05' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-07' AS Date), CAST(N'09:34:42' AS Time), CAST(N'09:35:01' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-07' AS Date), CAST(N'10:03:49' AS Time), CAST(N'10:03:55' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-07' AS Date), CAST(N'10:04:15' AS Time), CAST(N'10:04:46' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-07' AS Date), CAST(N'10:09:47' AS Time), CAST(N'10:10:06' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-07' AS Date), CAST(N'10:12:08' AS Time), CAST(N'10:12:30' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-07' AS Date), CAST(N'11:05:44' AS Time), CAST(N'11:05:52' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-07' AS Date), CAST(N'05:40:10' AS Time), CAST(N'05:40:24' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-07' AS Date), CAST(N'05:40:49' AS Time), CAST(N'05:41:02' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-07' AS Date), CAST(N'05:44:55' AS Time), CAST(N'05:45:01' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-07' AS Date), CAST(N'06:46:49' AS Time), CAST(N'06:47:27' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-07' AS Date), CAST(N'09:19:17' AS Time), CAST(N'09:19:43' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-07' AS Date), CAST(N'09:22:05' AS Time), CAST(N'09:22:09' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-07' AS Date), CAST(N'09:22:23' AS Time), CAST(N'09:22:28' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-07' AS Date), CAST(N'09:29:37' AS Time), CAST(N'09:30:03' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-07' AS Date), CAST(N'09:33:51' AS Time), CAST(N'09:34:00' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-07' AS Date), CAST(N'09:34:20' AS Time), CAST(N'09:34:35' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-07' AS Date), CAST(N'09:34:58' AS Time), CAST(N'09:35:02' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-07' AS Date), CAST(N'09:38:48' AS Time), CAST(N'09:38:58' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-07' AS Date), CAST(N'09:43:54' AS Time), CAST(N'09:44:01' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-07' AS Date), CAST(N'09:48:57' AS Time), CAST(N'09:49:11' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-07' AS Date), CAST(N'09:49:45' AS Time), CAST(N'09:49:52' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-07' AS Date), CAST(N'09:50:18' AS Time), CAST(N'09:50:24' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-07' AS Date), CAST(N'12:52:45' AS Time), CAST(N'12:52:57' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-07' AS Date), CAST(N'19:55:55' AS Time), CAST(N'19:56:39' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-07' AS Date), CAST(N'19:57:23' AS Time), CAST(N'19:57:58' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-07' AS Date), CAST(N'21:09:02' AS Time), CAST(N'21:09:09' AS Time), N'2         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-07' AS Date), CAST(N'21:28:57' AS Time), CAST(N'21:29:07' AS Time), N'2         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-07' AS Date), CAST(N'21:35:47' AS Time), CAST(N'21:36:11' AS Time), N'2         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-07' AS Date), CAST(N'21:36:22' AS Time), CAST(N'21:36:43' AS Time), N'2         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-06' AS Date), CAST(N'23:04:58' AS Time), CAST(N'23:05:24' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-06' AS Date), CAST(N'23:06:21' AS Time), CAST(N'23:06:51' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-06' AS Date), CAST(N'23:09:16' AS Time), CAST(N'23:09:24' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-06' AS Date), CAST(N'23:09:50' AS Time), CAST(N'23:10:23' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-06' AS Date), CAST(N'23:10:55' AS Time), CAST(N'23:11:19' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-06' AS Date), CAST(N'23:33:27' AS Time), CAST(N'23:33:44' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-07' AS Date), CAST(N'09:23:09' AS Time), CAST(N'09:23:14' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-07' AS Date), CAST(N'09:23:46' AS Time), CAST(N'09:23:51' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-07' AS Date), CAST(N'09:24:54' AS Time), CAST(N'09:25:06' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-07' AS Date), CAST(N'09:39:31' AS Time), CAST(N'09:39:51' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-07' AS Date), CAST(N'09:41:50' AS Time), CAST(N'09:42:16' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-07' AS Date), CAST(N'09:29:09' AS Time), CAST(N'09:29:14' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-07' AS Date), CAST(N'09:32:40' AS Time), CAST(N'09:32:45' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-07' AS Date), CAST(N'20:01:13' AS Time), CAST(N'20:01:25' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-07' AS Date), CAST(N'20:03:01' AS Time), CAST(N'20:03:31' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-07' AS Date), CAST(N'20:15:53' AS Time), CAST(N'20:15:58' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-07' AS Date), CAST(N'20:16:19' AS Time), CAST(N'20:17:38' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-07' AS Date), CAST(N'20:26:33' AS Time), CAST(N'20:26:40' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-07' AS Date), CAST(N'20:41:34' AS Time), CAST(N'20:42:18' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-07' AS Date), CAST(N'20:42:31' AS Time), CAST(N'20:42:51' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-07' AS Date), CAST(N'20:42:56' AS Time), CAST(N'20:43:10' AS Time), N'1         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-07' AS Date), CAST(N'20:43:16' AS Time), CAST(N'20:43:17' AS Time), N'2         ')
GO
INSERT [dbo].[SUDUNGPM] ([Ngay], [GioBatDau], [GioKetThuc], [MaNV]) VALUES (CAST(N'2019-10-07' AS Date), CAST(N'20:46:09' AS Time), CAST(N'20:46:30' AS Time), N'2         ')
GO
ALTER TABLE [dbo].[ACOUNT]  WITH CHECK ADD  CONSTRAINT [FK_ACOUNT_NHANVIEN] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[ACOUNT] CHECK CONSTRAINT [FK_ACOUNT_NHANVIEN]
GO
ALTER TABLE [dbo].[CHITIETHOADON]  WITH CHECK ADD  CONSTRAINT [FK_HOADON_CTHD] FOREIGN KEY([MaHoaDon])
REFERENCES [dbo].[HOADON] ([MaHoaDon])
GO
ALTER TABLE [dbo].[CHITIETHOADON] CHECK CONSTRAINT [FK_HOADON_CTHD]
GO
ALTER TABLE [dbo].[LAPHOADON]  WITH CHECK ADD  CONSTRAINT [FK_LAPHOADON_HOADON] FOREIGN KEY([MaHoaDon])
REFERENCES [dbo].[HOADON] ([MaHoaDon])
GO
ALTER TABLE [dbo].[LAPHOADON] CHECK CONSTRAINT [FK_LAPHOADON_HOADON]
GO
ALTER TABLE [dbo].[LAPHOADON]  WITH CHECK ADD  CONSTRAINT [FK_MUAHANG_KHACHHANG] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KHACHHANG] ([MaKH])
GO
ALTER TABLE [dbo].[LAPHOADON] CHECK CONSTRAINT [FK_MUAHANG_KHACHHANG]
GO
ALTER TABLE [dbo].[LAPHOADON]  WITH CHECK ADD  CONSTRAINT [FK_MUAHANG_NHANVIEN] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[LAPHOADON] CHECK CONSTRAINT [FK_MUAHANG_NHANVIEN]
GO
ALTER TABLE [dbo].[MUAHANG]  WITH CHECK ADD  CONSTRAINT [FK_MUAHANG_HANGHOA] FOREIGN KEY([MaHang])
REFERENCES [dbo].[HANGHOA] ([MaHang])
GO
ALTER TABLE [dbo].[MUAHANG] CHECK CONSTRAINT [FK_MUAHANG_HANGHOA]
GO
ALTER TABLE [dbo].[MUAHANG]  WITH CHECK ADD  CONSTRAINT [FK_MUAHANG_KHACHHANG1] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KHACHHANG] ([MaKH])
GO
ALTER TABLE [dbo].[MUAHANG] CHECK CONSTRAINT [FK_MUAHANG_KHACHHANG1]
GO
ALTER TABLE [dbo].[NGAYCONG]  WITH CHECK ADD  CONSTRAINT [FK_NGAYCONG_NHANVIEN] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[NGAYCONG] CHECK CONSTRAINT [FK_NGAYCONG_NHANVIEN]
GO
ALTER TABLE [dbo].[NHAPHANG]  WITH CHECK ADD  CONSTRAINT [FK_NHAPHANG_HANGHOA] FOREIGN KEY([MaHang])
REFERENCES [dbo].[HANGHOA] ([MaHang])
GO
ALTER TABLE [dbo].[NHAPHANG] CHECK CONSTRAINT [FK_NHAPHANG_HANGHOA]
GO
ALTER TABLE [dbo].[NHAPHANG]  WITH CHECK ADD  CONSTRAINT [FK_NHAPHANG_NHANVIEN] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[NHAPHANG] CHECK CONSTRAINT [FK_NHAPHANG_NHANVIEN]
GO
ALTER TABLE [dbo].[SUDUNGPM]  WITH CHECK ADD  CONSTRAINT [FK_SUDUNGPM_NHANVIEN] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[SUDUNGPM] CHECK CONSTRAINT [FK_SUDUNGPM_NHANVIEN]
GO
/****** Object:  StoredProcedure [dbo].[UPDATESOLUONG]    Script Date: 10/7/2019 9:43:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UPDATESOLUONG](@SoLuong INT, @MaHang NCHAR(10))
AS BEGIN
	DECLARE @temp INT;
	SELECT @temp = SoLuong FROM dbo.HANGHOA WHERE MaHang = @MaHang;
	SET @temp = @temp - @SoLuong;
	UPDATE dbo.HANGHOA SET SoLuong= @temp WHERE MaHang = @MaHang;
END
GO
