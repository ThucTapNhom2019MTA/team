--create [QLKhoHang]
--go
USE QLKhoHang
GO
/****** Object:  Table [dbo].[DMNhaCungCap]    Script Date: 04/26/2016 16:11:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DMNhaCungCap](
	[mancc] [int] IDENTITY(1,1) NOT NULL,
	[tenncc] [nvarchar](64) NOT NULL,
	[sdtncc] [numeric](18, 0) NOT NULL,
	[emailncc] [varchar](64) NOT NULL,
	[diachincc] [nvarchar](64) NOT NULL,
 CONSTRAINT [PK__DMNhaCun__0A7AC43507020F21] PRIMARY KEY CLUSTERED 
(
	[mancc] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[DMNhaCungCap] ON
INSERT [dbo].[DMNhaCungCap] ([mancc], [tenncc], [sdtncc], [emailncc], [diachincc]) VALUES (2, N'JErry', CAST(1111111111 AS Numeric(18, 0)), N'tun@gmail.com', N'Hà Nội')
INSERT [dbo].[DMNhaCungCap] ([mancc], [tenncc], [sdtncc], [emailncc], [diachincc]) VALUES (3, N'Tung', CAST(1111111111 AS Numeric(18, 0)), N'tun@gmail.com', N'Hà Nội')
SET IDENTITY_INSERT [dbo].[DMNhaCungCap] OFF
/****** Object:  Table [dbo].[DMKhachHang]    Script Date: 04/26/2016 16:11:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DMKhachHang](
	[makh] [int] IDENTITY(1,1) NOT NULL,
	[tenkh] [nvarchar](64) NOT NULL,
	[sdtkh] [numeric](18, 0) NOT NULL,
	[emailkh] [varchar](64) NOT NULL,
	[diachikh] [nvarchar](64) NULL,
 CONSTRAINT [PK__DMKhachH__7A21BB4C7F60ED59] PRIMARY KEY CLUSTERED 
(
	[makh] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[DMKhachHang] ON
INSERT [dbo].[DMKhachHang] ([makh], [tenkh], [sdtkh], [emailkh], [diachikh]) VALUES (2, N'Tùng', CAST(111111 AS Numeric(18, 0)), N'tung@gmail.com', N'Hà Nội')
SET IDENTITY_INSERT [dbo].[DMKhachHang] OFF
/****** Object:  Table [dbo].[DMHangHoa]    Script Date: 04/26/2016 16:11:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DMHangHoa](
	[mahh] [int] IDENTITY(1,1) NOT NULL,
	[tenhh] [nvarchar](100) NOT NULL,
	[soluong] [int] NOT NULL,
	[donvitinh] [nvarchar](64) NOT NULL,
	[ngaynhap] [date] NOT NULL,
 CONSTRAINT [PK__DMHangHo__7A2100A203317E3D] PRIMARY KEY CLUSTERED 
(
	[mahh] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[DMHangHoa] ON
INSERT [dbo].[DMHangHoa] ([mahh], [tenhh], [soluong], [donvitinh], [ngaynhap]) VALUES (4, N'Đồ chơi trẻ em', 11111111, N'chiếc', CAST(0x4F3B0B00 AS Date))
INSERT [dbo].[DMHangHoa] ([mahh], [tenhh], [soluong], [donvitinh], [ngaynhap]) VALUES (5, N'Đồ chơi người lớn', 11111111, N'bộ', CAST(0x4F3B0B00 AS Date))
SET IDENTITY_INSERT [dbo].[DMHangHoa] OFF
/****** Object:  Table [dbo].[TaiKhoanNV]    Script Date: 04/26/2016 16:11:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TaiKhoanNV](
	[MaTK] [int] IDENTITY(1,1) NOT NULL,
	[TenTK] [varchar](64) NOT NULL,
	[Role] [varchar](1) NOT NULL,
	[MKTK] [varchar](64) NOT NULL,
 CONSTRAINT [PK__TaiKhoan__E27F90981A14E395] PRIMARY KEY CLUSTERED 
(
	[MaTK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[TaiKhoanNV] ON
INSERT [dbo].[TaiKhoanNV] ([MaTK], [TenTK], [Role], [MKTK]) VALUES (1, N'admin', N'A', N'administrator'),
																   (2, N'quang', N'B', N'quang');
																   
SET IDENTITY_INSERT [dbo].[TaiKhoanNV] OFF
/****** Object:  Table [dbo].[PhieuXuat]    Script Date: 04/26/2016 16:11:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuXuat](
	[MaPXK] [int] IDENTITY(1,1) NOT NULL,
	[NgayXuat] [date] NOT NULL,
	[NguoiXuat] [nvarchar](64) NOT NULL,
	[MaKH] [int] NOT NULL,
	[SoLuongXuat] [int] NOT NULL,
	[MaHH] [int] NOT NULL,
 CONSTRAINT [PK__PhieuXua__3AE12C571273C1CD] PRIMARY KEY CLUSTERED 
(
	[MaPXK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuNhap]    Script Date: 04/26/2016 16:11:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuNhap](
	[MaPNK] [int] IDENTITY(1,1) NOT NULL,
	[NgayNhap] [datetime] NOT NULL,
	[NguoiNhap] [nvarchar](64) NOT NULL,
	[MaNCC] [int] NOT NULL,
	[SoLuongNhap] [int] NOT NULL,
	[MaHH] [int] NOT NULL,
 CONSTRAINT [PK__PhieuNha__3AE3E7970AD2A005] PRIMARY KEY CLUSTERED 
(
	[MaPNK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[PhieuNhap] ON
INSERT [dbo].[PhieuNhap] ([MaPNK], [NgayNhap], [NguoiNhap], [MaNCC], [SoLuongNhap], [MaHH]) VALUES (3, CAST(0x0000A5F400000000 AS DateTime), N'Tùng', 2, 111111, 4)
INSERT [dbo].[PhieuNhap] ([MaPNK], [NgayNhap], [NguoiNhap], [MaNCC], [SoLuongNhap], [MaHH]) VALUES (6, CAST(0x0000A5F400000000 AS DateTime), N'Tùng', 2, 1111111111, 4)
INSERT [dbo].[PhieuNhap] ([MaPNK], [NgayNhap], [NguoiNhap], [MaNCC], [SoLuongNhap], [MaHH]) VALUES (7, CAST(0x0000A5F400000000 AS DateTime), N'JERRY', 3, 111111, 4)
SET IDENTITY_INSERT [dbo].[PhieuNhap] OFF
/****** Object:  ForeignKey [FK_PhieuNhap_DMHangHoa]    Script Date: 04/26/2016 16:11:53 ******/
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhap_DMHangHoa] FOREIGN KEY([MaHH])
REFERENCES [dbo].[DMHangHoa] ([mahh])
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [FK_PhieuNhap_DMHangHoa]
GO
/****** Object:  ForeignKey [FK_PhieuNhap_DMNhaCungCap]    Script Date: 04/26/2016 16:11:53 ******/
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhap_DMNhaCungCap] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[DMNhaCungCap] ([mancc])
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [FK_PhieuNhap_DMNhaCungCap]
GO
/****** Object:  ForeignKey [FK_PhieuXuat_DMHangHoa]    Script Date: 04/26/2016 16:11:53 ******/
ALTER TABLE [dbo].[PhieuXuat]  WITH CHECK ADD  CONSTRAINT [FK_PhieuXuat_DMHangHoa] FOREIGN KEY([MaHH])
REFERENCES [dbo].[DMHangHoa] ([mahh])
GO
ALTER TABLE [dbo].[PhieuXuat] CHECK CONSTRAINT [FK_PhieuXuat_DMHangHoa]
GO
/****** Object:  ForeignKey [FK_PhieuXuat_DMKhachHang]    Script Date: 04/26/2016 16:11:53 ******/
ALTER TABLE [dbo].[PhieuXuat]  WITH CHECK ADD  CONSTRAINT [FK_PhieuXuat_DMKhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[DMKhachHang] ([makh])
GO
ALTER TABLE [dbo].[PhieuXuat] CHECK CONSTRAINT [FK_PhieuXuat_DMKhachHang]
GO
