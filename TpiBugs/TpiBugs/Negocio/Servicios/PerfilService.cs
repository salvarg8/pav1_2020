using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TpiBugs.Datos.Dao.Implementacion;
using TpiBugs.Negocio.Entidades;

namespace PrimerAppEnCapas.Negocio.Servicios
{
    public class PerfilService
    {
        private PerfillDaoSqlImp dao;

        public PerfilService()
        {
            dao = new PerfillDaoSqlImp();
        }


        public List<Perfil> FindByNombre(string filter)
        {
            return dao.FindByNombre(filter);
        }

        public List<OpcionMenu> getOpcionesByPerfil(int id)
        {
            return dao.getOpcionesByPerfil(id);
        }

        public List<OpcionMenu> getOpcionesMenu()
        {
            return dao.getOpcionesMenuAll();
        }



        public bool borrarPerfil(int id)
        {
            return dao.delete(id);
        }

        public bool crearPerfil(string nombre, List<int> ids)
        {
            List<OpcionMenu> opciones = new List<OpcionMenu>();

            foreach (int id in ids)
            {
                OpcionMenu om = new OpcionMenu();
                om.Id = id;
                opciones.Add(om);
            }

            Perfil oNuevo = new Perfil(0, nombre, opciones);

            return dao.add(oNuevo);
        }
    }
}
