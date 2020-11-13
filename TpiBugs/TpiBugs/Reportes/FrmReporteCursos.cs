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
using Microsoft.Reporting.WinForms;
using TpiBugs.Negocio.Servicios;
using TpiBugs.Reportes;

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
            cbo.SelectedIndex = 0;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            string strSql = "select Categorias.id_categoria as Categoria, Cursos.nombre as NombreCurso, Cursos.descripcion as Descripción, Cursos.fecha_vigencia as Vigencia from Cursos, Categorias where (cursos.id_categoria = Categorias.id_categoria and cursos.fecha_vigencia >= getdate() and Categorias.id_categoria = @Valorcmb and Cursos.borrado = 0) group by Categorias.id_categoria, cursos.nombre, cursos.descripcion, cursos.fecha_vigencia";

            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("Valorcmb", (cmbCategoria.SelectedIndex+1));
            //reportViewer1.LocalReport.SetParameters(new ReportParameter[] { new ReportParameter("Categoria", cmbCategoria.SelectedItem.ToString()) });

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", DataManager.GetInstance().ConsultaSQL(strSql, parametros)));
            reportViewer1.RefreshReport();
        }

        private void cmbCategoria_SelectedValueChanged(object sender, EventArgs e)
        {
            btnGenerar.Enabled = true;
        }
    }
}


