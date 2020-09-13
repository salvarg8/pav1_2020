using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpiBugs.Negocio.Entidades
{
    public class Perfil
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
        public List<OpcionMenu> OpcionesMenu { get; set; }

        public bool Borrado { get; set; }

        public Perfil()
        {
            OpcionesMenu = new List<OpcionMenu>();
        }

        public Perfil(int id, String nombre, List<OpcionMenu> opcionesMenu)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.OpcionesMenu = opcionesMenu;
        }
    }
}
