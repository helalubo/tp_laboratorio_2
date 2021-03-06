USE [Producto]
GO
/****** Object:  Table [dbo].[Accesorios]    Script Date: 29/11/2020 23:34:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Accesorios](
	[id] [int] IDENTITY(10000,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[precio] [float] NOT NULL,
	[cantidad] [int] NOT NULL,
	[gama] [int] NOT NULL,
	[tipo] [int] NOT NULL,
 CONSTRAINT [PK_Accesorios] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Instrumento]    Script Date: 29/11/2020 23:34:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Instrumento](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NOT NULL,
	[precio] [float] NOT NULL,
	[cantidad] [int] NOT NULL,
	[origen] [varchar](50) NOT NULL,
	[modelo] [int] NOT NULL,
 CONSTRAINT [PK_Instrumento] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Accesorios] ON 

INSERT [dbo].[Accesorios] ([id], [nombre], [precio], [cantidad], [gama], [tipo]) VALUES (10000, N'Puas Fender *12', 500, 20, 1, 0)
INSERT [dbo].[Accesorios] ([id], [nombre], [precio], [cantidad], [gama], [tipo]) VALUES (10001, N'Puas Fender *24', 850, 28, 1, 0)
INSERT [dbo].[Accesorios] ([id], [nombre], [precio], [cantidad], [gama], [tipo]) VALUES (10002, N'Correa Guitarra classic ', 550, 20, 0, 0)
INSERT [dbo].[Accesorios] ([id], [nombre], [precio], [cantidad], [gama], [tipo]) VALUES (10003, N'Palillos Logan', 350, 34, 2, 1)
INSERT [dbo].[Accesorios] ([id], [nombre], [precio], [cantidad], [gama], [tipo]) VALUES (10004, N'banquillo drum sonor', 8000, 7, 3, 1)
INSERT [dbo].[Accesorios] ([id], [nombre], [precio], [cantidad], [gama], [tipo]) VALUES (10005, N'banquillo Yamaha', 8500, 8, 3, 1)
INSERT [dbo].[Accesorios] ([id], [nombre], [precio], [cantidad], [gama], [tipo]) VALUES (10006, N'Banquillo Pearl', 9000, 8, 3, 1)
INSERT [dbo].[Accesorios] ([id], [nombre], [precio], [cantidad], [gama], [tipo]) VALUES (10007, N'afinador de guitarra Fender', 5000, 19, 2, 0)
INSERT [dbo].[Accesorios] ([id], [nombre], [precio], [cantidad], [gama], [tipo]) VALUES (10008, N'Pedal fender override 5', 5000, 19, 3, 0)
INSERT [dbo].[Accesorios] ([id], [nombre], [precio], [cantidad], [gama], [tipo]) VALUES (10009, N'Soporte Teclado', 6000, 4, 2, 2)
INSERT [dbo].[Accesorios] ([id], [nombre], [precio], [cantidad], [gama], [tipo]) VALUES (10010, N'Pedal de efectos teclado yamaha ', 7890, 5, 3, 2)
INSERT [dbo].[Accesorios] ([id], [nombre], [precio], [cantidad], [gama], [tipo]) VALUES (10011, N'Cuerdas de bajo Fender x6', 500, 5, 3, 3)
SET IDENTITY_INSERT [dbo].[Accesorios] OFF
GO
SET IDENTITY_INSERT [dbo].[Instrumento] ON 

INSERT [dbo].[Instrumento] ([id], [nombre], [precio], [cantidad], [origen], [modelo]) VALUES (1, N'Guitarra Stratocaster Fender ', 88000, 17, N'EEUU', 1999)
INSERT [dbo].[Instrumento] ([id], [nombre], [precio], [cantidad], [origen], [modelo]) VALUES (2, N'Bateria Sonor ', 100000, 10, N'EEUU', 2000)
INSERT [dbo].[Instrumento] ([id], [nombre], [precio], [cantidad], [origen], [modelo]) VALUES (4, N'Bajo Gibson', 50000, 7, N'EEUU', 1990)
INSERT [dbo].[Instrumento] ([id], [nombre], [precio], [cantidad], [origen], [modelo]) VALUES (5, N'Guitarra Gibson', 99999, 2, N'CHINA', 1990)
INSERT [dbo].[Instrumento] ([id], [nombre], [precio], [cantidad], [origen], [modelo]) VALUES (6, N'Teclado yamaha', 55000, 5, N'CHINA', 2007)
INSERT [dbo].[Instrumento] ([id], [nombre], [precio], [cantidad], [origen], [modelo]) VALUES (7, N'Teclado XYZ', 5000, 3, N'ARGENTINA', 2010)
INSERT [dbo].[Instrumento] ([id], [nombre], [precio], [cantidad], [origen], [modelo]) VALUES (8, N'Bateria  Ludwig ', 90000, 5, N'EEUU', 1999)
INSERT [dbo].[Instrumento] ([id], [nombre], [precio], [cantidad], [origen], [modelo]) VALUES (9, N'Bateria Mapex', 99000, 15, N'ALEMANIA', 1999)
INSERT [dbo].[Instrumento] ([id], [nombre], [precio], [cantidad], [origen], [modelo]) VALUES (10, N'Guitarra Fender Telecaster', 80000, 8, N'OTRO', 1999)
SET IDENTITY_INSERT [dbo].[Instrumento] OFF
GO
