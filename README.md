Consigna TP Integrador
Se necesita una aplicación para la gestión de artículos de un catálogo de un comercio. La aplicación debe ser genérica, es decir, aplicar para cualquier tipo de comercio; y la información que en ella se cargue será consumida luego desde distintos servicios para ser mostradas ya sea en webs, e-commerces, apps mobile, revistas, etc. Esto no es parte del desarrollo, pero sí del contexto en el cual se utilizará la aplicación a desarrollar.

Deberá ser una aplicación de escritorio que contemple la administración de artículos. Las funcionalidades que deberá tener la aplicación serán:

Listado de artículos.
Búsqueda de artículos por distintos criterios.
Agregar artículos.
Modificar artículos.
Eliminar artículos.
Ver detalle de un artículo.
Toda ésta información deberá ser persistida en una base de datos ya existente (la cual se adjunta).

Los datos mínimos con los que deberá contar el artículo son los siguientes:

Código de artículo.
Nombre.
Descripción.
Marca (seleccionable de una lista desplegable).
Categoría (seleccionable de una lista desplegable.
Imagen.
Precio.


Etapa 1: Construir las clases necesarias para el modelo de dicha aplicación junto a las ventanas con las que contará y su navegación.

Etapa 2: Construir la interacción con la base de datos y validaciones correspondiente para dar vida a la funcionalidad.

Consideraciones: la app debe manejar arquitectura en capas, manejo de excepciones y validaciones cuando corresponda.

Modo de entrega:

No deben realizar modificaciones en la DB, ante cualquier duda, me consultan.
Deben entregar un zip con la solución dentro con el nombre TPFinalNivel2_Apellido, por ejemplo: TPFinalNivel2_SarFernandez
Pueden eliminar las carpetas "bin" para achicar el tamaño del archivo final, esto es opcional.

Script de generación de Base de Datos:


use master
go
create database CATALOGO_DB
go
use CATALOGO_DB
go
USE [CATALOGO_DB]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MARCAS](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_MARCAS] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
USE [CATALOGO_DB]
GO
/****** Object:  Table [dbo].[CATEGORIAS]    Script Date: 08/09/2019 10:32:14 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CATEGORIAS](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_CATEGORIAS] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
USE [CATALOGO_DB]
GO
/****** Object:  Table [dbo].[ARTICULOS]    Script Date: 08/09/2019 10:32:24 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ARTICULOS](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [varchar](50) NULL,
	[Nombre] [varchar](50) NULL,
	[Descripcion] [varchar](150) NULL,
	[IdMarca] [int] NULL,
	[IdCategoria] [int] NULL,
	[ImagenUrl] [varchar](1000) NULL,
	[Precio] [money] NULL,
 CONSTRAINT [PK_ARTICULOS] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
insert into MARCAS values ('Samsung'), ('Apple'), ('Sony'), ('Huawei'), ('Motorola')
insert into CATEGORIAS values ('Celulares'),('Televisores'), ('Media'), ('Audio')
insert into ARTICULOS values ('S01', 'Galaxy S10', 'Una canoa cara', 1, 1, 'https://images.samsung.com/is/image/samsung/assets/ar/p6_gro2/p6_initial_mktpd/smartphones/galaxy-s10/specs/galaxy-s10-plus_specs_design_colors_prism_black.jpg?$163_346_PNG$', 69.999),
('M03', 'Moto G Play 7ma Gen', 'Ya siete de estos?', 5, 1, 'https://www.motorola.cl/arquivos/moto-g7-play-img-product.png?v=636862863804700000', 15699),
('S99', 'Play 4', 'Ya no se cuantas versiones hay', 3, 3, 'sin_imagen_para_que_de_error....muejeje', 35000),
('S56', 'Bravia 55', 'Alta tele', 3, 2, 'https://intercompras.com/product_thumb_keepratio_2.php?img=images/product/SONY_KDL-55W950A.jpg&w=650&h=450', 49500),
('A23', 'Apple TV', 'lindo loro', 2, 3, 'https://store.storeimages.cdn-apple.com/4668/as-images.apple.com/is/rfb-apple-tv-4k?wid=1144&hei=1144&fmt=jpeg&qlt=80&.v=1513897159574', 7850)
select * from ARTICULOS
