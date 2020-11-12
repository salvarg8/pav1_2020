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
        }

        private void FrmReporteEstadistico_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        

        private void DataTable1BindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        
    }
}
