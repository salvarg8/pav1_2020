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
    public partial class frmAbmcObjetivos : Form
    {
        private FormMode formMode = FormMode.nuevo;
        private ObjetivosService servicio;
        private Objetivos oObjetivoSelected;
        private ObjetivosService oObjetivoService;
       
        public frmAbmcObjetivos()
        {

            servicio = new ObjetivosService();
            InitializeComponent();
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
                        if (existeObjetivo() == false)
                            {
                            if (txtCorto.Text != null && txtLargo.Text != null)
                                servicio.cargaObjetivos(txtCorto.Text, txtLargo.Text);
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
                            if(oObjetivoService.actualizarObjetivo(oObjetivoSelected))
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
            if(txtCorto.Text == null)
            {
                return false;
            }
            if(txtLargo.Text == null)
            {
                return false;
            }
            return true;
        }

        private bool existeObjetivo()
        {
            throw new NotImplementedException();
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
            txtCorto.Text = oObjetivoSelected.Nombre_corto;
            txtLargo.Text = oObjetivoSelected.Nombre_largo;
        }
    }
}
