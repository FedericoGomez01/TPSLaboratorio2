namespace Vista
{
    partial class FormEliminar
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
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBuscarEliminar = new System.Windows.Forms.Button();
            this.rtbEliminar = new System.Windows.Forms.RichTextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lblDniEliminar = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.btnBuscarEliminar);
            this.groupBox1.Controls.Add(this.rtbEliminar);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.txtDni);
            this.groupBox1.Controls.Add(this.lblDniEliminar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(689, 321);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eliminar Cliente";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(51, 199);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(197, 43);
            this.btnModificar.TabIndex = 10;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnBuscarEliminar
            // 
            this.btnBuscarEliminar.Location = new System.Drawing.Point(51, 75);
            this.btnBuscarEliminar.Name = "btnBuscarEliminar";
            this.btnBuscarEliminar.Size = new System.Drawing.Size(197, 35);
            this.btnBuscarEliminar.TabIndex = 9;
            this.btnBuscarEliminar.Text = "Buscar Cliente por DNI";
            this.btnBuscarEliminar.UseVisualStyleBackColor = true;
            this.btnBuscarEliminar.Click += new System.EventHandler(this.btnBuscarEliminar_Click);
            // 
            // rtbEliminar
            // 
            this.rtbEliminar.Location = new System.Drawing.Point(262, 34);
            this.rtbEliminar.Margin = new System.Windows.Forms.Padding(1);
            this.rtbEliminar.Name = "rtbEliminar";
            this.rtbEliminar.Size = new System.Drawing.Size(402, 261);
            this.rtbEliminar.TabIndex = 8;
            this.rtbEliminar.Text = "";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.IndianRed;
            this.btnEliminar.Location = new System.Drawing.Point(51, 248);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(197, 43);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(51, 34);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(197, 27);
            this.txtDni.TabIndex = 4;
            // 
            // lblDniEliminar
            // 
            this.lblDniEliminar.AutoSize = true;
            this.lblDniEliminar.Location = new System.Drawing.Point(8, 37);
            this.lblDniEliminar.Name = "lblDniEliminar";
            this.lblDniEliminar.Size = new System.Drawing.Size(38, 20);
            this.lblDniEliminar.TabIndex = 2;
            this.lblDniEliminar.Text = "DNI:";
            // 
            // FormEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 346);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEliminar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar Cliente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscarEliminar;
        private System.Windows.Forms.RichTextBox rtbEliminar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lblDniEliminar;
        private System.Windows.Forms.Button btnModificar;
    }
}