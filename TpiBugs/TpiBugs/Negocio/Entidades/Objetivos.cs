using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpiBugs.Negocio.Entidades
{
    public class Objetivos
    {
        public int ID_objetivos { get; set; }
        public string Nombre_corto { get; set; }
        public string Nombre_largo { get; set; }
        public bool Borrado { get; set; }

        public Objetivos() { }

        public Objetivos(int id, string nomCorto, string nomLargo)
        {
            this.ID_objetivos = id;
            this.Nombre_corto = nomCorto;
            this.Nombre_largo = nomLargo;
        }
    }
}
