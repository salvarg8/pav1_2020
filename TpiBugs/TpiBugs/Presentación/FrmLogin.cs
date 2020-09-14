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
                MessageBox.Show("Se debe ingresar un usuario.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if ((txtContraseña.Text == ""))
            {
                MessageBox.Show("Se debe ingresar una contraseña.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var usr = usuarioService.ValidarUsuario(txtUsuario.Text, txtContraseña.Text);
            //Controlamos que las creadenciales sean las correctas. 
            if (usr != null)
            {
                // Login OK
                UsuarioLogueado = usr.NombreUsuario;
                this.Hide();
                FrmPrincipal frm = new FrmPrincipal();
                frm.Show();
                
            }
            else
            {
                
                txtContraseña.Text = "";
                txtContraseña.Focus();
                MessageBox.Show("Debe ingresar usuario y/o contraseña válidos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            
            this.CenterToParent();
        }

       

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
