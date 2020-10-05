using TpiBugs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TpiBugs.Negocio.Entidades;
using TpiBugs.Negocio.Servicios;
using TpiBugs.Presentación;



namespace TpiBugs
{
    public partial class FrmLogin : Form
    {
        private readonly UsuarioService usuarioService;

        public string UsuarioLogueado { get; internal set; }
        public FrmLogin()
        {
            InitializeComponent();
            usuarioService = new UsuarioService();

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if ((txtUsuario.Text == ""))
            {   
                msgError("Por favor ingresar un Usuario");
                return;
            }

            if ((txtContraseña.Text == ""))
            {
                msgError("Por favor ingresar una Contraseña");
                return;
            }

            var usr = usuarioService.ValidarUsuario(txtUsuario.Text, txtContraseña.Text);
            //Controlamos que las creadenciales sean las correctas. 
            if (usr != null)
            {
                // Login OK
                UsuarioLogueado = usr.NombreUsuario;
                this.Hide();
                var nombre = usr.NombreUsuario;

                FrmPrincipal frm = new FrmPrincipal();
                frm.IniciarFormulario(FrmPrincipal.FormMode.Logear, usr);
                frm.Show();
                
            }
            else
            {
                
                txtContraseña.Text = "";
                txtContraseña.Focus();
                msgError("Usuario y/o Contraseña Incorrecto");
            }
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            
            this.CenterToParent();
        }

        

        private void msgError(string mensaje)
        {
            lblError.Text = "      " + mensaje;
            lblError.Visible = true;

        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea Salir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                this.Dispose();

            else
                e.Cancel = true;
        }
    }
}
