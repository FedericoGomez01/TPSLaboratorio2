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
    public partial class FormAgregar : Form
    {
        Cliente cliente;
        FormEliminar formEliminar;
        PintureriaDB DB;

        public delegate void AgregarCliente(Cliente cliente);
        private event AgregarCliente agregarCliente;

        public FormAgregar()
        {
            InitializeComponent();
            this.DB = new PintureriaDB();
        }
        public FormAgregar(AgregarCliente agregarCliente)
            : this()
        {
            this.agregarCliente += agregarCliente;
            this.btnModificar.Visible = false;

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
            this.cmbTipo.Items.Add(TipoFactura.A);
            this.cmbTipo.Items.Add(TipoFactura.B);
            this.cmbTipo.Items.Add(TipoFactura.C);
            this.cmbTipo.SelectedIndex = 0;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {

                cliente = new Cliente(int.Parse(this.txtDni.Text),this.txtNombre.Text, this.txtApellido.Text, this.txtEmail.Text, (TipoFactura)this.cmbTipo.SelectedIndex);
                if(cliente is not null)
                {
                    agregarCliente.Invoke(cliente);
                }
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

        public void ModificarCliente(Cliente cliente)
        {
            try
            {
                if(cliente is not null)
                {
                    this.txtNombre.Text = cliente.Nombre;
                    this.txtApellido.Text = cliente.Apellido;
                    this.txtDni.Text = cliente.Dni.ToString();
                    this.txtEmail.Text = cliente.Email;
                    this.cmbTipo.Text = cliente.TipoDeFactura.ToString();
                    this.btnAgregar.Visible = false;
                    this.btnModificar.Visible = true;
                    this.btnModificar.Location = new Point(53, 307);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Algo salió mal", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            btnAgregar_Click(sender, e);
        }
    }
}
