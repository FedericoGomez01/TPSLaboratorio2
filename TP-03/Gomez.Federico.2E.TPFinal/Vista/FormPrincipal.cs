using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Vista
{
    public partial class FormPrincipal : Form
    {
        private AgregarCliente formAgregar;
        private FormEliminar formEliminar;
        public Pintureria pintureria;
        private GestorDeArchivos gda;
        private FormFactura formFactura;
        public float fondos;
        public FormPrincipal()
        {
            InitializeComponent();
            this.pintureria = new Pintureria();
            this.gda = new GestorDeArchivos();
            this.fondos = Pintureria.FondoActual;
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            this.ActualizarFondos(this.fondos);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            formAgregar = new AgregarCliente(this);
            formAgregar.Show();
        }

       
        public void ActualizarInformacionCliente()
        {
            try
            {
                if (this.pintureria.Clientes.Count != 0)
                {
                    foreach (Cliente c in this.pintureria.Clientes)
                    {
                        this.rtbInformacionClientes.Text += c.ToString();
                    }
                }
                else
                {
                    this.rtbInformacionClientes.Text = string.Empty;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Algo salió mal", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        public void AgregarCliente(Cliente cliente)
        {
            try
            {
                this.pintureria += cliente;
                this.rtbInformacionClientes.Text = "";
                ActualizarInformacionCliente();
            }
            catch (Exception)
            {
                MessageBox.Show("Algo salió mal", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void ActualizarFondos(float fondo)
        {
            try
            {

                this.fondos += fondo;
                Pintureria.FondoActual = fondos;
                this.lblFondos.Text = $"Fondos: {this.fondos}";
            }
            catch (Exception)
            {

                MessageBox.Show("Algo salió mal", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Cliente BuscarCliente(int dni)
        {
            try
            {
                foreach (Cliente c in this.pintureria.Clientes)
                {
                    if (c.Dni == dni)
                    {
                        return c;
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Algo salió mal", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }
        public void EliminarCliente(Cliente cliente)
        {
            try
            {
                this.pintureria -= cliente;
                this.rtbInformacionClientes.Text = "";
                ActualizarInformacionCliente();
            }
            catch (Exception)
            {
                MessageBox.Show("Algo salió mal", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {

                this.formEliminar = new FormEliminar(this);
                this.formEliminar.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Algo salió mal", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog archivo = new OpenFileDialog();
            archivo.Filter = " |*.json";
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    pintureria.Clientes = Serializadora.DesSerializar_JSON(archivo.FileName);
                    //pintureria += c;
                    ActualizarInformacionCliente();

                }
                catch (Exception)
                {
                    MessageBox.Show("Algo salió mal", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                Serializadora.Serializar_JSON("PintureriaClientes.json", pintureria.Clientes);
                /*
                foreach (Cliente cliente in pintureria.Clientes)
                {
                }
                */
                MessageBox.Show("El archivo se guardo con exito", "ARCHIVO GUARDADO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception)
            {
                MessageBox.Show("Algo salió mal", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                this.formFactura = new FormFactura(this);
                this.formFactura.Show();

            }
            catch (Exception)
            {
                MessageBox.Show("Algo salió mal", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
