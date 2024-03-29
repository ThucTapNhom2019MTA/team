USE [QuanLyKhachSan]
GO
/****** Object:  Table [dbo].[CTHD]    Script Date: 10/10/19 08:35:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTHD](
	[MaHDCT] [nvarchar](10) NOT NULL,
	[MaPhong] [nvarchar](10) NOT NULL,
	[MaDV] [nvarchar](10) NOT NULL,
	[TongTien] [bigint] NULL,
 CONSTRAINT [PK_tblCTHD_1] PRIMARY KEY CLUSTERED 
(
	[MaHDCT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DangNhap]    Script Date: 10/10/19 08:35:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DangNhap](
	[UserName] [nvarchar](20) NULL,
	[Pass] [nvarchar](20) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DichVu]    Script Date: 10/10/19 08:35:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DichVu](
	[MaDV] [nvarchar](10) NOT NULL,
	[TenDV] [nvarchar](50) NULL,
	[Gia] [float] NULL,
	[DonViTinh] [nvarchar](10) NULL,
 CONSTRAINT [PK_tblDichVu] PRIMARY KEY CLUSTERED 
(
	[MaDV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DoDung]    Script Date: 10/10/19 08:35:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DoDung](
	[MaDoDung] [nvarchar](10) NOT NULL,
	[TenDoDung] [nvarchar](50) NULL,
	[SoLuong] [int] NULL,
	[DonViTinh] [nvarchar](10) NULL,
	[TinhTrang] [nvarchar](50) NULL,
	[MaPhong] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_tblDoDung] PRIMARY KEY CLUSTERED 
(
	[MaDoDung] ASC,
	[MaPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 10/10/19 08:35:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHD] [nvarchar](10) NOT NULL,
	[MaKH] [nvarchar](10) NULL,
	[MaHDCT] [nvarchar](10) NULL,
	[NgayLapHD] [date] NULL,
	[NguoiLap] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblHoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachThuePhong]    Script Date: 10/10/19 08:35:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachThuePhong](
	[MaKH] [nvarchar](10) NOT NULL,
	[TenKH] [nvarchar](50) NULL,
	[GT] [nvarchar](3) NULL,
	[NgaySinh] [date] NULL,
	[CMND] [varchar](20) NULL,
 CONSTRAINT [PK_tblKhachThuePhong] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Phong]    Script Date: 10/10/19 08:35:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phong](
	[MaPhong] [nvarchar](10) NOT NULL,
	[TenPhong] [nvarchar](50) NULL,
	[LoaiPhong] [nvarchar](10) NULL,
	[TinhTrang] [nvarchar](50) NULL,
	[GiaPhong] [int] NULL,
 CONSTRAINT [PK_tblPhong] PRIMARY KEY CLUSTERED 
(
	[MaPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[DangNhap] ([UserName], [Pass]) VALUES (N'dat', N'123')
INSERT [dbo].[DangNhap] ([UserName], [Pass]) VALUES (N'huy', N'123')
INSERT [dbo].[DangNhap] ([UserName], [Pass]) VALUES (N'dan', N'123')
INSERT [dbo].[DangNhap] ([UserName], [Pass]) VALUES (N'thang', N'123')
INSERT [dbo].[DangNhap] ([UserName], [Pass]) VALUES (N'quang', N'123')
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [Gia], [DonViTinh]) VALUES (N'DV001', N'Giặt là', 50000, N'VNĐ/lần')
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [Gia], [DonViTinh]) VALUES (N'DV002', N'Ăn sáng', 50000, N'VNĐ/Bữa')
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [Gia], [DonViTinh]) VALUES (N'DV003', N'Ăn trưa', 150000, N'VNĐ/Bữa')
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [Gia], [DonViTinh]) VALUES (N'DV004', N'Ăn tối', 150000, N'VNĐ/Bữa')
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [Gia], [DonViTinh]) VALUES (N'DV005', N'Ăn khuya', 50000, N'VNĐ/Bữa')
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [Gia], [DonViTinh]) VALUES (N'DV006', N'Mát xa', 200000, N'VNĐ/lần')
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [Gia], [DonViTinh]) VALUES (N'DV007', N'Xông hơi', 150000, N'VNĐ/lần')
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [Gia], [DonViTinh]) VALUES (N'DV008', N'Bơi', 20000, N'VNĐ/lần')
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [Gia], [DonViTinh]) VALUES (N'DV009', N'Gym', 350000, N'VNĐ/Tháng')
INSERT [dbo].[DoDung] ([MaDoDung], [TenDoDung], [SoLuong], [DonViTinh], [TinhTrang], [MaPhong]) VALUES (N'DD0001', N'Bàn', 1, N'đơn', N'Bàn to', N'PH101')
INSERT [dbo].[DoDung] ([MaDoDung], [TenDoDung], [SoLuong], [DonViTinh], [TinhTrang], [MaPhong]) VALUES (N'DD0002', N'Bàn', 2, N'đơn', N'Bàn to', N'PH102')
INSERT [dbo].[DoDung] ([MaDoDung], [TenDoDung], [SoLuong], [DonViTinh], [TinhTrang], [MaPhong]) VALUES (N'DD0003', N'Bàn', 3, N'đơn', N'Bàn kích thước 1m x 1m', N'PH103')
INSERT [dbo].[DoDung] ([MaDoDung], [TenDoDung], [SoLuong], [DonViTinh], [TinhTrang], [MaPhong]) VALUES (N'DD0004', N'Bàn', 1, N'đơn', N'Bàn to', N'PH201')
INSERT [dbo].[DoDung] ([MaDoDung], [TenDoDung], [SoLuong], [DonViTinh], [TinhTrang], [MaPhong]) VALUES (N'DD0005', N'Bàn', 1, N'đơn', N'Bàn to', N'PH202')
INSERT [dbo].[DoDung] ([MaDoDung], [TenDoDung], [SoLuong], [DonViTinh], [TinhTrang], [MaPhong]) VALUES (N'DD0006', N'Ghế', 4, N'đơn', N'Ghế tựa', N'PH202')
INSERT [dbo].[DoDung] ([MaDoDung], [TenDoDung], [SoLuong], [DonViTinh], [TinhTrang], [MaPhong]) VALUES (N'DD0007', N'Ghế', 6, N'đơn', N'Ghế tựa', N'PH201')
INSERT [dbo].[DoDung] ([MaDoDung], [TenDoDung], [SoLuong], [DonViTinh], [TinhTrang], [MaPhong]) VALUES (N'DD0008', N'Ghế', 4, N'đơn', N'Ghế tựa', N'PH101')
INSERT [dbo].[DoDung] ([MaDoDung], [TenDoDung], [SoLuong], [DonViTinh], [TinhTrang], [MaPhong]) VALUES (N'DD0009', N'Ghế', 5, N'đơn', N'Ghế tựa', N'PH102')
INSERT [dbo].[DoDung] ([MaDoDung], [TenDoDung], [SoLuong], [DonViTinh], [TinhTrang], [MaPhong]) VALUES (N'DD0010', N'Ghế', 2, N'đơn', N'Ghế tựa', N'PH103')
INSERT [dbo].[DoDung] ([MaDoDung], [TenDoDung], [SoLuong], [DonViTinh], [TinhTrang], [MaPhong]) VALUES (N'DD0011', N'Giường', 2, N'đơn', N'kích thước 1x1 m', N'PH101')
INSERT [dbo].[DoDung] ([MaDoDung], [TenDoDung], [SoLuong], [DonViTinh], [TinhTrang], [MaPhong]) VALUES (N'DD0012', N'Giường', 1, N'đôi', N'kích thước 3x3 m', N'PH201')
INSERT [dbo].[DoDung] ([MaDoDung], [TenDoDung], [SoLuong], [DonViTinh], [TinhTrang], [MaPhong]) VALUES (N'DD0013', N'Giường', 2, N'đôi', N'kích thước 3x3 m', N'PH202')
INSERT [dbo].[DoDung] ([MaDoDung], [TenDoDung], [SoLuong], [DonViTinh], [TinhTrang], [MaPhong]) VALUES (N'DD0014', N'Giường', 1, N'đơn', N'kích thước 1x1 m', N'PH102')
INSERT [dbo].[DoDung] ([MaDoDung], [TenDoDung], [SoLuong], [DonViTinh], [TinhTrang], [MaPhong]) VALUES (N'DD0015', N'Giường', 2, N'đơn', N'kích thước 1x1 m', N'PH103')
INSERT [dbo].[KhachThuePhong] ([MaKH], [TenKH], [GT], [NgaySinh], [CMND]) VALUES (N'KH001', N'Hoàng Huy', N'Nam', CAST(N'1998-06-06' AS Date), N'164531004')
INSERT [dbo].[KhachThuePhong] ([MaKH], [TenKH], [GT], [NgaySinh], [CMND]) VALUES (N'KH002', N'Mạnh Đạt', N'Nam', CAST(N'1997-06-06' AS Date), N'232342344')
INSERT [dbo].[KhachThuePhong] ([MaKH], [TenKH], [GT], [NgaySinh], [CMND]) VALUES (N'KH003', N'Phạm Đan', N'Nam', CAST(N'1998-06-06' AS Date), N'123123123')
INSERT [dbo].[KhachThuePhong] ([MaKH], [TenKH], [GT], [NgaySinh], [CMND]) VALUES (N'KH004', N'Thiện Quang', N'Nam', CAST(N'1999-06-06' AS Date), N'187777888')
INSERT [dbo].[KhachThuePhong] ([MaKH], [TenKH], [GT], [NgaySinh], [CMND]) VALUES (N'KH005', N'Mạnh Thắng', N'Nu', CAST(N'1996-06-06' AS Date), N'162777333')
INSERT [dbo].[KhachThuePhong] ([MaKH], [TenKH], [GT], [NgaySinh], [CMND]) VALUES (N'KH006', N'Van', N'Nam', CAST(N'2000-04-05' AS Date), N'123456543')
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [LoaiPhong], [TinhTrang], [GiaPhong]) VALUES (N'PH101', N'101', N'Bình dân', N'Empty', 1000000)
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [LoaiPhong], [TinhTrang], [GiaPhong]) VALUES (N'PH102', N'102', N'Bình dân', N'Empty', 1000000)
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [LoaiPhong], [TinhTrang], [GiaPhong]) VALUES (N'PH103', N'103', N'Bình dân', N'Empty', 1200000)
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [LoaiPhong], [TinhTrang], [GiaPhong]) VALUES (N'PH201', N'201', N'VIP', N'Empty', 2000000)
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [LoaiPhong], [TinhTrang], [GiaPhong]) VALUES (N'PH202', N'202', N'VIP', N'Empty', 2500000)
ALTER TABLE [dbo].[CTHD]  WITH CHECK ADD  CONSTRAINT [FK_tblCTHD_tblDichVu] FOREIGN KEY([MaDV])
REFERENCES [dbo].[DichVu] ([MaDV])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[CTHD] CHECK CONSTRAINT [FK_tblCTHD_tblDichVu]
GO
ALTER TABLE [dbo].[CTHD]  WITH CHECK ADD  CONSTRAINT [FK_tblCTHD_tblPhong] FOREIGN KEY([MaPhong])
REFERENCES [dbo].[Phong] ([MaPhong])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[CTHD] CHECK CONSTRAINT [FK_tblCTHD_tblPhong]
GO
ALTER TABLE [dbo].[DoDung]  WITH CHECK ADD  CONSTRAINT [FK_tblDoDung_tblPhong1] FOREIGN KEY([MaPhong])
REFERENCES [dbo].[Phong] ([MaPhong])
GO
ALTER TABLE [dbo].[DoDung] CHECK CONSTRAINT [FK_tblDoDung_tblPhong1]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_tblHoaDon_tblCTHD] FOREIGN KEY([MaHDCT])
REFERENCES [dbo].[CTHD] ([MaHDCT])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_tblHoaDon_tblCTHD]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_tblHoaDon_tblKhachThuePhong] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachThuePhong] ([MaKH])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_tblHoaDon_tblKhachThuePhong]
GO
/****** Object:  StoredProcedure [dbo].[ADDKhachThuePhong]    Script Date: 10/10/19 08:35:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ADDKhachThuePhong] (@TenKH nvarchar(50), @GT nvarchar(3), @NgaySinh date, @CMND varchar(20))
AS
BEGIN
	DECLARE @MaKH nchar(10)
	DECLARE @sott int
	DECLARE contro CURSOR FORWARD_ONLY FOR SELECT MaKH FROM KhachThuePhong
	SET @sott = 0
	
	OPEN contro
	FETCH NEXT FROM contro INTO @MaKH
	WHILE (@@FETCH_STATUS = 0)
	BEGIN
		IF((CAST(right(@MaKH, 8) AS int) - @sott) = 1)
		BEGIN
			SET @sott = CAST(right(@MaKH, 8) AS int)
		END
	ELSE BREAK
	

	FETCH NEXT FROM contro INTO @MaKH
	END

	DECLARE @cdai int
	DECLARE @i int
	SET @MaKH = CAST((@sott + 1) as nchar(8))
	SET @cdai = LEN(@MaKH)
	SET @i = 1
	while ( @i <= 8 - @cdai)
	BEGIN
		SET @MaKH = '0' + @MaKH
		SET @i = @i + 1
	END
	SET @MaKH = 'KH' + @MaKH

	INSERT INTO KhachThuePhong values ( @MaKH, @TenKH, @GT, @NgaySinh, @CMND)
	SELECT @MaKH
	CLOSE contro
	DEALLOCATE contro
END
GO
/****** Object:  StoredProcedure [dbo].[ADDPhong]    Script Date: 10/10/19 08:35:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ADDPhong] (@TenPhong nvarchar(50), @LoaiPhong nvarchar(10))
AS 
BEGIN
	DECLARE @MaPhong nchar(10)
	DECLARE @sott int
	DECLARE contro CURSOR FORWARD_ONLY FOR SELECT MaPhong FROM tblPhong
	SET @sott = 0
	
	OPEN contro
	FETCH NEXT FROM contro INTO @MaPhong
	WHILE (@@FETCH_STATUS = 0)
	BEGIN
		IF((CAST(right(@MaPhong, 8) AS int) - @sott) = 1)
		BEGIN
			SET @sott = CAST(right(@MaPhong, 8) AS int)
		END
	ELSE BREAK
	FETCH NEXT FROM contro INTO @MaPhong
END

DECLARE @cdai int
DECLARE @i int
SET @MaPhong = CAST((@sott + 1) as nchar(8))
SET @cdai = LEN(@MaPhong)
SET @i = 1
while ( @i <= 8 - @cdai)
BEGIN
	SET @MaPhong = '0' + @MaPhong
	SET @i = @i + 1
END
SET @MaPhong = 'PH' + @MaPhong

INSERT INTO tblPhong values ( @MaPhong, @TenPhong, @LoaiPhong)
SELECT @MaPhong
CLOSE contro
DEALLOCATE contro
END
GO
/****** Object:  StoredProcedure [dbo].[SuaKhachThuePhong]    Script Date: 10/10/19 08:35:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SuaKhachThuePhong] (@MaKH nvarchar(10), @TenKH nvarchar(50), @GT nvarchar(3), @NgaySinh date, @CMND varchar(20))
AS
BEGIN
	UPDATE KhachThuePhong SET TenKH = @TenKH,GT = @GT, NgaySinh = @NgaySinh, CMND = @CMND WHERE MaKH = @MaKH
END
GO
/****** Object:  StoredProcedure [dbo].[SuaPhong]    Script Date: 10/10/19 08:35:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SuaPhong] (@MaPhong nvarchar(10), @TenPhong nvarchar(50), @LoaiPhong nvarchar(10))
AS
BEGIN
UPDATE tblPhong SET TenPhong=@TenPhong, LoaiPhong=@LoaiPhong
WHERE MaPhong=@MaPhong
END
GO
/****** Object:  StoredProcedure [dbo].[Xoa_KhachThuePhong]    Script Date: 10/10/19 08:35:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Xoa_KhachThuePhong] @MaKH nvarchar(10)
AS
BEGIN
	DELETE FROM KhachThuePhong WHERE MaKH = @MaKH
END
GO
/****** Object:  StoredProcedure [dbo].[Xoa_Phong]    Script Date: 10/10/19 08:35:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Xoa_Phong] (@MaPhong nvarchar(10))
AS
BEGIN
	DELETE FROM tblPhong WHERE MaPhong=@MaPhong
END
GO
