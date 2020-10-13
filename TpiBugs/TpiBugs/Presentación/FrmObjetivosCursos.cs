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
    public partial class FrmObjetivosCursos : Form
    {
        private readonly CursosService oCursosServices;
        private readonly ObjetivosCursosService oObjetivosCursosService;
        private readonly ObjetivosService oObjetivosService;
        public FrmObjetivosCursos()
        {
            oCursosServices = new CursosService();
            oObjetivosCursosService = new ObjetivosCursosService();
            oObjetivosService = new ObjetivosService();
            InitializeComponent();
        }

        private void FrmObjetivosCursos_Load(object sender, EventArgs e)
        {
            LlenarCombo(cmbCursos, oCursosServices.GetCursoConBorrado(""), "nombre", "id_curso");

        }


        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }

        private void cmbCursos_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dgvObjetivos.Rows.Clear();
            IList<ObjetivosCursos> lst = oObjetivosCursosService.GetObjetivosPorCurso(cmbCursos.SelectedIndex+1);
            int sumavalores = 0;
            foreach (ObjetivosCursos obj in lst)
            {
                IList<Objetivos> lst2 = oObjetivosService.GetObjetivosById(obj.Objetivo.ID_objetivos);
                
                dgvObjetivos.Rows.Add(new object[] { obj.Objetivo.ID_objetivos, obj.Curso.Id_curso, lst2[0].Nombre_corto, lst2[0].Nombre_largo, obj.Puntos, obj.Borrado });
                //dgvObjetivos.Rows.Add(new object[] { obj.Objetivo.ID_objetivos, obj.Curso.Id_curso, lst2[0].Nombre_corto, lst2[0].Nombre_largo, obj.Puntos, obj.Borrado });

                
                sumavalores = sumavalores + obj.Puntos;
            }
            if (sumavalores == 100)
            { }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FrmAbmcObjetivosCursos frm = new FrmAbmcObjetivosCursos();
            frm.IniciarFormulario(FrmAbmcObjetivosCursos.FormMode.actualizar, (Cursos)cmbCursos.SelectedItem);
            frm.ShowDialog();
        }
    }
}
