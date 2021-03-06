USE [Eventosdb]
GO
/****** Object:  Table [dbo].[Categoria]    Script Date: 03/31/2014 13:29:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categoria](
	[idCategoria] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](100) NULL,
 CONSTRAINT [PK_Categoria] PRIMARY KEY CLUSTERED 
(
	[idCategoria] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Organizador]    Script Date: 03/31/2014 13:29:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Organizador](
	[idOrganizador] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](100) NULL,
	[Usuario] [nvarchar](100) NULL,
	[Password] [nvarchar](100) NULL,
	[Correo] [nvarchar](100) NULL,
 CONSTRAINT [PK_Organizador] PRIMARY KEY CLUSTERED 
(
	[idOrganizador] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Evento]    Script Date: 03/31/2014 13:29:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Evento](
	[idEvento] [int] IDENTITY(1,1) NOT NULL,
	[idOrganizador] [int] NULL,
	[idCategoria] [int] NULL,
	[Nombre] [nvarchar](100) NULL,
	[Fecha] [nvarchar](25) NULL,
	[Lugar] [nvarchar](200) NULL,
	[Hora] [nvarchar](25) NULL,
	[Precio] [int] NULL,
	[Descripcion] [nvarchar](300) NULL,
	[PosterUrl] [nvarchar](500) NULL,
 CONSTRAINT [PK_Evento] PRIMARY KEY CLUSTERED 
(
	[idEvento] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_Evento_Categoria]    Script Date: 03/31/2014 13:29:11 ******/
ALTER TABLE [dbo].[Evento]  WITH CHECK ADD  CONSTRAINT [FK_Evento_Categoria] FOREIGN KEY([idCategoria])
REFERENCES [dbo].[Categoria] ([idCategoria])
GO
ALTER TABLE [dbo].[Evento] CHECK CONSTRAINT [FK_Evento_Categoria]
GO
/****** Object:  ForeignKey [FK_Evento_Organizador]    Script Date: 03/31/2014 13:29:11 ******/
ALTER TABLE [dbo].[Evento]  WITH CHECK ADD  CONSTRAINT [FK_Evento_Organizador] FOREIGN KEY([idOrganizador])
REFERENCES [dbo].[Organizador] ([idOrganizador])
GO
ALTER TABLE [dbo].[Evento] CHECK CONSTRAINT [FK_Evento_Organizador]
GO
