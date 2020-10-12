using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpiBugs.Negocio.Entidades
{
    public class ObjetivosCursos
    {
        public Objetivos Objetivo { get; set; }
        public Cursos Curso { get; set; }
        public int Puntos { get; set; }
        public bool Borrado { get; set; }

        public ObjetivosCursos(Objetivos objetivo, Cursos curso, int puntos, bool borrado)
        {
            Objetivo = objetivo;
            Curso = curso;
            Puntos = puntos;
            Borrado = borrado;
        }

        public ObjetivosCursos()
        {
        }
    }

}
