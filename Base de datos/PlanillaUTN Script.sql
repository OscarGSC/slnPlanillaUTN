USE [master]
GO
/****** Object:  Database [PlanillaUTN]    Script Date: 4/13/2021 6:48:15 PM ******/
CREATE DATABASE [PlanillaUTN]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'IQ2019ExamenII', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\PlanillaUTN.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'IQ2019ExamenII_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\PlanillaUTN_log.ldf' , SIZE = 3136KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PlanillaUTN].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PlanillaUTN] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PlanillaUTN] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PlanillaUTN] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PlanillaUTN] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PlanillaUTN] SET ARITHABORT OFF 
GO
ALTER DATABASE [PlanillaUTN] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PlanillaUTN] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PlanillaUTN] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PlanillaUTN] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PlanillaUTN] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PlanillaUTN] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PlanillaUTN] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PlanillaUTN] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PlanillaUTN] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PlanillaUTN] SET  DISABLE_BROKER 
GO
ALTER DATABASE [PlanillaUTN] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PlanillaUTN] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PlanillaUTN] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PlanillaUTN] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PlanillaUTN] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PlanillaUTN] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PlanillaUTN] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PlanillaUTN] SET RECOVERY FULL 
GO
ALTER DATABASE [PlanillaUTN] SET  MULTI_USER 
GO
ALTER DATABASE [PlanillaUTN] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PlanillaUTN] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PlanillaUTN] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PlanillaUTN] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [PlanillaUTN]
GO
/****** Object:  Table [dbo].[Categoria]    Script Date: 4/13/2021 6:48:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categoria](
	[id] [varchar](20) NOT NULL,
	[descripcion] [varchar](50) NULL,
	[salarioBase] [money] NULL,
	[costoAnualidad] [money] NULL,
 CONSTRAINT [PK_Categoria] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Docente]    Script Date: 4/13/2021 6:48:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Docente](
	[id] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
	[apellido] [varchar](50) NULL,
	[fechaIngreso] [date] NULL,
	[email] [varchar](50) NULL,
	[idCategoria] [varchar](20) NULL,
 CONSTRAINT [PK_Docente] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Jornada]    Script Date: 4/13/2021 6:48:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Jornada](
	[id] [int] NOT NULL,
	[descripcion] [varchar](50) NULL,
	[porcentajeSalario] [int] NULL,
 CONSTRAINT [PK_Jornada] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nombramiento]    Script Date: 4/13/2021 6:48:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nombramiento](
	[idDocente] [int] NOT NULL,
	[idJornada] [int] NOT NULL,
 CONSTRAINT [PK_Nombramiento] PRIMARY KEY CLUSTERED 
(
	[idDocente] ASC,
	[idJornada] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Categoria] ([id], [descripcion], [salarioBase], [costoAnualidad]) VALUES (N'1', N'profesor 1', 609176.0000, 3000.0000)
GO
INSERT [dbo].[Categoria] ([id], [descripcion], [salarioBase], [costoAnualidad]) VALUES (N'2', N'profesor 2', 706302.0000, 3100.0000)
GO
INSERT [dbo].[Categoria] ([id], [descripcion], [salarioBase], [costoAnualidad]) VALUES (N'3', N'profesor 3', 783108.0000, 3200.0000)
GO
INSERT [dbo].[Categoria] ([id], [descripcion], [salarioBase], [costoAnualidad]) VALUES (N'4', N'profesor 4', 865558.0000, 3300.0000)
GO
INSERT [dbo].[Categoria] ([id], [descripcion], [salarioBase], [costoAnualidad]) VALUES (N'5', N'especialista 1', 865558.0000, 3400.0000)
GO
INSERT [dbo].[Docente] ([id], [nombre], [apellido], [fechaIngreso], [email], [idCategoria]) VALUES (123123, N'María', N'Chaves', CAST(N'2009-10-01' AS Date), N'mchaves@utn.ac.cr', N'1')
GO
INSERT [dbo].[Docente] ([id], [nombre], [apellido], [fechaIngreso], [email], [idCategoria]) VALUES (234234, N'Luis', N'Campos', CAST(N'2000-01-01' AS Date), N'lcampos@utn.ac.cr', N'2')
GO
INSERT [dbo].[Docente] ([id], [nombre], [apellido], [fechaIngreso], [email], [idCategoria]) VALUES (345345, N'Camila', N'Ulate', CAST(N'2005-01-09' AS Date), N'culate@utn.ac.cr', N'5')
GO
INSERT [dbo].[Docente] ([id], [nombre], [apellido], [fechaIngreso], [email], [idCategoria]) VALUES (456456, N'Isabel', N'González', CAST(N'2001-01-07' AS Date), N'igonzalez@utn.ac.cr', N'3')
GO
INSERT [dbo].[Docente] ([id], [nombre], [apellido], [fechaIngreso], [email], [idCategoria]) VALUES (567567, N'Jose', N'Arce', CAST(N'2010-01-10' AS Date), N'jarce@utn.ac.cr', N'4')
GO
INSERT [dbo].[Docente] ([id], [nombre], [apellido], [fechaIngreso], [email], [idCategoria]) VALUES (678678, N'Vanessa', N'Flores', CAST(N'2017-01-09' AS Date), N'vflores@utn.ac.cr', N'3')
GO
INSERT [dbo].[Jornada] ([id], [descripcion], [porcentajeSalario]) VALUES (1, N'tiempo completo', 100)
GO
INSERT [dbo].[Jornada] ([id], [descripcion], [porcentajeSalario]) VALUES (2, N'medio tiempo', 50)
GO
INSERT [dbo].[Jornada] ([id], [descripcion], [porcentajeSalario]) VALUES (3, N'cuarto tiempo', 25)
GO
INSERT [dbo].[Jornada] ([id], [descripcion], [porcentajeSalario]) VALUES (4, N'tres cuartos tiempo', 75)
GO
INSERT [dbo].[Nombramiento] ([idDocente], [idJornada]) VALUES (234234, 1)
GO
INSERT [dbo].[Nombramiento] ([idDocente], [idJornada]) VALUES (567567, 2)
GO
INSERT [dbo].[Nombramiento] ([idDocente], [idJornada]) VALUES (567567, 3)
GO
ALTER TABLE [dbo].[Docente]  WITH CHECK ADD  CONSTRAINT [FK_Docente_Categoria] FOREIGN KEY([idCategoria])
REFERENCES [dbo].[Categoria] ([id])
GO
ALTER TABLE [dbo].[Docente] CHECK CONSTRAINT [FK_Docente_Categoria]
GO
ALTER TABLE [dbo].[Nombramiento]  WITH CHECK ADD  CONSTRAINT [FK_Nombramiento_Docente] FOREIGN KEY([idDocente])
REFERENCES [dbo].[Docente] ([id])
GO
ALTER TABLE [dbo].[Nombramiento] CHECK CONSTRAINT [FK_Nombramiento_Docente]
GO
ALTER TABLE [dbo].[Nombramiento]  WITH CHECK ADD  CONSTRAINT [FK_Nombramiento_Jornada] FOREIGN KEY([idJornada])
REFERENCES [dbo].[Jornada] ([id])
GO
ALTER TABLE [dbo].[Nombramiento] CHECK CONSTRAINT [FK_Nombramiento_Jornada]
GO
/****** Object:  StoredProcedure [dbo].[SP_ActualizarCategoria]    Script Date: 4/13/2021 6:48:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_ActualizarCategoria]
	(@Id	varchar(20)
	,@Descripcion	varchar(50)
	,@SalarioBase	money
	,@CostoAnualidad	money)
AS
BEGIN

UPDATE [dbo].[Categoria]
   SET [Descripcion] = @Descripcion
      ,[salarioBase] = @SalarioBase
	  ,[costoAnualidad] = @CostoAnualidad
 WHERE [Id] = @Id

END
GO
/****** Object:  StoredProcedure [dbo].[SP_ActualizarDocente]    Script Date: 4/13/2021 6:48:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_ActualizarDocente]
	(@Id int
	,@Nombre	varchar(50)
	,@Apellido	varchar(50)
	,@FechaIngreso	datetime
	,@email varchar(50)
	,@IdCategoria varchar(20))
AS
BEGIN

	UPDATE [dbo].[Docente]
	   SET [Nombre] = @Nombre
		  ,[apellido] = @Apellido
		  ,[fechaIngreso] = @FechaIngreso	
		  ,[Email] = @email
		  ,[idCategoria] = @IdCategoria
	 WHERE [Id] = @Id

END
GO
/****** Object:  StoredProcedure [dbo].[SP_ActualizarJornada]    Script Date: 4/13/2021 6:48:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_ActualizarJornada]
	(@Id	int
	,@Descripcion	varchar(50)
	,@porcentaje int)
AS
BEGIN

UPDATE [dbo].[Jornada]
   SET [Descripcion] = @Descripcion
      ,[porcentajeSalario] = @porcentaje
 WHERE [Id] = @Id

END
GO
/****** Object:  StoredProcedure [dbo].[SP_ActualizarNombramientoporIdDocente]    Script Date: 4/13/2021 6:48:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_ActualizarNombramientoporIdDocente]
	(@IdDocente	int
	,@IdJornada	int)
AS
BEGIN

UPDATE [dbo].[Nombramiento]
   SET [idJornada] = @IdJornada
 WHERE [idDocente] = @IdDocente

END
GO
/****** Object:  StoredProcedure [dbo].[SP_EliminarNombramiento]    Script Date: 4/13/2021 6:48:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_EliminarNombramiento]
	(@IdDocente	int
	,@IdJornada	int)
AS
BEGIN

DELETE FROM [dbo].[Nombramiento]
      WHERE idDocente = @IdDocente
	  AND idJornada = @IdJornada

END
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertarCategoria]    Script Date: 4/13/2021 6:48:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_InsertarCategoria]
	(@Id	varchar(20)
	,@Descripcion	varchar(50)
	,@SalarioBase money
	,@CostoAnualidad money)
AS
BEGIN

INSERT INTO [dbo].[Categoria]
           ([id]
           ,[descripcion]
           ,[salarioBase]
		   ,[costoAnualidad])
     VALUES
           (@Id
           ,@Descripcion
           ,@SalarioBase
		   ,@CostoAnualidad)

END
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertarDocente]    Script Date: 4/13/2021 6:48:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_InsertarDocente]
	(@Id int
	,@Nombre	varchar(50)
	,@Apellido	varchar(50)
	,@FechaIngreso	datetime
	,@email varchar(50)
	,@IdCategoria varchar(20))
AS
BEGIN

	Insert into [dbo].[Docente]
	   ([id]
		  ,[Nombre]
		  ,[apellido]
		  ,[fechaIngreso]
		  ,[Email]
		  ,[idCategoria])
		values (
		@Id,
		@Nombre,
		@Apellido,
		@FechaIngreso,
		@email,
		@IdCategoria)

END
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertarJornada]    Script Date: 4/13/2021 6:48:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_InsertarJornada]
	(@Id int
	,@Descripcion	varchar(50)
	,@porcentaje int)
AS
BEGIN

INSERT INTO [dbo].[Jornada]
           ([id]
           ,[descripcion]
           ,[porcentajeSalario])
     VALUES
           (@Id
           ,@Descripcion
           ,@porcentaje)

END
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertarNombramiento]    Script Date: 4/13/2021 6:48:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_InsertarNombramiento]
	(@IdDocente	int
	,@IdJornada	int)
AS
BEGIN

INSERT INTO [dbo].[Nombramiento]
           ([idDocente]
           ,[idJornada])
     VALUES
           (@IdDocente
           ,@IdJornada
           )

END
GO
/****** Object:  StoredProcedure [dbo].[SP_SeleccionarCategoriaPorId]    Script Date: 4/13/2021 6:48:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_SeleccionarCategoriaPorId]
	(@Id int)
AS
BEGIN

SELECT [Id]
      ,[descripcion]	
	  ,[salarioBase]
	  ,[costoAnualidad]
  FROM [dbo].[Categoria]
  WHERE Id = @Id

END
GO
/****** Object:  StoredProcedure [dbo].[SP_SeleccionarCategorias]    Script Date: 4/13/2021 6:48:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_SeleccionarCategorias]

AS
BEGIN

SELECT [Id]
      ,[Descripcion]
      ,[SalarioBase]
	  ,[costoAnualidad]
  FROM [dbo].[Categoria]

END
GO
/****** Object:  StoredProcedure [dbo].[SP_SeleccionarDocentePorId]    Script Date: 4/13/2021 6:48:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_SeleccionarDocentePorId]
	(@Id int)
AS
BEGIN

SELECT [Id]
      ,[Nombre]
      ,[Apellido]
      ,[fechaIngreso]
      ,[email]
	  ,[idCategoria]
  FROM [dbo].[Docente]
  WHERE Id = @Id

END
GO
/****** Object:  StoredProcedure [dbo].[SP_SeleccionarDocentePorIdCategoria]    Script Date: 4/13/2021 6:48:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_SeleccionarDocentePorIdCategoria]
( @IdCategoria varchar(20))
AS
BEGIN

SELECT [Id]
      ,[Nombre]
      ,[apellido]
	  ,[fechaIngreso]
	  ,[email]
	  ,[idCategoria]
  FROM [dbo].[Docente] I
  WHERE [idCategoria] = @IdCategoria

END
GO
/****** Object:  StoredProcedure [dbo].[SP_SeleccionarDocentes]    Script Date: 4/13/2021 6:48:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_SeleccionarDocentes]

AS
BEGIN

SELECT [Id]
      ,[Nombre]
      ,[apellido]
	  ,[fechaIngreso]
	  ,[email]
	  ,[idCategoria]
  FROM [dbo].[Docente]

END
GO
/****** Object:  StoredProcedure [dbo].[SP_SeleccionarDocentesReporte]    Script Date: 4/13/2021 6:48:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_SeleccionarDocentesReporte]

AS
BEGIN

SELECT D.[id]
      ,[Nombre]
      ,[apellido]
	  ,[fechaIngreso]
	  ,[email]
	  ,[idCategoria]
	  ,C.descripcion
  FROM [dbo].[Docente] D
  INNER JOIN Categoria C ON C.id = D.idCategoria

END
GO
/****** Object:  StoredProcedure [dbo].[SP_SeleccionarJornadaPorId]    Script Date: 4/13/2021 6:48:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_SeleccionarJornadaPorId]
	(@Id int)
AS
BEGIN

SELECT [Id]
      ,[descripcion]	
	  ,[porcentajeSalario]
  FROM [dbo].[Jornada]
  WHERE Id = @Id

END
GO
/****** Object:  StoredProcedure [dbo].[SP_SeleccionarJornadas]    Script Date: 4/13/2021 6:48:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_SeleccionarJornadas]

AS
BEGIN

SELECT [Id]
      ,[Descripcion]
      ,[porcentajeSalario]
  FROM [dbo].[Jornada]

END
GO
/****** Object:  StoredProcedure [dbo].[SP_SeleccionarJornadasPorDocente]    Script Date: 4/13/2021 6:48:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_SeleccionarJornadasPorDocente]
	(@IdDocente int)
AS
BEGIN

SELECT [Id]
      ,[descripcion]	
	  ,[porcentajeSalario]
  FROM [dbo].[Jornada] J
  INNER JOIN Nombramiento N ON N.idJornada = J.id
  WHERE N.idDocente = @IdDocente

END
GO
/****** Object:  StoredProcedure [dbo].[SP_SeleccionarNombramientos]    Script Date: 4/13/2021 6:48:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_SeleccionarNombramientos]

AS
BEGIN

SELECT [IdDocente]
      ,[idJornada]
  FROM [dbo].[Nombramiento]

END
GO
/****** Object:  StoredProcedure [dbo].[SP_SeleccionarNombramientosporIdDocente]    Script Date: 4/13/2021 6:48:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_SeleccionarNombramientosporIdDocente]
(@IdDocente int)
AS
BEGIN

SELECT [IdDocente]
      ,[idJornada]
  FROM [dbo].[Nombramiento]
Where [IdDocente] = @IdDocente
END
GO
/****** Object:  StoredProcedure [dbo].[SP_SeleccionarNombramientosporIdJornada]    Script Date: 4/13/2021 6:48:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_SeleccionarNombramientosporIdJornada]
(@IdJornada int)
AS
BEGIN

SELECT [IdDocente]
      ,[idJornada]
  FROM [dbo].[Nombramiento]
Where [idJornada] = @IdJornada
END
GO
USE [master]
GO
ALTER DATABASE [PlanillaUTN] SET  READ_WRITE 
GO

select  * from categoria
select  * from DOCENTE
