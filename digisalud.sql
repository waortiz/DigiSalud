USE [master]
GO
/****** Object:  Database [DigiSaludDesk]    Script Date: 11/11/2019 15:46:20 ******/
CREATE DATABASE [DigiSaludDesk]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DigiSaludDesk', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\DigiSaludDesk.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DigiSaludDesk_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\DigiSaludDesk_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [DigiSaludDesk] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DigiSaludDesk].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DigiSaludDesk] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DigiSaludDesk] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DigiSaludDesk] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DigiSaludDesk] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DigiSaludDesk] SET ARITHABORT OFF 
GO
ALTER DATABASE [DigiSaludDesk] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DigiSaludDesk] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DigiSaludDesk] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DigiSaludDesk] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DigiSaludDesk] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DigiSaludDesk] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DigiSaludDesk] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DigiSaludDesk] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DigiSaludDesk] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DigiSaludDesk] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DigiSaludDesk] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DigiSaludDesk] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DigiSaludDesk] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DigiSaludDesk] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DigiSaludDesk] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DigiSaludDesk] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DigiSaludDesk] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DigiSaludDesk] SET RECOVERY FULL 
GO
ALTER DATABASE [DigiSaludDesk] SET  MULTI_USER 
GO
ALTER DATABASE [DigiSaludDesk] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DigiSaludDesk] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DigiSaludDesk] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DigiSaludDesk] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DigiSaludDesk] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'DigiSaludDesk', N'ON'
GO
ALTER DATABASE [DigiSaludDesk] SET QUERY_STORE = OFF
GO
USE [DigiSaludDesk]
GO
/****** Object:  Table [dbo].[Ciudades]    Script Date: 11/11/2019 15:46:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ciudades](
	[Id] [int] NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Ciudad] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pacientes]    Script Date: 11/11/2019 15:46:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pacientes](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[PrimerNombre] [nvarchar](50) NOT NULL,
	[SegundoNombre] [nvarchar](50) NULL,
	[PrimerApellido] [nvarchar](50) NOT NULL,
	[SegundoApellido] [nvarchar](50) NULL,
	[IdTipoDocumento] [int] NOT NULL,
	[NumeroDocumento] [nvarchar](50) NOT NULL,
	[FechaNacimiento] [datetime] NOT NULL,
	[IdSexo] [int] NOT NULL,
	[Cotizante] [bit] NOT NULL,
	[Salario] [decimal](10, 2) NOT NULL,
	[Direccion] [nvarchar](max) NOT NULL,
	[Telefono] [nvarchar](max) NOT NULL,
	[IdCiudad] [int] NOT NULL,
 CONSTRAINT [PK_Paciente] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sexo]    Script Date: 11/11/2019 15:46:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sexo](
	[Id] [int] NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Sexo] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TiposDocumento]    Script Date: 11/11/2019 15:46:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TiposDocumento](
	[Id] [int] NOT NULL,
	[Nombre] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_TiposDocumento] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Ciudades] ([Id], [Nombre]) VALUES (1, N'Medellín')
INSERT [dbo].[Ciudades] ([Id], [Nombre]) VALUES (2, N'Bogotá')
INSERT [dbo].[Ciudades] ([Id], [Nombre]) VALUES (3, N'Bello')
INSERT [dbo].[Ciudades] ([Id], [Nombre]) VALUES (4, N'Sabaneta')
INSERT [dbo].[Ciudades] ([Id], [Nombre]) VALUES (5, N'Envigado')
INSERT [dbo].[Ciudades] ([Id], [Nombre]) VALUES (6, N'La Estrella')
INSERT [dbo].[Ciudades] ([Id], [Nombre]) VALUES (7, N'Itagüí')
INSERT [dbo].[Ciudades] ([Id], [Nombre]) VALUES (8, N'Barbosa')
INSERT [dbo].[Ciudades] ([Id], [Nombre]) VALUES (9, N'Copacabana')
INSERT [dbo].[Ciudades] ([Id], [Nombre]) VALUES (10, N'Girardota')
INSERT [dbo].[Sexo] ([Id], [Nombre]) VALUES (1, N'Femenino')
INSERT [dbo].[Sexo] ([Id], [Nombre]) VALUES (2, N'Masculino')
INSERT [dbo].[TiposDocumento] ([Id], [Nombre]) VALUES (1, N'Cédula de Ciudadanía')
INSERT [dbo].[TiposDocumento] ([Id], [Nombre]) VALUES (2, N'Tarjeta de Identidad')
INSERT [dbo].[TiposDocumento] ([Id], [Nombre]) VALUES (3, N'Tarjeta de Extranjería')
ALTER TABLE [dbo].[Pacientes]  WITH CHECK ADD  CONSTRAINT [FK_Paciente_Ciudad] FOREIGN KEY([IdCiudad])
REFERENCES [dbo].[Ciudades] ([Id])
GO
ALTER TABLE [dbo].[Pacientes] CHECK CONSTRAINT [FK_Paciente_Ciudad]
GO
ALTER TABLE [dbo].[Pacientes]  WITH CHECK ADD  CONSTRAINT [FK_Paciente_Paciente] FOREIGN KEY([Id])
REFERENCES [dbo].[Pacientes] ([Id])
GO
ALTER TABLE [dbo].[Pacientes] CHECK CONSTRAINT [FK_Paciente_Paciente]
GO
ALTER TABLE [dbo].[Pacientes]  WITH CHECK ADD  CONSTRAINT [FK_Paciente_Sexo] FOREIGN KEY([IdSexo])
REFERENCES [dbo].[Sexo] ([Id])
GO
ALTER TABLE [dbo].[Pacientes] CHECK CONSTRAINT [FK_Paciente_Sexo]
GO
ALTER TABLE [dbo].[Pacientes]  WITH CHECK ADD  CONSTRAINT [FK_Paciente_TiposDocumento] FOREIGN KEY([IdTipoDocumento])
REFERENCES [dbo].[TiposDocumento] ([Id])
GO
ALTER TABLE [dbo].[Pacientes] CHECK CONSTRAINT [FK_Paciente_TiposDocumento]
GO
/****** Object:  StoredProcedure [dbo].[IngresarPaciente]    Script Date: 11/11/2019 15:46:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		William Ortiz
-- Create date: 11/11/2019
-- Description:	Ingresa un paciente
-- =============================================
CREATE PROCEDURE [dbo].[IngresarPaciente]
			@PrimerNombre nvarchar(50)
           ,@SegundoNombre nvarchar(50)
           ,@PrimerApellido nvarchar(50)
           ,@SegundoApellido nvarchar(50)
           ,@IdTipoDocumento int
           ,@NumeroDocumento nvarchar(50)
           ,@FechaNacimiento datetime
           ,@IdSexo int
           ,@Cotizante bit
           ,@Salario decimal(10,2)
           ,@Direccion nvarchar(max)
           ,@Telefono nvarchar(max)
           ,@IdCiudad int
		   ,@IdPaciente bigint out
AS
BEGIN
	
	 INSERT INTO [dbo].[Pacientes]
           ([PrimerNombre]
           ,[SegundoNombre]
           ,[PrimerApellido]
           ,[SegundoApellido]
           ,[IdTipoDocumento]
           ,[NumeroDocumento]
           ,[FechaNacimiento]
           ,[IdSexo]
           ,[Cotizante]
           ,[Salario]
           ,[Direccion]
           ,[Telefono]
           ,[IdCiudad])
     VALUES
           (@PrimerNombre
           ,@SegundoNombre
           ,@PrimerApellido
           ,@SegundoApellido
           ,@IdTipoDocumento
           ,@NumeroDocumento
           ,@FechaNacimiento
           ,@IdSexo
           ,@Cotizante
           ,@Salario
           ,@Direccion
           ,@Telefono
           ,@IdCiudad)

	  SET @IdPaciente = @@IDENTITY

END
GO
USE [master]
GO
ALTER DATABASE [DigiSaludDesk] SET  READ_WRITE 
GO
