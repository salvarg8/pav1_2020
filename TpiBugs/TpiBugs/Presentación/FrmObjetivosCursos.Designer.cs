namespace TpiBugs.Presentación
{
    partial class FrmObjetivosCursos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmObjetivosCursos));
            this.lblCantEncontrado = new System.Windows.Forms.Label();
            this.cmbCursos = new System.Windows.Forms.ComboBox();
            this.dgvObjetivos = new System.Windows.Forms.DataGridView();
            this.Id_Objetivos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_corto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_largo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puntos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjetivos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCantEncontrado
            // 
            this.lblCantEncontrado.AutoSize = true;
            this.lblCantEncontrado.Font = new System.Drawing.Font("Verdana", 11F);
            this.lblCantEncontrado.Location = new System.Drawing.Point(9, 64);
            this.lblCantEncontrado.Name = "lblCantEncontrado";
            this.lblCantEncontrado.Size = new System.Drawing.Size(91, 18);
            this.lblCantEncontrado.TabIndex = 42;
            this.lblCantEncontrado.Text = "Objetivos: ";
            // 
            // cmbCursos
            // 
            this.cmbCursos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCursos.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbCursos.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.cmbCursos.FormattingEnabled = true;
            this.cmbCursos.Location = new System.Drawing.Point(12, 30);
            this.cmbCursos.Name = "cmbCursos";
            this.cmbCursos.Size = new System.Drawing.Size(227, 31);
            this.cmbCursos.TabIndex = 37;
            this.cmbCursos.SelectionChangeCommitted += new System.EventHandler(this.cmbCursos_SelectionChangeCommitted);
            // 
            // dgvObjetivos
            // 
            this.dgvObjetivos.AllowUserToAddRows = false;
            this.dgvObjetivos.AllowUserToDeleteRows = false;
            this.dgvObjetivos.AllowUserToResizeRows = false;
            this.dgvObjetivos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvObjetivos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvObjetivos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvObjetivos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvObjetivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObjetivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Objetivos,
            this.id_curso,
            this.nom_corto,
            this.nom_largo,
            this.puntos,
            this.borrado});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 8.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(130)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvObjetivos.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvObjetivos.Location = new System.Drawing.Point(11, 85);
            this.dgvObjetivos.MultiSelect = false;
            this.dgvObjetivos.Name = "dgvObjetivos";
            this.dgvObjetivos.ReadOnly = true;
            this.dgvObjetivos.RowHeadersVisible = false;
            this.dgvObjetivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvObjetivos.Size = new System.Drawing.Size(541, 292);
            this.dgvObjetivos.TabIndex = 41;
            // 
            // Id_Objetivos
            // 
            this.Id_Objetivos.FillWeight = 44.43543F;
            this.Id_Objetivos.HeaderText = "id_objetivos";
            this.Id_Objetivos.Name = "Id_Objetivos";
            this.Id_Objetivos.ReadOnly = true;
            this.Id_Objetivos.Visible = false;
            // 
            // id_curso
            // 
            this.id_curso.HeaderText = "id_curso";
            this.id_curso.Name = "id_curso";
            this.id_curso.ReadOnly = true;
            this.id_curso.Visible = false;
            // 
            // nom_corto
            // 
            this.nom_corto.FillWeight = 75F;
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
            // puntos
            // 
            this.puntos.FillWeight = 40F;
            this.puntos.HeaderText = "Puntos";
            this.puntos.Name = "puntos";
            this.puntos.ReadOnly = true;
            // 
            // borrado
            // 
            this.borrado.HeaderText = "borrado";
            this.borrado.Name = "borrado";
            this.borrado.ReadOnly = true;
            this.borrado.Visible = false;
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditar.BackColor = System.Drawing.Color.Transparent;
            this.btnEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditar.BackgroundImage")));
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditar.Enabled = false;
            this.btnEditar.Location = new System.Drawing.Point(12, 383);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(60, 60);
            this.btnEditar.TabIndex = 44;
            this.toolTip1.SetToolTip(this.btnEditar, "Editar");
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 46;
            this.label1.Text = "Curso: ";
            // 
            // FrmObjetivosCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 455);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.lblCantEncontrado);
            this.Controls.Add(this.dgvObjetivos);
            this.Controls.Add(this.cmbCursos);
            this.Name = "FrmObjetivosCursos";
            this.Text = "FrmObjetivosCursos";
            this.Load += new System.EventHandler(this.FrmObjetivosCursos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjetivos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCantEncontrado;
        private System.Windows.Forms.ComboBox cmbCursos;
        internal System.Windows.Forms.DataGridView dgvObjetivos;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Objetivos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_corto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_largo;
        private System.Windows.Forms.DataGridViewTextBoxColumn puntos;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrado;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}