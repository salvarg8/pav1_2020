﻿namespace TpiBugs.Presentación
{
    partial class FrmCategorias
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCategorias));
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.id_categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.chbBuscarTodos = new System.Windows.Forms.CheckBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblCantEncontrado = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.AllowUserToAddRows = false;
            this.dgvCategorias.AllowUserToDeleteRows = false;
            this.dgvCategorias.AllowUserToResizeRows = false;
            this.dgvCategorias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCategorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategorias.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategorias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_categoria,
            this.nombre,
            this.descripcion,
            this.borrado});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(130)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCategorias.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCategorias.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvCategorias.Location = new System.Drawing.Point(12, 128);
            this.dgvCategorias.MultiSelect = false;
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.ReadOnly = true;
            this.dgvCategorias.RowHeadersVisible = false;
            this.dgvCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategorias.Size = new System.Drawing.Size(547, 289);
            this.dgvCategorias.TabIndex = 39;
            this.dgvCategorias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategorias_CellClick);
            // 
            // id_categoria
            // 
            this.id_categoria.HeaderText = "id";
            this.id_categoria.Name = "id_categoria";
            this.id_categoria.ReadOnly = true;
            this.id_categoria.Visible = false;
            // 
            // nombre
            // 
            this.nombre.FillWeight = 60F;
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // borrado
            // 
            this.borrado.HeaderText = "Borrado";
            this.borrado.Name = "borrado";
            this.borrado.ReadOnly = true;
            this.borrado.Visible = false;
            // 
            // btnBuscar
            // 
//<<<<<<< HEAD
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.BackgroundImage")));
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(505, 30);
//=======
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnBuscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.BackgroundImage")));
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Location = new System.Drawing.Point(499, 30);
//>>>>>>> 351f32fd6bdf2aa3690255d654df63e1796f148b
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(60, 60);
            this.btnBuscar.TabIndex = 38;
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.toolTip1.SetToolTip(this.btnBuscar, "Buscar");
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // chbBuscarTodos
            // 
            this.chbBuscarTodos.AutoSize = true;
            this.chbBuscarTodos.Font = new System.Drawing.Font("Verdana", 11F);
            this.chbBuscarTodos.Location = new System.Drawing.Point(132, 75);
            this.chbBuscarTodos.Name = "chbBuscarTodos";
            this.chbBuscarTodos.Size = new System.Drawing.Size(185, 22);
            this.chbBuscarTodos.TabIndex = 37;
            this.chbBuscarTodos.Text = "Buscar Con Borrados";
            this.chbBuscarTodos.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(132, 30);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(233, 31);
            this.txtNombre.TabIndex = 35;
            this.txtNombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNombre_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11F);
            this.label2.Location = new System.Drawing.Point(40, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 18);
            this.label2.TabIndex = 33;
            this.label2.Text = "Catergoría";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEliminar.BackColor = System.Drawing.Color.White;
            this.btnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.BackgroundImage")));
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.Enabled = false;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(144, 423);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(60, 60);
            this.btnEliminar.TabIndex = 31;
            this.toolTip1.SetToolTip(this.btnEliminar, "Eliminar");
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditar.BackColor = System.Drawing.Color.White;
            this.btnEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditar.BackgroundImage")));
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditar.Enabled = false;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Location = new System.Drawing.Point(78, 423);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(60, 60);
            this.btnEditar.TabIndex = 30;
            this.toolTip1.SetToolTip(this.btnEditar, "Editar");
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregar.BackColor = System.Drawing.Color.White;
            this.btnAgregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregar.BackgroundImage")));
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Location = new System.Drawing.Point(12, 423);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(60, 60);
            this.btnAgregar.TabIndex = 29;
            this.toolTip1.SetToolTip(this.btnAgregar, "Agregar");
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblCantEncontrado
            // 
            this.lblCantEncontrado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCantEncontrado.AutoSize = true;
            this.lblCantEncontrado.Font = new System.Drawing.Font("Verdana", 11F);
            this.lblCantEncontrado.Location = new System.Drawing.Point(332, 423);
            this.lblCantEncontrado.Name = "lblCantEncontrado";
            this.lblCantEncontrado.Size = new System.Drawing.Size(227, 18);
            this.lblCantEncontrado.TabIndex = 40;
            this.lblCantEncontrado.Text = "Categorias Encontradas: 100";
            this.lblCantEncontrado.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.chbBuscarTodos);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(571, 116);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Categoria con Filtro";
            // 
            // FrmCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//<<<</<<< HEAD
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(577, 495);
//=======
            this.ClientSize = new System.Drawing.Size(571, 495);
            this.Controls.Add(this.groupBox1);
//>>>>>>> 351f32fd6bdf2aa3690255d654df63e1796f148b
            this.Controls.Add(this.lblCantEncontrado);
            this.Controls.Add(this.dgvCategorias);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Name = "FrmCategorias";
            this.Text = "FrmCategorias";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.DataGridView dgvCategorias;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrado;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.CheckBox chbBuscarTodos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblCantEncontrado;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}