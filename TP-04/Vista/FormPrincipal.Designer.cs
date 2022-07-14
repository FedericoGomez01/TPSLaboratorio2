namespace Vista
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnBorrarModificar = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.lblFondos = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rtbInformacionClientes = new System.Windows.Forms.RichTextBox();
            this.lblPintureriaAbierta = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(13, 586);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(246, 43);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo Cliente";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnBorrarModificar
            // 
            this.btnBorrarModificar.Location = new System.Drawing.Point(507, 586);
            this.btnBorrarModificar.Name = "btnBorrarModificar";
            this.btnBorrarModificar.Size = new System.Drawing.Size(246, 43);
            this.btnBorrarModificar.TabIndex = 1;
            this.btnBorrarModificar.Text = "Borrar / Modificar";
            this.btnBorrarModificar.UseVisualStyleBackColor = true;
            this.btnBorrarModificar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(560, 81);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(193, 43);
            this.btnGenerar.TabIndex = 4;
            this.btnGenerar.Text = "Generar Factura";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // lblFondos
            // 
            this.lblFondos.AutoSize = true;
            this.lblFondos.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFondos.Location = new System.Drawing.Point(13, 72);
            this.lblFondos.Name = "lblFondos";
            this.lblFondos.Size = new System.Drawing.Size(146, 46);
            this.lblFondos.TabIndex = 5;
            this.lblFondos.Text = "Fondos: ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(770, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.guardarToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // rtbInformacionClientes
            // 
            this.rtbInformacionClientes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rtbInformacionClientes.Location = new System.Drawing.Point(13, 142);
            this.rtbInformacionClientes.Name = "rtbInformacionClientes";
            this.rtbInformacionClientes.ReadOnly = true;
            this.rtbInformacionClientes.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbInformacionClientes.Size = new System.Drawing.Size(740, 421);
            this.rtbInformacionClientes.TabIndex = 4;
            this.rtbInformacionClientes.Text = "";
            // 
            // lblPintureriaAbierta
            // 
            this.lblPintureriaAbierta.AutoSize = true;
            this.lblPintureriaAbierta.Location = new System.Drawing.Point(163, 40);
            this.lblPintureriaAbierta.Name = "lblPintureriaAbierta";
            this.lblPintureriaAbierta.Size = new System.Drawing.Size(132, 20);
            this.lblPintureriaAbierta.TabIndex = 7;
            this.lblPintureriaAbierta.Text = "Pintureria abrierta ";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 641);
            this.Controls.Add(this.lblPintureriaAbierta);
            this.Controls.Add(this.rtbInformacionClientes);
            this.Controls.Add(this.lblFondos);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.btnBorrarModificar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pintureria";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnBorrarModificar;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label lblFondos;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.RichTextBox rtbInformacionClientes;
        private System.Windows.Forms.Label lblPintureriaAbierta;
    }
}
