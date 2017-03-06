USE [tempdb]
 GO

/****** Object:  Table [dbo].[tblABIData]    Script Date: 27/02/2017 17:39:03 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[tblABIData](
	[ABICode] [varchar](8) NOT NULL,
	[ProductClass] [varchar](2) NULL,
	[Manufacturer] [varchar](30) NULL,
	[Model] [varchar](30) NULL,
	[Trim] [varchar](50) NULL,
	[FullDescription] [varchar](140) NULL,
	[EngineCapacity] [varchar](6) NULL,
	[EngineSize] [varchar](4) NULL,
	[StartYear] [decimal](18, 0) NULL,
	[EndYear] [decimal](18, 0) NULL,
	[NumberOfDoors] [varchar](3) NULL,
	[BodyShape] [varchar](10) NULL,
	[FuelType] [varchar](10) NULL,
	[Transmission] [varchar](12) NULL,
	[LiabilityCategory] [varchar](10) NULL,
	[LCVBody] [varchar](20) NULL,
	[GrossWeight] [decimal](18, 0) NULL,
	[MaxValue] [decimal](18, 0) NULL,
	[SecurityDeviceCategory] [varchar](2) NULL,
	[GreyImport] [varchar](1) NULL,
	[LiabilitySubCategory] [varchar](1) NULL,
	[Status] [varchar](1) NULL,
	[EffectiveDate] [varchar](10) NULL,
	[BodyStyle] [varchar](15) NULL,
	[EngineDescription] [varchar](15) NULL,
	[ShortDescription] [varchar](60) NULL,
	[SequenceNumber] [int] NULL,
 CONSTRAINT [PK_tblABIData] PRIMARY KEY CLUSTERED 
(
	[ABICode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

