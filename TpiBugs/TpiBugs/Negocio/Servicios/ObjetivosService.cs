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
        public IList<Objetivos> GetObjetivosConBorrado(string corto, string largo)
        {
            return oObjetivosDao.getObjConBorrado(corto,largo);
        }
        public IList<Objetivos> GetObjetivosSinBorrado(string corto, string largo)
        {
            return oObjetivosDao.getObjSinBorrado(corto, largo);
        }
        internal IList<Objetivos> GetObjetivosNomCorto(string nombreCorto)
        {
            return oObjetivosDao.getPorNombreCorto(nombreCorto);
        }
        internal void cargaObjetivos(string nombreCorto, string nombreLargo)
        {
            oObjetivosDao.cargaObjetivo(nombreCorto, nombreLargo);
        }

        internal bool existeNombre(string nombre,string columna,int id)
        {
            return oObjetivosDao.getIfExisteNombre(nombre, columna, id);
        }

        internal IList<Objetivos> GetObjetivosNomLargo(string nombreLargo)
        {
            return oObjetivosDao.getPorNombreLargo(nombreLargo);
        }

        internal bool actualizarObjetivo(Objetivos oObjetivoSeleccionado)
        {
            return oObjetivosDao.Actualizar(oObjetivoSeleccionado); 
        }

        internal IList<Objetivos> GetObjetivosById(int id_objetivos)
        {
            return oObjetivosDao.GetObjetivosByid(id_objetivos);
        }

        internal bool borrarObjetivo(int id)
        {
            return oObjetivosDao.delete(id);
        }

        internal IList<Objetivos> GetObjetivosDisponibles(int id_curso)
        {
            return oObjetivosDao.GetObjetivosDisponibles(id_curso);
        }
    }
}
