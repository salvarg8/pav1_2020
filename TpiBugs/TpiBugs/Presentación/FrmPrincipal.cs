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

        private void button1_Click(object sender, EventArgs e)
        {
            //aca va la consulta larga de SQL ajja - Fijate que con  @ toma toda la consulta entre las comillas
            string consulta = @"DELETE FROM [dbo].[ObjetivosCursos]
            dELETE FROM [dbo].[Cursos]
            Delete From [dbo].[Categorias]
            DELETE FROM [dbo].[Objetivos]




            // Insertar datos en la tabla de objetivos  


            SET IDENTITY_INSERT[dbo].[Objetivos] ON
           INSERT INTO[dbo].[Objetivos]([id_objetivo],[nombre_corto],[nombre_largo],[borrado])VALUES(1, N'Parcial', N'Parcial de la parte practica', 0)

            INSERT INTO[dbo].[Objetivos]([id_objetivo],[nombre_corto],[nombre_largo],[borrado])VALUES(2, N'Parcial Integrador', N'Parcial Teorico y practico', 1)

            INSERT INTO[dbo].[Objetivos]([id_objetivo],[nombre_corto],[nombre_largo],[borrado])VALUES(3, N'Coloquio', N'Coloquio final de un tema a elegir', 0)

            INSERT INTO[dbo].[Objetivos]([id_objetivo],[nombre_corto],[nombre_largo],[borrado])VALUES(4, N'Coloquio Integrador', N'Coloqui integrador de toda la materia', 1)

            INSERT INTO[dbo].[Objetivos]([id_objetivo],[nombre_corto],[nombre_largo],[borrado])VALUES(5, N'Parcial Oral Practico', N'Parcial Oral de las unidades practicas', 0)

            INSERT INTO[dbo].[Objetivos]([id_objetivo],[nombre_corto],[nombre_largo],[borrado])VALUES(6, N'Trabajo Practico', N'Presentar Todos los trabajos practicos', 0)

            INSERT INTO[dbo].[Objetivos]([id_objetivo],[nombre_corto],[nombre_largo],[borrado])VALUES(7, N'Laboratorio', N'TRabajos practicos a realizar en laboratorio', 1)

            INSERT INTO[dbo].[Objetivos]([id_objetivo],[nombre_corto],[nombre_largo],[borrado])VALUES(8, N'Maqueta', N'Maquetado 3d de piezas del curso', 0)

            INSERT INTO[dbo].[Objetivos]([id_objetivo],[nombre_corto],[nombre_largo],[borrado])VALUES(9, N'Caramelos para el profe', N'Porque ya no aprobas con nada', 1)

            INSERT INTO[dbo].[Objetivos]([id_objetivo],[nombre_corto],[nombre_largo],[borrado])VALUES(10, N'Final', N'Este te la debo', 0)

            SET IDENTITY_INSERT[dbo].[Objetivos] OFF


               // Insertar datos en la tabla de Categorias 

               SET IDENTITY_INSERT[dbo].[Categorias] ON
              INSERT INTO[dbo].[Categorias]([id_categoria],[nombre],[descripcion],[borrado])VALUES(1, N'Categoria 1', N'descripcion de categoria 1', 0)

                INSERT INTO[dbo].[Categorias]([id_categoria],[nombre],[descripcion],[borrado])VALUES(2, N'Categoria 2', N'descripcion de categoria 2', 0)

                INSERT INTO[dbo].[Categorias]([id_categoria],[nombre],[descripcion],[borrado])VALUES(3, N'Categoria 3', N'descripcion de categoria 3', 0)

                INSERT INTO[dbo].[Categorias]([id_categoria],[nombre],[descripcion],[borrado])VALUES(4, N'Categoria 4', N'descripcion de categoria 4', 0)

                INSERT INTO[dbo].[Categorias]([id_categoria],[nombre],[descripcion],[borrado])VALUES(5, N'Categoria 5', N'descripcion de categoria 5', 0)

                INSERT INTO[dbo].[Categorias]([id_categoria],[nombre],[descripcion],[borrado])VALUES(6, N'Categoria 6', N'descripcion de categoria 6', 0)

                INSERT INTO[dbo].[Categorias]([id_categoria],[nombre],[descripcion],[borrado])VALUES(7, N'Categoria 7', N'descripcion de categoria 7', 0)

                INSERT INTO[dbo].[Categorias]([id_categoria],[nombre],[descripcion],[borrado])VALUES(8, N'Categoria 8', N'descripcion de categoria 8', 0)

                INSERT INTO[dbo].[Categorias]([id_categoria],[nombre],[descripcion],[borrado])VALUES(9, N'Categoria 9', N'descripcion de categoria 9', 0)

                INSERT INTO[dbo].[Categorias]([id_categoria],[nombre],[descripcion],[borrado])VALUES(10, N'Categoria 10', N'descripcion de categoria 10', 0)

                SET IDENTITY_INSERT[dbo].[Categorias] OFF


               //Insertar datos en la tabla Cursos
               SET IDENTITY_INSERT[dbo].[Cursos] ON
              INSERT INTO[dbo].[Cursos]([id_curso],[nombre],[descripcion],[fecha_vigencia],[id_categoria],[borrado])VALUES(1, N'Cocina', N'Cocina Mediterranea', CAST(N'2020-12-01' AS Date), 1, 1)

                INSERT INTO[dbo].[Cursos]([id_curso],[nombre],[descripcion],[fecha_vigencia],[id_categoria],[borrado])VALUES(2, N'Reposteria', N'Tartas Dulces', CAST(N'2020-11-15' AS Date), 2, 0)

                INSERT INTO[dbo].[Cursos]([id_curso],[nombre],[descripcion],[fecha_vigencia],[id_categoria],[borrado])VALUES(3, N'Mecanica', N'Mecanica de Motos', CAST(N'2020-12-11' AS Date), 3, 0)

                INSERT INTO[dbo].[Cursos]([id_curso],[nombre],[descripcion],[fecha_vigencia],[id_categoria],[borrado])VALUES(4, N'FloorWork', N'Danza', CAST(N'2020-11-01' AS Date), 3, 1)

                INSERT INTO[dbo].[Cursos]([id_curso],[nombre],[descripcion],[fecha_vigencia],[id_categoria],[borrado])VALUES(5, N'Fotografia', N'Fotografia Mediterranea', CAST(N'2020-12-01' AS Date), 4, 0)


                INSERT INTO[dbo].[Cursos]([id_curso],[nombre],[descripcion],[fecha_vigencia],[id_categoria],[borrado])VALUES(6, N'Cocina Oriental', N'Cocina Asia', CAST(N'2021-12-01' AS Date), 5, 0)

                INSERT INTO[dbo].[Cursos]([id_curso],[nombre],[descripcion],[fecha_vigencia],[id_categoria],[borrado])VALUES(7, N'Reapracion de Celu', N' Iphone', CAST(N'2020-10-18' AS Date), 6, 0)

                INSERT INTO[dbo].[Cursos]([id_curso],[nombre],[descripcion],[fecha_vigencia],[id_categoria],[borrado])VALUES(8, N'Mecanica Dental', N'Mecanica de Dientes', CAST(N'2020-01-08' AS Date), 2, 0)

                INSERT INTO[dbo].[Cursos]([id_curso],[nombre],[descripcion],[fecha_vigencia],[id_categoria],[borrado])VALUES(9, N'Clasico', N'Danza Clasica', CAST(N'2020-11-01' AS Date), 4, 0)

                INSERT INTO[dbo].[Cursos]([id_curso],[nombre],[descripcion],[fecha_vigencia],[id_categoria],[borrado])VALUES(10, N'Fotografia Estenopeica', N'Fotografia EStenopeica en laboratorio', CAST(N'2019-12-01' AS Date), 3, 0)



                INSERT INTO[dbo].[Cursos]([id_curso],[nombre],[descripcion],[fecha_vigencia],[id_categoria],[borrado])VALUES(11, N'Cocina Turca', N'Cocina Turca con arena', CAST(N'2020-12-07' AS Date), 1, 1)

                INSERT INTO[dbo].[Cursos]([id_curso],[nombre],[descripcion],[fecha_vigencia],[id_categoria],[borrado])VALUES(12, N'Reposteria de Babyshower', N'Tartas Dulces para babyshower', CAST(N'2020-10-05' AS Date), 2, 0)

                INSERT INTO[dbo].[Cursos]([id_curso],[nombre],[descripcion],[fecha_vigencia],[id_categoria],[borrado])VALUES(13, N'Mecanica de autos', N'Mecanica de Automoviles', CAST(N'2020-11-18' AS Date), 5, 0)

                INSERT INTO[dbo].[Cursos]([id_curso],[nombre],[descripcion],[fecha_vigencia],[id_categoria],[borrado])VALUES(14, N'Contemporaneo', N'Danza Contemporanea', CAST(N'2020-11-01' AS Date), 4, 1)

                INSERT INTO[dbo].[Cursos]([id_curso],[nombre],[descripcion],[fecha_vigencia],[id_categoria],[borrado])VALUES(15, N'Fotografia Digital', N'Fotografia Digital y Retoque', CAST(N'2018-12-01' AS Date), 4, 0)



                INSERT INTO[dbo].[Cursos]([id_curso],[nombre],[descripcion],[fecha_vigencia],[id_categoria],[borrado])VALUES(16, N'Cocina Quemada', N'Como recuperar comida quemada', CAST(N'2018-12-01' AS Date), 1, 1)

                INSERT INTO[dbo].[Cursos]([id_curso],[nombre],[descripcion],[fecha_vigencia],[id_categoria],[borrado])VALUES(17, N'Reposteria azul', N'Tartas Dulces azules', CAST(N'2020-11-15' AS Date), 2, 0)

                INSERT INTO[dbo].[Cursos]([id_curso],[nombre],[descripcion],[fecha_vigencia],[id_categoria],[borrado])VALUES(18, N'Mecanica de Aviones', N'Mecanica de Aviones a chorro', CAST(N'2020-12-11' AS Date), 3, 0)

                INSERT INTO[dbo].[Cursos]([id_curso],[nombre],[descripcion],[fecha_vigencia],[id_categoria],[borrado])VALUES(19, N'Salsa', N'Danza Salsistica', CAST(N'2020-11-01' AS Date), 3, 1)

                INSERT INTO[dbo].[Cursos]([id_curso],[nombre],[descripcion],[fecha_vigencia],[id_categoria],[borrado])VALUES(20, N'Fotografia de Retrato', N'Fotografia Mediterranea de Retratos', CAST(N'2020-12-01' AS Date), 4, 0)



                INSERT INTO[dbo].[Cursos]([id_curso],[nombre],[descripcion],[fecha_vigencia],[id_categoria],[borrado])VALUES(21, N'Cocina Mexicana', N'Cocina Mexicana con Aji', CAST(N'2020-12-12' AS Date), 1, 1)

                INSERT INTO[dbo].[Cursos]([id_curso],[nombre],[descripcion],[fecha_vigencia],[id_categoria],[borrado])VALUES(22, N'Reposteria Vegetal', N'Tartas Dulces veganas', CAST(N'2020-11-15' AS Date), 5, 0)

                INSERT INTO[dbo].[Cursos]([id_curso],[nombre],[descripcion],[fecha_vigencia],[id_categoria],[borrado])VALUES(23, N'Mecanica de Autitos de juguete', N'Mecanica de Juguetes', CAST(N'2021-11-11' AS Date), 3, 0)

                INSERT INTO[dbo].[Cursos]([id_curso],[nombre],[descripcion],[fecha_vigencia],[id_categoria],[borrado])VALUES(24, N'Hip hop', N'Danza del Bronxs', CAST(N'2020-11-01' AS Date), 2, 1)

                INSERT INTO[dbo].[Cursos]([id_curso],[nombre],[descripcion],[fecha_vigencia],[id_categoria],[borrado])VALUES(25, N'Fotografia de paisajes', N'Fotografia de paisajes urbanos', CAST(N'2020-11-01' AS Date), 4, 0)



                INSERT INTO[dbo].[Cursos]([id_curso],[nombre],[descripcion],[fecha_vigencia],[id_categoria],[borrado])VALUES(31, N'Cocina Ecuatoriana', N'Cocina del Centro del mundo', CAST(N'2020-12-01' AS Date), 1, 0)

                INSERT INTO[dbo].[Cursos]([id_curso],[nombre],[descripcion],[fecha_vigencia],[id_categoria],[borrado])VALUES(32, N'Reposteria italiana', N'Tartas Dulces de Italia', CAST(N'2020-11-15' AS Date), 2, 0)

                INSERT INTO[dbo].[Cursos]([id_curso],[nombre],[descripcion],[fecha_vigencia],[id_categoria],[borrado])VALUES(33, N'Mecanica de Motosierras', N'Mecanica de Motosierras', CAST(N'2020-12-11' AS Date), 3, 0)

                INSERT INTO[dbo].[Cursos]([id_curso],[nombre],[descripcion],[fecha_vigencia],[id_categoria],[borrado])VALUES(34, N'Danza Irlandesa', N'Danza y Zapateo irlandes', CAST(N'2020-11-01' AS Date), 3, 1)

                INSERT INTO[dbo].[Cursos]([id_curso],[nombre],[descripcion],[fecha_vigencia],[id_categoria],[borrado])VALUES(35, N'Fotografia de perros', N'Fotografia contemporanea retratos de perro', CAST(N'2020-12-01' AS Date), 4, 0)



                INSERT INTO[dbo].[Cursos]([id_curso],[nombre],[descripcion],[fecha_vigencia],[id_categoria],[borrado])VALUES(26, N'Cocina Egipcia', N'Cocina Mediterranea entre las piramides', CAST(N'2021-12-01' AS Date), 1, 0)

                INSERT INTO[dbo].[Cursos]([id_curso],[nombre],[descripcion],[fecha_vigencia],[id_categoria],[borrado])VALUES(27, N'Reposteria frutral', N'Tartas Dulces con frutas de estacion', CAST(N'2020-10-15' AS Date), 2, 0)

                INSERT INTO[dbo].[Cursos]([id_curso],[nombre],[descripcion],[fecha_vigencia],[id_categoria],[borrado])VALUES(28, N'Mecanica de gruas', N'Mecanica de gruas', CAST(N'2020-12-11' AS Date), 3, 0)

                INSERT INTO[dbo].[Cursos]([id_curso],[nombre],[descripcion],[fecha_vigencia],[id_categoria],[borrado])VALUES(29, N'Danza Aerea', N'Danza en tela', CAST(N'2020-11-01' AS Date), 3, 1)

                INSERT INTO[dbo].[Cursos]([id_curso],[nombre],[descripcion],[fecha_vigencia],[id_categoria],[borrado])VALUES(30, N'Fotografia de cuadros', N'Fotografia en museos', CAST(N'2020-11-01' AS Date), 4, 0)



                SET IDENTITY_INSERT[dbo].[Cursos] OFF





               INSERT INTO[dbo].[Cursos]
                  ([nombre],[descripcion],[fecha_vigencia],[id_categoria],[borrado])
                VALUES
                   ('Reparacion de Celus', 'Curso Intensivo', '2020-10-10 10:10:10', 2, 0)

                // PRINT 'Objetivos por Curso'

                INSERT INTO[dbo].[ObjetivosCursos]
                    ([id_objetivo],[id_curso],[puntos],[borrado])

                            VALUES(1, 4, 20, 0)
                INSERT INTO[dbo].[ObjetivosCursos]
                    ([id_curso],[id_objetivo],[puntos],[borrado])

                            VALUES(1, 5, 20, 0)

                INSERT INTO[dbo].[ObjetivosCursos]
                    ([id_curso],[id_objetivo],[puntos],[borrado])

                            VALUES(2, 5, 20, 0)

                INSERT INTO[dbo].[ObjetivosCursos]
                    ([id_curso],[id_objetivo],[puntos],[borrado])

                            VALUES(2, 7, 20, 0)
                INSERT INTO[dbo].[ObjetivosCursos]
                    ([id_curso],[id_objetivo],[puntos],[borrado])

                            VALUES(3, 4, 20, 0)
                INSERT INTO[dbo].[ObjetivosCursos]
                    ([id_curso],[id_objetivo],[puntos],[borrado])

                            VALUES(3, 1, 20, 0)

                INSERT INTO[dbo].[ObjetivosCursos]
                    ([id_curso],[id_objetivo],[puntos],[borrado])

                            VALUES(3, 2, 20, 0)

                INSERT INTO[dbo].[ObjetivosCursos]
                    ([id_curso],[id_objetivo],[puntos],[borrado])

                            VALUES(3, 3, 20, 0)

                INSERT INTO[dbo].[ObjetivosCursos]
                    ([id_curso],[id_objetivo],[puntos],[borrado])

                            VALUES(1, 1, 20, 0)
                INSERT INTO[dbo].[ObjetivosCursos]
                    ([id_curso],[id_objetivo],[puntos],[borrado])

                            VALUES(1, 3, 20, 0)

                INSERT INTO[dbo].[ObjetivosCursos]
                    ([id_curso],[id_objetivo],[puntos],[borrado])

                            VALUES(2, 1, 20, 0)

                INSERT INTO[dbo].[ObjetivosCursos]
                    ([id_curso],[id_objetivo],[puntos],[borrado])

                            VALUES(2, 2, 20, 0)

                INSERT INTO[dbo].[ObjetivosCursos]
                    ([id_curso],[id_objetivo],[puntos],[borrado])

                            VALUES(1, 2, 22, 0)
                INSERT INTO[dbo].[ObjetivosCursos]
                    ([id_curso],[id_objetivo],[puntos],[borrado])

                            VALUES(1, 6, 23, 0)

                INSERT INTO[dbo].[ObjetivosCursos]
                    ([id_curso],[id_objetivo],[puntos],[borrado])

                            VALUES(2, 3, 20, 0)

                INSERT INTO[dbo].[ObjetivosCursos]
                    ([id_curso],[id_objetivo],[puntos],[borrado])

                            VALUES(2, 6, 20, 0)


                INSERT INTO[dbo].[ObjetivosCursos]
                    ([id_curso],[id_objetivo],[puntos],[borrado])

                            VALUES(3, 5, 20, 0)
                INSERT INTO[dbo].[ObjetivosCursos]
                    ([id_curso],[id_objetivo],[puntos],[borrado])

                            VALUES(3, 6, 20, 0)

                INSERT INTO[dbo].[ObjetivosCursos]
                    ([id_curso],[id_objetivo],[puntos],[borrado])

                            VALUES(3, 7, 20, 0)




                INSERT INTO[dbo].[ObjetivosCursos]
                    ([id_curso],[id_objetivo],[puntos],[borrado])

                            VALUES(4, 6, 20, 0)
                INSERT INTO[dbo].[ObjetivosCursos]
                    ([id_curso],[id_objetivo],[puntos],[borrado])

                            VALUES(4, 4, 20, 0)
                INSERT INTO[dbo].[ObjetivosCursos]
                    ([id_curso],[id_objetivo],[puntos],[borrado])

                            VALUES(4, 2, 20, 0)

                INSERT INTO[dbo].[ObjetivosCursos]
                    ([id_curso],[id_objetivo],[puntos],[borrado])

                            VALUES(4, 7, 20, 0)

                INSERT INTO[dbo].[ObjetivosCursos]
                    ([id_curso],[id_objetivo],[puntos],[borrado])

                            VALUES(4, 5, 20, 0)


                INSERT INTO[dbo].[ObjetivosCursos]
                    ([id_curso],[id_objetivo],[puntos],[borrado])

                            VALUES(5, 6, 20, 0)
                INSERT INTO[dbo].[ObjetivosCursos]
                    ([id_curso],[id_objetivo],[puntos],[borrado])

                            VALUES(5, 4, 20, 0)
                INSERT INTO[dbo].[ObjetivosCursos]
                    ([id_curso],[id_objetivo],[puntos],[borrado])

                            VALUES(5, 2, 20, 0)

                INSERT INTO[dbo].[ObjetivosCursos]
                    ([id_curso],[id_objetivo],[puntos],[borrado])

                            VALUES(5, 7, 20, 0)

                INSERT INTO[dbo].[ObjetivosCursos]
                    ([id_curso],[id_objetivo],[puntos],[borrado])

                            VALUES(5, 5, 20, 0)


                INSERT INTO[dbo].[ObjetivosCursos]
                    ([id_curso],[id_objetivo],[puntos],[borrado])

                            VALUES(6, 6, 20, 0)
                INSERT INTO[dbo].[ObjetivosCursos]
                    ([id_curso],[id_objetivo],[puntos],[borrado])

                            VALUES(6, 4, 20, 0)
                INSERT INTO[dbo].[ObjetivosCursos]
                    ([id_curso],[id_objetivo],[puntos],[borrado])

                            VALUES(6, 2, 20, 0)

                INSERT INTO[dbo].[ObjetivosCursos]
                    ([id_curso],[id_objetivo],[puntos],[borrado])

                            VALUES(6, 7, 20, 0)

                INSERT INTO[dbo].[ObjetivosCursos]
                    ([id_curso],[id_objetivo],[puntos],[borrado])

                            VALUES(6, 5, 20, 0)


                INSERT INTO[dbo].[ObjetivosCursos]
                    ([id_curso],[id_objetivo],[puntos],[borrado])

                            VALUES(7, 6, 20, 0)
                INSERT INTO[dbo].[ObjetivosCursos]
                    ([id_curso],[id_objetivo],[puntos],[borrado])

                            VALUES(7, 4, 20, 0)
                INSERT INTO[dbo].[ObjetivosCursos]
                    ([id_curso],[id_objetivo],[puntos],[borrado])

                            VALUES(7, 2, 20, 0)

                INSERT INTO[dbo].[ObjetivosCursos]
                    ([id_curso],[id_objetivo],[puntos],[borrado])

                            VALUES(7, 7, 20, 0)

                INSERT INTO[dbo].[ObjetivosCursos]
                    ([id_curso],[id_objetivo],[puntos],[borrado])

                            VALUES(7, 5, 20, 0)


                INSERT INTO[dbo].[ObjetivosCursos]
                    ([id_curso],[id_objetivo],[puntos],[borrado])

                            VALUES(8, 6, 20, 0)
                INSERT INTO[dbo].[ObjetivosCursos]
                    ([id_curso],[id_objetivo],[puntos],[borrado])

                            VALUES(8, 4, 20, 0)
                INSERT INTO[dbo].[ObjetivosCursos]
                    ([id_curso],[id_objetivo],[puntos],[borrado])

                            VALUES(8, 2, 20, 0)

                INSERT INTO[dbo].[ObjetivosCursos]
                    ([id_curso],[id_objetivo],[puntos],[borrado])

                            VALUES(8, 7, 20, 0)

                INSERT INTO[dbo].[ObjetivosCursos]
                    ([id_curso],[id_objetivo],[puntos],[borrado])

                            VALUES(8, 5, 20, 0)";




            
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
