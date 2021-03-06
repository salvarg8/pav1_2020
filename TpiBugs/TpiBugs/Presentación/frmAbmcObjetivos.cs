﻿using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using TpiBugs.Negocio.Entidades;
using TpiBugs.Negocio.Servicios;

namespace TpiBugs.Presentación
{
    public partial class frmAbmcObjetivos : Form
    {
        private FormMode formMode = FormMode.nuevo;

        private readonly ObjetivosService oObjetivoService;
        private readonly ObjetivosCursosService oObjetivosCursosService;
        private Objetivos oObjetivoSelected;


        public frmAbmcObjetivos()
        {
            InitializeComponent();
            oObjetivoService = new ObjetivosService();
            oObjetivosCursosService = new ObjetivosCursosService();

        }

        public enum FormMode
        {
            nuevo,
            actualizar,
            eliminar
        }






        private bool validarCampos2()
        {
            if (txtCorto.Text == "")
            {
                msgError("Por favor Ingrese un Nombre Corto");
                txtCorto.Focus();
                return false;
            }
            if (txtLargo.Text == "")
            {
                msgError("Por favor Ingrese un Nombre Largo");
                txtLargo.Focus();
                return false;
            }
            if (oObjetivoService.existeNombre(txtCorto.Text,"nombre_corto",oObjetivoSelected.ID_objetivos))
            {
                msgError("El Nombre Corto Ingresado ya existe");
                txtCorto.Focus();
                return false;
            }
            if (oObjetivoService.existeNombre(txtLargo.Text, "nombre_largo", oObjetivoSelected.ID_objetivos))
            {
                msgError("El Nombre Largo Ingresado ya existe");
                txtLargo.Focus();
                return false;
            }
            return true;
        }
        private bool validarCampos()
        {
            if (txtCorto.Text == "")
            {
                msgError("Por favor Ingrese un Nombre Corto");
                txtCorto.Focus();
                return false;
            }
            if (txtLargo.Text == "")
            {
                msgError("Por favor Ingrese un Nombre Largo");
                txtLargo.Focus();
                return false;
            }
            if (oObjetivoService.existeNombre(txtCorto.Text, "nombre_corto", -1))
            {
                msgError("El Nombre Corto Ingresado ya existe");
                txtCorto.Focus();
                return false;
            }
            if (oObjetivoService.existeNombre(txtLargo.Text, "nombre_largo", -1))
            {
                msgError("El Nombre Largo Ingresado ya existe");
                txtLargo.Focus();
                return false;
            }
            return true;
        }


        internal void IniciarFormulario(FormMode actualizar, Objetivos objetivo)
        {
            
            formMode = actualizar;
            oObjetivoSelected = objetivo;
            
        }

        private void frmAbmcObjetivos_Load(object sender, EventArgs e)
        {
            
            switch (formMode)
            {
                case FormMode.nuevo:
                    {
                        this.Text = "Nuevo Objetivo";
                        break;
                    }
                case FormMode.actualizar:
                    {
                        this.Text = "Actualizar Objetivo";
                        MostrarDatos();
                        txtCorto.Enabled = true;
                        txtLargo.Enabled = true;
                        break;
                    }
                case FormMode.eliminar:
                    {
                        this.Text = "Eliminar Objetivo";
                        MostrarDatos();
                        txtCorto.Enabled = false;
                        txtLargo.Enabled = false;
                        btnAceptar.Text = "Eliminar";
                        break;
                    }
            }
        }

        private void MostrarDatos()
        {
            if (oObjetivoSelected != null)
            {
                txtCorto.Text = oObjetivoSelected.Nombre_corto;
                txtLargo.Text = oObjetivoSelected.Nombre_largo;
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void btnCerrar2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea Salir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        
        
        
        private void panelBarraTitulo2_Paint(object sender, PaintEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnAceptar2_Click(object sender, EventArgs e)
        {
            switch (formMode)
            {
                case FormMode.nuevo:
                    {
                        if (validarCampos())
                        {
                            oObjetivoService.cargaObjetivos(txtCorto.Text, txtLargo.Text);
                            MessageBox.Show("Carga realizada Exitosamente");
                            this.Close();
                        }


                    }
                    break;
                case FormMode.actualizar:
                    {

                        if (validarCampos2())
                        {
                            oObjetivoSelected.Nombre_corto = txtCorto.Text;
                            oObjetivoSelected.Nombre_largo = txtLargo.Text;
                            if (oObjetivoService.actualizarObjetivo(oObjetivoSelected))
                            {
                                MessageBox.Show("Objetivo actualizado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Dispose();
                            }
                        }
                    }
                    break;
                case FormMode.eliminar:
                    {
                        if (!oObjetivosCursosService.objetivoUsado(oObjetivoSelected.ID_objetivos))
                        {
                            if (MessageBox.Show("¿Seguro que desea Eliminar el Objetivo seleccionado?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                            {
                                if (oObjetivoService.borrarObjetivo(oObjetivoSelected.ID_objetivos))
                                {
                                    MessageBox.Show("Objetivo Eliminado", "Aviso");
                                }
                                else
                                    MessageBox.Show("Ha ocurrido un error al intentar borrar el Objetivo", "Error");
                            }
                            else
                                MessageBox.Show("Ha ocurrido un error al intentar borrar el Objetivo", "Error");
                        }
                        else
                            MessageBox.Show("Ha ocurrido un error al intentar borrar el Objetivo", "Error");
                    }
                    break;
            }

        }

        

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea Salir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Dispose();
            }
        }
        
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

        private void btnCerrar_MouseEnter(object sender, EventArgs e)
        {
            btnCerrar.BackColor = Color.FromArgb(8, 62, 94);
        }

        private void btnCerrar_MouseLeave(object sender, EventArgs e)
        {
            btnCerrar.BackColor = Color.FromArgb(13, 93, 142);
        }
    }
}
