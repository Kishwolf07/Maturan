USE [SIS]
GO
ALTER TABLE [dbo].[User_Login] DROP CONSTRAINT [FK__User_Logi__role___5AEE82B9]
GO
ALTER TABLE [dbo].[Teacher] DROP CONSTRAINT [FK__Teacher__role_id__5165187F]
GO
ALTER TABLE [dbo].[Student] DROP CONSTRAINT [FK__Student__role_id__4E88ABD4]
GO
ALTER TABLE [dbo].[Grade] DROP CONSTRAINT [FK__Grade__student_i__571DF1D5]
GO
ALTER TABLE [dbo].[Grade] DROP CONSTRAINT [FK__Grade__course_id__5812160E]
GO
ALTER TABLE [dbo].[Course] DROP CONSTRAINT [FK__Course__teacher___5441852A]
GO
ALTER TABLE [dbo].[Admin] DROP CONSTRAINT [FK__Admin__role_id__4BAC3F29]
GO
/****** Object:  Table [dbo].[User_Login]    Script Date: 22/07/2025 11:38:43 pm ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[User_Login]') AND type in (N'U'))
DROP TABLE [dbo].[User_Login]
GO
/****** Object:  Table [dbo].[Teacher]    Script Date: 22/07/2025 11:38:43 pm ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Teacher]') AND type in (N'U'))
DROP TABLE [dbo].[Teacher]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 22/07/2025 11:38:43 pm ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Student]') AND type in (N'U'))
DROP TABLE [dbo].[Student]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 22/07/2025 11:38:43 pm ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Role]') AND type in (N'U'))
DROP TABLE [dbo].[Role]
GO
/****** Object:  Table [dbo].[Grade]    Script Date: 22/07/2025 11:38:43 pm ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Grade]') AND type in (N'U'))
DROP TABLE [dbo].[Grade]
GO
/****** Object:  Table [dbo].[Course]    Script Date: 22/07/2025 11:38:43 pm ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Course]') AND type in (N'U'))
DROP TABLE [dbo].[Course]
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 22/07/2025 11:38:43 pm ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Admin]') AND type in (N'U'))
DROP TABLE [dbo].[Admin]
GO
USE [master]
GO
/****** Object:  Database [SIS]    Script Date: 22/07/2025 11:38:43 pm ******/
DROP DATABASE [SIS]
GO
/****** Object:  Database [SIS]    Script Date: 22/07/2025 11:38:43 pm ******/
CREATE DATABASE [SIS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SIS', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\SIS.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SIS_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\SIS_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [SIS] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SIS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SIS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SIS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SIS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SIS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SIS] SET ARITHABORT OFF 
GO
ALTER DATABASE [SIS] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [SIS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SIS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SIS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SIS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SIS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SIS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SIS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SIS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SIS] SET  ENABLE_BROKER 
GO
ALTER DATABASE [SIS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SIS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SIS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SIS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SIS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SIS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SIS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SIS] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SIS] SET  MULTI_USER 
GO
ALTER DATABASE [SIS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SIS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SIS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SIS] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SIS] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SIS] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [SIS] SET QUERY_STORE = ON
GO
ALTER DATABASE [SIS] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [SIS]
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 22/07/2025 11:38:44 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin](
	[admin_id] [int] NOT NULL,
	[email] [nvarchar](100) NULL,
	[full_name] [nvarchar](100) NULL,
	[role_id] [int] NULL,
	[created_at] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[admin_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Course]    Script Date: 22/07/2025 11:38:44 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Course](
	[course_id] [int] NOT NULL,
	[course_name] [nvarchar](100) NULL,
	[course_code] [nvarchar](20) NULL,
	[description] [nvarchar](150) NULL,
	[credits] [int] NULL,
	[teacher_id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[course_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Grade]    Script Date: 22/07/2025 11:38:44 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Grade](
	[grade_id] [int] NOT NULL,
	[student_id] [int] NULL,
	[course_id] [int] NULL,
	[grade] [float] NULL,
	[semester] [nvarchar](10) NULL,
	[grade_date] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[grade_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 22/07/2025 11:38:44 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[role_id] [int] NOT NULL,
	[role] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[role_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 22/07/2025 11:38:44 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[student_id] [int] NOT NULL,
	[first_name] [nvarchar](50) NULL,
	[last_name] [nvarchar](50) NULL,
	[date_of_birth] [date] NULL,
	[gender] [nvarchar](10) NULL,
	[email] [nvarchar](100) NULL,
	[phone] [nvarchar](20) NULL,
	[address] [nvarchar](150) NULL,
	[enrollment_date] [date] NULL,
	[status] [nvarchar](20) NULL,
	[role_id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[student_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teacher]    Script Date: 22/07/2025 11:38:44 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teacher](
	[teacher_id] [int] NOT NULL,
	[first_name] [nvarchar](50) NULL,
	[last_name] [nvarchar](50) NULL,
	[email] [nvarchar](100) NULL,
	[phone] [nvarchar](20) NULL,
	[hire_date] [date] NULL,
	[department] [nvarchar](100) NULL,
	[specialization] [nvarchar](100) NULL,
	[status] [nvarchar](20) NULL,
	[role_id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[teacher_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User_Login]    Script Date: 22/07/2025 11:38:44 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User_Login](
	[user_id] [int] NOT NULL,
	[username] [nvarchar](50) NULL,
	[password_hash] [nvarchar](100) NULL,
	[role_id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[user_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Admin] ([admin_id], [email], [full_name], [role_id], [created_at]) VALUES (1, N'admin123@gmail.com', N'Lucky M. Ata', 1, CAST(N'2025-07-22T21:59:53.000' AS DateTime))
GO
INSERT [dbo].[Role] ([role_id], [role]) VALUES (1, N'Admin')
INSERT [dbo].[Role] ([role_id], [role]) VALUES (2, N'Student')
INSERT [dbo].[Role] ([role_id], [role]) VALUES (3, N'Teacher')
GO
INSERT [dbo].[Student] ([student_id], [first_name], [last_name], [date_of_birth], [gender], [email], [phone], [address], [enrollment_date], [status], [role_id]) VALUES (101, N'Renno', N'Maturan', CAST(N'2004-04-29' AS Date), N'Male', N'rennom@gmail.com', N'09992345564', N'Cebu City', CAST(N'2023-06-01' AS Date), N'Active', 2)
GO
INSERT [dbo].[Teacher] ([teacher_id], [first_name], [last_name], [email], [phone], [hire_date], [department], [specialization], [status], [role_id]) VALUES (201, N'Raymund', N'Sismunders', N'raymundS@gmail.com', N'09981234567', CAST(N'2022-08-15' AS Date), N'Computer Science', N'Software Engineer', N'Active', 3)
GO
INSERT [dbo].[User_Login] ([user_id], [username], [password_hash], [role_id]) VALUES (1, N'admin123', N'adminbrah', 1)
INSERT [dbo].[User_Login] ([user_id], [username], [password_hash], [role_id]) VALUES (2, N'studen123', N'studentbrah', 2)
INSERT [dbo].[User_Login] ([user_id], [username], [password_hash], [role_id]) VALUES (3, N'teache123', N'teacherbrah', 3)
GO
ALTER TABLE [dbo].[Admin]  WITH CHECK ADD FOREIGN KEY([role_id])
REFERENCES [dbo].[Role] ([role_id])
GO
ALTER TABLE [dbo].[Course]  WITH CHECK ADD FOREIGN KEY([teacher_id])
REFERENCES [dbo].[Teacher] ([teacher_id])
GO
ALTER TABLE [dbo].[Grade]  WITH CHECK ADD FOREIGN KEY([course_id])
REFERENCES [dbo].[Course] ([course_id])
GO
ALTER TABLE [dbo].[Grade]  WITH CHECK ADD FOREIGN KEY([student_id])
REFERENCES [dbo].[Student] ([student_id])
GO
ALTER TABLE [dbo].[Student]  WITH CHECK ADD FOREIGN KEY([role_id])
REFERENCES [dbo].[Role] ([role_id])
GO
ALTER TABLE [dbo].[Teacher]  WITH CHECK ADD FOREIGN KEY([role_id])
REFERENCES [dbo].[Role] ([role_id])
GO
ALTER TABLE [dbo].[User_Login]  WITH CHECK ADD FOREIGN KEY([role_id])
REFERENCES [dbo].[Role] ([role_id])
GO
USE [master]
GO
ALTER DATABASE [SIS] SET  READ_WRITE 
GO
