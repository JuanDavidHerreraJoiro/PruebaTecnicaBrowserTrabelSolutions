USE [LibraryDB]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 10/05/2023 21:36:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Autores]    Script Date: 10/05/2023 21:36:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Autores](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](max) NULL,
	[Apellido] [nvarchar](max) NULL,
 CONSTRAINT [PK_Autores] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AutorLibro]    Script Date: 10/05/2023 21:36:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AutorLibro](
	[AutoresId] [int] NOT NULL,
	[LibrosISBN] [int] NOT NULL,
 CONSTRAINT [PK_AutorLibro] PRIMARY KEY CLUSTERED 
(
	[AutoresId] ASC,
	[LibrosISBN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Editoriales]    Script Date: 10/05/2023 21:36:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Editoriales](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](max) NULL,
	[Sede] [nvarchar](max) NULL,
 CONSTRAINT [PK_Editoriales] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Libros]    Script Date: 10/05/2023 21:36:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Libros](
	[ISBN] [int] IDENTITY(1,1) NOT NULL,
	[Editoriales_id] [int] NOT NULL,
	[Titulo] [nvarchar](max) NULL,
	[Sinopsis] [nvarchar](max) NULL,
	[N_paginas] [nvarchar](max) NULL,
 CONSTRAINT [PK_Libros] PRIMARY KEY CLUSTERED 
(
	[ISBN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230511005816_Create tables', N'5.0.17')
GO
SET IDENTITY_INSERT [dbo].[Autores] ON 

INSERT [dbo].[Autores] ([Id], [Nombre], [Apellido]) VALUES (1, N'Juan', N'Herrera')
INSERT [dbo].[Autores] ([Id], [Nombre], [Apellido]) VALUES (2, N'Oscar', N'Ortiz')
INSERT [dbo].[Autores] ([Id], [Nombre], [Apellido]) VALUES (3, N'Hernando', N'Rueda')
INSERT [dbo].[Autores] ([Id], [Nombre], [Apellido]) VALUES (4, N'Aline Wood', N'Lindsey')
INSERT [dbo].[Autores] ([Id], [Nombre], [Apellido]) VALUES (5, N'Jada Hudson', N'Vinson')
INSERT [dbo].[Autores] ([Id], [Nombre], [Apellido]) VALUES (6, N'Hadley Terry', N'Mcmillan')
INSERT [dbo].[Autores] ([Id], [Nombre], [Apellido]) VALUES (7, N'Victor Noel', N'Chandler')
INSERT [dbo].[Autores] ([Id], [Nombre], [Apellido]) VALUES (8, N'Maya Dean', N'Reid')
INSERT [dbo].[Autores] ([Id], [Nombre], [Apellido]) VALUES (9, N'Arsenio Erickson', N'Huber')
INSERT [dbo].[Autores] ([Id], [Nombre], [Apellido]) VALUES (10, N'Emi Berry', N'Ewing')
INSERT [dbo].[Autores] ([Id], [Nombre], [Apellido]) VALUES (11, N'Bernard Stone', N'Alston')
INSERT [dbo].[Autores] ([Id], [Nombre], [Apellido]) VALUES (12, N'Sydney Sargent', N'Faulkner')
INSERT [dbo].[Autores] ([Id], [Nombre], [Apellido]) VALUES (13, N'Kane Evans', N'Lang')
INSERT [dbo].[Autores] ([Id], [Nombre], [Apellido]) VALUES (14, N'Veronica Castro', N'Frederick')
INSERT [dbo].[Autores] ([Id], [Nombre], [Apellido]) VALUES (15, N'Nerea Lambert', N'Eaton')
INSERT [dbo].[Autores] ([Id], [Nombre], [Apellido]) VALUES (16, N'Walter Gay', N'Ortega')
INSERT [dbo].[Autores] ([Id], [Nombre], [Apellido]) VALUES (17, N'Kuame Rose', N'Hensley')
INSERT [dbo].[Autores] ([Id], [Nombre], [Apellido]) VALUES (18, N'Mallory Henson', N'Wilder')
INSERT [dbo].[Autores] ([Id], [Nombre], [Apellido]) VALUES (19, N'Fitzgerald Silva', N'Berry')
INSERT [dbo].[Autores] ([Id], [Nombre], [Apellido]) VALUES (20, N'Keely Mcmillan', N'Kirby')
INSERT [dbo].[Autores] ([Id], [Nombre], [Apellido]) VALUES (21, N'Lillian Flowers', N'Erickson')
INSERT [dbo].[Autores] ([Id], [Nombre], [Apellido]) VALUES (22, N'Holmes Ford', N'Holcomb')
INSERT [dbo].[Autores] ([Id], [Nombre], [Apellido]) VALUES (23, N'Hedley Melton', N'Albert')
INSERT [dbo].[Autores] ([Id], [Nombre], [Apellido]) VALUES (24, N'Chloe Rodriguez', N'Mckay')
INSERT [dbo].[Autores] ([Id], [Nombre], [Apellido]) VALUES (25, N'Galena Oneil', N'Wyatt')
INSERT [dbo].[Autores] ([Id], [Nombre], [Apellido]) VALUES (26, N'Perry Huber', N'Rosa')
INSERT [dbo].[Autores] ([Id], [Nombre], [Apellido]) VALUES (27, N'Cassandra Snider', N'Wells')
INSERT [dbo].[Autores] ([Id], [Nombre], [Apellido]) VALUES (28, N'Indigo Palmer', N'Foster')
INSERT [dbo].[Autores] ([Id], [Nombre], [Apellido]) VALUES (29, N'Palmer Sexton', N'Levy')
INSERT [dbo].[Autores] ([Id], [Nombre], [Apellido]) VALUES (30, N'Gil Crane', N'Maynard')
INSERT [dbo].[Autores] ([Id], [Nombre], [Apellido]) VALUES (31, N'Wade Solomon', N'Aguirre')
INSERT [dbo].[Autores] ([Id], [Nombre], [Apellido]) VALUES (32, N'Carson Chavez', N'Paul')
INSERT [dbo].[Autores] ([Id], [Nombre], [Apellido]) VALUES (33, N'Amity Hill', N'O''connor')
INSERT [dbo].[Autores] ([Id], [Nombre], [Apellido]) VALUES (34, N'Omar Farmer', N'Ellis')
INSERT [dbo].[Autores] ([Id], [Nombre], [Apellido]) VALUES (35, N'Julian Herman', N'Winters')
INSERT [dbo].[Autores] ([Id], [Nombre], [Apellido]) VALUES (36, N'Fay Combs', N'Gibson')
INSERT [dbo].[Autores] ([Id], [Nombre], [Apellido]) VALUES (37, N'Ahmed Hawkins', N'Barker')
INSERT [dbo].[Autores] ([Id], [Nombre], [Apellido]) VALUES (38, N'Jemima Franco', N'Ellis')
INSERT [dbo].[Autores] ([Id], [Nombre], [Apellido]) VALUES (39, N'Mariko Burton', N'Middleton')
INSERT [dbo].[Autores] ([Id], [Nombre], [Apellido]) VALUES (40, N'Raven Meyer', N'Ramos')
INSERT [dbo].[Autores] ([Id], [Nombre], [Apellido]) VALUES (41, N'Risa Dennis', N'Pugh')
INSERT [dbo].[Autores] ([Id], [Nombre], [Apellido]) VALUES (42, N'Kane Wiley', N'Harrell')
INSERT [dbo].[Autores] ([Id], [Nombre], [Apellido]) VALUES (43, N'Indira Richmond', N'Benton')
SET IDENTITY_INSERT [dbo].[Autores] OFF
GO
INSERT [dbo].[AutorLibro] ([AutoresId], [LibrosISBN]) VALUES (1, 1)
INSERT [dbo].[AutorLibro] ([AutoresId], [LibrosISBN]) VALUES (3, 1)
INSERT [dbo].[AutorLibro] ([AutoresId], [LibrosISBN]) VALUES (1, 2)
INSERT [dbo].[AutorLibro] ([AutoresId], [LibrosISBN]) VALUES (1, 3)
INSERT [dbo].[AutorLibro] ([AutoresId], [LibrosISBN]) VALUES (1, 4)
INSERT [dbo].[AutorLibro] ([AutoresId], [LibrosISBN]) VALUES (23, 5)
INSERT [dbo].[AutorLibro] ([AutoresId], [LibrosISBN]) VALUES (13, 7)
INSERT [dbo].[AutorLibro] ([AutoresId], [LibrosISBN]) VALUES (32, 8)
INSERT [dbo].[AutorLibro] ([AutoresId], [LibrosISBN]) VALUES (35, 8)
INSERT [dbo].[AutorLibro] ([AutoresId], [LibrosISBN]) VALUES (13, 9)
INSERT [dbo].[AutorLibro] ([AutoresId], [LibrosISBN]) VALUES (16, 9)
INSERT [dbo].[AutorLibro] ([AutoresId], [LibrosISBN]) VALUES (9, 12)
INSERT [dbo].[AutorLibro] ([AutoresId], [LibrosISBN]) VALUES (37, 12)
INSERT [dbo].[AutorLibro] ([AutoresId], [LibrosISBN]) VALUES (38, 12)
INSERT [dbo].[AutorLibro] ([AutoresId], [LibrosISBN]) VALUES (40, 14)
INSERT [dbo].[AutorLibro] ([AutoresId], [LibrosISBN]) VALUES (41, 15)
INSERT [dbo].[AutorLibro] ([AutoresId], [LibrosISBN]) VALUES (19, 17)
INSERT [dbo].[AutorLibro] ([AutoresId], [LibrosISBN]) VALUES (11, 21)
INSERT [dbo].[AutorLibro] ([AutoresId], [LibrosISBN]) VALUES (2, 22)
INSERT [dbo].[AutorLibro] ([AutoresId], [LibrosISBN]) VALUES (5, 23)
INSERT [dbo].[AutorLibro] ([AutoresId], [LibrosISBN]) VALUES (22, 25)
INSERT [dbo].[AutorLibro] ([AutoresId], [LibrosISBN]) VALUES (30, 27)
INSERT [dbo].[AutorLibro] ([AutoresId], [LibrosISBN]) VALUES (6, 28)
INSERT [dbo].[AutorLibro] ([AutoresId], [LibrosISBN]) VALUES (19, 28)
INSERT [dbo].[AutorLibro] ([AutoresId], [LibrosISBN]) VALUES (27, 28)
INSERT [dbo].[AutorLibro] ([AutoresId], [LibrosISBN]) VALUES (27, 29)
INSERT [dbo].[AutorLibro] ([AutoresId], [LibrosISBN]) VALUES (35, 29)
INSERT [dbo].[AutorLibro] ([AutoresId], [LibrosISBN]) VALUES (16, 30)
INSERT [dbo].[AutorLibro] ([AutoresId], [LibrosISBN]) VALUES (17, 30)
INSERT [dbo].[AutorLibro] ([AutoresId], [LibrosISBN]) VALUES (18, 30)
INSERT [dbo].[AutorLibro] ([AutoresId], [LibrosISBN]) VALUES (5, 32)
INSERT [dbo].[AutorLibro] ([AutoresId], [LibrosISBN]) VALUES (30, 33)
INSERT [dbo].[AutorLibro] ([AutoresId], [LibrosISBN]) VALUES (21, 34)
INSERT [dbo].[AutorLibro] ([AutoresId], [LibrosISBN]) VALUES (34, 34)
INSERT [dbo].[AutorLibro] ([AutoresId], [LibrosISBN]) VALUES (33, 38)
INSERT [dbo].[AutorLibro] ([AutoresId], [LibrosISBN]) VALUES (13, 39)
INSERT [dbo].[AutorLibro] ([AutoresId], [LibrosISBN]) VALUES (24, 39)
INSERT [dbo].[AutorLibro] ([AutoresId], [LibrosISBN]) VALUES (10, 40)
INSERT [dbo].[AutorLibro] ([AutoresId], [LibrosISBN]) VALUES (28, 40)
INSERT [dbo].[AutorLibro] ([AutoresId], [LibrosISBN]) VALUES (13, 41)
INSERT [dbo].[AutorLibro] ([AutoresId], [LibrosISBN]) VALUES (30, 41)
INSERT [dbo].[AutorLibro] ([AutoresId], [LibrosISBN]) VALUES (17, 42)
INSERT [dbo].[AutorLibro] ([AutoresId], [LibrosISBN]) VALUES (24, 42)
INSERT [dbo].[AutorLibro] ([AutoresId], [LibrosISBN]) VALUES (39, 42)
INSERT [dbo].[AutorLibro] ([AutoresId], [LibrosISBN]) VALUES (11, 43)
GO
SET IDENTITY_INSERT [dbo].[Editoriales] ON 

INSERT [dbo].[Editoriales] ([Id], [Nombre], [Sede]) VALUES (1, N'Norma', N'Bogota')
INSERT [dbo].[Editoriales] ([Id], [Nombre], [Sede]) VALUES (2, N'Cobiook', N'Bogota')
INSERT [dbo].[Editoriales] ([Id], [Nombre], [Sede]) VALUES (3, N'Norma', N'Valledupar')
INSERT [dbo].[Editoriales] ([Id], [Nombre], [Sede]) VALUES (4, N'Gilmore', N'Leticia')
INSERT [dbo].[Editoriales] ([Id], [Nombre], [Sede]) VALUES (5, N'Stone', N'San Juan de Pasto')
INSERT [dbo].[Editoriales] ([Id], [Nombre], [Sede]) VALUES (6, N'Farmer', N'Los Patios')
INSERT [dbo].[Editoriales] ([Id], [Nombre], [Sede]) VALUES (7, N'Reyes', N'Plato')
INSERT [dbo].[Editoriales] ([Id], [Nombre], [Sede]) VALUES (8, N'Rivers', N'Sahagún')
INSERT [dbo].[Editoriales] ([Id], [Nombre], [Sede]) VALUES (9, N'Mcleod', N'Medio Atrato')
INSERT [dbo].[Editoriales] ([Id], [Nombre], [Sede]) VALUES (10, N'Mcguire', N'San José del Guaviare')
INSERT [dbo].[Editoriales] ([Id], [Nombre], [Sede]) VALUES (11, N'Stone', N'Florencia')
INSERT [dbo].[Editoriales] ([Id], [Nombre], [Sede]) VALUES (12, N'Chavez', N'Valle del Guamuez')
INSERT [dbo].[Editoriales] ([Id], [Nombre], [Sede]) VALUES (13, N'Lyons', N'Bello')
INSERT [dbo].[Editoriales] ([Id], [Nombre], [Sede]) VALUES (14, N'Buckner', N'Pitalito')
INSERT [dbo].[Editoriales] ([Id], [Nombre], [Sede]) VALUES (15, N'Rojas', N'Popayán')
INSERT [dbo].[Editoriales] ([Id], [Nombre], [Sede]) VALUES (16, N'Potts', N'Fusagasugá')
INSERT [dbo].[Editoriales] ([Id], [Nombre], [Sede]) VALUES (17, N'Howell', N'San Vicente del Caguán')
INSERT [dbo].[Editoriales] ([Id], [Nombre], [Sede]) VALUES (18, N'Langley', N'El Tambo')
INSERT [dbo].[Editoriales] ([Id], [Nombre], [Sede]) VALUES (19, N'Swanson', N'Malambo')
INSERT [dbo].[Editoriales] ([Id], [Nombre], [Sede]) VALUES (20, N'Conley', N'Ipiales')
INSERT [dbo].[Editoriales] ([Id], [Nombre], [Sede]) VALUES (21, N'Solis', N'Acacías')
INSERT [dbo].[Editoriales] ([Id], [Nombre], [Sede]) VALUES (22, N'Huber', N'Bogotá')
INSERT [dbo].[Editoriales] ([Id], [Nombre], [Sede]) VALUES (23, N'Humphrey', N'Puerto Nariño')
INSERT [dbo].[Editoriales] ([Id], [Nombre], [Sede]) VALUES (24, N'Kent', N'Florencia')
INSERT [dbo].[Editoriales] ([Id], [Nombre], [Sede]) VALUES (25, N'Fuller', N'Medio Atrato')
INSERT [dbo].[Editoriales] ([Id], [Nombre], [Sede]) VALUES (26, N'Hoffman', N'Inírida')
INSERT [dbo].[Editoriales] ([Id], [Nombre], [Sede]) VALUES (27, N'Shepherd', N'Puerto Guzmán')
INSERT [dbo].[Editoriales] ([Id], [Nombre], [Sede]) VALUES (28, N'Fletcher', N'Riohacha')
INSERT [dbo].[Editoriales] ([Id], [Nombre], [Sede]) VALUES (29, N'Vaughan', N'Riohacha')
INSERT [dbo].[Editoriales] ([Id], [Nombre], [Sede]) VALUES (30, N'Swanson', N'Puerto Nariño')
INSERT [dbo].[Editoriales] ([Id], [Nombre], [Sede]) VALUES (31, N'Emerson', N'Bogotá')
INSERT [dbo].[Editoriales] ([Id], [Nombre], [Sede]) VALUES (32, N'Mann', N'Ciénaga')
INSERT [dbo].[Editoriales] ([Id], [Nombre], [Sede]) VALUES (33, N'Gill', N'Florencia')
INSERT [dbo].[Editoriales] ([Id], [Nombre], [Sede]) VALUES (34, N'Buckner', N'Montenegro')
INSERT [dbo].[Editoriales] ([Id], [Nombre], [Sede]) VALUES (35, N'Jacobson', N'Inírida')
INSERT [dbo].[Editoriales] ([Id], [Nombre], [Sede]) VALUES (36, N'Copeland', N'Pacoa')
INSERT [dbo].[Editoriales] ([Id], [Nombre], [Sede]) VALUES (37, N'Coleman', N'El Tambo')
INSERT [dbo].[Editoriales] ([Id], [Nombre], [Sede]) VALUES (38, N'Hale', N'Orito')
INSERT [dbo].[Editoriales] ([Id], [Nombre], [Sede]) VALUES (39, N'Martinez', N'Buenaventura')
INSERT [dbo].[Editoriales] ([Id], [Nombre], [Sede]) VALUES (40, N'Wolf', N'Saravena')
INSERT [dbo].[Editoriales] ([Id], [Nombre], [Sede]) VALUES (41, N'James', N'San Marcos')
INSERT [dbo].[Editoriales] ([Id], [Nombre], [Sede]) VALUES (42, N'Santiago', N'Plato')
INSERT [dbo].[Editoriales] ([Id], [Nombre], [Sede]) VALUES (43, N'Richardson', N'Neiva')
SET IDENTITY_INSERT [dbo].[Editoriales] OFF
GO
SET IDENTITY_INSERT [dbo].[Libros] ON 

INSERT [dbo].[Libros] ([ISBN], [Editoriales_id], [Titulo], [Sinopsis], [N_paginas]) VALUES (1, 2, N'Principito', N'qqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqq', N'50')
INSERT [dbo].[Libros] ([ISBN], [Editoriales_id], [Titulo], [Sinopsis], [N_paginas]) VALUES (2, 3, N'Libro 1', N'asdasdasdasfasfasf', N'20')
INSERT [dbo].[Libros] ([ISBN], [Editoriales_id], [Titulo], [Sinopsis], [N_paginas]) VALUES (3, 1, N'Libro 2', N'asdasdasdasfasfasf', N'20')
INSERT [dbo].[Libros] ([ISBN], [Editoriales_id], [Titulo], [Sinopsis], [N_paginas]) VALUES (4, 2, N'Libro 4', N'asdasdasdasfasfasf', N'20')
INSERT [dbo].[Libros] ([ISBN], [Editoriales_id], [Titulo], [Sinopsis], [N_paginas]) VALUES (5, 20, N'Amos', N'ultrices. Vivamus rhoncus. Donec', N'693')
INSERT [dbo].[Libros] ([ISBN], [Editoriales_id], [Titulo], [Sinopsis], [N_paginas]) VALUES (6, 26, N'Nathan', N'vel, mauris. Integer', N'260')
INSERT [dbo].[Libros] ([ISBN], [Editoriales_id], [Titulo], [Sinopsis], [N_paginas]) VALUES (7, 33, N'Garrison', N'nibh. Aliquam ornare, libero', N'255')
INSERT [dbo].[Libros] ([ISBN], [Editoriales_id], [Titulo], [Sinopsis], [N_paginas]) VALUES (8, 42, N'Xavier', N'Praesent interdum ligula eu enim. Etiam imperdiet dictum magna. Ut', N'593')
INSERT [dbo].[Libros] ([ISBN], [Editoriales_id], [Titulo], [Sinopsis], [N_paginas]) VALUES (9, 29, N'Laith', N'nunc sit amet metus. Aliquam erat volutpat. Nulla facilisis. Suspendisse', N'333')
INSERT [dbo].[Libros] ([ISBN], [Editoriales_id], [Titulo], [Sinopsis], [N_paginas]) VALUES (10, 27, N'Giacomo', N'nonummy ut, molestie', N'135')
INSERT [dbo].[Libros] ([ISBN], [Editoriales_id], [Titulo], [Sinopsis], [N_paginas]) VALUES (11, 11, N'Eric', N'nec, leo.', N'658')
INSERT [dbo].[Libros] ([ISBN], [Editoriales_id], [Titulo], [Sinopsis], [N_paginas]) VALUES (12, 29, N'Lester', N'tempus risus. Donec egestas. Duis ac', N'433')
INSERT [dbo].[Libros] ([ISBN], [Editoriales_id], [Titulo], [Sinopsis], [N_paginas]) VALUES (13, 18, N'Burke', N'aliquet, sem', N'630')
INSERT [dbo].[Libros] ([ISBN], [Editoriales_id], [Titulo], [Sinopsis], [N_paginas]) VALUES (14, 14, N'Demetrius', N'Nullam scelerisque neque sed sem', N'464')
INSERT [dbo].[Libros] ([ISBN], [Editoriales_id], [Titulo], [Sinopsis], [N_paginas]) VALUES (15, 29, N'Keith', N'nec, leo. Morbi neque tellus, imperdiet', N'632')
INSERT [dbo].[Libros] ([ISBN], [Editoriales_id], [Titulo], [Sinopsis], [N_paginas]) VALUES (16, 31, N'Walter', N'in lobortis tellus justo sit amet', N'543')
INSERT [dbo].[Libros] ([ISBN], [Editoriales_id], [Titulo], [Sinopsis], [N_paginas]) VALUES (17, 39, N'Hamish', N'lobortis. Class aptent taciti sociosqu ad litora torquent', N'914')
INSERT [dbo].[Libros] ([ISBN], [Editoriales_id], [Titulo], [Sinopsis], [N_paginas]) VALUES (18, 5, N'Timon', N'mi eleifend egestas. Sed pharetra,', N'783')
INSERT [dbo].[Libros] ([ISBN], [Editoriales_id], [Titulo], [Sinopsis], [N_paginas]) VALUES (19, 43, N'Hasad', N'ut, pharetra', N'210')
INSERT [dbo].[Libros] ([ISBN], [Editoriales_id], [Titulo], [Sinopsis], [N_paginas]) VALUES (20, 5, N'Oren', N'Ut semper pretium neque.', N'486')
INSERT [dbo].[Libros] ([ISBN], [Editoriales_id], [Titulo], [Sinopsis], [N_paginas]) VALUES (21, 37, N'Jonah', N'augue eu', N'137')
INSERT [dbo].[Libros] ([ISBN], [Editoriales_id], [Titulo], [Sinopsis], [N_paginas]) VALUES (22, 36, N'Abraham', N'nulla. Integer vulputate, risus a ultricies adipiscing, enim', N'377')
INSERT [dbo].[Libros] ([ISBN], [Editoriales_id], [Titulo], [Sinopsis], [N_paginas]) VALUES (23, 12, N'Chandler', N'nascetur ridiculus mus. Aenean', N'695')
INSERT [dbo].[Libros] ([ISBN], [Editoriales_id], [Titulo], [Sinopsis], [N_paginas]) VALUES (24, 27, N'Cullen', N'Aenean gravida nunc sed pede.', N'899')
INSERT [dbo].[Libros] ([ISBN], [Editoriales_id], [Titulo], [Sinopsis], [N_paginas]) VALUES (25, 14, N'Gil', N'consequat, lectus', N'194')
INSERT [dbo].[Libros] ([ISBN], [Editoriales_id], [Titulo], [Sinopsis], [N_paginas]) VALUES (26, 13, N'Herman', N'ipsum. Donec', N'683')
INSERT [dbo].[Libros] ([ISBN], [Editoriales_id], [Titulo], [Sinopsis], [N_paginas]) VALUES (27, 27, N'Maxwell', N'velit', N'833')
INSERT [dbo].[Libros] ([ISBN], [Editoriales_id], [Titulo], [Sinopsis], [N_paginas]) VALUES (28, 11, N'Sawyer', N'Donec', N'330')
INSERT [dbo].[Libros] ([ISBN], [Editoriales_id], [Titulo], [Sinopsis], [N_paginas]) VALUES (29, 1, N'Rudyard', N'dui, nec tempus mauris erat eget', N'965')
INSERT [dbo].[Libros] ([ISBN], [Editoriales_id], [Titulo], [Sinopsis], [N_paginas]) VALUES (30, 18, N'Lawrence', N'libero. Donec', N'405')
INSERT [dbo].[Libros] ([ISBN], [Editoriales_id], [Titulo], [Sinopsis], [N_paginas]) VALUES (31, 29, N'Simon', N'ullamcorper, nisl arcu iaculis enim, sit amet', N'813')
INSERT [dbo].[Libros] ([ISBN], [Editoriales_id], [Titulo], [Sinopsis], [N_paginas]) VALUES (32, 28, N'Amir', N'dui quis accumsan convallis,', N'946')
INSERT [dbo].[Libros] ([ISBN], [Editoriales_id], [Titulo], [Sinopsis], [N_paginas]) VALUES (33, 10, N'Gage', N'in aliquet lobortis, nisi nibh', N'719')
INSERT [dbo].[Libros] ([ISBN], [Editoriales_id], [Titulo], [Sinopsis], [N_paginas]) VALUES (34, 25, N'Brennan', N'fringilla euismod enim. Etiam gravida molestie', N'413')
INSERT [dbo].[Libros] ([ISBN], [Editoriales_id], [Titulo], [Sinopsis], [N_paginas]) VALUES (35, 27, N'Ryder', N'et, commodo at, libero. Morbi accumsan', N'550')
INSERT [dbo].[Libros] ([ISBN], [Editoriales_id], [Titulo], [Sinopsis], [N_paginas]) VALUES (36, 32, N'Hashim', N'Mauris vestibulum, neque sed dictum eleifend,', N'671')
INSERT [dbo].[Libros] ([ISBN], [Editoriales_id], [Titulo], [Sinopsis], [N_paginas]) VALUES (37, 31, N'Keith', N'erat volutpat. Nulla facilisis. Suspendisse commodo tincidunt', N'630')
INSERT [dbo].[Libros] ([ISBN], [Editoriales_id], [Titulo], [Sinopsis], [N_paginas]) VALUES (38, 9, N'Kirk', N'vel, faucibus id,', N'461')
INSERT [dbo].[Libros] ([ISBN], [Editoriales_id], [Titulo], [Sinopsis], [N_paginas]) VALUES (39, 37, N'Barclay', N'Quisque purus sapien, gravida non, sollicitudin a, malesuada id,', N'536')
INSERT [dbo].[Libros] ([ISBN], [Editoriales_id], [Titulo], [Sinopsis], [N_paginas]) VALUES (40, 7, N'Kennedy', N'nec urna suscipit nonummy. Fusce', N'718')
INSERT [dbo].[Libros] ([ISBN], [Editoriales_id], [Titulo], [Sinopsis], [N_paginas]) VALUES (41, 8, N'Noble', N'luctus, ipsum leo elementum sem, vitae aliquam eros', N'584')
INSERT [dbo].[Libros] ([ISBN], [Editoriales_id], [Titulo], [Sinopsis], [N_paginas]) VALUES (42, 37, N'Keegan', N'diam. Sed diam lorem, auctor quis,', N'118')
INSERT [dbo].[Libros] ([ISBN], [Editoriales_id], [Titulo], [Sinopsis], [N_paginas]) VALUES (43, 3, N'Jonas', N'faucibus orci luctus et ultrices posuere cubilia', N'370')
INSERT [dbo].[Libros] ([ISBN], [Editoriales_id], [Titulo], [Sinopsis], [N_paginas]) VALUES (44, 29, N'Cooper', N'pede. Cras vulputate velit eu sem. Pellentesque ut ipsum', N'796')
SET IDENTITY_INSERT [dbo].[Libros] OFF
GO
ALTER TABLE [dbo].[AutorLibro]  WITH CHECK ADD  CONSTRAINT [FK_AutorLibro_Autores_AutoresId] FOREIGN KEY([AutoresId])
REFERENCES [dbo].[Autores] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AutorLibro] CHECK CONSTRAINT [FK_AutorLibro_Autores_AutoresId]
GO
ALTER TABLE [dbo].[AutorLibro]  WITH CHECK ADD  CONSTRAINT [FK_AutorLibro_Libros_LibrosISBN] FOREIGN KEY([LibrosISBN])
REFERENCES [dbo].[Libros] ([ISBN])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AutorLibro] CHECK CONSTRAINT [FK_AutorLibro_Libros_LibrosISBN]
GO
ALTER TABLE [dbo].[Libros]  WITH CHECK ADD  CONSTRAINT [FK_Libros_Editoriales_Editoriales_id] FOREIGN KEY([Editoriales_id])
REFERENCES [dbo].[Editoriales] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Libros] CHECK CONSTRAINT [FK_Libros_Editoriales_Editoriales_id]
GO
