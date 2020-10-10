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
    class CursosDao
    {
        internal IList<Cursos> getCursoConBorrado(string nombre)
        {
            List<Cursos> cursos = new List<Cursos>();
            String strSql = "SELECT * FROM dbo.Cursos where nombre like '%' + @param1 + '%'";
            DataTable data = DBHelper.getDBHelper().ConsultarSQLConParametros(strSql, new object[] { nombre });
            foreach (DataRow row in data.Rows)
            {
                cursos.Add(ObjectMapping(row));
            }
            return cursos;
        }

        internal IList<Cursos> getCursoSinBorrado(string nombre)
        {
            List<Cursos> cursos = new List<Cursos>();
            String strSql = "SELECT * FROM dbo.Cursos where nombre like '%' + @param1 + '%' and borrado <>1";
            DataTable data = DBHelper.getDBHelper().ConsultarSQLConParametros(strSql, new object[] { nombre });
            foreach (DataRow row in data.Rows)
            {
                cursos.Add(ObjectMapping(row));
            }
            return cursos;
        }

        internal bool delete(int id)
        {
            string strSql = "UPDATE Cursos set borrado = 1 WHERE id_curso =" + id;
            return DBHelper.getDBHelper().ejecutarSQL(strSql) != 0;
        }

        private Cursos ObjectMapping(DataRow row)
        {
            Cursos oCursos = new Cursos
            {
                Id_curso = Convert.ToInt32(row["id_curso"].ToString()),
                Nombre = row["nombre"].ToString(),
                Descripcion = row["descripcion"].ToString(),
                Vigencia = Convert.ToDateTime(row["fecha_vigencia"].ToString()),
                Categoria = new Categorias()
                {
                    Id_Categoria = Convert.ToInt32(row["id_categoria"].ToString()),
                    //Nombre = row["nombre"].ToString(),
                },
                Borrado = Convert.ToBoolean(row["borrado"].ToString())
            };

            return oCursos;
        }
    }
}
