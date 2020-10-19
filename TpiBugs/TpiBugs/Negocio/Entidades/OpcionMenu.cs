using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpiBugs.Negocio.Entidades
{
    public class OpcionMenu
    {
        public int Id { get; set; }
        public String Nombre { get; set; }

        public OpcionMenu() { }
        public OpcionMenu(int id, String nombre)
        {
            this.Id = id;
            this.Nombre = nombre;
        }
    }
}
