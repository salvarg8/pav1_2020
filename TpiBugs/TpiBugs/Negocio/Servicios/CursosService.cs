using System;
using System.Collections.Generic;
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

        internal bool borrarCurso(int id)
        {
            return oCursosDao.delete(id);
        }

        internal void cargaCurso(string nombre, string descripcion, DateTime vigencia, int id_categoria)
        {
            oCursosDao.cargaCurso(nombre, descripcion, vigencia, id_categoria);
        }

        internal bool ActualizarCurso(int id_curso, string nombre, string descripcion, DateTime vigencia, int id_categoria)
        {
            return (oCursosDao.ActualizarCurso(id_curso, nombre, descripcion, vigencia, id_categoria));
        }

        internal bool CategoriaEnUso(int id_Categoria)
        {
            return (oCursosDao.CategoriaEnUso(id_Categoria));
        }
    }
}
