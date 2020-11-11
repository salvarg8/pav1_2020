namespace TpiBugs.Presentación
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.panelContendor = new System.Windows.Forms.Panel();
            this.panelFormularios = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnObjetivos = new System.Windows.Forms.Button();
            this.btnObjetivosCursos = new System.Windows.Forms.Button();
            this.btnCategorias = new System.Windows.Forms.Button();
            this.btnGestionarCursos = new System.Windows.Forms.Button();
            this.btnCursos = new System.Windows.Forms.Button();
            this.btnGestionarMisCursos = new System.Windows.Forms.Button();
            this.btnAvances = new System.Windows.Forms.Button();
            this.btnMisCursos = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.panelContendor.SuspendLayout();
            this.panelFormularios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContendor
            // 
            this.panelContendor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelContendor.Controls.Add(this.panelFormularios);
            this.panelContendor.Controls.Add(this.panelMenu);
            this.panelContendor.Controls.Add(this.panelBarraTitulo);
            this.panelContendor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContendor.Location = new System.Drawing.Point(0, 0);
            this.panelContendor.Name = "panelContendor";
            this.panelContendor.Size = new System.Drawing.Size(900, 500);
            this.panelContendor.TabIndex = 3;
            // 
            // panelFormularios
            // 
            this.panelFormularios.BackColor = System.Drawing.Color.White;
            this.panelFormularios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFormularios.Controls.Add(this.label1);
            this.panelFormularios.Controls.Add(this.pictureBox1);
            this.panelFormularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormularios.Location = new System.Drawing.Point(200, 24);
            this.panelFormularios.Name = "panelFormularios";
            this.panelFormularios.Size = new System.Drawing.Size(700, 476);
            this.panelFormularios.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Bug Tracking System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(283, 157);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 133);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenu.Controls.Add(this.btnObjetivos);
            this.panelMenu.Controls.Add(this.btnObjetivosCursos);
            this.panelMenu.Controls.Add(this.btnCategorias);
            this.panelMenu.Controls.Add(this.btnGestionarCursos);
            this.panelMenu.Controls.Add(this.btnCursos);
            this.panelMenu.Controls.Add(this.btnGestionarMisCursos);
            this.panelMenu.Controls.Add(this.btnAvances);
            this.panelMenu.Controls.Add(this.btnMisCursos);
            this.panelMenu.Controls.Add(this.panel4);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 24);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 476);
            this.panelMenu.TabIndex = 7;
            // 
            // btnObjetivos
            // 
            this.btnObjetivos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnObjetivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObjetivos.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObjetivos.ForeColor = System.Drawing.SystemColors.Control;
            this.btnObjetivos.Location = new System.Drawing.Point(0, 302);
            this.btnObjetivos.Name = "btnObjetivos";
            this.btnObjetivos.Size = new System.Drawing.Size(198, 30);
            this.btnObjetivos.TabIndex = 18;
            this.btnObjetivos.Text = "Objetivos";
            this.btnObjetivos.UseVisualStyleBackColor = true;
            this.btnObjetivos.Click += new System.EventHandler(this.btnObjetivos_Click);
            // 
            // btnObjetivosCursos
            // 
            this.btnObjetivosCursos.BackColor = System.Drawing.Color.White;
            this.btnObjetivosCursos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnObjetivosCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObjetivosCursos.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObjetivosCursos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.btnObjetivosCursos.Location = new System.Drawing.Point(0, 272);
            this.btnObjetivosCursos.Name = "btnObjetivosCursos";
            this.btnObjetivosCursos.Size = new System.Drawing.Size(198, 30);
            this.btnObjetivosCursos.TabIndex = 15;
            this.btnObjetivosCursos.Text = "Objetivos Cursos";
            this.btnObjetivosCursos.UseVisualStyleBackColor = false;
            this.btnObjetivosCursos.Visible = false;
            this.btnObjetivosCursos.Click += new System.EventHandler(this.btnObjetivosCursos_Click);
            // 
            // btnCategorias
            // 
            this.btnCategorias.BackColor = System.Drawing.Color.White;
            this.btnCategorias.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategorias.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategorias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.btnCategorias.Location = new System.Drawing.Point(0, 242);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Size = new System.Drawing.Size(198, 30);
            this.btnCategorias.TabIndex = 14;
            this.btnCategorias.Text = "Categorias";
            this.btnCategorias.UseVisualStyleBackColor = false;
            this.btnCategorias.Visible = false;
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // btnGestionarCursos
            // 
            this.btnGestionarCursos.BackColor = System.Drawing.Color.White;
            this.btnGestionarCursos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionarCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionarCursos.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionarCursos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.btnGestionarCursos.Location = new System.Drawing.Point(0, 212);
            this.btnGestionarCursos.Name = "btnGestionarCursos";
            this.btnGestionarCursos.Size = new System.Drawing.Size(198, 30);
            this.btnGestionarCursos.TabIndex = 13;
            this.btnGestionarCursos.Text = "Gestionar Cursos";
            this.btnGestionarCursos.UseVisualStyleBackColor = false;
            this.btnGestionarCursos.Visible = false;
            this.btnGestionarCursos.Click += new System.EventHandler(this.btnGestionarCursos_Click);
            // 
            // btnCursos
            // 
            this.btnCursos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCursos.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCursos.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCursos.Location = new System.Drawing.Point(0, 182);
            this.btnCursos.Name = "btnCursos";
            this.btnCursos.Size = new System.Drawing.Size(198, 30);
            this.btnCursos.TabIndex = 12;
            this.btnCursos.Text = "Cursos";
            this.btnCursos.UseVisualStyleBackColor = true;
            this.btnCursos.Click += new System.EventHandler(this.btnCursos_Click);
            // 
            // btnGestionarMisCursos
            // 
            this.btnGestionarMisCursos.BackColor = System.Drawing.Color.White;
            this.btnGestionarMisCursos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionarMisCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionarMisCursos.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionarMisCursos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.btnGestionarMisCursos.Location = new System.Drawing.Point(0, 152);
            this.btnGestionarMisCursos.Name = "btnGestionarMisCursos";
            this.btnGestionarMisCursos.Size = new System.Drawing.Size(198, 30);
            this.btnGestionarMisCursos.TabIndex = 11;
            this.btnGestionarMisCursos.Text = "Reporte Estadístico";
            this.btnGestionarMisCursos.UseVisualStyleBackColor = false;
            this.btnGestionarMisCursos.Visible = false;
            this.btnGestionarMisCursos.Click += new System.EventHandler(this.btnGestionarMisCursos_Click);
            // 
            // btnAvances
            // 
            this.btnAvances.BackColor = System.Drawing.Color.White;
            this.btnAvances.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAvances.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAvances.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvances.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.btnAvances.Location = new System.Drawing.Point(0, 122);
            this.btnAvances.Name = "btnAvances";
            this.btnAvances.Size = new System.Drawing.Size(198, 30);
            this.btnAvances.TabIndex = 10;
            this.btnAvances.Text = "Reporte Cursos";
            this.btnAvances.UseVisualStyleBackColor = false;
            this.btnAvances.Visible = false;
            this.btnAvances.Click += new System.EventHandler(this.btnAvances_Click);
            // 
            // btnMisCursos
            // 
            this.btnMisCursos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMisCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMisCursos.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMisCursos.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMisCursos.Location = new System.Drawing.Point(0, 92);
            this.btnMisCursos.Name = "btnMisCursos";
            this.btnMisCursos.Size = new System.Drawing.Size(198, 30);
            this.btnMisCursos.TabIndex = 9;
            this.btnMisCursos.Text = "Reportes";
            this.btnMisCursos.UseVisualStyleBackColor = true;
            this.btnMisCursos.Click += new System.EventHandler(this.btnMisCursos_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblPerfil);
            this.panel4.Controls.Add(this.lblUsuario);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(198, 92);
            this.panel4.TabIndex = 6;
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Font = new System.Drawing.Font("Verdana", 9.25F);
            this.lblPerfil.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPerfil.Location = new System.Drawing.Point(74, 48);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(40, 16);
            this.lblPerfil.TabIndex = 2;
            this.lblPerfil.Text = "Perfil";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUsuario.Location = new System.Drawing.Point(74, 19);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(66, 18);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "nombre";
            // 
            // label3
            // 
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(-3, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 81);
            this.label3.TabIndex = 0;
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.panelBarraTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBarraTitulo.Controls.Add(this.label2);
            this.panelBarraTitulo.Controls.Add(this.btnRestaurar);
            this.panelBarraTitulo.Controls.Add(this.btnMinimizar);
            this.panelBarraTitulo.Controls.Add(this.btnMaximizar);
            this.panelBarraTitulo.Controls.Add(this.btnCerrar);
            this.panelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelBarraTitulo.Name = "panelBarraTitulo";
            this.panelBarraTitulo.Size = new System.Drawing.Size(900, 24);
            this.panelBarraTitulo.TabIndex = 5;
            this.panelBarraTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBarraTitulo_Paint);
            this.panelBarraTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelBarraTitulo_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(3, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bug Tracking System";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.Location = new System.Drawing.Point(857, 2);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(16, 16);
            this.btnRestaurar.TabIndex = 3;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            this.btnRestaurar.MouseEnter += new System.EventHandler(this.btnRestaurar_MouseEnter);
            this.btnRestaurar.MouseLeave += new System.EventHandler(this.btnRestaurar_MouseLeave);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(835, 2);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(16, 16);
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            this.btnMinimizar.MouseEnter += new System.EventHandler(this.btnMinimizar_MouseEnter);
            this.btnMinimizar.MouseLeave += new System.EventHandler(this.btnMinimizar_MouseLeave);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(857, 2);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(16, 16);
            this.btnMaximizar.TabIndex = 1;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            this.btnMaximizar.MouseEnter += new System.EventHandler(this.btnMaximizar_MouseEnter);
            this.btnMaximizar.MouseLeave += new System.EventHandler(this.btnMaximizar_MouseLeave);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(879, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(16, 16);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            this.btnCerrar.MouseEnter += new System.EventHandler(this.btnCerrar_MouseEnter);
            this.btnCerrar.MouseLeave += new System.EventHandler(this.btnCerrar_MouseLeave);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.panelContendor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrincipal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.panelContendor.ResumeLayout(false);
            this.panelFormularios.ResumeLayout(false);
            this.panelFormularios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panelBarraTitulo.ResumeLayout(false);
            this.panelBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelContendor;
        private System.Windows.Forms.Panel panelFormularios;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelBarraTitulo;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.Button btnObjetivos;
        private System.Windows.Forms.Button btnObjetivosCursos;
        private System.Windows.Forms.Button btnCategorias;
        private System.Windows.Forms.Button btnGestionarCursos;
        private System.Windows.Forms.Button btnCursos;
        private System.Windows.Forms.Button btnGestionarMisCursos;
        private System.Windows.Forms.Button btnAvances;
        private System.Windows.Forms.Button btnMisCursos;
    }
}