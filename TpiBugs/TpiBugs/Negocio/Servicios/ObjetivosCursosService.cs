using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpiBugs.Datos.Dao.Implementacion;
using TpiBugs.Negocio.Entidades;

namespace TpiBugs.Negocio.Servicios
{

    public class ObjetivosCursosService
    {
        private ObjetivosCursosDao oObjetivosCursosDao;
        public ObjetivosCursosService()
        {
            oObjetivosCursosDao = new ObjetivosCursosDao();
        }

        internal IList<ObjetivosCursos> GetObjetivosPorCurso(int id_curso)
        {
            return (oObjetivosCursosDao.GetObjetivosPorCurso(id_curso));
        }

        internal bool crear(int id_curso, List<Objetivos> objetivos, int porc)
        {
            return oObjetivosCursosDao.Create(id_curso, objetivos, porc);
        }
    }
}


