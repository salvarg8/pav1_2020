using System;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using TpiBugs.Negocio.Entidades;
using TpiBugs.Negocio.Servicios;
using TpiBugs.Reportes;

namespace TpiBugs.Presentación
{
    public partial class FrmPrincipal : Form
    {
        private FormMode formMode = FormMode.Logear;
        private readonly UsuarioService oUsuarioService;
        private Usuario oUsuarioLogeado;
        public FrmPrincipal()
        {
            InitializeComponent();
            oUsuarioService = new UsuarioService();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;

        }




        




        //RESIZE METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO EN TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
            region.Exclude(sizeGripRectangle);
            this.panelContendor.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);
            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

        

        int lx, ly;
        int sw, sh;

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            MinimumSize = this.Size;
            MaximumSize = this.Size;

        }
        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            MinimumSize = new Size(sw, sh);
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
        }

        private void panelBarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelBarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {

            Form formulario;
            formulario = panelFormularios.Controls.OfType<MiForm>().FirstOrDefault();
                                                                                     
            Form[] OpenForms = Application.OpenForms.Cast<Form>().ToArray();
            foreach (Form thisForm in OpenForms)
            {
                if (thisForm.Name != "FrmPrincipal" && thisForm.Name != "FrmLogin") thisForm.Close();
            }
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelFormularios.Controls.Add(formulario);
                panelFormularios.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            //si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            switch (formMode)
            {
                case FormMode.Logear:
                    {
                        string a = oUsuarioLogeado.NombreUsuario;
                        string b = oUsuarioLogeado.Perfil.Nombre;
                        lblUsuario.Text = a;
                        lblPerfil.Text = b;
                        break;
                    }
            }
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea Salir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                this.Dispose();

            else
                e.Cancel = true;

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnObjetivos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmObjetivos>();
        }

        

        private void btnMisCursos_Click(object sender, EventArgs e)
        {
            btnGestionarMisCursos.Visible = !btnGestionarMisCursos.Visible;
            btnAvances.Visible = !btnAvances.Visible;

        }

        private void btnCursos_Click(object sender, EventArgs e)
        {
            btnObjetivosCursos.Visible = !btnObjetivosCursos.Visible;
            btnCategorias.Visible = !btnCategorias.Visible;
            btnGestionarCursos.Visible = !btnGestionarCursos.Visible;

        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmCategorias>();
        }

        private void btnGestionarCursos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmCursos>();
        }

        private void btnObjetivosCursos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmObjetivosCursos>();
        }

        private void btnCerrar_MouseEnter(object sender, EventArgs e)
        {
            btnCerrar.BackColor = Color.FromArgb(8, 62, 94);
        }

        private void btnCerrar_MouseLeave(object sender, EventArgs e)
        {
            btnCerrar.BackColor = Color.FromArgb(13, 93, 142);
        }

        private void btnMaximizar_MouseEnter(object sender, EventArgs e)
        {
            btnMaximizar.BackColor = Color.FromArgb(8, 62, 94);
        }

        private void btnMaximizar_MouseLeave(object sender, EventArgs e)
        {
            btnMaximizar.BackColor = Color.FromArgb(13, 93, 142);
        }

        private void btnMinimizar_MouseEnter(object sender, EventArgs e)
        {
            btnMinimizar.BackColor = Color.FromArgb(8, 62, 94);
        }

        private void btnMinimizar_MouseLeave(object sender, EventArgs e)
        {
            btnMinimizar.BackColor = Color.FromArgb(13, 93, 142);

        }

        private void btnRestaurar_MouseEnter(object sender, EventArgs e)
        {
            btnRestaurar.BackColor = Color.FromArgb(8, 62, 94);
        }

        private void btnRestaurar_MouseLeave(object sender, EventArgs e)
        {
            btnRestaurar.BackColor = Color.FromArgb(13, 93, 142);

        }

        private void btnAvances_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmReporteCursos>();
        }

        private void btnGestionarMisCursos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmReporteEstadistico>();
        }

        public enum FormMode
        {
            asd,
            Logear
        }


        internal void IniciarFormulario(FormMode Actualizar, Usuario usuario)
        {
            {
                formMode = Actualizar;
                oUsuarioLogeado = usuario;
            }
        }




    }


}
