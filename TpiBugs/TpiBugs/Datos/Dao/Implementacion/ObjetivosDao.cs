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
                Objetivos obj = new Objetivos(id, row["nombre_corto"].ToString(), row["nombre_largo"].ToString(), bool.Parse(row["borrado"].ToString()));
                objetivos.Add(obj);
            }
            return objetivos;
        }

       
        internal bool Actualizar(Objetivos oObjetivoSeleccionado)
        {
            String strSql = "UPDATE objetivos set nombre_corto = @param1, nombre_largo = @param2 where id_objetivo = @param3";
            var parametros = new Dictionary<string, object>();
            parametros.Add("param1", oObjetivoSeleccionado.Nombre_corto);
            parametros.Add("param2", oObjetivoSeleccionado.Nombre_largo);
            parametros.Add("param3", oObjetivoSeleccionado.ID_objetivos);
            return (DataManager.GetInstance().EjecutarSQL(strSql, parametros) == 1);
        }

        public bool delete(int id)
        {
            String strSql = "UPDATE objetivos set borrado = 1 WHERE id_objetivo ="+id;
            return DBHelper.getDBHelper().ejecutarSQL(strSql) != 0;
        }

        internal bool cargaObjetivo(string nombreCorto, string nombreLargo)
        {
            List<Objetivos> objetivos = new List<Objetivos>();
            string sql = "SELECT * from dbo.Objetivos";
            DataTable t = DBHelper.getDBHelper().ConsultaSQL(sql);
            foreach (DataRow row in t.Rows)
            {
                int id = int.Parse(row["id_objetivo"].ToString());
                Objetivos obj = new Objetivos(id, row["nombre_corto"].ToString(), row["nombre_largo"].ToString(), bool.Parse(row["borrado"].ToString()));
                objetivos.Add(obj);
            }
            int a = objetivos.Count + 1;
            String strSql = "INSERT INTO [dbo].[Objetivos]([id_objetivo],[nombre_corto],[nombre_largo],[borrado])VALUES('"+a+"','"+nombreCorto+"','"+nombreLargo+"',0)";
            return DBHelper.getDBHelper().ejecutarSQL(strSql) > 0;
        }

        

        internal IList<Objetivos> getPorNombreLargo(string nombreLargo)
        {
            List<Objetivos> objetivos = new List<Objetivos>();

            String strSql = "SELECT * FROM dbo.Objetivos where nombre_largo like '%' + @param1 + '%' and borrado <> 1";
            DataTable data = DBHelper.getDBHelper().ConsultarSQLConParametros(strSql, new object[] { nombreLargo });
            foreach (DataRow row in data.Rows)
            {
                int id = int.Parse(row["id_objetivo"].ToString());
                Objetivos obj = new Objetivos(id, row["nombre_corto"].ToString(), row["nombre_largo"].ToString(), bool.Parse(row["borrado"].ToString()));
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
                Objetivos obj = new Objetivos(id, row["nombre_corto"].ToString(), row["nombre_largo"].ToString(), bool.Parse(row["borrado"].ToString()));
                objetivos.Add(obj);
            }
            return objetivos;
        }

        internal IList<Objetivos> getObjConBorrado(string nombreCorto, string nombreLargo)
        {
            List<Objetivos> objetivos = new List<Objetivos>();
            String strSql = "SELECT * FROM dbo.Objetivos where nombre_corto like '%' + @param1 + '%' and nombre_largo like '%' + @param2 + '%'";
            DataTable data = DBHelper.getDBHelper().ConsultarSQLConParametros(strSql, new object[] { nombreCorto, nombreLargo });
            foreach (DataRow row in data.Rows)
            {
                int id = int.Parse(row["id_objetivo"].ToString());
                Boolean borrado = Boolean.Parse(row["borrado"].ToString());
                Objetivos obj = new Objetivos(id, row["nombre_corto"].ToString(), row["nombre_largo"].ToString(), borrado);
                objetivos.Add(obj);
            }
            return objetivos;
        }

        internal IList<Objetivos> getObjSinBorrado(string nombreCorto, string nombreLargo)
        {
            List<Objetivos> objetivos = new List<Objetivos>();
            String strSql = "SELECT * FROM dbo.Objetivos where nombre_corto like '%' + @param1 + '%' and nombre_largo like '%' + @param2 + '%' and borrado <> 1";
            DataTable data = DBHelper.getDBHelper().ConsultarSQLConParametros(strSql, new object[] { nombreCorto, nombreLargo });
            foreach (DataRow row in data.Rows)
            {
                int id = int.Parse(row["id_objetivo"].ToString());
                bool borrado = bool.Parse(row["borrado"].ToString());
                Objetivos obj = new Objetivos(id, row["nombre_corto"].ToString(), row["nombre_largo"].ToString(), borrado);
                objetivos.Add(obj);
            }
            return objetivos;
        }
    }
}
