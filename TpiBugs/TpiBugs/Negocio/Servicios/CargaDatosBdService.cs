using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpiBugs.Datos.Dao.Implementacion;

namespace TpiBugs.Negocio.Servicios
{
    
    public class CargaDatosBdService
    {
        private CargaDatosBdDao oCargaDatosBdDao;

        public CargaDatosBdService()
        {
            oCargaDatosBdDao = new CargaDatosBdDao();
        }

        internal bool cargarDatos()
        {
            return oCargaDatosBdDao.cargarDatos();
        }
    }
}
