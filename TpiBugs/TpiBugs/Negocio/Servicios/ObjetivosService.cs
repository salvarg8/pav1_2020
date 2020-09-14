using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpiBugs.Datos.Dao.Implementacion;
using TpiBugs.Negocio.Entidades;
using TpiBugs.Datos.Dao;

namespace TpiBugs.Negocio.Servicios
{
    public class ObjetivosService
    {
        private ObjetivosDao dao;

        public ObjetivosService()
        {
            dao = new ObjetivosDao();
        }


        public IList<Objetivos> GetObjetivos()
        {
            return dao.GetAll();
            

        }

        internal IList<Objetivos> GetObjetivosNomCorto(string nombreCorto)
        {
            return dao.getPorNombreCorto(nombreCorto);
        }

        internal IList<Objetivos> GetObjetivosNomLargo(string nombreLargo)
        {
            return dao.getPorNombreLargo(nombreLargo);
        }
    }
}
