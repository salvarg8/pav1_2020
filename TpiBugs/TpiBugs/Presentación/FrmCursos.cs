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
        public FrmCursos()
        {
            servicio = new CursosService();
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
                    dgvCursos.Rows.Add(new object[] { obj.Id_curso, obj.Nombre, obj.Descripcion,obj.Vigencia ,obj.Categoria.Nombre, obj.Borrado});
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
                    dgvCursos.Rows.Add(new object[] { obj.Id_curso, obj.Nombre, obj.Descripcion,obj.Vigencia ,obj.Categoria.Nombre, obj.Borrado });
                }
            }
            lblCantEncontrado.Visible = true;
            lblCantEncontrado.Text = "Cursos encontrados = " + dgvCursos.Rows.Count;
        }
    }
}

