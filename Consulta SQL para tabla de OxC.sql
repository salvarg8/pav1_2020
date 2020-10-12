select nombre_corto,nombre_largo
from [dbo].[ObjetivosCursos] OC, Objetivos O, Cursos C
where OC.id_curso = C.id_curso 
and OC.id_objetivo = O.id_objetivo 
and C.id_curso = ?



select nombre_corto,nombre_largo
from Objetivos O 
where id_objetivo 
not in(select o.id_objetivo
from [dbo].[ObjetivosCursos] OC, Objetivos O, Cursos C
where OC.id_curso = C.id_curso and OC.id_objetivo = O.id_objetivo and C.id_curso = ?)
