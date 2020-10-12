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
        private Objetivos oObjetivoSelected;
        private ObjetivosCursos oObjetivoCursoSelected;



        public FrmAbmcObjetivosCursos()
        {
            InitializeComponent();
            oObjetivoCursoService = new ObjetivosCursosService();
            oObjetivoService = new ObjetivosService();
        }

        public enum FormMode
        {
            nuevo,
            actualizar,
            eliminar
        }
        internal void IniciarFormulario(FormMode actualizar, ObjetivosCursos objetivoCurso)
        {

            formMode = actualizar;
            oObjetivoCursoSelected = objetivoCurso;

        }

        private void FrmAbmcObjetivosCursos_Load(object sender, EventArgs e)
        {
            lblCurso.Text = "Curso: " + oObjetivoCursoSelected.Curso.Nombre;
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
                        txtPuntos.Enabled = true;
                        break;
                    }
            }
        }

        private void MostrarDatos()
        {
         
            if (oObjetivoCursoSelected != null)
            {
                txtCorto.Text = oObjetivoCursoSelected.Objetivo.Nombre_corto;
                txtPuntos.Text = oObjetivoCursoSelected.Puntos.ToString();
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


    }
}
