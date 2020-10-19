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

        internal bool ActualizarCurso(int id_curso, string nombre, string descripcion, DateTime vigencia, int id_categoria)
        {
            string strSql = ("UPDATE Cursos set nombre = @param1, descripcion = @param2, fecha_vigencia = @param3,id_categoria = @param4 WHERE id_curso = @param5");
            var parametros = new Dictionary<string, object>();
            parametros.Add("param1", nombre);
            parametros.Add("param2", descripcion);
            parametros.Add("param3", vigencia);
            parametros.Add("param4", id_categoria);
            parametros.Add("param5", id_curso);
            return (DataManager.GetInstance().EjecutarSQL(strSql, parametros) == 1);

        }

        internal bool CategoriaEnUso(int id_Categoria)
        {
            string strSql = ("Select * from Cursos where id_categoria =" + id_Categoria);
            return (Convert.ToInt32(DBHelper.getDBHelper().ConsultaSQLScalar(strSql))!= 0);
        }

        internal void cargaCurso(string nombre, string descripcion, DateTime vigencia, int id_categoria)
        {
            string strSql = ("Insert into Cursos (nombre,descripcion,fecha_vigencia,id_categoria,borrado) Values(@param1,@param2,@param3,@param4,@param5)");
           
            DBHelper.getDBHelper().ConsultarSQLConParametros(strSql, new object[] { nombre,descripcion,vigencia,id_categoria,0});
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
