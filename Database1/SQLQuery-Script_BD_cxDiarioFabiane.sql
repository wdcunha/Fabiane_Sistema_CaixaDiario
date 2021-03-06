USE [master]
GO
/****** Object:  Database [CaixaDiariaFabiane]    Script Date: 26/12/2016 12:17:28 ******/
CREATE DATABASE [CaixaDiariaFabiane]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CaixaDiariaFabiane', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\CaixaDiariaFabiane.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CaixaDiariaFabiane_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\CaixaDiariaFabiane_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [CaixaDiariaFabiane] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CaixaDiariaFabiane].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CaixaDiariaFabiane] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CaixaDiariaFabiane] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CaixaDiariaFabiane] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CaixaDiariaFabiane] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CaixaDiariaFabiane] SET ARITHABORT OFF 
GO
ALTER DATABASE [CaixaDiariaFabiane] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CaixaDiariaFabiane] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CaixaDiariaFabiane] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CaixaDiariaFabiane] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CaixaDiariaFabiane] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CaixaDiariaFabiane] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CaixaDiariaFabiane] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CaixaDiariaFabiane] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CaixaDiariaFabiane] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CaixaDiariaFabiane] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CaixaDiariaFabiane] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CaixaDiariaFabiane] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CaixaDiariaFabiane] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CaixaDiariaFabiane] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CaixaDiariaFabiane] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CaixaDiariaFabiane] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CaixaDiariaFabiane] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CaixaDiariaFabiane] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [CaixaDiariaFabiane] SET  MULTI_USER 
GO
ALTER DATABASE [CaixaDiariaFabiane] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CaixaDiariaFabiane] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CaixaDiariaFabiane] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CaixaDiariaFabiane] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CaixaDiariaFabiane] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'CaixaDiariaFabiane', N'ON'
GO
ALTER DATABASE [CaixaDiariaFabiane] SET QUERY_STORE = OFF
GO
USE [CaixaDiariaFabiane]
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [CaixaDiariaFabiane]
GO
/****** Object:  Table [dbo].[Competencia]    Script Date: 26/12/2016 12:17:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Competencia](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CompNome] [date] NULL,
	[DataRegistro] [datetime] NULL,
	[Usuario] [nchar](30) NULL,
 CONSTRAINT [PK__tmp_ms_x__3214EC07E657B1CC] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Empresa]    Script Date: 26/12/2016 12:17:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empresa](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NomeFantasia] [nvarchar](100) NULL,
	[RazaoSocial] [nvarchar](150) NULL,
	[Endereco] [nvarchar](250) NULL,
	[CEP] [nchar](9) NULL,
	[Fone] [nvarchar](14) NULL,
	[Email] [nvarchar](50) NULL,
	[DataRegistro] [datetime] NULL,
	[Usuario] [nchar](30) NULL,
 CONSTRAINT [PK__tmp_ms_x__3214EC0741B86AFE] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Movimentacao]    Script Date: 26/12/2016 12:17:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Movimentacao](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Data] [date] NULL,
	[Descricao] [nvarchar](300) NULL,
	[Valor] [money] NULL,
	[TipoMovimentacao_fk] [int] NULL,
	[ParteEnvolvida_fk] [int] NULL,
	[Competencia_fk] [int] NULL,
	[Empresa_fk] [int] NULL,
	[DataRegistro] [datetime] NULL,
	[Usuario] [nchar](30) NULL,
 CONSTRAINT [PK__tmp_ms_x__3214EC07AD610C81] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ParteEnvolvida]    Script Date: 26/12/2016 12:17:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ParteEnvolvida](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [nvarchar](150) NULL,
	[TipoParteEnvolvida_fk] [int] NULL,
	[Endereco] [nvarchar](200) NULL,
	[CEP] [nchar](9) NULL,
	[Fone] [nvarchar](14) NULL,
	[Email] [nvarchar](50) NULL,
	[DataRegistro] [datetime] NULL,
	[Usuario] [nchar](30) NULL,
 CONSTRAINT [PK_ParteEnvolvida] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TipoMovimentacao]    Script Date: 26/12/2016 12:17:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoMovimentacao](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TipoMovimentacao] [nchar](10) NULL,
 CONSTRAINT [PK_TipoMovimentacao] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TipoParteEnvolvida]    Script Date: 26/12/2016 12:17:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoParteEnvolvida](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [nvarchar](50) NULL,
	[DataRegistro] [datetime] NULL,
	[Usuario] [nchar](30) NULL,
 CONSTRAINT [PK_TipoParteEnvolvida] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Movimentacao]  WITH CHECK ADD  CONSTRAINT [FK_Comepetencia] FOREIGN KEY([Competencia_fk])
REFERENCES [dbo].[Competencia] ([Id])
GO
ALTER TABLE [dbo].[Movimentacao] CHECK CONSTRAINT [FK_Comepetencia]
GO
ALTER TABLE [dbo].[Movimentacao]  WITH CHECK ADD  CONSTRAINT [FK_Empresa] FOREIGN KEY([Empresa_fk])
REFERENCES [dbo].[Empresa] ([Id])
GO
ALTER TABLE [dbo].[Movimentacao] CHECK CONSTRAINT [FK_Empresa]
GO
ALTER TABLE [dbo].[Movimentacao]  WITH CHECK ADD  CONSTRAINT [FK_Movimentacao_ParteEnvolvida] FOREIGN KEY([ParteEnvolvida_fk])
REFERENCES [dbo].[ParteEnvolvida] ([Id])
GO
ALTER TABLE [dbo].[Movimentacao] CHECK CONSTRAINT [FK_Movimentacao_ParteEnvolvida]
GO
ALTER TABLE [dbo].[Movimentacao]  WITH CHECK ADD  CONSTRAINT [FK_Movimentacao_TipoMovimentacao] FOREIGN KEY([TipoMovimentacao_fk])
REFERENCES [dbo].[TipoMovimentacao] ([Id])
GO
ALTER TABLE [dbo].[Movimentacao] CHECK CONSTRAINT [FK_Movimentacao_TipoMovimentacao]
GO
ALTER TABLE [dbo].[ParteEnvolvida]  WITH CHECK ADD  CONSTRAINT [FK_ParteEnvolvida_TipoParteEnvolvida] FOREIGN KEY([TipoParteEnvolvida_fk])
REFERENCES [dbo].[TipoParteEnvolvida] ([Id])
GO
ALTER TABLE [dbo].[ParteEnvolvida] CHECK CONSTRAINT [FK_ParteEnvolvida_TipoParteEnvolvida]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Destina-se a relacionar com a tabela Envolvido que visa registrar a parte envolvida, seja fornedor ou cliente, de forma que permita controlar individualmente os valores envolvidos, seja histórico ou movimentação futura para acompanhamento de seu cumprimento' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Movimentacao', @level2type=N'COLUMN',@level2name=N'ParteEnvolvida_fk'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Relacionamento com a tabela Competencia que tem o objetivo de controlar os lançamentos por período' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Movimentacao', @level2type=N'COLUMN',@level2name=N'Competencia_fk'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Chave estrangeira com a tabela Empresa para relacione a movimentação a uma empresa específica, de forma que se possa ter mais de uma empresa cadastrada e consequentemente possa fazer movimentações distintas.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Movimentacao', @level2type=N'COLUMN',@level2name=N'Empresa_fk'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Objetiva a guarda da data/hora de registro de operação realizada nessa tabela a fim de se ter controle de quando foi realizada, para fins de auditoria do sistema.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Movimentacao', @level2type=N'COLUMN',@level2name=N'DataRegistro'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Destinado a registrar o nome da pessoa que realizar a operação em campo(s) dessa tabela.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Movimentacao', @level2type=N'COLUMN',@level2name=N'Usuario'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Controle da movimentação diária de caixa' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Movimentacao'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Objetiva a guarda da data/hora de registro de operação realizada nessa tabela a fim de se ter controle de quando foi realizada, para fins de auditoria do sistema.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TipoParteEnvolvida', @level2type=N'COLUMN',@level2name=N'DataRegistro'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Destinado a registrar o nome da pessoa que realizar a operação em campo(s) dessa tabela.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TipoParteEnvolvida', @level2type=N'COLUMN',@level2name=N'Usuario'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Cadastro do tipo da parte envolvida que pode ser Cliente, Fornecedor ou qualquer outro que se faça necessário' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TipoParteEnvolvida'
GO
USE [master]
GO
ALTER DATABASE [CaixaDiariaFabiane] SET  READ_WRITE 
GO
