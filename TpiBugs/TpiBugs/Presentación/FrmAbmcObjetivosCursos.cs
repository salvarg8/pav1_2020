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
    public partial class FrmAbmcObjetivosCursos : Form
    {
        private FormMode formMode = FormMode.nuevo;

        private readonly ObjetivosService oObjetivoService;
        private readonly ObjetivosCursosService oObjetivoCursoService;
        private readonly CursosService oCursosService;
        private Objetivos oObjetivoSelected;
        private Cursos oCursoSelected;
        private ObjetivosCursos oObjetivoCursoSelected;



        public FrmAbmcObjetivosCursos()
        {
            InitializeComponent();
            oObjetivoCursoService = new ObjetivosCursosService();
            oObjetivoService = new ObjetivosService();
            oCursosService = new CursosService();
        }

        public enum FormMode
        {
            nuevo,
            actualizar,
            eliminar
        }
        internal void IniciarFormulario(FormMode actualizar, Cursos Curso)
        {

            formMode = actualizar;
            oCursoSelected = Curso;

        }

        private void FrmAbmcObjetivosCursos_Load(object sender, EventArgs e)
        {
            lblNombreCurso.Text = "Curso: " + oCursoSelected.Nombre;
            switch (formMode)
            {
                case FormMode.nuevo:
                    {
                        this.Text = "Nuevo Objetivo";
                        break;
                    }
                case FormMode.actualizar:
                    {
                        this.Text = "Actualizar Usuario";
                        MostrarDatos();
                        break;
                    }
            }
        }

        private void MostrarDatos()
        {
            LlenardgvObjetivosCurso();
            LlenarDgvObjetivosDisponibles();
        }


        private void LlenardgvObjetivosCurso()
        {
            dgvObjetivosCurso.Rows.Clear();
            IList<ObjetivosCursos> lst = oObjetivoCursoService.GetObjetivosPorCurso(oCursoSelected.Id_curso);
            foreach (ObjetivosCursos obj in lst)
            {
                IList<Objetivos> lst2 = oObjetivoService.GetObjetivosById(obj.Objetivo.ID_objetivos);
                dgvObjetivosCurso.Rows.Add(new object[] { lst2[0].ID_objetivos, lst2[0].Nombre_corto, lst2[0].Nombre_largo, lst2[0].Borrado });
            }
        }

        private void LlenarDgvObjetivosDisponibles()
        {
            dgvObjetivosDisponibles.Rows.Clear();
            IList<Objetivos> lst = oObjetivoService.GetObjetivosDisponibles(oCursoSelected.Id_curso);
            foreach (Objetivos obj in lst)
            {
                dgvObjetivosDisponibles.Rows.Add(new object[] { obj.ID_objetivos, obj.Nombre_corto, obj.Nombre_largo, obj.Borrado });
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea Salir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea Salir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAbmcObjetivos frm = new frmAbmcObjetivos();
            frm.ShowDialog();
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (dgvObjetivosCurso.CurrentRow != null && dgvObjetivosCurso.CurrentRow.Index != -1)
            {
                DataGridViewRow fila = dgvObjetivosCurso.CurrentRow;
                dgvObjetivosCurso.Rows.Remove(fila);
                dgvObjetivosDisponibles.Rows.Add(fila);
                btnUp.Enabled = true;
                btnDown.Enabled = dgvObjetivosCurso.Rows.Count > 0;

            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            
            if (dgvObjetivosDisponibles.CurrentRow.Index != -1)
            {
                DataGridViewRow fila = dgvObjetivosDisponibles.CurrentRow;
                dgvObjetivosDisponibles.Rows.Remove(fila);
                dgvObjetivosCurso.Rows.Add(fila);
                btnDown.Enabled = true;
                btnUp.Enabled = dgvObjetivosDisponibles.Rows.Count > 0;
            }
            
        }
    }
}
