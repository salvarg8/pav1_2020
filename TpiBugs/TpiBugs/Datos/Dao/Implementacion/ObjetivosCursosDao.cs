using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpiBugs.Datos.Helper;
using TpiBugs.Negocio.Entidades;

namespace TpiBugs.Datos.Dao.Implementacion
{
    class ObjetivosCursosDao
    {
        internal IList<ObjetivosCursos> GetObjetivosPorCurso(int id_curso)
        {
            string strSql = "SELECT * FROM ObjetivosCursos where id_curso = @param1 and borrado <> 1";
            List<ObjetivosCursos> objetivoCursos = new List<ObjetivosCursos>();
            DataTable data = DBHelper.getDBHelper().ConsultarSQLConParametros(strSql, new object[] { id_curso });
            foreach (DataRow row in data.Rows)
            { 
                objetivoCursos.Add(ObjectMapping(row));
            }
            return objetivoCursos;
        }

        internal bool Create(int id_curso, List<Objetivos> objetivos, int porc)
        {
            DataManager dm = new DataManager();
            try
            {
                dm.Open();
                dm.BeginTransaction();
                
                string strSql = "Delete from ObjetivosCursos where id_curso = @param1";
                var param = new Dictionary<string, object>();
                param.Add("param1", id_curso);
                dm.EjecutarSQL(strSql, param);



                foreach (var obj in objetivos)
                {
                    string sql = "INSERT INTO ObjetivosCursos (id_objetivo,id_curso,puntos,borrado) VALUES (@param1, @param2, @param3, @param4)";

                    var parametros = new Dictionary<string, object>();
                    parametros.Add("param1", obj.ID_objetivos);
                    parametros.Add("param2", id_curso);
                    parametros.Add("param3", porc);
                    parametros.Add("param4", false);
                    
                    dm.EjecutarSQL(sql, parametros);
                }

                dm.Commit();

            }       
            catch (Exception ex)
            {
                dm.Rollback();
                throw ex;
            }
            finally
            {
                // Cierra la conexión 
                dm.Close();
            }
            return true;
        }

        internal bool objetivoUsado(int id)
        {
            string sql = "select * from ObjetivosCursos where id_objetivo =" + id;
            var a = Convert.ToInt32(DBHelper.getDBHelper().ConsultaSQLScalar(sql));
            if (a > 0)
            {
                return true;
            }
            return false;
        }

        private ObjetivosCursos ObjectMapping(DataRow row)
        {
            ObjetivosCursos oObjetivoCursos = new ObjetivosCursos
            {
                Objetivo = new Objetivos()
                {
                    ID_objetivos = Convert.ToInt32(row["id_objetivo"].ToString())
                },
                Curso = new Cursos()
                {
                    Id_curso = Convert.ToInt32(row["id_curso"].ToString())
                },
                Puntos = Convert.ToInt32(row["puntos"].ToString()),
                Borrado = Convert.ToBoolean(row["borrado"].ToString())
            };

            return oObjetivoCursos;
        }
    }
}
