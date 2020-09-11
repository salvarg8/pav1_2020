USE [BD_extendida]
GO
/* Insertar datos en la tabla de objetivos  */

INSERT INTO [dbo].[Objetivos]([id_objetivo],[nombre_corto],[nombre_largo],[borrado])VALUES(4,N'corto',N'largo',0)
INSERT INTO [dbo].[Objetivos]([id_objetivo],[nombre_corto],[nombre_largo],[borrado])VALUES(5,N'corto5',N'largo5',1)
INSERT INTO [dbo].[Objetivos]([id_objetivo],[nombre_corto],[nombre_largo],[borrado])VALUES(6,N'corto6',N'largo6',0)
INSERT INTO [dbo].[Objetivos]([id_objetivo],[nombre_corto],[nombre_largo],[borrado])VALUES(7,N'corto7',N'largo7',1)
INSERT INTO [dbo].[Objetivos]([id_objetivo],[nombre_corto],[nombre_largo],[borrado])VALUES(8,N'corto8',N'largo8',0)
GO

/* Insertar datos en la tabla de Categorias */


INSERT INTO [dbo].[Categorias]([id_categoria],[nombre],[descripcion],[borrado])VALUES(1,N'Categoria 1',N'descripcion de categoria 1', 1)
INSERT INTO [dbo].[Categorias]([id_categoria],[nombre],[descripcion],[borrado])VALUES(2,N'Categoria 2',N'descripcion de categoria 2', 1)
INSERT INTO [dbo].[Categorias]([id_categoria],[nombre],[descripcion],[borrado])VALUES(3,N'Categoria 3',N'descripcion de categoria 3', 1)
INSERT INTO [dbo].[Categorias]([id_categoria],[nombre],[descripcion],[borrado])VALUES(4,N'Categoria 4',N'descripcion de categoria 4', 0)
INSERT INTO [dbo].[Categorias]([id_categoria],[nombre],[descripcion],[borrado])VALUES(5,N'Categoria 5',N'descripcion de categoria 5', 1)
INSERT INTO [dbo].[Categorias]([id_categoria],[nombre],[descripcion],[borrado])VALUES(6,N'Categoria 6',N'descripcion de categoria 6', 0)
          
GO

/*Insertar datos en la tabla Cursos*/

INSERT INTO [dbo].[Cursos]([id_curso],[nombre],[descripcion],[fecha_vigencia],[id_categoria],[borrado])VALUES(1,N'Cocina',N'Cocina Mediterranea',CAST(N'2020-12-01' AS Date),1,1)
INSERT INTO [dbo].[Cursos]([id_curso],[nombre],[descripcion],[fecha_vigencia],[id_categoria],[borrado])VALUES(2,N'Reposteria',N'Tartas Dulces',CAST(N'2020-11-15' AS Date),2,1)
INSERT INTO [dbo].[Cursos]([id_curso],[nombre],[descripcion],[fecha_vigencia],[id_categoria],[borrado])VALUES(3,N'Mecanica',N'Mecanica de Motos',CAST(N'2020-12-11' AS Date),3,0)
INSERT INTO [dbo].[Cursos]([id_curso],[nombre],[descripcion],[fecha_vigencia],[id_categoria],[borrado])VALUES(4,N'FloorWork',N'Danza',CAST(N'2020-11-01' AS Date),3,1)
INSERT INTO [dbo].[Cursos]([id_curso],[nombre],[descripcion],[fecha_vigencia],[id_categoria],[borrado])VALUES(5,N'Fotografia',N'Fotografia Mediterranea',CAST(N'2020-12-01' AS Date),4,1)

GO



