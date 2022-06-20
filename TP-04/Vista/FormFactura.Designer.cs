namespace Vista
{
    partial class FormFactura
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.rtbDescripcion = new System.Windows.Forms.RichTextBox();
            this.rtbFacturar = new System.Windows.Forms.RichTextBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.txtMontoAFacturar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.txtDniFacturar = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCliente);
            this.groupBox1.Controls.Add(this.lblDescripcion);
            this.groupBox1.Controls.Add(this.rtbDescripcion);
            this.groupBox1.Controls.Add(this.rtbFacturar);
            this.groupBox1.Controls.Add(this.lblMonto);
            this.groupBox1.Controls.Add(this.txtMontoAFacturar);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.btnFacturar);
            this.groupBox1.Controls.Add(this.txtDniFacturar);
            this.groupBox1.Controls.Add(this.lblDni);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(689, 503);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccionar Cliente";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(51, 304);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(123, 20);
            this.lblCliente.TabIndex = 15;
            this.lblCliente.Text = "Cliente a Facturar";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(51, 178);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(179, 20);
            this.lblDescripcion.TabIndex = 14;
            this.lblDescripcion.Text = "Descripcion de la compra";
            // 
            // rtbDescripcion
            // 
            this.rtbDescripcion.Location = new System.Drawing.Point(51, 214);
            this.rtbDescripcion.Multiline = false;
            this.rtbDescripcion.Name = "rtbDescripcion";
            this.rtbDescripcion.Size = new System.Drawing.Size(565, 60);
            this.rtbDescripcion.TabIndex = 13;
            this.rtbDescripcion.Text = "";
            // 
            // rtbFacturar
            // 
            this.rtbFacturar.Location = new System.Drawing.Point(51, 336);
            this.rtbFacturar.Name = "rtbFacturar";
            this.rtbFacturar.ReadOnly = true;
            this.rtbFacturar.Size = new System.Drawing.Size(565, 137);
            this.rtbFacturar.TabIndex = 12;
            this.rtbFacturar.Text = "";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(431, 37);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(121, 20);
            this.lblMonto.TabIndex = 11;
            this.lblMonto.Text = "Monto a Facturar";
            // 
            // txtMontoAFacturar
            // 
            this.txtMontoAFacturar.Location = new System.Drawing.Point(347, 71);
            this.txtMontoAFacturar.Name = "txtMontoAFacturar";
            this.txtMontoAFacturar.Size = new System.Drawing.Size(269, 27);
            this.txtMontoAFacturar.TabIndex = 10;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(51, 112);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(197, 35);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar Cliente por DNI";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscarEliminar_Click);
            // 
            // btnFacturar
            // 
            this.btnFacturar.Location = new System.Drawing.Point(347, 112);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(269, 35);
            this.btnFacturar.TabIndex = 7;
            this.btnFacturar.Text = "Facturar";
            this.btnFacturar.UseVisualStyleBackColor = true;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // txtDniFacturar
            // 
            this.txtDniFacturar.Location = new System.Drawing.Point(51, 71);
            this.txtDniFacturar.Name = "txtDniFacturar";
            this.txtDniFacturar.Size = new System.Drawing.Size(197, 27);
            this.txtDniFacturar.TabIndex = 4;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(122, 37);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(38, 20);
            this.lblDni.TabIndex = 2;
            this.lblDni.Text = "DNI:";
            // 
            // FormFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 550);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generar Factura";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.TextBox txtDniFacturar;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.RichTextBox rtbFacturar;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.TextBox txtMontoAFacturar;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.RichTextBox rtbDescripcion;
        private System.Windows.Forms.Label lblCliente;
    }
}