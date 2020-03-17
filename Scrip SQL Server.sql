USE [master]
GO
/****** Object:  Database [PROJETOPILOTO_BD]    Script Date: 16/03/2020 15:35:42 ******/
CREATE DATABASE [PROJETOPILOTO_BD]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PROJETOPILOTO_BD', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\PROJETOPILOTO_BD.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'PROJETOPILOTO_BD_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\PROJETOPILOTO_BD_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [PROJETOPILOTO_BD] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PROJETOPILOTO_BD].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PROJETOPILOTO_BD] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PROJETOPILOTO_BD] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PROJETOPILOTO_BD] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PROJETOPILOTO_BD] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PROJETOPILOTO_BD] SET ARITHABORT OFF 
GO
ALTER DATABASE [PROJETOPILOTO_BD] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PROJETOPILOTO_BD] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PROJETOPILOTO_BD] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PROJETOPILOTO_BD] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PROJETOPILOTO_BD] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PROJETOPILOTO_BD] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PROJETOPILOTO_BD] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PROJETOPILOTO_BD] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PROJETOPILOTO_BD] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PROJETOPILOTO_BD] SET  DISABLE_BROKER 
GO
ALTER DATABASE [PROJETOPILOTO_BD] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PROJETOPILOTO_BD] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PROJETOPILOTO_BD] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PROJETOPILOTO_BD] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PROJETOPILOTO_BD] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PROJETOPILOTO_BD] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PROJETOPILOTO_BD] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PROJETOPILOTO_BD] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [PROJETOPILOTO_BD] SET  MULTI_USER 
GO
ALTER DATABASE [PROJETOPILOTO_BD] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PROJETOPILOTO_BD] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PROJETOPILOTO_BD] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PROJETOPILOTO_BD] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [PROJETOPILOTO_BD] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [PROJETOPILOTO_BD] SET QUERY_STORE = OFF
GO
USE [PROJETOPILOTO_BD]
GO
/****** Object:  Table [dbo].[TBPRODUCT]    Script Date: 16/03/2020 15:35:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBPRODUCT](
	[codproduct] [int] IDENTITY(1,1) NOT NULL,
	[typeproduct] [varchar](max) NOT NULL,
	[modelproduct] [varchar](max) NOT NULL,
	[companyproduct] [varchar](max) NOT NULL,
	[sizeproduct] [varchar](max) NOT NULL,
	[amountproduct] [int] NOT NULL,
	[storageproduct] [varchar](max) NOT NULL,
	[imageproduct] [varchar](max) NOT NULL,
	[statusproduct] [int] NOT NULL,
	[dateregisterproduct] [datetime] NOT NULL,
	[userregisterproduct] [varchar](max) NOT NULL,
 CONSTRAINT [PK_TBPRODUCT] PRIMARY KEY CLUSTERED 
(
	[codproduct] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[TBPRODUCT] ADD  CONSTRAINT [DF_TBPRODUCT_statusproduct]  DEFAULT ((1)) FOR [statusproduct]
GO
USE [master]
GO
ALTER DATABASE [PROJETOPILOTO_BD] SET  READ_WRITE 
GO
