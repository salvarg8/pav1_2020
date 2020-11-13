using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TpiBugs.Reportes
{
    public partial class FrmReporteEstadistico : Form
    {
        public FrmReporteEstadistico()
        {
            InitializeComponent();
            Generar();
        }

        private void FrmReporteEstadistico_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }



        private void Generar()
        {
            string strSql = "select Categorias.id_categoria as id_categoria, Categorias.nombre as nombre_categ from Cursos, Categorias where (Categorias.id_categoria = Cursos.id_categoria AND cursos.fecha_vigencia >= getdate()  and Cursos.borrado = 0)";

            Dictionary<string, object> parametros = new Dictionary<string, object>();

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", DataManager.GetInstance().ConsultaSQL(strSql, parametros)));
            reportViewer1.RefreshReport();

        }


        private void DataTable1BindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        
    }
}
