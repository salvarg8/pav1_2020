using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpiBugs.Datos.Dao.Implementacion;
using TpiBugs.Negocio.Servicios;

namespace TpiBugs.Negocio.Entidades
{
    public class Objetivos
    {

        public int ID_objetivos { get; set; }
        public string Nombre_corto { get; set; }
        public string Nombre_largo { get; set; }
        public int Borrado { get; set; }

        public Objetivos(int iD_objetivos, string nombre_corto, string nombre_largo)
        {
           
            ID_objetivos = iD_objetivos;
            Nombre_corto = nombre_corto;
            Nombre_largo = nombre_largo;
            
           
            
        }
    }   
    
}
