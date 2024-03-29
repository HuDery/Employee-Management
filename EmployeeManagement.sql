USE [master]
GO
/****** Object:  Database [EmployeeManagement]    Script Date: 3/15/2024 12:40:36 PM ******/
CREATE DATABASE [EmployeeManagement]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'EmployeeManagement', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\EmployeeManagement.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'EmployeeManagement_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\EmployeeManagement_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [EmployeeManagement] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [EmployeeManagement].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [EmployeeManagement] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [EmployeeManagement] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [EmployeeManagement] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [EmployeeManagement] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [EmployeeManagement] SET ARITHABORT OFF 
GO
ALTER DATABASE [EmployeeManagement] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [EmployeeManagement] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [EmployeeManagement] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [EmployeeManagement] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [EmployeeManagement] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [EmployeeManagement] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [EmployeeManagement] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [EmployeeManagement] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [EmployeeManagement] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [EmployeeManagement] SET  DISABLE_BROKER 
GO
ALTER DATABASE [EmployeeManagement] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [EmployeeManagement] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [EmployeeManagement] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [EmployeeManagement] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [EmployeeManagement] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [EmployeeManagement] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [EmployeeManagement] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [EmployeeManagement] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [EmployeeManagement] SET  MULTI_USER 
GO
ALTER DATABASE [EmployeeManagement] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [EmployeeManagement] SET DB_CHAINING OFF 
GO
ALTER DATABASE [EmployeeManagement] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [EmployeeManagement] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [EmployeeManagement] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [EmployeeManagement] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [EmployeeManagement] SET QUERY_STORE = OFF
GO
USE [EmployeeManagement]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 3/15/2024 12:40:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeCode] [nvarchar](20) NOT NULL,
	[EmployeeName] [nvarchar](20) NOT NULL,
	[BirthDay] [date] NOT NULL,
	[RoleId] [int] NOT NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 3/15/2024 12:40:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[Id] [int] NOT NULL,
	[RoleName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Employee] ON 

INSERT [dbo].[Employee] ([Id], [EmployeeCode], [EmployeeName], [BirthDay], [RoleId]) VALUES (8, N'NV_2024_3_14_1', N'Huỳnh Ngô Gia Bảo', CAST(N'1999-03-14' AS Date), 3)
INSERT [dbo].[Employee] ([Id], [EmployeeCode], [EmployeeName], [BirthDay], [RoleId]) VALUES (10, N'NV_2024_3_14_2', N'Nguyễn Bảo Toàn', CAST(N'2001-03-16' AS Date), 2)
INSERT [dbo].[Employee] ([Id], [EmployeeCode], [EmployeeName], [BirthDay], [RoleId]) VALUES (11, N'NV_2024_3_14_3', N'Trân Phú Hưng', CAST(N'2001-03-14' AS Date), 2)
INSERT [dbo].[Employee] ([Id], [EmployeeCode], [EmployeeName], [BirthDay], [RoleId]) VALUES (12, N'NV_2024_3_14_4', N'Trân Phú Mỹ', CAST(N'2001-03-14' AS Date), 2)
INSERT [dbo].[Employee] ([Id], [EmployeeCode], [EmployeeName], [BirthDay], [RoleId]) VALUES (13, N'NV_2024_3_14_5', N'Trân Phú Mỹ Tho', CAST(N'2001-03-14' AS Date), 2)
INSERT [dbo].[Employee] ([Id], [EmployeeCode], [EmployeeName], [BirthDay], [RoleId]) VALUES (14, N'NV_2024_3_14_6', N'Nguyễn Tấn Duy', CAST(N'2001-04-12' AS Date), 1)
INSERT [dbo].[Employee] ([Id], [EmployeeCode], [EmployeeName], [BirthDay], [RoleId]) VALUES (15, N'NV_2024_3_14_7', N'Nguyễn Tấn Hùng', CAST(N'2001-02-12' AS Date), 1)
INSERT [dbo].[Employee] ([Id], [EmployeeCode], [EmployeeName], [BirthDay], [RoleId]) VALUES (16, N'NV_2024_3_14_8', N'Trần Đình Trọng', CAST(N'2001-05-16' AS Date), 3)
INSERT [dbo].[Employee] ([Id], [EmployeeCode], [EmployeeName], [BirthDay], [RoleId]) VALUES (17, N'NV_2024_3_14_9', N'Võ Văn Lý', CAST(N'2004-06-14' AS Date), 3)
INSERT [dbo].[Employee] ([Id], [EmployeeCode], [EmployeeName], [BirthDay], [RoleId]) VALUES (18, N'NV_2024_3_14_10', N'Võ Bình Minh', CAST(N'2004-03-14' AS Date), 3)
INSERT [dbo].[Employee] ([Id], [EmployeeCode], [EmployeeName], [BirthDay], [RoleId]) VALUES (19, N'NV_2024_3_14_11', N'Bùi Như Quỳnh', CAST(N'2001-03-14' AS Date), 1)
INSERT [dbo].[Employee] ([Id], [EmployeeCode], [EmployeeName], [BirthDay], [RoleId]) VALUES (20, N'NV_2024_3_14_12', N'Bùi Ngọc Nữ', CAST(N'2001-03-14' AS Date), 3)
INSERT [dbo].[Employee] ([Id], [EmployeeCode], [EmployeeName], [BirthDay], [RoleId]) VALUES (21, N'NV_2024_3_14_13', N'Khả Ngân', CAST(N'1999-03-14' AS Date), 1)
INSERT [dbo].[Employee] ([Id], [EmployeeCode], [EmployeeName], [BirthDay], [RoleId]) VALUES (22, N'NV_2024_3_14_14', N'Trần Thái Thơ', CAST(N'1991-03-14' AS Date), 1)
INSERT [dbo].[Employee] ([Id], [EmployeeCode], [EmployeeName], [BirthDay], [RoleId]) VALUES (23, N'NV_2024_3_14_15', N'Trần Phúc Thịnh', CAST(N'1995-03-14' AS Date), 1)
INSERT [dbo].[Employee] ([Id], [EmployeeCode], [EmployeeName], [BirthDay], [RoleId]) VALUES (24, N'NV_2024_3_14_16', N'Nguyễn Thị Thâp', CAST(N'1899-03-14' AS Date), 1)
INSERT [dbo].[Employee] ([Id], [EmployeeCode], [EmployeeName], [BirthDay], [RoleId]) VALUES (25, N'NV_2024_3_14_17', N'Nguyễn Văn Hiếu', CAST(N'2000-03-16' AS Date), 3)
INSERT [dbo].[Employee] ([Id], [EmployeeCode], [EmployeeName], [BirthDay], [RoleId]) VALUES (26, N'NV_2024_3_14_18', N'Phan Kim Liên', CAST(N'2000-03-16' AS Date), 3)
SET IDENTITY_INSERT [dbo].[Employee] OFF
GO
INSERT [dbo].[Role] ([Id], [RoleName]) VALUES (1, N'Quản lý')
INSERT [dbo].[Role] ([Id], [RoleName]) VALUES (2, N'Học vụ')
INSERT [dbo].[Role] ([Id], [RoleName]) VALUES (3, N'Tư vấn viên')
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Role] FOREIGN KEY([RoleId])
REFERENCES [dbo].[Role] ([Id])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_Role]
GO
USE [master]
GO
ALTER DATABASE [EmployeeManagement] SET  READ_WRITE 
GO
