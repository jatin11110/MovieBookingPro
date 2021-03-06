USE [master]
GO
/****** Object:  Database [DbMovieBookingPro]    Script Date: 28/06/2021 12:09:56 AM ******/
CREATE DATABASE [DbMovieBookingPro]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MovieBookingPro1_Data', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\MovieBookingPro1.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'MovieBookingPro1_Log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\MovieBookingPro1.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [DbMovieBookingPro] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DbMovieBookingPro].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DbMovieBookingPro] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DbMovieBookingPro] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DbMovieBookingPro] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DbMovieBookingPro] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DbMovieBookingPro] SET ARITHABORT OFF 
GO
ALTER DATABASE [DbMovieBookingPro] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DbMovieBookingPro] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DbMovieBookingPro] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DbMovieBookingPro] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DbMovieBookingPro] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DbMovieBookingPro] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DbMovieBookingPro] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DbMovieBookingPro] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DbMovieBookingPro] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DbMovieBookingPro] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DbMovieBookingPro] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DbMovieBookingPro] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DbMovieBookingPro] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DbMovieBookingPro] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DbMovieBookingPro] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DbMovieBookingPro] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DbMovieBookingPro] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DbMovieBookingPro] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DbMovieBookingPro] SET  MULTI_USER 
GO
ALTER DATABASE [DbMovieBookingPro] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DbMovieBookingPro] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DbMovieBookingPro] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DbMovieBookingPro] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DbMovieBookingPro] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DbMovieBookingPro] SET QUERY_STORE = OFF
GO
USE [DbMovieBookingPro]
GO
/****** Object:  Table [dbo].[tblBooking]    Script Date: 28/06/2021 12:09:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblBooking](
	[BookId] [int] IDENTITY(1,1) NOT NULL,
	[CustomerId] [int] NULL,
	[VideoId] [int] NULL,
	[VideoBook] [nchar](100) NULL,
	[VideoReturn] [nchar](100) NULL,
 CONSTRAINT [PK_tblBooking] PRIMARY KEY CLUSTERED 
(
	[BookId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblCustomer]    Script Date: 28/06/2021 12:09:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCustomer](
	[CustomerId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nchar](100) NULL,
	[Email] [nchar](100) NULL,
	[City] [nchar](100) NULL,
 CONSTRAINT [PK_tblCustomer] PRIMARY KEY CLUSTERED 
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblVideos]    Script Date: 28/06/2021 12:09:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblVideos](
	[VideoId] [int] IDENTITY(1,1) NOT NULL,
	[MovieName] [nchar](10) NULL,
	[MovieRatting] [nchar](10) NULL,
	[MovieYear] [nchar](10) NULL,
	[MovieCost] [nchar](10) NULL,
	[MovieCopies] [nchar](10) NULL,
	[MoviePlot] [nchar](10) NULL,
	[MovieGenre] [nchar](10) NULL,
 CONSTRAINT [PK_tblVideos] PRIMARY KEY CLUSTERED 
(
	[VideoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tblCustomer] ON 

INSERT [dbo].[tblCustomer] ([CustomerId], [Name], [Email], [City]) VALUES (1, N'test                                                                                                ', N'test@gmail.com                                                                                      ', N'aucklan                                                                                             ')
SET IDENTITY_INSERT [dbo].[tblCustomer] OFF
SET IDENTITY_INSERT [dbo].[tblVideos] ON 

INSERT [dbo].[tblVideos] ([VideoId], [MovieName], [MovieRatting], [MovieYear], [MovieCost], [MovieCopies], [MoviePlot], [MovieGenre]) VALUES (2, N'test      ', N'3         ', N'3         ', N'2         ', N'3         ', N'3         ', N'3         ')
SET IDENTITY_INSERT [dbo].[tblVideos] OFF
USE [master]
GO
ALTER DATABASE [DbMovieBookingPro] SET  READ_WRITE 
GO
