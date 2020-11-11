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
            
        }
    }
}
