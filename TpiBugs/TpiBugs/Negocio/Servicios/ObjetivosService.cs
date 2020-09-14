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
        private ObjetivosDao oObjetivosDao;
        public ObjetivosService()
        {   
            oObjetivosDao = new ObjetivosDao();
        }
        public IList<Objetivos> GetObjetivos()
        {
            return oObjetivosDao.GetAll();
        }
        internal IList<Objetivos> GetObjetivosNomCorto(string nombreCorto)
        {
            return oObjetivosDao.getPorNombreCorto(nombreCorto);
        }
        internal void cargaObjetivos(string nombreCorto, string nombreLargo)
        {
            oObjetivosDao.cargaObjetivo(nombreCorto, nombreLargo);
        }
        internal IList<Objetivos> GetObjetivosNomLargo(string nombreLargo)
        {
            return oObjetivosDao.getPorNombreLargo(nombreLargo);
        }

        internal bool actualizarObjetivo(Objetivos oObjetivoSeleccionado)
        {
            return oObjetivosDao.Actualizar(oObjetivoSeleccionado); 
        }

        internal bool borrarObjetivo(int id)
        {
            return oObjetivosDao.delete(id);
        }
    }
}
