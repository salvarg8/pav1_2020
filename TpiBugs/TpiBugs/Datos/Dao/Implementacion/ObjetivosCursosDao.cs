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
