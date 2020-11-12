select Categorias.id_categoria, cursos.nombre,cursos.fecha_vigencia
from cursos, categorias
where ( cursos.id_categoria=Categorias.id_categoria 
        and cursos.fecha_vigencia >= getdate()
		and Categorias.id_categoria = 1 )     
		/*1 seria un PARAMETRO*/


group by Categorias.id_categoria, cursos.nombre,  cursos.fecha_vigencia