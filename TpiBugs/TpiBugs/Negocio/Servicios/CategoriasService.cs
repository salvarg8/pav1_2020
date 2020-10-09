using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpiBugs.Datos.Dao.Implementacion;
using TpiBugs.Negocio.Entidades;

namespace TpiBugs.Negocio.Servicios
{
    public class CategoriasService
    {
        private CategoriasDao oCategoriasDao;

        public CategoriasService()
        {
            oCategoriasDao = new CategoriasDao();
        }

        internal IList<Categorias> GetCategoriasConBorrado(string nombre)
        {
            return oCategoriasDao.getObjConBorrado(nombre);
        }

        internal IList<Categorias> GetCategoriasSinBorrado(string nombre)
        {
            return oCategoriasDao.getObjSinBorrado(nombre);
        }

        internal bool existeCaracteristica(string nombre, string columna, int id)
        {
            return oCategoriasDao.getIfExisteCaracteristica(nombre, columna, id);
        }

        internal bool actualizarCategoria(Categorias oCategoriaSelected)
        {
            return oCategoriasDao.Actualizar(oCategoriaSelected);
        }

        internal void cargarCategoria(string nombre, string descripcion)
        {
            oCategoriasDao.cargaCategoria(nombre, descripcion);
        }

        internal bool borrarCategoria(int id)
        {
            return oCategoriasDao.delete(id);
        }
    }
}
