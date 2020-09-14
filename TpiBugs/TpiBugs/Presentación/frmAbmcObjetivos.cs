﻿using System;
using System.Windows.Forms;
using TpiBugs.Negocio.Entidades;
using TpiBugs.Negocio.Servicios;

namespace TpiBugs.Presentación
{
    public partial class frmAbmcObjetivos : Form
    {
        private FormMode formMode = FormMode.nuevo;

        private readonly ObjetivosService oObjetivoService;
        private Objetivos oObjetivoSelected;


        public frmAbmcObjetivos()
        {
            InitializeComponent();
            oObjetivoService = new ObjetivosService();

        }

        public enum FormMode
        {
            nuevo,
            actualizar,
            eliminar
        }




        private void btnAceptar_Click(object sender, EventArgs e)
        {
            switch (formMode)
            {
                case FormMode.nuevo:
                    {
                        if (txtCorto.Text != null && txtLargo.Text != null)
                        {
                            oObjetivoService.cargaObjetivos(txtCorto.Text, txtLargo.Text);
                            MessageBox.Show("Carga realizada Exitosamente");
                            this.Close();
                        }
                        

                    }
                    break;
                case FormMode.actualizar:
                    {

                        if (validarCampos())
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

            }

        }

        private bool validarCampos()
        {
            if (txtCorto.Text == null)
            {
                return false;
            }
            if (txtLargo.Text == null)
            {
                return false;
            }
            return true;
        }

        

        internal void IniciarFormulario(FormMode actualizar, Objetivos objetivo)
        {
            {
                formMode = actualizar;
                oObjetivoSelected = objetivo;
            }
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
                        this.Text = "Actualizar Usuario";
                        MostrarDatos();
                        txtCorto.Enabled = true;
                        txtLargo.Enabled = true;
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
    }
}
