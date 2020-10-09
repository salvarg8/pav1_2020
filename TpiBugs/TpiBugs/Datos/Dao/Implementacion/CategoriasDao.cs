using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpiBugs.Datos.Helper;
using TpiBugs.Negocio.Entidades;

namespace TpiBugs.Datos.Dao.Implementacion
{
    class CategoriasDao
    {
        internal IList<Categorias> getObjConBorrado(string nombre)
        {
            List<Categorias> categorias = new List<Categorias>();
            String strSql = "SELECT * FROM dbo.Categorias where nombre like '%' + @param1 + '%'";
            DataTable data = DBHelper.getDBHelper().ConsultarSQLConParametros(strSql, new object[] { nombre });
            foreach (DataRow row in data.Rows)
            {
                int id = int.Parse(row["id_categoria"].ToString());
                Boolean borrado = Boolean.Parse(row["borrado"].ToString());
                Categorias obj = new Categorias(id, row["nombre"].ToString(), row["descripcion"].ToString(), borrado);
                categorias.Add(obj);
            }
            return categorias;
        }

        internal bool Actualizar(Categorias oCategoriaSelected)
        {
            String strSql = "UPDATE Categorias set nombre = @param1, descripcion = @param2 where id_objetivo = @param3";
            var parametros = new Dictionary<string, object>();
            parametros.Add("param1", oCategoriaSelected.Nombre);
            parametros.Add("param2", oCategoriaSelected.Descripcion);
            parametros.Add("param3", oCategoriaSelected.Id_Categoria);
            return (DataManager.GetInstance().EjecutarSQL(strSql, parametros) == 1);
        }

        internal bool delete(int id)
        {
            string strSql = "UPDATE Categorias set borrado = 1 WHERE id_categoria =" + id;
            return DBHelper.getDBHelper().ejecutarSQL(strSql) != 0;
        }

        internal bool cargaCategoria(string nombre, string descripcion)
        {
            String strSql = "INSERT INTO [dbo].[Categorias]([nombre],[descripcion],[borrado])VALUES('" + nombre + "','" + descripcion + "',0)";
            return DBHelper.getDBHelper().ejecutarSQL(strSql) > 0;
        }

        internal bool getIfExisteCaracteristica(string nombre, string columna, int id)
        {
            String strSql = "select * from Categorias where " + columna + " = '" + nombre + "' and id_categoria <> " + id;
            if (Convert.ToInt32(DBHelper.getDBHelper().ConsultaSQLScalar(strSql)) == 0)
            {
                return false;
            }
            else
                return true;
        }

        internal IList<Categorias> getObjSinBorrado(string nombre)
        {
            List<Categorias> categorias = new List<Categorias>();
            String strSql = "SELECT * FROM dbo.Categorias where nombre like '%' + @param1 + '%' and borrado <> 1";
            DataTable data = DBHelper.getDBHelper().ConsultarSQLConParametros(strSql, new object[] { nombre });
            foreach (DataRow row in data.Rows)
            {
                int id = int.Parse(row["id_categoria"].ToString());
                Boolean borrado = Boolean.Parse(row["borrado"].ToString());
                Categorias obj = new Categorias(id, row["nombre"].ToString(), row["descripcion"].ToString(), borrado);
                categorias.Add(obj);
            }
            return categorias;
        }
    }
}
