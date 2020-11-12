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
using TpiBugs.Negocio.Servicios;

namespace TpiBugs.Reportes
{
    public partial class FrmReporteCursos : Form
    {
        private readonly CategoriasService oCategoriasServices;
        public FrmReporteCursos()
        {
            oCategoriasServices = new CategoriasService();

            InitializeComponent();
        }

        private void FrmReporteCursos_Load(object sender, EventArgs e)
        {
            LlenarCombo(cmbCategoria, oCategoriasServices.GetCategoriasSinBorrado(""), "nombre", "id_categoria");

            this.reportViewer1.RefreshReport();
        }

        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            // Datasource: establece el origen de datos de este objeto.
            cbo.DataSource = source;
            // DisplayMember: establece la propiedad que se va a mostrar para este ListControl.
            cbo.DisplayMember = display;
            // ValueMember: establece la ruta de acceso de la propiedad que se utilizará como valor real para los elementos de ListControl.
            cbo.ValueMember = value;
            //SelectedIndex: establece el índice que especifica el elemento seleccionado actualmente.
            cbo.SelectedIndex = -1;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            string strSql = " select Categorias.id_categoria as Categoria, cursos.nombre as NombreCurso, cursos.descripcion as Descripción, cursos.fecha_vigencia as Vigencia" +
                            "from cursos, categorias where(cursos.id_categoria = Categorias.id_categoria and cursos.fecha_vigencia >= getdate() and Categorias.id_categoria = @param1)" +
                             "group by Categorias.id_categoria, cursos.nombre,  cursos.descripcion, cursos.fecha_vigencia";

            Dictionary<string, object> parametros = new Dictionary<string, object>();
            {
                parametros.Add("Categoria", cmbCategoria.SelectedItem); // aca no se si es cbmCategoria.Text o .Seleccionado o que 

                // Dictionary: Representa una colección de claves y valores.
                /*
                Dictionary & lt; string, object&gt; parametros = new Dictionary& lt; string, object&gt; ();
                DateTime fechaDesde;
                DateTime fechaHasta;
                if (DateTime.TryParse(txtFechaDesde.Text, out fechaDesde) & amp; &amp;
                DateTime.TryParse(txtFechaHasta.Text, out fechaHasta))
            {
                    parametros.Add(&quot; fechaDesde & quot;, txtFechaDesde.Text);
                    parametros.Add(&quot; fechaHasta & quot;, txtFechaHasta.Text);
                    rpvBugs.LocalReport.SetParameters(new ReportParameter[] { new ReportParameter(&quot; prFechaDesde & quot;,
                txtFechaDesde.Text), new ReportParameter(&quot; prFechaHasta & quot;, txtFechaHasta.Text) });
                */
                reportViewer1.LocalReport.SetParameters(new ReportParameter[] { new ReportParameter("Categoria", cmbCategoria.Text) }); // aca no se si es cbmCategoria.Text o .Seleccionado o que 
                //DATASOURCE
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DSReporte",
                    DataManager.GetInstance().ConsultaSQL(strSql, parametros)));

                reportViewer1.RefreshReport();
            }
        }
        //}
    }
}
