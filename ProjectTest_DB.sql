USE [master]
GO
/****** Object:  Database [ProjectTest_DB]    Script Date: 2018/7/23 17:38:17 ******/
CREATE DATABASE [ProjectTest_DB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ProjectTest_DB', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\ProjectTest_DB.mdf' , SIZE = 7168KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ProjectTest_DB_log', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\ProjectTest_DB_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [ProjectTest_DB] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ProjectTest_DB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ProjectTest_DB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ProjectTest_DB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ProjectTest_DB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ProjectTest_DB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ProjectTest_DB] SET ARITHABORT OFF 
GO
ALTER DATABASE [ProjectTest_DB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ProjectTest_DB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ProjectTest_DB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ProjectTest_DB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ProjectTest_DB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ProjectTest_DB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ProjectTest_DB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ProjectTest_DB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ProjectTest_DB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ProjectTest_DB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ProjectTest_DB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ProjectTest_DB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ProjectTest_DB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ProjectTest_DB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ProjectTest_DB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ProjectTest_DB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ProjectTest_DB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ProjectTest_DB] SET RECOVERY FULL 
GO
ALTER DATABASE [ProjectTest_DB] SET  MULTI_USER 
GO
ALTER DATABASE [ProjectTest_DB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ProjectTest_DB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ProjectTest_DB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ProjectTest_DB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [ProjectTest_DB] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'ProjectTest_DB', N'ON'
GO
USE [ProjectTest_DB]
GO
/****** Object:  Table [dbo].[JC_CustomerBank]    Script Date: 2018/7/23 17:38:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[JC_CustomerBank](
	[Id] [int] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[CustId] [int] NULL,
	[CardName] [nvarchar](20) NULL,
	[BankName] [nvarchar](100) NULL,
	[BankCard] [nvarchar](25) NULL,
	[OpenBak] [nvarchar](100) NULL,
	[BakProvince] [nvarchar](50) NULL,
	[BakCity] [nvarchar](50) NULL,
	[CardType] [int] NOT NULL CONSTRAINT [DF_JC_CustomerBank_CardType]  DEFAULT ((1)),
	[BankType] [varchar](50) NOT NULL CONSTRAINT [DF_JC_CustomerBank_BankType]  DEFAULT (''),
	[CreateTime] [datetime] NOT NULL CONSTRAINT [DF_JC_CustomerBank_CreateTime]  DEFAULT (getdate()),
	[IsDelete] [int] NOT NULL CONSTRAINT [DF_JC_CustomerBank_IsDelete]  DEFAULT ((0)),
	[Remark] [varchar](100) NULL,
	[ReserveMobile] [varchar](50) NOT NULL CONSTRAINT [DF_JC_CustomerBank_ReserveMobile]  DEFAULT (''),
	[CardNum] [varchar](50) NOT NULL CONSTRAINT [DF_JC_CustomerBank_CardNum]  DEFAULT (''),
	[BankName2Reapal] [varchar](50) NOT NULL CONSTRAINT [DF_JC_CustomerBank_BankName2Reapal]  DEFAULT (''),
	[BankCode2Reapal] [varchar](50) NOT NULL CONSTRAINT [DF_JC_CustomerBank_BankCode2Reapal]  DEFAULT (''),
	[BindId2Reapal] [varchar](50) NOT NULL CONSTRAINT [DF_JC_CustomerBank_BindId2Reapal]  DEFAULT (''),
 CONSTRAINT [PK_JC_CustomerBank] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Score_T]    Script Date: 2018/7/23 17:38:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Score_T](
	[ScoreID] [int] IDENTITY(1,1) NOT NULL,
	[StudentID] [int] NULL,
	[ScoreNum] [decimal](18, 2) NULL,
 CONSTRAINT [PK_Score_T] PRIMARY KEY CLUSTERED 
(
	[ScoreID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Student_T]    Script Date: 2018/7/23 17:38:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student_T](
	[StudentID] [int] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Age] [int] NULL,
 CONSTRAINT [PK_Student_T] PRIMARY KEY CLUSTERED 
(
	[StudentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Score_T]  WITH NOCHECK ADD  CONSTRAINT [FK_Score_T_Score_T] FOREIGN KEY([ScoreID])
REFERENCES [dbo].[Score_T] ([ScoreID])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[Score_T] CHECK CONSTRAINT [FK_Score_T_Score_T]
GO
ALTER TABLE [dbo].[Score_T]  WITH CHECK ADD  CONSTRAINT [FK_Score_T_Score_T1] FOREIGN KEY([ScoreID])
REFERENCES [dbo].[Score_T] ([ScoreID])
GO
ALTER TABLE [dbo].[Score_T] CHECK CONSTRAINT [FK_Score_T_Score_T1]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'JC_CustomerBank', @level2type=N'COLUMN',@level2name=N'Id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'JC_CustomerBank', @level2type=N'COLUMN',@level2name=N'CustId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'持卡人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'JC_CustomerBank', @level2type=N'COLUMN',@level2name=N'CardName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'银行名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'JC_CustomerBank', @level2type=N'COLUMN',@level2name=N'BankName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'银行卡号码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'JC_CustomerBank', @level2type=N'COLUMN',@level2name=N'BankCard'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'支行名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'JC_CustomerBank', @level2type=N'COLUMN',@level2name=N'OpenBak'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'银行省份' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'JC_CustomerBank', @level2type=N'COLUMN',@level2name=N'BakProvince'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'银行城市' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'JC_CustomerBank', @level2type=N'COLUMN',@level2name=N'BakCity'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'卡种 1 储蓄卡/借记卡 2 信用卡/贷记卡 ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'JC_CustomerBank', @level2type=N'COLUMN',@level2name=N'CardType'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'银行类型，小写全称首字母 如中国人民银行 zgrmyh' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'JC_CustomerBank', @level2type=N'COLUMN',@level2name=N'BankType'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'JC_CustomerBank', @level2type=N'COLUMN',@level2name=N'CreateTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'是否删除' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'JC_CustomerBank', @level2type=N'COLUMN',@level2name=N'IsDelete'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'备注' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'JC_CustomerBank', @level2type=N'COLUMN',@level2name=N'Remark'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'银行卡预留手机号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'JC_CustomerBank', @level2type=N'COLUMN',@level2name=N'ReserveMobile'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'身份证' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'JC_CustomerBank', @level2type=N'COLUMN',@level2name=N'CardNum'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'来自融宝返回的银行名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'JC_CustomerBank', @level2type=N'COLUMN',@level2name=N'BankName2Reapal'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'来自融宝返回的银行代码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'JC_CustomerBank', @level2type=N'COLUMN',@level2name=N'BankCode2Reapal'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'来自融宝返回的绑卡编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'JC_CustomerBank', @level2type=N'COLUMN',@level2name=N'BindId2Reapal'
GO
USE [master]
GO
ALTER DATABASE [ProjectTest_DB] SET  READ_WRITE 
GO
