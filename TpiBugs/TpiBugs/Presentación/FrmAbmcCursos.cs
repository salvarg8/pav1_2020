using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TpiBugs.Negocio.Entidades;
using TpiBugs.Negocio.Servicios;

namespace TpiBugs.Presentación
{
    public partial class FrmAbmcCursos : Form
    {
        private FormMode formMode = FormMode.nuevo;
        private readonly CursosService oCursosServices;
        private readonly CategoriasService oCategoriasServices;
        private Cursos oCursoSelected;
        public FrmAbmcCursos()
        {
            oCategoriasServices = new CategoriasService();
            oCursosServices = new CursosService();
            InitializeComponent();
        }

        internal void IniciarFormulario(FormMode actualizar, Cursos curso)
        {
            formMode = actualizar;
            oCursoSelected = curso;
        }
        public enum FormMode
        {
            nuevo,
            actualizar,
            eliminar
        }

        private void FrmAbmcCursos_Load(object sender, EventArgs e)
        {
            switch (formMode)
            {
                case FormMode.nuevo:
                    {
                        this.Text = "Nueva Curso";
                        LlenarCombo(cmbCategoria, oCategoriasServices.GetCategoriasSinBorrado(""), "nombre", "id_categoria");
                        break;
                    }
                case FormMode.actualizar:
                    {
                        LlenarCombo(cmbCategoria, oCategoriasServices.GetCategoriasSinBorrado(""), "nombre", "id_categoria");
                        this.Text = "Actualizar Curso";
                        MostrarDatos();
                        txtNombre.Enabled = true;
                        txtDescripcion.Enabled = true;
                        dtpVigencia.Enabled = true;
                        cmbCategoria.Enabled = true;
                        break;
                    }
                case FormMode.eliminar:
                    {
                        LlenarCombo(cmbCategoria, oCategoriasServices.GetCategoriasSinBorrado(""), "nombre", "id_categoria");
                        this.Text = "Actualizar Curso";
                        MostrarDatos();
                        txtNombre.Enabled = false;
                        txtDescripcion.Enabled = false;
                        dtpVigencia.Enabled = false;
                        cmbCategoria.Enabled = false;
                        btnAceptar.Text = "Eliminar";
                        break;
                    }
            }

        }
        private void MostrarDatos()
        {
            if (oCursoSelected != null)
            {
                txtNombre.Text = oCursoSelected.Nombre;
                txtDescripcion.Text = oCursoSelected.Descripcion;
                dtpVigencia.Value = oCursoSelected.Vigencia;
                cmbCategoria.SelectedIndex = oCursoSelected.Categoria.Id_Categoria-1;
            }
        }


        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            // Datasource: establece el origen de datos de este objeto.
            cbo.DataSource = source;
            // DisplayMember: establece la propiedad que se va a mostrar para este ListControl.
            cbo.DisplayMember = display;
            // ValueMember: establece la ruta de acceso de la propiedad que se utilizará como valor real para los elementos de ListControl.
            cbo.ValueMember = value;
            //SelectedIndex: establece el índice que especifica el elemento seleccionado actualmente.
            cbo.SelectedIndex = -1;
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

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelBarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void msgError(string mensaje)
        {
            lblError.Text = "      " + mensaje;
            lblError.Visible = true;

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            switch (formMode)
            {
                case FormMode.nuevo:
                    {
                        if (ValidarCampos())
                        {
                            oCursosServices.cargaCurso(txtNombre.Text, txtDescripcion.Text, dtpVigencia.Value, cmbCategoria.SelectedIndex+1);
                            MessageBox.Show("Carga realizada Exitosamente");
                            this.Close();
                        }
                        break;
                    }
                case FormMode.actualizar:
                    {
                        if (ValidarCampos())
                        {
                            if(oCursosServices.ActualizarCurso(oCursoSelected.Id_curso,txtNombre.Text, txtDescripcion.Text, dtpVigencia.Value, cmbCategoria.SelectedIndex+1));
                            {
                                MessageBox.Show("Actualización realizada Exitosamente");
                                this.Close();
                            }
                        }
                        break;
                    }
                case FormMode.eliminar:
                    {
                        if (MessageBox.Show("¿Seguro que desea Eliminar el Objetivo seleccionado?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                        {
                            if (oCursosServices.borrarCurso(oCursoSelected.Id_curso))
                            {
                                MessageBox.Show("Objetivo Eliminado", "Aviso");
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Ha ocurrido un error al intentar borrar el Objetivo", "Error");
                                this.Close();
                            }
                            

                        }
                        else
                        {
                            MessageBox.Show("Ha ocurrido un error al intentar borrar el Objetivo", "Error");
                            this.Close();
                        }
                        break;
                    }
                
            }
        }

        private bool ValidarCampos()
        {
            if (txtNombre.Text == "")
            {
                msgError("Por favor Ingrese un Nombre");
                txtNombre.Focus();
                return false;
            }
            if (txtDescripcion.Text == "")
            {
                msgError("Por favor Ingrese una Descripción");
                txtDescripcion.Focus();
                return false;
            }
            if (dtpVigencia.Value.Date < DateTime.Today.Date)
            {
                msgError("Por favor Ingrese una fecha Correcta");
                dtpVigencia.Focus();
                return false;
            }
            if (cmbCategoria.SelectedIndex < 0)
            {
                msgError("Por favor Seleccione una Categoría");
                cmbCategoria.Focus();
                return false;
            }
            return true;
        }
    }
}
