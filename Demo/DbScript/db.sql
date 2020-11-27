USE [master]
GO
/****** Object:  Database [Station]    Script Date: 11/27/2020 8:56:57 PM ******/
CREATE DATABASE [Station]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Station', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\Station.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Station_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\Station_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Station] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Station].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Station] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Station] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Station] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Station] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Station] SET ARITHABORT OFF 
GO
ALTER DATABASE [Station] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Station] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Station] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Station] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Station] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Station] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Station] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Station] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Station] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Station] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Station] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Station] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Station] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Station] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Station] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Station] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Station] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Station] SET RECOVERY FULL 
GO
ALTER DATABASE [Station] SET  MULTI_USER 
GO
ALTER DATABASE [Station] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Station] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Station] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Station] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Station] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Station', N'ON'
GO
USE [Station]
GO
/****** Object:  Table [dbo].[COMMENT]    Script Date: 11/27/2020 8:56:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[COMMENT](
	[COMMENT_ID] [int] IDENTITY(1,1) NOT NULL,
	[POST_ID] [int] NULL,
	[USER_ID] [nvarchar](255) NULL,
	[LIKE_COUNT] [int] NULL,
	[DISLIKE_COUNT] [int] NULL,
	[COMMENT_TIME] [datetimeoffset](7) NULL,
	[COMMNET_CONTENT] [nvarchar](max) NULL,
 CONSTRAINT [PK_COMMENT] PRIMARY KEY CLUSTERED 
(
	[COMMENT_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[POST]    Script Date: 11/27/2020 8:56:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[POST](
	[POST_ID] [int] IDENTITY(1,1) NOT NULL,
	[POST_CONTENT] [nvarchar](max) NULL,
	[POST_TIME] [datetimeoffset](7) NULL,
	[USER_ID] [nvarchar](255) NULL,
 CONSTRAINT [PK_POST] PRIMARY KEY CLUSTERED 
(
	[POST_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[COMMENT] ON 

INSERT [dbo].[COMMENT] ([COMMENT_ID], [POST_ID], [USER_ID], [LIKE_COUNT], [DISLIKE_COUNT], [COMMENT_TIME], [COMMNET_CONTENT]) VALUES (1, 1, N'Sourav', 1, 0, CAST(N'2025-05-21T10:15:30.5555555+07:30' AS DateTimeOffset), N'Some')
INSERT [dbo].[COMMENT] ([COMMENT_ID], [POST_ID], [USER_ID], [LIKE_COUNT], [DISLIKE_COUNT], [COMMENT_TIME], [COMMNET_CONTENT]) VALUES (2, 2, N'Some', 0, 0, CAST(N'2025-05-21T10:15:30.5555555+07:30' AS DateTimeOffset), N'hey')
INSERT [dbo].[COMMENT] ([COMMENT_ID], [POST_ID], [USER_ID], [LIKE_COUNT], [DISLIKE_COUNT], [COMMENT_TIME], [COMMNET_CONTENT]) VALUES (3, 3, N'Sourav', 1, 2, CAST(N'2025-05-21T10:15:30.5555555+07:30' AS DateTimeOffset), N'No')
INSERT [dbo].[COMMENT] ([COMMENT_ID], [POST_ID], [USER_ID], [LIKE_COUNT], [DISLIKE_COUNT], [COMMENT_TIME], [COMMNET_CONTENT]) VALUES (4, 3, N'Some', 0, 1, CAST(N'2025-05-21T10:15:30.5555555+07:30' AS DateTimeOffset), N'Yes')
SET IDENTITY_INSERT [dbo].[COMMENT] OFF
SET IDENTITY_INSERT [dbo].[POST] ON 

INSERT [dbo].[POST] ([POST_ID], [POST_CONTENT], [POST_TIME], [USER_ID]) VALUES (1, N'Some', CAST(N'2025-05-21T10:15:30.5555555+07:30' AS DateTimeOffset), N'Sourav')
INSERT [dbo].[POST] ([POST_ID], [POST_CONTENT], [POST_TIME], [USER_ID]) VALUES (2, N'new', CAST(N'2025-05-21T10:15:30.5555555+07:30' AS DateTimeOffset), N'New')
INSERT [dbo].[POST] ([POST_ID], [POST_CONTENT], [POST_TIME], [USER_ID]) VALUES (3, N'check', CAST(N'2025-05-21T10:15:30.5555555+07:30' AS DateTimeOffset), N'check')
INSERT [dbo].[POST] ([POST_ID], [POST_CONTENT], [POST_TIME], [USER_ID]) VALUES (4, N'Just check', CAST(N'2025-05-21T10:15:30.5555555+07:30' AS DateTimeOffset), N'New')
INSERT [dbo].[POST] ([POST_ID], [POST_CONTENT], [POST_TIME], [USER_ID]) VALUES (5, N'more', CAST(N'2025-05-21T10:15:30.5555555+07:30' AS DateTimeOffset), N'New')
SET IDENTITY_INSERT [dbo].[POST] OFF
USE [master]
GO
ALTER DATABASE [Station] SET  READ_WRITE 
GO
