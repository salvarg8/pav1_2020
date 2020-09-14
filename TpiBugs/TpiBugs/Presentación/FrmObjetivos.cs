using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
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
            dgvObjetivos.Rows.Clear();
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
                foreach (Objetivos obj in lst)
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

        private void btnEditar_Click(System.Object sender, System.EventArgs e)
        {
            
            int id = Convert.ToInt32(dgvObjetivos.CurrentRow.Cells["Id_Objetivos"].Value);
            string nombre_corto = Convert.ToString(dgvObjetivos.CurrentRow.Cells["nom_corto"].Value);
            string nombre_largo = Convert.ToString(dgvObjetivos.CurrentRow.Cells["nom_largo"].Value);
            Objetivos objetivo = new Objetivos(id, nombre_corto, nombre_largo);
            frmAbmcObjetivos frm = new frmAbmcObjetivos();
            frm.IniciarFormulario(frmAbmcObjetivos.FormMode.actualizar, objetivo);
            frm.ShowDialog();
            




            //var a = (Objetivos)dgvObjetivos.CurrentRow.DataBoundItem;
            //frmAbmcObjetivos frm = new frmAbmcObjetivos();
            //frm.IniciarFormulario(frmAbmcObjetivos.FormMode.actualizar, a);
            //frm.ShowDialog();
        }
        private void InitializeDataGridView()
        {
            // Cree un DataGridView no vinculado declarando un recuento de columnas.
            dgvObjetivos.ColumnCount = 3;
            dgvObjetivos.ColumnHeadersVisible = true;

            // Configuramos la AutoGenerateColumns en false para que no se autogeneren las columnas
            dgvObjetivos.AutoGenerateColumns = false;

            // Cambia el estilo de la cabecera de la grilla.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 8, FontStyle.Bold);
            dgvObjetivos.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Cambia el tamaño de la altura de los encabezados de columna.
            dgvObjetivos.AutoResizeColumnHeadersHeight();

            // Cambia el tamaño de todas las alturas de fila para ajustar el contenido de todas las celdas que no sean de encabezado.
            dgvObjetivos.AutoResizeRows(
                DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvObjetivos.Rows.Count > 0)
            {
                if (MessageBox.Show("¿Seguro que desea Eliminar el Objetivo seleccionado?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dgvObjetivos.CurrentRow.Cells["Id_Objetivos"].Value);
                    if (servicio.borrarObjetivo(id))
                    {
                        dgvObjetivos.Rows.RemoveAt(dgvObjetivos.CurrentRow.Index);
                        MessageBox.Show("Objetivo Eliminado", "Aviso");
                    }
                }
                else
                    MessageBox.Show("Ha ocurrido un error al intentar borrar el Objetivo", "Error");
            }
        }
    }
}