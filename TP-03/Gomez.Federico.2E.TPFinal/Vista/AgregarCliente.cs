using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Vista
{
    public partial class AgregarCliente : Form
    {
        Cliente cliente;
        FormPrincipal principal;
        public AgregarCliente(FormPrincipal principal)
        {
            InitializeComponent();
            this.principal = principal;
        }

        private void NuevoClienteProveedor_Load(object sender, EventArgs e)
        {
            MostrarCargaDeDatos();
        }

        private void MostrarCargaDeDatos()
        {
            this.lblNombre.Visible = true;
            this.txtNombre.Visible = true;
            this.lblApellido.Visible = true;
            this.txtApellido.Visible = true;
            this.lblEmail.Visible = true;
            this.txtEmail.Visible = true;
            this.lblDni.Visible = true;
            this.txtDni.Visible = true;
            this.lblTipoFactura.Visible = true;
            this.cmbTipo.Visible = true;
            this.cmbTipo.Items.Add(Cliente.TipoFactura.A);
            this.cmbTipo.Items.Add(Cliente.TipoFactura.B);
            this.cmbTipo.Items.Add(Cliente.TipoFactura.C);


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {

                cliente = new Cliente(int.Parse(this.txtDni.Text),this.txtNombre.Text, this.txtApellido.Text, this.txtEmail.Text, (Cliente.TipoFactura)this.cmbTipo.SelectedIndex);
                principal.AgregarCliente(cliente);
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Algo salió mal", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
