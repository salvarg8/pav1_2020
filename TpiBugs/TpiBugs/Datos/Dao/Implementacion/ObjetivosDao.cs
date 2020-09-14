using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using TpiBugs.Negocio.Entidades;
using System.Data;
using System.Data.SqlClient;
using TpiBugs.Datos.Helper;

namespace TpiBugs.Datos.Dao.Implementacion
{
    public class ObjetivosDao
    {
        public IList<Objetivos> GetAll()
        {
            List<Objetivos> objetivos = new List<Objetivos>();

            String strSql = "SELECT * from dbo.Objetivos where borrado <> 1;";
            DataTable t = DBHelper.getDBHelper().ConsultaSQL(strSql);
            foreach(DataRow row in t.Rows)
            {
                int id = int.Parse(row["id_objetivo"].ToString());
                Objetivos obj = new Objetivos(id, row["nombre_corto"].ToString(), row["nombre_largo"].ToString());
                objetivos.Add(obj);
            }
            return objetivos;

            
        }

        internal IList<Objetivos> getPorNombreLargo(string nombreLargo)
        {
            List<Objetivos> objetivos = new List<Objetivos>();

            String strSql = "SELECT * FROM dbo.Objetivos where nombre_largo like '%' + @param1 + '%' and borrado <> 1";
            DataTable data = DBHelper.getDBHelper().ConsultarSQLConParametros(strSql, new object[] { nombreLargo });
            foreach (DataRow row in data.Rows)
            {
                int id = int.Parse(row["id_objetivo"].ToString());
                Objetivos obj = new Objetivos(id, row["nombre_corto"].ToString(), row["nombre_largo"].ToString());
                objetivos.Add(obj);
            }
            return objetivos;
        }

        internal IList<Objetivos> getPorNombreCorto(string nombreCorto)
        {
            
            List<Objetivos> objetivos = new List<Objetivos>();

            String strSql = "SELECT * FROM dbo.Objetivos where nombre_corto like '%' + @param1 + '%' and borrado <> 1";
            DataTable data = DBHelper.getDBHelper().ConsultarSQLConParametros(strSql, new object[] { nombreCorto });
            foreach (DataRow row in data.Rows)
            {
                int id = int.Parse(row["id_objetivo"].ToString());
                Objetivos obj = new Objetivos(id, row["nombre_corto"].ToString(), row["nombre_largo"].ToString());
                objetivos.Add(obj);
            }
            return objetivos;
        }




        /*

            private Objetivos ObjectMapping(DataRow row)
            {
                Objetivos oObjetivos = new Objetivos
                {
                    ID_objetivos = Convert.ToInt32(row["id_objetivo"].ToString()),
                    Nombre_corto = row["nombre_corto"].ToString(),
                    Nombre_largo = row["nombre_largo"].ToString(),


                    Objetivos = new Objetivos()
                    {
                        ID_objetivos = Convert.ToInt32(row["id_objetivo"].ToString()),
                        Nombre_corto = row["nombre_corto"].ToString(),
                        Nombre_largo = row["nombre_largo"].ToString(),

                    }
                };
                return oObjetivos;


            }*/
    }
}
