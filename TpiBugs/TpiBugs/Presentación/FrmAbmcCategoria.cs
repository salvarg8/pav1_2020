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
    public partial class FrmAbmcCategoria : Form
    {
        private FormMode formMode = FormMode.nuevo;

        private readonly CursosService oCursoService;
        private readonly CategoriasService oCategoriasServices;
        private Categorias oCategoriaSelected;


        public FrmAbmcCategoria()
        {
            InitializeComponent();
            oCategoriasServices = new CategoriasService();
            oCursoService = new CursosService();
        }

        internal void IniciarFormulario(FormMode actualizar, Categorias categoria)
        {
            formMode = actualizar;
            oCategoriaSelected = categoria;
        }

        public enum FormMode
        {
            nuevo,
            actualizar,
            eliminar
        }

        private void FrmAbmcCategoria_Load(object sender, EventArgs e)
        {
            switch (formMode)
            {
                case FormMode.nuevo:
                    {
                        this.Text = "Nueva Categoria";
                        break;
                    }
                case FormMode.actualizar:
                    {
                        this.Text = "Actualizar Usuario";
                        MostrarDatos();
                        txtNombre.Enabled = true;
                        txtDescripcion.Enabled = true;
                        break;
                    }
                case FormMode.eliminar:
                    {
                        this.Text = "Actualizar Usuario";
                        MostrarDatos();
                        txtNombre.Enabled = false;
                        txtDescripcion.Enabled = false;
                        btnAceptar.Text = "Eliminar";
                        break;
                    }
            }
        }
        private void MostrarDatos()
        {
            if (oCategoriaSelected != null)
            {
                txtNombre.Text = oCategoriaSelected.Nombre;
                txtDescripcion.Text = oCategoriaSelected.Descripcion;
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea Salir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            switch (formMode)
            {
                case FormMode.nuevo:
                    {
                        if (validarCampos())
                        {
                            oCategoriasServices.cargarCategoria(txtNombre.Text, txtDescripcion.Text);
                            MessageBox.Show("Carga realizada Exitosamente");
                            this.Close();
                        }


                    }
                    break;
                case FormMode.actualizar:
                    {

                        if (validarCampos2())
                        {
                            oCategoriaSelected.Nombre = txtNombre.Text;
                            oCategoriaSelected.Descripcion = txtDescripcion.Text;
                            if (oCategoriasServices.actualizarCategoria(oCategoriaSelected))
                            {
                                MessageBox.Show("Categoría actualizada!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Dispose();
                            }
                        }
                    }
                    break;
                case FormMode.eliminar:
                    {
                        if(!oCursoService.CategoriaEnUso(oCategoriaSelected.Id_Categoria))
                        {
                            if (MessageBox.Show("¿Seguro que desea Eliminar la Categoría seleccionada?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                            {
                                if (oCategoriasServices.borrarCategoria(oCategoriaSelected.Id_Categoria))
                                {
                                    MessageBox.Show("Categoría Eliminada", "Aviso");
                                    this.Close();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Ha ocurrido un error al intentar borrar la Categoría", "Error");
                                this.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("No se puede Eliminar la Categoría Seleccionada", "Error");
                            this.Close();
                        }

                    }
                    break;
            }
        }

            private bool validarCampos()
            {
                if (txtNombre.Text == "")
                {
                    msgError("Por favor Ingrese el nombre de la Categoría");
                    txtNombre.Focus();
                    return false;
                }
                if (txtDescripcion.Text == "")
                {
                    msgError("Por favor Ingrese una descripción");
                    txtDescripcion.Focus();
                    return false;
                }
                if (oCategoriasServices.existeCaracteristica(txtNombre.Text, "nombre", -1))
                {
                    msgError("El Nombre Ingresado ya existe");
                    txtNombre.Focus();
                    return false;
                }
                
                return true;
            }
            private bool validarCampos2()
            {
                if (txtNombre.Text == "")
                {
                    msgError("Por favor Ingrese el nombre de la Categoría");
                    txtNombre.Focus();
                    return false;
                }
                if (txtDescripcion.Text == "")
                {
                    msgError("Por favor Ingrese una descripción");
                    txtDescripcion.Focus();
                    return false;
                }
                if (oCategoriasServices.existeCaracteristica(txtNombre.Text, "nombre", oCategoriaSelected.Id_Categoria))
                {
                    msgError("El Nombre Ingresado ya existe");
                    txtNombre.Focus();
                    return false;
                }
                return true;
            }
        
            private void msgError(string mensaje)
            {
                lblError.Text = "      " + mensaje;
                lblError.Visible = true;

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
