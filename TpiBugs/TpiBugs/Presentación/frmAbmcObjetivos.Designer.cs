namespace TpiBugs.Presentación
{
    partial class frmAbmcObjetivos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbmcObjetivos));
            this.panel = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblError = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtLargo = new System.Windows.Forms.TextBox();
            this.txtCorto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.panel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.panel5);
            this.panel.Controls.Add(this.panelBarraTitulo);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(477, 201);
            this.panel.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.lblError);
            this.panel5.Controls.Add(this.btnCancelar);
            this.panel5.Controls.Add(this.btnAceptar);
            this.panel5.Controls.Add(this.txtLargo);
            this.panel5.Controls.Add(this.txtCorto);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 24);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(477, 177);
            this.panel5.TabIndex = 1;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblError.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.lblError.Image = ((System.Drawing.Image)(resources.GetObject("lblError.Image")));
            this.lblError.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblError.Location = new System.Drawing.Point(115, 96);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(52, 14);
            this.lblError.TabIndex = 8;
            this.lblError.Text = "lblError";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblError.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.btnCancelar.Location = new System.Drawing.Point(356, 128);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(91, 31);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.btnAceptar.Location = new System.Drawing.Point(259, 128);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(91, 31);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar2_Click);
            // 
            // txtLargo
            // 
            this.txtLargo.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.txtLargo.Location = new System.Drawing.Point(145, 56);
            this.txtLargo.MaxLength = 100;
            this.txtLargo.Name = "txtLargo";
            this.txtLargo.Size = new System.Drawing.Size(302, 26);
            this.txtLargo.TabIndex = 3;
            // 
            // txtCorto
            // 
            this.txtCorto.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.txtCorto.Location = new System.Drawing.Point(145, 21);
            this.txtCorto.MaxLength = 50;
            this.txtCorto.Name = "txtCorto";
            this.txtCorto.Size = new System.Drawing.Size(302, 26);
            this.txtCorto.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.label4.Location = new System.Drawing.Point(12, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nombre Largo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.label3.Location = new System.Drawing.Point(12, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombre Corto";
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
            this.panelBarraTitulo.Size = new System.Drawing.Size(477, 24);
            this.panelBarraTitulo.TabIndex = 0;
            this.panelBarraTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBarraTitulo2_Paint);
            this.panelBarraTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelBarraTitulo_MouseMove);
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
            this.btnCerrar.Location = new System.Drawing.Point(456, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(16, 16);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar2_Click);
            this.btnCerrar.MouseEnter += new System.EventHandler(this.btnCerrar_MouseEnter);
            this.btnCerrar.MouseLeave += new System.EventHandler(this.btnCerrar_MouseLeave);
            // 
            // frmAbmcObjetivos
            // 
            this.ClientSize = new System.Drawing.Size(477, 201);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAbmcObjetivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmAbmcObjetivos_Load);
            this.panel.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panelBarraTitulo.ResumeLayout(false);
            this.panelBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Panel panelBarraTitulo;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtLargo;
        private System.Windows.Forms.TextBox txtCorto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblError;
    }
}