USE [BD_extendida]

BEGIN TRY
    BEGIN TRANSACTION

		DELETE FROM [dbo].[ObjetivosCursos]
		dELETE FROM [dbo].[Cursos]
		Delete From [dbo].[Categorias]
		DELETE FROM [dbo].[Objetivos]
    


		
		/* Insertar datos en la tabla de objetivos  */

																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																						 
		SET IDENTITY_INSERT [dbo].[Objetivos] ON 
		INSERT INTO [dbo].[Objetivos]([id_objetivo],[nombre_corto],[nombre_largo],[borrado])VALUES(1,N'Parcial',N'Parcial de la parte practica',0)
		INSERT INTO [dbo].[Objetivos]([id_objetivo],[nombre_corto],[nombre_largo],[borrado])VALUES(2,N'Parcial Integrador',N'Parcial Teorico y practico',1)
		INSERT INTO [dbo].[Objetivos]([id_objetivo],[nombre_corto],[nombre_largo],[borrado])VALUES(3,N'Coloquio',N'Coloquio final de un tema a elegir',0)
		INSERT INTO [dbo].[Objetivos]([id_objetivo],[nombre_corto],[nombre_largo],[borrado])VALUES(4,N'Coloquio Integrador',N'Coloqui integrador de toda la materia',1)
		INSERT INTO [dbo].[Objetivos]([id_objetivo],[nombre_corto],[nombre_largo],[borrado])VALUES(5,N'Parcial Oral Practico',N'Parcial Oral de las unidades practicas',0)
		INSERT INTO [dbo].[Objetivos]([id_objetivo],[nombre_corto],[nombre_largo],[borrado])VALUES(6,N'Trabajo Practico',N'Presentar Todos los trabajos practicos',0)
		INSERT INTO [dbo].[Objetivos]([id_objetivo],[nombre_corto],[nombre_largo],[borrado])VALUES(7,N'Laboratorio',N'TRabajos practicos a realizar en laboratorio',1)
		INSERT INTO [dbo].[Objetivos]([id_objetivo],[nombre_corto],[nombre_largo],[borrado])VALUES(8,N'Maqueta',N'Maquetado 3d de piezas del curso',0)
		INSERT INTO [dbo].[Objetivos]([id_objetivo],[nombre_corto],[nombre_largo],[borrado])VALUES(9,N'Caramelos para el profe',N'Porque ya no aprobas con nada',1)
		INSERT INTO [dbo].[Objetivos]([id_objetivo],[nombre_corto],[nombre_largo],[borrado])VALUES(10,N'Final',N'Este te la debo',0)
		SET IDENTITY_INSERT [dbo].[Objetivos] OFF
		

		/* Insertar datos en la tabla de Categorias */

		SET IDENTITY_INSERT [dbo].[Categorias] ON  
		INSERT INTO [dbo].[Categorias]([id_categoria],[nombre],[descripcion],[borrado])VALUES(1,N'Categoria 1',N'descripcion de categoria 1', 0)
		INSERT INTO [dbo].[Categorias]([id_categoria],[nombre],[descripcion],[borrado])VALUES(2,N'Categoria 2',N'descripcion de categoria 2', 0)
		INSERT INTO [dbo].[Categorias]([id_categoria],[nombre],[descripcion],[borrado])VALUES(3,N'Categoria 3',N'descripcion de categoria 3', 0)
		INSERT INTO [dbo].[Categorias]([id_categoria],[nombre],[descripcion],[borrado])VALUES(4,N'Categoria 4',N'descripcion de categoria 4', 0)
		INSERT INTO [dbo].[Categorias]([id_categoria],[nombre],[descripcion],[borrado])VALUES(5,N'Categoria 5',N'descripcion de categoria 5', 0)
		INSERT INTO [dbo].[Categorias]([id_categoria],[nombre],[descripcion],[borrado])VALUES(6,N'Categoria 6',N'descripcion de categoria 6', 0)
		INSERT INTO [dbo].[Categorias]([id_categoria],[nombre],[descripcion],[borrado])VALUES(7,N'Categoria 7',N'descripcion de categoria 7', 0)
		INSERT INTO [dbo].[Categorias]([id_categoria],[nombre],[descripcion],[borrado])VALUES(8,N'Categoria 8',N'descripcion de categoria 8', 0)
		INSERT INTO [dbo].[Categorias]([id_categoria],[nombre],[descripcion],[borrado])VALUES(9,N'Categoria 9',N'descripcion de categoria 9', 0)
		INSERT INTO [dbo].[Categorias]([id_categoria],[nombre],[descripcion],[borrado])VALUES(10,N'Categoria 10',N'descripcion de categoria 10', 0)
		SET IDENTITY_INSERT [dbo].[Categorias] OFF         
		

		/*Insertar datos en la tabla Cursos*/
		SET IDENTITY_INSERT [dbo].[Cursos] ON
		INSERT INTO [dbo].[Cursos]([id_curso],[nombre],[descripcion],[fecha_vigencia],[id_categoria],[borrado])VALUES(1,N'Cocina',N'Cocina Mediterranea',CAST(N'2020-12-01' AS Date),1,1)
		INSERT INTO [dbo].[Cursos]([id_curso],[nombre],[descripcion],[fecha_vigencia],[id_categoria],[borrado])VALUES(2,N'Reposteria',N'Tartas Dulces',CAST(N'2020-11-15' AS Date),2,0)
		INSERT INTO [dbo].[Cursos]([id_curso],[nombre],[descripcion],[fecha_vigencia],[id_categoria],[borrado])VALUES(3,N'Mecanica',N'Mecanica de Motos',CAST(N'2020-12-11' AS Date),3,0)
		INSERT INTO [dbo].[Cursos]([id_curso],[nombre],[descripcion],[fecha_vigencia],[id_categoria],[borrado])VALUES(4,N'FloorWork',N'Danza',CAST(N'2020-11-01' AS Date),3,1)
		INSERT INTO [dbo].[Cursos]([id_curso],[nombre],[descripcion],[fecha_vigencia],[id_categoria],[borrado])VALUES(5,N'Fotografia',N'Fotografia Mediterranea',CAST(N'2020-12-01' AS Date),4,0)
		
		INSERT INTO [dbo].[Cursos]([id_curso],[nombre],[descripcion],[fecha_vigencia],[id_categoria],[borrado])VALUES(6,N'Cocina Oriental',N'Cocina Asia',CAST(N'2021-12-01' AS Date),5,0)
		INSERT INTO [dbo].[Cursos]([id_curso],[nombre],[descripcion],[fecha_vigencia],[id_categoria],[borrado])VALUES(7,N'Reapracion de Celu',N' Iphone',CAST(N'2020-10-18' AS Date),6,0)
		INSERT INTO [dbo].[Cursos]([id_curso],[nombre],[descripcion],[fecha_vigencia],[id_categoria],[borrado])VALUES(8,N'Mecanica Dental',N'Mecanica de Dientes',CAST(N'2020-01-08' AS Date),2,0)
		INSERT INTO [dbo].[Cursos]([id_curso],[nombre],[descripcion],[fecha_vigencia],[id_categoria],[borrado])VALUES(9,N'Clasico',N'Danza Clasica',CAST(N'2020-11-01' AS Date),4,0)
		INSERT INTO [dbo].[Cursos]([id_curso],[nombre],[descripcion],[fecha_vigencia],[id_categoria],[borrado])VALUES(10,N'Fotografia Estenopeica',N'Fotografia EStenopeica en laboratorio',CAST(N'2019-12-01' AS Date),3,0)
		
		
		INSERT INTO [dbo].[Cursos]([id_curso],[nombre],[descripcion],[fecha_vigencia],[id_categoria],[borrado])VALUES(11,N'Cocina Turca',N'Cocina Turca con arena',CAST(N'2020-12-07' AS Date),1,1)
		INSERT INTO [dbo].[Cursos]([id_curso],[nombre],[descripcion],[fecha_vigencia],[id_categoria],[borrado])VALUES(12,N'Reposteria de Babyshower',N'Tartas Dulces para babyshower',CAST(N'2020-10-05' AS Date),2,0)
		INSERT INTO [dbo].[Cursos]([id_curso],[nombre],[descripcion],[fecha_vigencia],[id_categoria],[borrado])VALUES(13,N'Mecanica de autos',N'Mecanica de Automoviles',CAST(N'2020-11-18' AS Date),5,0)
		INSERT INTO [dbo].[Cursos]([id_curso],[nombre],[descripcion],[fecha_vigencia],[id_categoria],[borrado])VALUES(14,N'Contemporaneo',N'Danza Contemporanea',CAST(N'2020-11-01' AS Date),4,1)
		INSERT INTO [dbo].[Cursos]([id_curso],[nombre],[descripcion],[fecha_vigencia],[id_categoria],[borrado])VALUES(15,N'Fotografia Digital',N'Fotografia Digital y Retoque',CAST(N'2018-12-01' AS Date),4,0)
		
		
		INSERT INTO [dbo].[Cursos]([id_curso],[nombre],[descripcion],[fecha_vigencia],[id_categoria],[borrado])VALUES(16,N'Cocina Quemada',N'Como recuperar comida quemada',CAST(N'2018-12-01' AS Date),1,1)
		INSERT INTO [dbo].[Cursos]([id_curso],[nombre],[descripcion],[fecha_vigencia],[id_categoria],[borrado])VALUES(17,N'Reposteria azul',N'Tartas Dulces azules',CAST(N'2020-11-15' AS Date),2,0)
		INSERT INTO [dbo].[Cursos]([id_curso],[nombre],[descripcion],[fecha_vigencia],[id_categoria],[borrado])VALUES(18,N'Mecanica de Aviones',N'Mecanica de Aviones a chorro',CAST(N'2020-12-11' AS Date),3,0)
		INSERT INTO [dbo].[Cursos]([id_curso],[nombre],[descripcion],[fecha_vigencia],[id_categoria],[borrado])VALUES(19,N'Salsa',N'Danza Salsistica',CAST(N'2020-11-01' AS Date),3,1)
		INSERT INTO [dbo].[Cursos]([id_curso],[nombre],[descripcion],[fecha_vigencia],[id_categoria],[borrado])VALUES(20,N'Fotografia de Retrato',N'Fotografia Mediterranea de Retratos',CAST(N'2020-12-01' AS Date),4,0)
		
		
		INSERT INTO [dbo].[Cursos]([id_curso],[nombre],[descripcion],[fecha_vigencia],[id_categoria],[borrado])VALUES(21,N'Cocina Mexicana',N'Cocina Mexicana con Aji',CAST(N'2020-12-12' AS Date),1,1)
		INSERT INTO [dbo].[Cursos]([id_curso],[nombre],[descripcion],[fecha_vigencia],[id_categoria],[borrado])VALUES(22,N'Reposteria Vegetal',N'Tartas Dulces veganas',CAST(N'2020-11-15' AS Date),5,0)
		INSERT INTO [dbo].[Cursos]([id_curso],[nombre],[descripcion],[fecha_vigencia],[id_categoria],[borrado])VALUES(23,N'Mecanica de Autitos de juguete',N'Mecanica de Juguetes',CAST(N'2021-11-11' AS Date),3,0)
		INSERT INTO [dbo].[Cursos]([id_curso],[nombre],[descripcion],[fecha_vigencia],[id_categoria],[borrado])VALUES(24,N'Hip hop',N'Danza del Bronxs',CAST(N'2020-11-01' AS Date),2,1)
		INSERT INTO [dbo].[Cursos]([id_curso],[nombre],[descripcion],[fecha_vigencia],[id_categoria],[borrado])VALUES(25,N'Fotografia de paisajes',N'Fotografia de paisajes urbanos',CAST(N'2020-11-01' AS Date),4,0)
		
		
		INSERT INTO [dbo].[Cursos]([id_curso],[nombre],[descripcion],[fecha_vigencia],[id_categoria],[borrado])VALUES(31,N'Cocina Ecuatoriana',N'Cocina del Centro del mundo',CAST(N'2020-12-01' AS Date),1,0)
		INSERT INTO [dbo].[Cursos]([id_curso],[nombre],[descripcion],[fecha_vigencia],[id_categoria],[borrado])VALUES(32,N'Reposteria italiana',N'Tartas Dulces de Italia',CAST(N'2020-11-15' AS Date),2,0)
		INSERT INTO [dbo].[Cursos]([id_curso],[nombre],[descripcion],[fecha_vigencia],[id_categoria],[borrado])VALUES(33,N'Mecanica de Motosierras',N'Mecanica de Motosierras',CAST(N'2020-12-11' AS Date),3,0)
		INSERT INTO [dbo].[Cursos]([id_curso],[nombre],[descripcion],[fecha_vigencia],[id_categoria],[borrado])VALUES(34,N'Danza Irlandesa',N'Danza y Zapateo irlandes',CAST(N'2020-11-01' AS Date),3,1)
		INSERT INTO [dbo].[Cursos]([id_curso],[nombre],[descripcion],[fecha_vigencia],[id_categoria],[borrado])VALUES(35,N'Fotografia de perros',N'Fotografia contemporanea retratos de perro',CAST(N'2020-12-01' AS Date),4,0)
		
		
		INSERT INTO [dbo].[Cursos]([id_curso],[nombre],[descripcion],[fecha_vigencia],[id_categoria],[borrado])VALUES(26,N'Cocina Egipcia',N'Cocina Mediterranea entre las piramides',CAST(N'2021-12-01' AS Date),1,0)
		INSERT INTO [dbo].[Cursos]([id_curso],[nombre],[descripcion],[fecha_vigencia],[id_categoria],[borrado])VALUES(27,N'Reposteria frutral',N'Tartas Dulces con frutas de estacion',CAST(N'2020-10-15' AS Date),2,0)
		INSERT INTO [dbo].[Cursos]([id_curso],[nombre],[descripcion],[fecha_vigencia],[id_categoria],[borrado])VALUES(28,N'Mecanica de gruas',N'Mecanica de gruas',CAST(N'2020-12-11' AS Date),3,0)
		INSERT INTO [dbo].[Cursos]([id_curso],[nombre],[descripcion],[fecha_vigencia],[id_categoria],[borrado])VALUES(29,N'Danza Aerea',N'Danza en tela',CAST(N'2020-11-01' AS Date),3,1)
		INSERT INTO [dbo].[Cursos]([id_curso],[nombre],[descripcion],[fecha_vigencia],[id_categoria],[borrado])VALUES(30,N'Fotografia de cuadros',N'Fotografia en museos',CAST(N'2020-11-01' AS Date),4,0)
		

		SET IDENTITY_INSERT [dbo].[Cursos] OFF
		




        INSERT INTO [dbo].[Cursos]
           ([nombre],[descripcion],[fecha_vigencia],[id_categoria],[borrado])
        VALUES
           ('Reparacion de Celus','Curso Intensivo','2020-10-10 10:10:10',2,0)

		/*  PRINT 'Objetivos por Curso'   */

        INSERT INTO [dbo].[ObjetivosCursos]
					([id_objetivo],[id_curso],[puntos],[borrado])
					VALUES (1,4,20,0)
        INSERT INTO [dbo].[ObjetivosCursos]
					([id_curso],[id_objetivo],[puntos],[borrado])
					VALUES (1,5,20,0)
		INSERT INTO [dbo].[ObjetivosCursos]
					([id_curso],[id_objetivo],[puntos],[borrado])
					VALUES (2,5,20,0)
		INSERT INTO [dbo].[ObjetivosCursos]
					([id_curso],[id_objetivo],[puntos],[borrado])
					VALUES (2,7,20,0)
        INSERT INTO [dbo].[ObjetivosCursos]
					([id_curso],[id_objetivo],[puntos],[borrado])
					VALUES (3,4,20,0)
        INSERT INTO [dbo].[ObjetivosCursos]
					([id_curso],[id_objetivo],[puntos],[borrado])
					VALUES (3,1,20,0)
		INSERT INTO [dbo].[ObjetivosCursos]
					([id_curso],[id_objetivo],[puntos],[borrado])
					VALUES (3,2,20,0)
		INSERT INTO [dbo].[ObjetivosCursos]
					([id_curso],[id_objetivo],[puntos],[borrado])
					VALUES (3,3,20,0)

        INSERT INTO [dbo].[ObjetivosCursos]
					([id_curso],[id_objetivo],[puntos],[borrado])
					VALUES (1,1,20,0)
        INSERT INTO [dbo].[ObjetivosCursos]
					([id_curso],[id_objetivo],[puntos],[borrado])
					VALUES (1,3,20,0)
		INSERT INTO [dbo].[ObjetivosCursos]
					([id_curso],[id_objetivo],[puntos],[borrado])
					VALUES (2,1,20,0)
		INSERT INTO [dbo].[ObjetivosCursos]
					([id_curso],[id_objetivo],[puntos],[borrado])
					VALUES (2,2,20,0)

        INSERT INTO [dbo].[ObjetivosCursos]
					([id_curso],[id_objetivo],[puntos],[borrado])
					VALUES (1,2,22,0)
        INSERT INTO [dbo].[ObjetivosCursos]
					([id_curso],[id_objetivo],[puntos],[borrado])
					VALUES (1,6,23,0)
		INSERT INTO [dbo].[ObjetivosCursos]
					([id_curso],[id_objetivo],[puntos],[borrado])
					VALUES (2,3,20,0)
		INSERT INTO [dbo].[ObjetivosCursos]
					([id_curso],[id_objetivo],[puntos],[borrado])
					VALUES (2,6,20,0)


        INSERT INTO [dbo].[ObjetivosCursos]
					([id_curso],[id_objetivo],[puntos],[borrado])
					VALUES (3,5,20,0)
        INSERT INTO [dbo].[ObjetivosCursos]
					([id_curso],[id_objetivo],[puntos],[borrado])
					VALUES (3,6,20,0)
		INSERT INTO [dbo].[ObjetivosCursos]
					([id_curso],[id_objetivo],[puntos],[borrado])
					VALUES (3,7,20,0)

 
 
		INSERT INTO [dbo].[ObjetivosCursos]
					([id_curso],[id_objetivo],[puntos],[borrado])
					VALUES (4,6,20,0)
        INSERT INTO [dbo].[ObjetivosCursos]
					([id_curso],[id_objetivo],[puntos],[borrado])
					VALUES (4,4,20,0)
        INSERT INTO [dbo].[ObjetivosCursos]
					([id_curso],[id_objetivo],[puntos],[borrado])
					VALUES (4,2,20,0)
		INSERT INTO [dbo].[ObjetivosCursos]
					([id_curso],[id_objetivo],[puntos],[borrado])
					VALUES (4,7,20,0)
		INSERT INTO [dbo].[ObjetivosCursos]
					([id_curso],[id_objetivo],[puntos],[borrado])
					VALUES (4,5,20,0)

		INSERT INTO [dbo].[ObjetivosCursos]
					([id_curso],[id_objetivo],[puntos],[borrado])
					VALUES (5,6,20,0)
        INSERT INTO [dbo].[ObjetivosCursos]
					([id_curso],[id_objetivo],[puntos],[borrado])
					VALUES (5,4,20,0)
        INSERT INTO [dbo].[ObjetivosCursos]
					([id_curso],[id_objetivo],[puntos],[borrado])
					VALUES (5,2,20,0)
		INSERT INTO [dbo].[ObjetivosCursos]
					([id_curso],[id_objetivo],[puntos],[borrado])
					VALUES (5,7,20,0)
		INSERT INTO [dbo].[ObjetivosCursos]
					([id_curso],[id_objetivo],[puntos],[borrado])
					VALUES (5,5,20,0)

		INSERT INTO [dbo].[ObjetivosCursos]
					([id_curso],[id_objetivo],[puntos],[borrado])
					VALUES (6,6,20,0)
        INSERT INTO [dbo].[ObjetivosCursos]
					([id_curso],[id_objetivo],[puntos],[borrado])
					VALUES (6,4,20,0)
        INSERT INTO [dbo].[ObjetivosCursos]
					([id_curso],[id_objetivo],[puntos],[borrado])
					VALUES (6,2,20,0)
		INSERT INTO [dbo].[ObjetivosCursos]
					([id_curso],[id_objetivo],[puntos],[borrado])
					VALUES (6,7,20,0)
		INSERT INTO [dbo].[ObjetivosCursos]
					([id_curso],[id_objetivo],[puntos],[borrado])
					VALUES (6,5,20,0)

		INSERT INTO [dbo].[ObjetivosCursos]
					([id_curso],[id_objetivo],[puntos],[borrado])
					VALUES (7,6,20,0)
        INSERT INTO [dbo].[ObjetivosCursos]
					([id_curso],[id_objetivo],[puntos],[borrado])
					VALUES (7,4,20,0)
        INSERT INTO [dbo].[ObjetivosCursos]
					([id_curso],[id_objetivo],[puntos],[borrado])
					VALUES (7,2,20,0)
		INSERT INTO [dbo].[ObjetivosCursos]
					([id_curso],[id_objetivo],[puntos],[borrado])
					VALUES (7,7,20,0)
		INSERT INTO [dbo].[ObjetivosCursos]
					([id_curso],[id_objetivo],[puntos],[borrado])
					VALUES (7,5,20,0)

		INSERT INTO [dbo].[ObjetivosCursos]
					([id_curso],[id_objetivo],[puntos],[borrado])
					VALUES (8,6,20,0)
        INSERT INTO [dbo].[ObjetivosCursos]
					([id_curso],[id_objetivo],[puntos],[borrado])
					VALUES (8,4,20,0)
        INSERT INTO [dbo].[ObjetivosCursos]
					([id_curso],[id_objetivo],[puntos],[borrado])
					VALUES (8,2,20,0)
		INSERT INTO [dbo].[ObjetivosCursos]
					([id_curso],[id_objetivo],[puntos],[borrado])
					VALUES (8,7,20,0)
		INSERT INTO [dbo].[ObjetivosCursos]
					([id_curso],[id_objetivo],[puntos],[borrado])
					VALUES (8,5,20,0)


		PRINT 'realizado'

		PRINT 'COMMIT'

        COMMIT
END TRY
BEGIN CATCH
	PRINT 'ROLLBACK'
    ROLLBACK
END CATCH