﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using TpiBugs.Datos.Dao.Implementacion;
using TpiBugs.Negocio.Entidades;
using TpiBugs.Negocio.Servicios;

namespace TpiBugs.Presentación
{
    public partial class FrmObjetivos : Form
    {
        private ObjetivosCursosService oObjetivosCursoService;
        private ObjetivosService servicio;
        public FrmObjetivos()
        {
            servicio = new ObjetivosService();
            oObjetivosCursoService = new ObjetivosCursosService();
            InitializeComponent();
        }

        private void btnBuscar_Click(System.Object sender, System.EventArgs e)
        {
            dgvObjetivos.Rows.Clear();
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            
            var filters = new Dictionary<string, object>();
            if (chbBuscarTodos.Checked)
            {
                IList<Objetivos> lst = servicio.GetObjetivosConBorrado(txtNombreCorto.Text, txtNombreLargo.Text);

                foreach (Objetivos obj in lst)
                {
                    dgvObjetivos.Rows.Add(new object[] { obj.ID_objetivos, obj.Nombre_corto, obj.Nombre_largo, obj.Borrado});
                    if (obj.Borrado == true)
                    {
                        dgvObjetivos.Rows[dgvObjetivos.RowCount-1].DefaultCellStyle.ForeColor = Color.Red;
                        dgvObjetivos.Rows[dgvObjetivos.RowCount - 1].DefaultCellStyle.SelectionForeColor = Color.Red;
                    }

                }
            }
            else 
            {
                IList<Objetivos> lst = servicio.GetObjetivosSinBorrado(txtNombreCorto.Text, txtNombreLargo.Text);

                foreach (Objetivos obj in lst)
                {
                    dgvObjetivos.Rows.Add(new object[] { obj.ID_objetivos, obj.Nombre_corto, obj.Nombre_largo, obj.Borrado });
                }
            }
            lblCantEncontrado.Visible = true;
            lblCantEncontrado.Text = "Objetivos encontrados = " + dgvObjetivos.Rows.Count;
        }



        private void FrmObjetivos_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }


        

        private void FrmObjetivos_Load(object sender, EventArgs e)
        {
            
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        

       

        private void dgvObjetivos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAbmcObjetivos frm = new frmAbmcObjetivos();
            frm.ShowDialog();
            btnBuscar_Click(sender, e);

        }

        private void btnEditar_Click(System.Object sender, System.EventArgs e)
        {
            
            int id = Convert.ToInt32(dgvObjetivos.CurrentRow.Cells["Id_Objetivos"].Value);
            string nombre_corto = Convert.ToString(dgvObjetivos.CurrentRow.Cells["nom_corto"].Value);
            string nombre_largo = Convert.ToString(dgvObjetivos.CurrentRow.Cells["nom_largo"].Value);
            bool borrado = Convert.ToBoolean(dgvObjetivos.CurrentRow.Cells["borrado"].Value);
            if (!borrado)
            {
                Objetivos objetivo = new Objetivos(id, nombre_corto, nombre_largo, borrado);
                frmAbmcObjetivos frm = new frmAbmcObjetivos();
                frm.IniciarFormulario(frmAbmcObjetivos.FormMode.actualizar, objetivo);
                frm.ShowDialog();
                btnBuscar_Click(sender, e);
            }
            else
                MessageBox.Show("No se puede Editar el Objetivo Seleccionado", "Error");
            
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvObjetivos.CurrentRow.Cells["Id_Objetivos"].Value);
            string nombre_corto = Convert.ToString(dgvObjetivos.CurrentRow.Cells["nom_corto"].Value);
            string nombre_largo = Convert.ToString(dgvObjetivos.CurrentRow.Cells["nom_largo"].Value);
            bool borrado = Convert.ToBoolean(dgvObjetivos.CurrentRow.Cells["borrado"].Value);
            if (!borrado)
            {
                Objetivos objetivo = new Objetivos(id, nombre_corto, nombre_largo, borrado);
                frmAbmcObjetivos frm = new frmAbmcObjetivos();
                frm.IniciarFormulario(frmAbmcObjetivos.FormMode.eliminar, objetivo);
                frm.ShowDialog();
                btnBuscar_Click(sender, e);
            }
            else
                MessageBox.Show("No se puede Eliminar el Objetivo Seleccionado", "Error");
        }

        private void dgvObjetivos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvObjetivos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditar_Click(sender, e);
        }

        private void txtNombreLargo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBuscar_Click(sender, e);
            }
        }

        private void txtNombreCorto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBuscar_Click(sender, e);
            }
        }
    }
}