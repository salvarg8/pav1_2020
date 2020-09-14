using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TpiBugs.Datos.Dao.Implementacion;
using TpiBugs.Negocio.Entidades;
using TpiBugs.Negocio.Servicios;

namespace TpiBugs.Presentación
{
    public partial class FrmObjetivos : Form
    {   
        private ObjetivosService servicio;
        public FrmObjetivos()
        {
            servicio = new ObjetivosService();
            InitializeComponent();
        }

        private void btnBuscar_Click(System.Object sender, System.EventArgs e)
        {
            var filters = new Dictionary<string, object>();
            if (chbBuscarTodos.Checked)
            {
                IList<Objetivos> lst = servicio.GetObjetivos();

                foreach (Objetivos obj in lst)
                {
                    dgvObjetivos.Rows.Add(new object[] { obj.ID_objetivos, obj.Nombre_corto, obj.Nombre_largo });
                }
            }
            if (chbBuscarTodos.Checked == false && txtNombreLargo.Text != "")
            {
                IList<Objetivos> lst = servicio.GetObjetivosNomLargo(txtNombreLargo.Text);
                foreach(Objetivos obj in lst)
                {
                    dgvObjetivos.Rows.Add(new object[] { obj.ID_objetivos, obj.Nombre_corto, obj.Nombre_largo });
                }

            }
            if (chbBuscarTodos.Checked == false && txtNombreCorto.Text != "")
            {
                IList<Objetivos> lst = servicio.GetObjetivosNomCorto(txtNombreCorto.Text);
                foreach (Objetivos obj in lst)
                {
                    dgvObjetivos.Rows.Add(new object[] { obj.ID_objetivos, obj.Nombre_corto, obj.Nombre_largo });
                }

            }
        }             
                


        private void FrmObjetivos_FormClosed(object sender, FormClosedEventArgs e)
        {
            // al cerrar el formulario vacío los textbox
            txtNombreCorto.Text = "";
            txtNombreLargo.Text = "";
            FrmPrincipal frm = new FrmPrincipal();
            frm.Show();
        }

        private void FrmObjetivos_Load(object sender, EventArgs e)
        {
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void txtNombreCorto_TextChanged(object sender, EventArgs e)
        {
            if (txtNombreCorto.Text != "")
            
                txtNombreLargo.Enabled = false;
            
            if (txtNombreCorto.Text == "")
            
                txtNombreLargo.Enabled = true;
        }

        private void txtNombreLargo_TextChanged(object sender, EventArgs e)
        {

            if (txtNombreLargo.Text != "")
                txtNombreCorto.Enabled = false;

            if (txtNombreLargo.Text == "")
                txtNombreCorto.Enabled = true;

        }

        private void chbBuscarTodos_CheckedChanged(object sender, EventArgs e)
        {
            txtNombreCorto.Clear();
            txtNombreLargo.Clear();
            if (chbBuscarTodos.Checked == true)
            {
                txtNombreLargo.Enabled = false;
                txtNombreCorto.Enabled = false;
            }
            if (chbBuscarTodos.Checked == false)
            {

                txtNombreLargo.Enabled = true;
                txtNombreCorto.Enabled = true;
            }

        }

        private void dgvObjetivos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAbmcObjetivos frm = new frmAbmcObjetivos();
            frm.ShowDialog();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmAbmcObjetivos frm = new frmAbmcObjetivos();
            var a = (Objetivos)dgvObjetivos.CurrentRow.DataBoundItem;
            frm.IniciarFormulario(frmAbmcObjetivos.FormMode.actualizar, a);
            frm.ShowDialog();
            btnBuscar_Click(sender, e);
        }
    }
}
