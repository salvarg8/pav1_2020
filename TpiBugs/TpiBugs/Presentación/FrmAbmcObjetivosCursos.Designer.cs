namespace TpiBugs.Presentación
{
    partial class FrmAbmcObjetivosCursos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAbmcObjetivosCursos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombreCurso = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.dgvObjetivosDisponibles = new System.Windows.Forms.DataGridView();
            this.id_objetivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvObjetivosCurso = new System.Windows.Forms.DataGridView();
            this.Id_Objetivos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_corto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_largo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjetivosDisponibles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjetivosCurso)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.panelBarraTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBarraTitulo.Controls.Add(this.label2);
            this.panelBarraTitulo.Controls.Add(this.btnCerrar);
            this.panelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelBarraTitulo.Name = "panelBarraTitulo";
            this.panelBarraTitulo.Size = new System.Drawing.Size(622, 24);
            this.panelBarraTitulo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bug Tracking System";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(601, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(16, 16);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            this.btnCerrar.MouseEnter += new System.EventHandler(this.btnCerrar_MouseEnter);
            this.btnCerrar.MouseLeave += new System.EventHandler(this.btnCerrar_MouseLeave);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.btnAgregar);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.lblNombreCurso);
            this.panel5.Controls.Add(this.btnGuardar);
            this.panel5.Controls.Add(this.btnCancelar);
            this.panel5.Controls.Add(this.btnUp);
            this.panel5.Controls.Add(this.btnDown);
            this.panel5.Controls.Add(this.dgvObjetivosDisponibles);
            this.panel5.Controls.Add(this.dgvObjetivosCurso);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 24);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(622, 516);
            this.panel5.TabIndex = 6;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregar.BackgroundImage")));
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregar.Location = new System.Drawing.Point(11, 451);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(60, 60);
            this.btnAgregar.TabIndex = 27;
            this.toolTip1.SetToolTip(this.btnAgregar, "Nuevo Objetivo");
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.label3.Location = new System.Drawing.Point(11, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 18);
            this.label3.TabIndex = 26;
            this.label3.Text = "Objetivos Disponibles";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.label1.Location = new System.Drawing.Point(8, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 18);
            this.label1.TabIndex = 25;
            this.label1.Text = "Objetivos del Curso";
            // 
            // lblNombreCurso
            // 
            this.lblNombreCurso.AutoSize = true;
            this.lblNombreCurso.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCurso.Location = new System.Drawing.Point(249, 2);
            this.lblNombreCurso.Name = "lblNombreCurso";
            this.lblNombreCurso.Size = new System.Drawing.Size(123, 18);
            this.lblNombreCurso.TabIndex = 24;
            this.lblNombreCurso.Text = "Nombre Curso";
            this.lblNombreCurso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.BackgroundImage")));
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Location = new System.Drawing.Point(483, 451);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(60, 60);
            this.btnGuardar.TabIndex = 23;
            this.toolTip1.SetToolTip(this.btnGuardar, "Guardar");
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.Location = new System.Drawing.Point(549, 451);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(60, 60);
            this.btnCancelar.TabIndex = 22;
            this.toolTip1.SetToolTip(this.btnCancelar, "Cancelar");
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnUp
            // 
            this.btnUp.Image = ((System.Drawing.Image)(resources.GetObject("btnUp.Image")));
            this.btnUp.Location = new System.Drawing.Point(49, 221);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(32, 32);
            this.btnUp.TabIndex = 21;
            this.toolTip1.SetToolTip(this.btnUp, "Agregar Objetivo");
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Image = ((System.Drawing.Image)(resources.GetObject("btnDown.Image")));
            this.btnDown.Location = new System.Drawing.Point(11, 221);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(32, 32);
            this.btnDown.TabIndex = 20;
            this.toolTip1.SetToolTip(this.btnDown, "Quitar Objetivo");
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // dgvObjetivosDisponibles
            // 
            this.dgvObjetivosDisponibles.AllowUserToAddRows = false;
            this.dgvObjetivosDisponibles.AllowUserToDeleteRows = false;
            this.dgvObjetivosDisponibles.AllowUserToResizeRows = false;
            this.dgvObjetivosDisponibles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvObjetivosDisponibles.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvObjetivosDisponibles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvObjetivosDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObjetivosDisponibles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_objetivo,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(130)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvObjetivosDisponibles.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvObjetivosDisponibles.Location = new System.Drawing.Point(11, 279);
            this.dgvObjetivosDisponibles.MultiSelect = false;
            this.dgvObjetivosDisponibles.Name = "dgvObjetivosDisponibles";
            this.dgvObjetivosDisponibles.ReadOnly = true;
            this.dgvObjetivosDisponibles.RowHeadersVisible = false;
            this.dgvObjetivosDisponibles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvObjetivosDisponibles.Size = new System.Drawing.Size(598, 166);
            this.dgvObjetivosDisponibles.TabIndex = 19;
            // 
            // id_objetivo
            // 
            this.id_objetivo.FillWeight = 44.43543F;
            this.id_objetivo.HeaderText = "ID";
            this.id_objetivo.Name = "id_objetivo";
            this.id_objetivo.ReadOnly = true;
            this.id_objetivo.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 76.14214F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre Corto";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.FillWeight = 179.4224F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Nombre Largo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "borrado";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dgvObjetivosCurso
            // 
            this.dgvObjetivosCurso.AllowUserToAddRows = false;
            this.dgvObjetivosCurso.AllowUserToDeleteRows = false;
            this.dgvObjetivosCurso.AllowUserToResizeRows = false;
            this.dgvObjetivosCurso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvObjetivosCurso.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvObjetivosCurso.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvObjetivosCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObjetivosCurso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Objetivos,
            this.nom_corto,
            this.nom_largo,
            this.borrado});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 8.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(130)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvObjetivosCurso.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvObjetivosCurso.Location = new System.Drawing.Point(11, 52);
            this.dgvObjetivosCurso.MultiSelect = false;
            this.dgvObjetivosCurso.Name = "dgvObjetivosCurso";
            this.dgvObjetivosCurso.ReadOnly = true;
            this.dgvObjetivosCurso.RowHeadersVisible = false;
            this.dgvObjetivosCurso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvObjetivosCurso.Size = new System.Drawing.Size(598, 163);
            this.dgvObjetivosCurso.TabIndex = 16;
            // 
            // Id_Objetivos
            // 
            this.Id_Objetivos.FillWeight = 44.43543F;
            this.Id_Objetivos.HeaderText = "ID";
            this.Id_Objetivos.Name = "Id_Objetivos";
            this.Id_Objetivos.ReadOnly = true;
            this.Id_Objetivos.Visible = false;
            // 
            // nom_corto
            // 
            this.nom_corto.FillWeight = 76.14214F;
            this.nom_corto.HeaderText = "Nombre Corto";
            this.nom_corto.Name = "nom_corto";
            this.nom_corto.ReadOnly = true;
            // 
            // nom_largo
            // 
            this.nom_largo.FillWeight = 179.4224F;
            this.nom_largo.HeaderText = "Nombre Largo";
            this.nom_largo.Name = "nom_largo";
            this.nom_largo.ReadOnly = true;
            // 
            // borrado
            // 
            this.borrado.HeaderText = "borrado";
            this.borrado.Name = "borrado";
            this.borrado.ReadOnly = true;
            this.borrado.Visible = false;
            // 
            // FrmAbmcObjetivosCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 540);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panelBarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAbmcObjetivosCursos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAbmcObjetivosCursos";
            this.Load += new System.EventHandler(this.FrmAbmcObjetivosCursos_Load);
            this.panelBarraTitulo.ResumeLayout(false);
            this.panelBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjetivosDisponibles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjetivosCurso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelBarraTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombreCurso;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        internal System.Windows.Forms.DataGridView dgvObjetivosDisponibles;
        internal System.Windows.Forms.DataGridView dgvObjetivosCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Objetivos;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_corto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_largo;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrado;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_objetivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}