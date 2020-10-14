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
        private Cursos oCursoSelected;



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
            if (dgvObjetivosCurso.Rows.Count == 0)
            {
                btnDown.Enabled = false;
            }

            if (dgvObjetivosDisponibles.Rows.Count == 0)
            {
                btnUp.Enabled = false;
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
            LlenarDgvObjetivosDisponibles();
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(dgvObjetivosCurso.Rows.Count > 0)
            {
                int cont = 0;
                int porc = 100 / dgvObjetivosCurso.Rows.Count;
                int id_curso = oCursoSelected.Id_curso;
                //empezar la cosa que no sabemos
                try
                {
                    List<Objetivos> objetivos = new List<Objetivos>();

                    foreach (DataGridViewRow row in dgvObjetivosCurso.Rows)
                    {
                        cont += 1;
                        int id = Convert.ToInt32(row.Cells["Id_Objetivos"].Value);
                        string nombre_corto = Convert.ToString(dgvObjetivosCurso.CurrentRow.Cells["nom_corto"].Value);
                        string nombre_largo = Convert.ToString(dgvObjetivosCurso.CurrentRow.Cells["nom_largo"].Value);
                        bool borrado = Convert.ToBoolean(dgvObjetivosCurso.CurrentRow.Cells["borrado"].Value);
                        Objetivos obj = new Objetivos(id,nombre_corto,nombre_largo,borrado);
                        objetivos.Add(obj);
                    }
                    oObjetivoCursoService.crear(oCursoSelected.Id_curso, objetivos, porc);
                    MessageBox.Show("Objetivos Actualizados!");
                    this.Close();

                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Error al Guardar los Cambios! " + ex.Message + ex.StackTrace, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea Salir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Dispose();
            }
        }
    }
}
