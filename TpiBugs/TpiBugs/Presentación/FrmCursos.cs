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
    public partial class FrmCursos : Form
    {
        private CursosService servicio;
        private CategoriasService servicioCat;
        public FrmCursos()
        {
            servicio = new CursosService();
            servicioCat = new CategoriasService();
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvCursos.Rows.Clear();
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;

            var filters = new Dictionary<string, object>();
            if (chbBuscarTodos.Checked)
            {
                IList<Cursos> lst = servicio.GetCursoConBorrado(txtNombre.Text);

                foreach (Cursos obj in lst)
                {
                    IList<Categorias> lst2 = servicioCat.getCategoriaId(obj.Categoria.Id_Categoria);
                    dgvCursos.Rows.Add(new object[] { obj.Id_curso, obj.Nombre, obj.Descripcion,obj.Vigencia ,lst2[0].Nombre, obj.Borrado});
                    if (obj.Borrado == true)
                    {
                        dgvCursos.Rows[dgvCursos.RowCount - 1].DefaultCellStyle.ForeColor = Color.Red;
                        dgvCursos.Rows[dgvCursos.RowCount - 1].DefaultCellStyle.SelectionForeColor = Color.Red;
                    }

                }
            }
            else
            {
                IList<Cursos> lst = servicio.GetCursoSinBorrado(txtNombre.Text);

                foreach (Cursos obj in lst)
                {
                    IList<Categorias> lst2 = servicioCat.getCategoriaId(obj.Categoria.Id_Categoria);
                    dgvCursos.Rows.Add(new object[] { obj.Id_curso, obj.Nombre, obj.Descripcion, obj.Vigencia, lst2[0].Nombre, obj.Borrado });
                }
            }
            lblCantEncontrado.Visible = true;
            lblCantEncontrado.Text = "Cursos encontrados = " + dgvCursos.Rows.Count;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAbmcCursos frm = new FrmAbmcCursos();
            frm.ShowDialog();
            btnBuscar_Click(sender, e);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string nombre = Convert.ToString(dgvCursos.CurrentRow.Cells["nombre"].Value);
            bool borrado = Convert.ToBoolean(dgvCursos.CurrentRow.Cells["borrado"].Value);
          
            if (!borrado)
            {
                IList<Cursos> lst = servicio.GetCursoSinBorrado(nombre);
                Cursos curso = new Cursos(lst[0].Id_curso, lst[0].Nombre, lst[0].Descripcion, lst[0].Vigencia, lst[0].Categoria, lst[0].Borrado);
                FrmAbmcCursos frm = new FrmAbmcCursos();
                frm.IniciarFormulario(FrmAbmcCursos.FormMode.actualizar, curso);
                frm.ShowDialog();
                btnBuscar_Click(sender, e);
            }
            else
                MessageBox.Show("No se puede Editar el Curso Seleccionado", "Error");


        }

        private void dgvCursos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string nombre = Convert.ToString(dgvCursos.CurrentRow.Cells["nombre"].Value);
            bool borrado = Convert.ToBoolean(dgvCursos.CurrentRow.Cells["borrado"].Value);

            if (!borrado)
            {
                IList<Cursos> lst = servicio.GetCursoSinBorrado(nombre);
                Cursos curso = new Cursos(lst[0].Id_curso, lst[0].Nombre, lst[0].Descripcion, lst[0].Vigencia, lst[0].Categoria, lst[0].Borrado);
                FrmAbmcCursos frm = new FrmAbmcCursos();
                frm.IniciarFormulario(FrmAbmcCursos.FormMode.eliminar, curso);
                frm.ShowDialog();
                btnBuscar_Click(sender, e);
            }
            else
                MessageBox.Show("No se puede Eliminar el Curso Seleccionado", "Error");
        }
    }
}

