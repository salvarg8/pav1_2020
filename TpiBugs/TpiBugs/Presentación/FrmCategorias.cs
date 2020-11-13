using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TpiBugs.Negocio.Entidades;
using TpiBugs.Negocio.Servicios;

namespace TpiBugs.Presentación
{
    public partial class FrmCategorias : Form
    {
        private CategoriasService servicio;
        public FrmCategorias()
        {
            servicio = new CategoriasService();
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvCategorias.Rows.Clear();
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;

            var filters = new Dictionary<string, object>();
            if (chbBuscarTodos.Checked)
            {
                IList<Categorias> lst = servicio.GetCategoriasConBorrado(txtNombre.Text);

                foreach (Categorias obj in lst)
                {
                    dgvCategorias.Rows.Add(new object[] { obj.Id_Categoria, obj.Nombre, obj.Descripcion, obj.Borrado });
                    if (obj.Borrado == true)
                    {
                        dgvCategorias.Rows[dgvCategorias.RowCount - 1].DefaultCellStyle.ForeColor = Color.Red;
                        dgvCategorias.Rows[dgvCategorias.RowCount - 1].DefaultCellStyle.SelectionForeColor = Color.Red;
                    }

                }
            }
            else
            {
                IList<Categorias> lst = servicio.GetCategoriasSinBorrado(txtNombre.Text);

                foreach (Categorias obj in lst)
                {
                    dgvCategorias.Rows.Add(new object[] { obj.Id_Categoria, obj.Nombre, obj.Descripcion, obj.Borrado });
                }
            }
            lblCantEncontrado.Visible = true;
            lblCantEncontrado.Text = "Categorías encontradas = " + dgvCategorias.Rows.Count;
        }

        private void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAbmcCategoria frm = new FrmAbmcCategoria();
            frm.ShowDialog();
            btnBuscar_Click(sender, e);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvCategorias.CurrentRow.Cells["id_categoria"].Value);
            string nombre= Convert.ToString(dgvCategorias.CurrentRow.Cells["nombre"].Value);
            string descripcion = Convert.ToString(dgvCategorias.CurrentRow.Cells["descripcion"].Value);
            bool borrado = Convert.ToBoolean(dgvCategorias.CurrentRow.Cells["borrado"].Value);
            if (!borrado)
            {
                Categorias categoria = new Categorias(id, nombre, descripcion, borrado);
                FrmAbmcCategoria frm = new FrmAbmcCategoria();
                frm.IniciarFormulario(FrmAbmcCategoria.FormMode.actualizar, categoria);
                frm.ShowDialog();
                btnBuscar_Click(sender, e);
            }
            else
                MessageBox.Show("No se puede editar la Categoría Seleccionada", "Error");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.Rows.Count > 0)
            {
                int id = Convert.ToInt32(dgvCategorias.CurrentRow.Cells["id_categoria"].Value);
                string nombre = Convert.ToString(dgvCategorias.CurrentRow.Cells["nombre"].Value);
                string descripcion = Convert.ToString(dgvCategorias.CurrentRow.Cells["descripcion"].Value);
                bool borrado = Convert.ToBoolean(dgvCategorias.CurrentRow.Cells["borrado"].Value);
                if (!borrado)
                {
                    Categorias categoria = new Categorias(id, nombre, descripcion, borrado);
                    FrmAbmcCategoria frm = new FrmAbmcCategoria();
                    frm.IniciarFormulario(FrmAbmcCategoria.FormMode.eliminar, categoria);
                    frm.ShowDialog();
                    btnBuscar_Click(sender, e);
                }
                else
                    MessageBox.Show("No se puede Eliminar la Categoría Seleccionada", "Error");
            }
            btnBuscar_Click(sender, e);
        }

        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBuscar_Click(sender, e);
            }
        }
    }
    
}
