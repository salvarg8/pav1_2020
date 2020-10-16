namespace TpiBugs.Presentación
{
    partial class FrmObjetivos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmObjetivos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvObjetivos = new System.Windows.Forms.DataGridView();
            this.Id_Objetivos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_corto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_largo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.chbBuscarTodos = new System.Windows.Forms.CheckBox();
            this.txtNombreLargo = new System.Windows.Forms.TextBox();
            this.txtNombreCorto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCantEncontrado = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjetivos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregar.BackgroundImage")));
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregar.Location = new System.Drawing.Point(12, 423);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(60, 60);
            this.btnAgregar.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnAgregar, "Agregar");
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditar.BackColor = System.Drawing.Color.Transparent;
            this.btnEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditar.BackgroundImage")));
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditar.Location = new System.Drawing.Point(78, 423);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(60, 60);
            this.btnEditar.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnEditar, "Editar");
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.BackgroundImage")));
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.Location = new System.Drawing.Point(144, 423);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(60, 60);
            this.btnEliminar.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnEliminar, "Eliminar");
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvObjetivos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvObjetivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObjetivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Objetivos,
            this.nom_corto,
            this.nom_largo,
            this.borrado});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(130)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvObjetivos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvObjetivos.Location = new System.Drawing.Point(12, 133);
            this.dgvObjetivos.MultiSelect = false;
            this.dgvObjetivos.Name = "dgvObjetivos";
            this.dgvObjetivos.ReadOnly = true;
            this.dgvObjetivos.RowHeadersVisible = false;
            this.dgvObjetivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvObjetivos.Size = new System.Drawing.Size(553, 284);
            this.dgvObjetivos.TabIndex = 15;
            this.dgvObjetivos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvObjetivos_CellClick);
            this.dgvObjetivos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvObjetivos_CellContentClick);
            this.dgvObjetivos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvObjetivos_CellDoubleClick);
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
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.BackgroundImage")));
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Location = new System.Drawing.Point(505, 67);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(60, 60);
            this.btnBuscar.TabIndex = 14;
            this.toolTip1.SetToolTip(this.btnBuscar, "Buscar");
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // chbBuscarTodos
            // 
            this.chbBuscarTodos.AutoSize = true;
            this.chbBuscarTodos.Font = new System.Drawing.Font("Verdana", 11F);
            this.chbBuscarTodos.Location = new System.Drawing.Point(196, 104);
            this.chbBuscarTodos.Name = "chbBuscarTodos";
            this.chbBuscarTodos.Size = new System.Drawing.Size(185, 22);
            this.chbBuscarTodos.TabIndex = 13;
            this.chbBuscarTodos.Text = "Buscar Con Borrados";
            this.chbBuscarTodos.UseVisualStyleBackColor = true;
            // 
            // txtNombreLargo
            // 
            this.txtNombreLargo.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreLargo.Location = new System.Drawing.Point(172, 67);
            this.txtNombreLargo.Name = "txtNombreLargo";
            this.txtNombreLargo.Size = new System.Drawing.Size(233, 31);
            this.txtNombreLargo.TabIndex = 12;
            // 
            // txtNombreCorto
            // 
            this.txtNombreCorto.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCorto.Location = new System.Drawing.Point(172, 30);
            this.txtNombreCorto.Name = "txtNombreCorto";
            this.txtNombreCorto.Size = new System.Drawing.Size(233, 31);
            this.txtNombreCorto.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11F);
            this.label3.Location = new System.Drawing.Point(51, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nombre Largo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11F);
            this.label2.Location = new System.Drawing.Point(50, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre Corto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11F);
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Filtros";
            // 
            // lblCantEncontrado
            // 
            this.lblCantEncontrado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCantEncontrado.AutoSize = true;
            this.lblCantEncontrado.Font = new System.Drawing.Font("Verdana", 11F);
            this.lblCantEncontrado.Location = new System.Drawing.Point(341, 423);
            this.lblCantEncontrado.Name = "lblCantEncontrado";
            this.lblCantEncontrado.Size = new System.Drawing.Size(224, 18);
            this.lblCantEncontrado.TabIndex = 16;
            this.lblCantEncontrado.Text = "Objetivos encontrados:  100";
            this.lblCantEncontrado.Visible = false;
            // 
            // FrmObjetivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(577, 495);
            this.Controls.Add(this.lblCantEncontrado);
            this.Controls.Add(this.dgvObjetivos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.chbBuscarTodos);
            this.Controls.Add(this.txtNombreLargo);
            this.Controls.Add(this.txtNombreCorto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Name = "FrmObjetivos";
            this.Text = "FrmObjetivos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmObjetivos_FormClosed);
            this.Load += new System.EventHandler(this.FrmObjetivos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjetivos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.CheckBox chbBuscarTodos;
        private System.Windows.Forms.TextBox txtNombreLargo;
        private System.Windows.Forms.TextBox txtNombreCorto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.DataGridView dgvObjetivos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Objetivos;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_corto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_largo;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrado;
        private System.Windows.Forms.Label lblCantEncontrado;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}