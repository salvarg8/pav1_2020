using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpiBugs.Negocio.Entidades
{
    public class Categorias
    {
        public int Id_Categoria { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool Borrado { get; set; }

        public Categorias(int id_Categoria, string nombre, string descripcion, bool borrado)
        {
            Id_Categoria = id_Categoria;
            Nombre = nombre;
            Descripcion = descripcion;
            Borrado = borrado;
        }

        public Categorias()
        {
        }
    }
}
