using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpiBugs.Datos.Dao.Implementacion;
using TpiBugs.Negocio.Entidades;

namespace TpiBugs.Negocio.Servicios
{
    class CursosService
    {
        private CursosDao oCursosDao;
        
        public CursosService()
        {
            oCursosDao = new CursosDao();
        }

        internal IList<Cursos> GetCursoConBorrado(string nombre)
        {
            return oCursosDao.getCursoConBorrado(nombre);
        }
        internal IList<Cursos> GetCursoSinBorrado(string nombre)
        {
            return oCursosDao.getCursoSinBorrado(nombre);
        }
    }
}
