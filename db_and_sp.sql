USE [QLVT_DATHANG]
GO
/****** Object:  User [tklink]    Script Date: 01/09/21 9:50:56 PM ******/
CREATE USER [tklink] FOR LOGIN [tklink] WITH DEFAULT_SCHEMA=[tklink]
GO
/****** Object:  DatabaseRole [MSmerge_14331E84F2D14A2C89DE5C2CFC6066FB]    Script Date: 01/09/21 9:50:56 PM ******/
CREATE ROLE [MSmerge_14331E84F2D14A2C89DE5C2CFC6066FB]
GO
/****** Object:  DatabaseRole [MSmerge_889A1646A00B4D8D8A2470365BAB8F7C]    Script Date: 01/09/21 9:50:56 PM ******/
CREATE ROLE [MSmerge_889A1646A00B4D8D8A2470365BAB8F7C]
GO
/****** Object:  DatabaseRole [MSmerge_B44EADC825864A819EB027D96FA36DB0]    Script Date: 01/09/21 9:50:56 PM ******/
CREATE ROLE [MSmerge_B44EADC825864A819EB027D96FA36DB0]
GO
/****** Object:  DatabaseRole [MSmerge_PAL_role]    Script Date: 01/09/21 9:50:56 PM ******/
CREATE ROLE [MSmerge_PAL_role]
GO
ALTER ROLE [db_owner] ADD MEMBER [tklink]
GO
ALTER ROLE [MSmerge_PAL_role] ADD MEMBER [MSmerge_14331E84F2D14A2C89DE5C2CFC6066FB]
GO
ALTER ROLE [MSmerge_PAL_role] ADD MEMBER [MSmerge_889A1646A00B4D8D8A2470365BAB8F7C]
GO
ALTER ROLE [MSmerge_PAL_role] ADD MEMBER [MSmerge_B44EADC825864A819EB027D96FA36DB0]
GO
/****** Object:  View [dbo].[Get_Subcribes]    Script Date: 01/09/21 9:50:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Get_Subcribes]
AS
SELECT  TENCN=PUBS.description, TENSERVER= subscriber_server
   FROM dbo.sysmergepublications PUBS,  dbo.sysmergesubscriptions SUBS
   WHERE PUBS.pubid= SUBS.PUBID  AND PUBS.publisher <> SUBS.subscriber_server
GO
/****** Object:  Table [dbo].[ChiNhanh]    Script Date: 01/09/21 9:50:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiNhanh](
	[MACN] [nchar](10) NOT NULL,
	[ChiNhanh] [nvarchar](100) NOT NULL,
	[DIACHI] [nvarchar](100) NOT NULL,
	[SoDT] [nvarchar](15) NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_ChiNhanh] PRIMARY KEY CLUSTERED 
(
	[MACN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UK_ChiNhanh] UNIQUE NONCLUSTERED 
(
	[ChiNhanh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CTDDH]    Script Date: 01/09/21 9:50:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTDDH](
	[MasoDDH] [nchar](8) NOT NULL,
	[MAVT] [nchar](4) NOT NULL,
	[SOLUONG] [int] NULL,
	[DONGIA] [float] NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_CTDDH] PRIMARY KEY CLUSTERED 
(
	[MasoDDH] ASC,
	[MAVT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CTPN]    Script Date: 01/09/21 9:50:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTPN](
	[MAPN] [nchar](8) NOT NULL,
	[MAVT] [nchar](4) NOT NULL,
	[SOLUONG] [int] NOT NULL,
	[DONGIA] [float] NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_CTPN] PRIMARY KEY CLUSTERED 
(
	[MAPN] ASC,
	[MAVT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CTPX]    Script Date: 01/09/21 9:50:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTPX](
	[MAPX] [nchar](8) NOT NULL,
	[MAVT] [nchar](4) NOT NULL,
	[SOLUONG] [int] NOT NULL,
	[DONGIA] [float] NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_CTPX] PRIMARY KEY CLUSTERED 
(
	[MAPX] ASC,
	[MAVT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DatHang]    Script Date: 01/09/21 9:50:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DatHang](
	[MasoDDH] [nchar](8) NOT NULL,
	[NGAY] [date] NOT NULL,
	[NhaCC] [nvarchar](100) NOT NULL,
	[MAKHO] [nchar](4) NOT NULL,
	[MANV] [nchar](4) NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_DatHang] PRIMARY KEY CLUSTERED 
(
	[MasoDDH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kho]    Script Date: 01/09/21 9:50:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kho](
	[MAKHO] [nchar](4) NOT NULL,
	[TENKHO] [nvarchar](30) NOT NULL,
	[DIACHI] [nvarchar](100) NULL,
	[MACN] [nchar](10) NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_Kho] PRIMARY KEY CLUSTERED 
(
	[MAKHO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UK_TENKHO] UNIQUE NONCLUSTERED 
(
	[TENKHO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 01/09/21 9:50:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MANV] [nchar](4) NOT NULL,
	[HO] [nvarchar](40) NULL,
	[TEN] [nvarchar](10) NULL,
	[DIACHI] [nvarchar](100) NULL,
	[NGAYSINH] [datetime] NULL,
	[LUONG] [float] NULL,
	[MACN] [nchar](10) NULL,
	[TrangThaiXoa] [int] NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MANV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuNhap]    Script Date: 01/09/21 9:50:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuNhap](
	[MAPN] [nchar](8) NOT NULL,
	[NGAY] [date] NOT NULL,
	[MasoDDH] [nchar](8) NOT NULL,
	[MANV] [nchar](4) NOT NULL,
	[MAKHO] [nchar](4) NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_PhieuNhap] PRIMARY KEY CLUSTERED 
(
	[MAPN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UK_MaSoDDH] UNIQUE NONCLUSTERED 
(
	[MasoDDH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuXuat]    Script Date: 01/09/21 9:50:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuXuat](
	[MAPX] [nchar](8) NOT NULL,
	[NGAY] [date] NOT NULL,
	[HOTENKH] [nvarchar](100) NOT NULL,
	[MANV] [nchar](4) NOT NULL,
	[MAKHO] [nchar](4) NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_PX] PRIMARY KEY CLUSTERED 
(
	[MAPX] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vattu]    Script Date: 01/09/21 9:50:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vattu](
	[MAVT] [nchar](4) NOT NULL,
	[TENVT] [nvarchar](30) NOT NULL,
	[DVT] [nvarchar](15) NOT NULL,
	[SOLUONGTON] [int] NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_VatTu] PRIMARY KEY CLUSTERED 
(
	[MAVT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UK_TENVT] UNIQUE NONCLUSTERED 
(
	[TENVT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ChiNhanh] ADD  CONSTRAINT [MSmerge_df_rowguid_4092FEAE177A4C908A70B61692C45412]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[CTDDH] ADD  CONSTRAINT [MSmerge_df_rowguid_2C78F4105A5D47E690656C1E02840E51]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[CTPN] ADD  CONSTRAINT [MSmerge_df_rowguid_E19A4F93186C460B92EF4AB12672BF49]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[CTPX] ADD  CONSTRAINT [MSmerge_df_rowguid_38CC6FE77446427CA1DC6E5D64266FB1]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[DatHang] ADD  CONSTRAINT [DF_DatHang_MasoDDH]  DEFAULT (getdate()) FOR [MasoDDH]
GO
ALTER TABLE [dbo].[DatHang] ADD  CONSTRAINT [DF_DatHang_NGAY]  DEFAULT (getdate()) FOR [NGAY]
GO
ALTER TABLE [dbo].[DatHang] ADD  CONSTRAINT [MSmerge_df_rowguid_9A654BA420064EFDAA2A2BD3D256D224]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[Kho] ADD  CONSTRAINT [MSmerge_df_rowguid_AEEC5EF569BF45F594B26048ED1B5469]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[NhanVien] ADD  CONSTRAINT [DF_NhanVien_TrangThaiXoa]  DEFAULT ((0)) FOR [TrangThaiXoa]
GO
ALTER TABLE [dbo].[NhanVien] ADD  CONSTRAINT [MSmerge_df_rowguid_9180B5DA6D984EE1ADCE16AE21FF0983]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[PhieuNhap] ADD  CONSTRAINT [DF_PhieuNhap_MAPN]  DEFAULT (getdate()) FOR [MAPN]
GO
ALTER TABLE [dbo].[PhieuNhap] ADD  CONSTRAINT [DF_PhieuNhap_NGAY]  DEFAULT (getdate()) FOR [NGAY]
GO
ALTER TABLE [dbo].[PhieuNhap] ADD  CONSTRAINT [MSmerge_df_rowguid_5B6DED1122984F8EA18D6FCB42FC0FEA]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[PhieuXuat] ADD  CONSTRAINT [DF_PX_NGAY]  DEFAULT (getdate()) FOR [NGAY]
GO
ALTER TABLE [dbo].[PhieuXuat] ADD  CONSTRAINT [MSmerge_df_rowguid_3E83870D7DED42EF8AEA39B3E24B247E]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[Vattu] ADD  CONSTRAINT [MSmerge_df_rowguid_F38433E158C34F3EBEF4A631194A46E7]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[CTDDH]  WITH NOCHECK ADD  CONSTRAINT [FK_CTDDH_DatHang] FOREIGN KEY([MasoDDH])
REFERENCES [dbo].[DatHang] ([MasoDDH])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[CTDDH] CHECK CONSTRAINT [FK_CTDDH_DatHang]
GO
ALTER TABLE [dbo].[CTDDH]  WITH NOCHECK ADD  CONSTRAINT [FK_CTDDH_VatTu] FOREIGN KEY([MAVT])
REFERENCES [dbo].[Vattu] ([MAVT])
ON UPDATE CASCADE
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[CTDDH] CHECK CONSTRAINT [FK_CTDDH_VatTu]
GO
ALTER TABLE [dbo].[CTPN]  WITH NOCHECK ADD  CONSTRAINT [FK_CTPN_PhieuNhap] FOREIGN KEY([MAPN])
REFERENCES [dbo].[PhieuNhap] ([MAPN])
ON UPDATE CASCADE
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[CTPN] CHECK CONSTRAINT [FK_CTPN_PhieuNhap]
GO
ALTER TABLE [dbo].[CTPN]  WITH NOCHECK ADD  CONSTRAINT [FK_CTPN_VatTu] FOREIGN KEY([MAVT])
REFERENCES [dbo].[Vattu] ([MAVT])
ON UPDATE CASCADE
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[CTPN] CHECK CONSTRAINT [FK_CTPN_VatTu]
GO
ALTER TABLE [dbo].[CTPX]  WITH NOCHECK ADD  CONSTRAINT [FK_CTPX_PX] FOREIGN KEY([MAPX])
REFERENCES [dbo].[PhieuXuat] ([MAPX])
ON UPDATE CASCADE
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[CTPX] CHECK CONSTRAINT [FK_CTPX_PX]
GO
ALTER TABLE [dbo].[CTPX]  WITH NOCHECK ADD  CONSTRAINT [FK_CTPX_VatTu] FOREIGN KEY([MAVT])
REFERENCES [dbo].[Vattu] ([MAVT])
ON UPDATE CASCADE
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[CTPX] CHECK CONSTRAINT [FK_CTPX_VatTu]
GO
ALTER TABLE [dbo].[DatHang]  WITH CHECK ADD  CONSTRAINT [FK_DatHang_Kho] FOREIGN KEY([MAKHO])
REFERENCES [dbo].[Kho] ([MAKHO])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[DatHang] CHECK CONSTRAINT [FK_DatHang_Kho]
GO
ALTER TABLE [dbo].[DatHang]  WITH NOCHECK ADD  CONSTRAINT [FK_DatHang_NhanVien] FOREIGN KEY([MANV])
REFERENCES [dbo].[NhanVien] ([MANV])
ON UPDATE CASCADE
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[DatHang] CHECK CONSTRAINT [FK_DatHang_NhanVien]
GO
ALTER TABLE [dbo].[Kho]  WITH NOCHECK ADD  CONSTRAINT [FK_Kho_Kho] FOREIGN KEY([MACN])
REFERENCES [dbo].[ChiNhanh] ([MACN])
ON UPDATE CASCADE
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[Kho] CHECK CONSTRAINT [FK_Kho_Kho]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_ChiNhanh] FOREIGN KEY([MACN])
REFERENCES [dbo].[ChiNhanh] ([MACN])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_ChiNhanh]
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH NOCHECK ADD  CONSTRAINT [FK_PhieuNhap_DatHang] FOREIGN KEY([MasoDDH])
REFERENCES [dbo].[DatHang] ([MasoDDH])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [FK_PhieuNhap_DatHang]
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhap_Kho] FOREIGN KEY([MAKHO])
REFERENCES [dbo].[Kho] ([MAKHO])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [FK_PhieuNhap_Kho]
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH NOCHECK ADD  CONSTRAINT [FK_PhieuNhap_NhanVien] FOREIGN KEY([MANV])
REFERENCES [dbo].[NhanVien] ([MANV])
ON UPDATE CASCADE
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [FK_PhieuNhap_NhanVien]
GO
ALTER TABLE [dbo].[PhieuXuat]  WITH CHECK ADD  CONSTRAINT [FK_PhieuXuat_Kho] FOREIGN KEY([MAKHO])
REFERENCES [dbo].[Kho] ([MAKHO])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[PhieuXuat] CHECK CONSTRAINT [FK_PhieuXuat_Kho]
GO
ALTER TABLE [dbo].[PhieuXuat]  WITH NOCHECK ADD  CONSTRAINT [FK_PX_NhanVien] FOREIGN KEY([MANV])
REFERENCES [dbo].[NhanVien] ([MANV])
ON UPDATE CASCADE
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[PhieuXuat] CHECK CONSTRAINT [FK_PX_NhanVien]
GO
ALTER TABLE [dbo].[CTDDH]  WITH NOCHECK ADD  CONSTRAINT [CK_DONGIA] CHECK NOT FOR REPLICATION (([DONGIA]>(0)))
GO
ALTER TABLE [dbo].[CTDDH] CHECK CONSTRAINT [CK_DONGIA]
GO
ALTER TABLE [dbo].[CTDDH]  WITH NOCHECK ADD  CONSTRAINT [CK_SOLUONG] CHECK NOT FOR REPLICATION (([SOLUONG]>(0)))
GO
ALTER TABLE [dbo].[CTDDH] CHECK CONSTRAINT [CK_SOLUONG]
GO
ALTER TABLE [dbo].[CTPN]  WITH NOCHECK ADD  CONSTRAINT [CK_DONGIACTPN] CHECK NOT FOR REPLICATION (([DONGIA]>=(0)))
GO
ALTER TABLE [dbo].[CTPN] CHECK CONSTRAINT [CK_DONGIACTPN]
GO
ALTER TABLE [dbo].[CTPN]  WITH NOCHECK ADD  CONSTRAINT [CK_SOLUONGCTPN] CHECK NOT FOR REPLICATION (([SOLUONG]>(0)))
GO
ALTER TABLE [dbo].[CTPN] CHECK CONSTRAINT [CK_SOLUONGCTPN]
GO
ALTER TABLE [dbo].[CTPX]  WITH NOCHECK ADD  CONSTRAINT [CK_DONGIACTPX] CHECK NOT FOR REPLICATION (([DONGIA]>=(0)))
GO
ALTER TABLE [dbo].[CTPX] CHECK CONSTRAINT [CK_DONGIACTPX]
GO
ALTER TABLE [dbo].[CTPX]  WITH NOCHECK ADD  CONSTRAINT [CK_SOLUONGCTPX] CHECK NOT FOR REPLICATION (([SOLUONG]>(0)))
GO
ALTER TABLE [dbo].[CTPX] CHECK CONSTRAINT [CK_SOLUONGCTPX]
GO
ALTER TABLE [dbo].[NhanVien]  WITH NOCHECK ADD  CONSTRAINT [CK_LUONG] CHECK NOT FOR REPLICATION (([LUONG]>=(4000000)))
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [CK_LUONG]
GO
ALTER TABLE [dbo].[Vattu]  WITH NOCHECK ADD  CONSTRAINT [CK_SOLUONGTON] CHECK NOT FOR REPLICATION (([SOLUONGTON]>=(0)))
GO
ALTER TABLE [dbo].[Vattu] CHECK CONSTRAINT [CK_SOLUONGTON]
GO
/****** Object:  StoredProcedure [dbo].[Get_Branches_ID]    Script Date: 01/09/21 9:50:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Get_Branches_ID]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT MACN
	From dbo.ChiNhanh
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CHECKID]    Script Date: 01/09/21 9:50:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_CHECKID] 
	@Ma NVARCHAR(15),
@Type NVARCHAR(15)
AS
BEGIN
	-- LOP
	IF(@Type = 'MAVT')
	BEGIN	
		IF EXISTS(SELECT * FROM dbo.Vattu WHERE dbo.Vattu.MAVT = @Ma)
			RETURN 1; -- Mã tồn tại ở phân mãnh hiện tại
	END

	RETURN 0	--Không bị trùng được thêm
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CHECKID_CTPN]    Script Date: 01/09/21 9:50:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_CHECKID_CTPN] 
@MAPHIEU NVARCHAR(15),
@MAVT NVARCHAR(15)
AS
BEGIN
	-- LOP
	BEGIN	
		IF EXISTS(SELECT * FROM dbo.CTPN WHERE dbo.CTPN.MAVT = @MAVT AND dbo.CTPN.MAPN=@MAPHIEU)
			RETURN 1; 
	END
	RETURN 0
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CHECKID_PN]    Script Date: 01/09/21 9:50:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_CHECKID_PN]
@MAPHIEU nvarchar(10)
AS
BEGIN	
		
		IF EXISTS(SELECT * FROM dbo.PhieuNhap WHERE dbo.PhieuNhap.MAPN= @MAPHIEU)
			RETURN 1;		
		RETURN 0;
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CHECKNAME]    Script Date: 01/09/21 9:50:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE  [dbo].[SP_CHECKNAME] 
@Name NVARCHAR(15),
@Type NVARCHAR(15)
AS
BEGIN
	IF(@Type = 'TENVT')
	BEGIN	
		IF EXISTS(SELECT * FROM dbo.Vattu WHERE dbo.Vattu.TENVT = @Name)
			RETURN 1; -- Mã tồn tại ở phân mãnh hiện tại
	END

	RETURN 0	--Không bị trùng được thêm
END
GO
/****** Object:  StoredProcedure [dbo].[SP_DANGNHAP]    Script Date: 01/09/21 9:50:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_DANGNHAP]
@TENLOGIN NVARCHAR (50)
AS
DECLARE @TENUSER NVARCHAR(50)
SELECT @TENUSER=NAME FROM sys.sysusers WHERE sid = SUSER_SID(@TENLOGIN)
 
 SELECT USERNAME = @TENUSER, 
  HOTEN = (SELECT HO+ ' '+ TEN FROM NHANVIEN  WHERE MANV = @TENUSER ),
   TENNHOM= NAME
   FROM sys.sysusers 
   WHERE UID = (SELECT GROUPUID 
                 FROM SYS.SYSMEMBERS 
                   WHERE MEMBERUID= (SELECT UID FROM sys.sysusers 
                                      WHERE NAME=@TENUSER))
GO
/****** Object:  StoredProcedure [dbo].[SP_GET_CTDDH_VATTU]    Script Date: 01/09/21 9:50:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_GET_CTDDH_VATTU]
	-- Add the parameters for the stored procedure here
	@maddh nchar(8)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.

    select Vattu.MAVT, TENVT
	from (SELECT MAVT FROM CTDDH WHERE MasoDDH = @maddh) as MaVatTu, Vattu
	where MaVatTu.MAVT = Vattu.MAVT
END
GO
