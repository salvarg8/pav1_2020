using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpiBugs.Negocio.Entidades
{
    public class Cursos
    {
        public int Id_curso { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime Vigencia { get; set; }
        public Categorias Categoria { get; set; }
        public bool Borrado { get; set; }

        public Cursos(int id_curso, string nombre, string descripcion, DateTime vigencia, Categorias categoria, bool borrado)
        {
            Id_curso = id_curso;
            Nombre = nombre;
            Descripcion = descripcion;
            Vigencia = vigencia;
            Categoria = categoria;
            Borrado = borrado;
        }

        public Cursos()
        {
        }
    }
}
