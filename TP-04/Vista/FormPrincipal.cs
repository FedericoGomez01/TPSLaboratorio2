using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Vista
{

    public partial class FormPrincipal : Form
    {
        private FormAgregar formAgregar;
        private FormEliminar formEliminar;
        public Pintureria<Cliente> pintureria;
        private FormFactura formFactura;
        public float fondos;
        CancellationTokenSource cancellation;
        DateTime tiempo;
        private PintureriaDB DB;

        public FormPrincipal()
        {
            InitializeComponent();
            this.pintureria = new Pintureria<Cliente>();
            this.fondos = Pintureria<Cliente>.FondoActual;
            this.DB = new PintureriaDB();
            this.tiempo = new DateTime();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            this.ActualizarFondos(this.fondos); 
            this.cancellation = new CancellationTokenSource();
            CancellationToken cancellationToken = cancellation.Token;
            Task.Run(() => AbrirPinruteria(cancellation), cancellationToken);
            //this.pintureria.Clientes = this.DB.ObtenerListaClientes();
            //this.ActualizarInformacionCliente();
            this.pintureria.Clientes = this.DB.ObtenerListaClientes();
            this.ActualizarInformacionCliente();
        }

        private void ActualizarHora()
        {
            if (this.InvokeRequired)
            {
                Action callback = new Action(ActualizarHora);
                this.BeginInvoke(callback);
            }
            else
            {
                this.lblPintureriaAbierta.Text = $"Pintureria abrierta : {DateTime.Now}";
                this.tiempo = DateTime.Now;
            }
        }
        private void AbrirPinruteria(CancellationTokenSource cancellation)
        {
            do
            {
                this.ActualizarHora();
                Thread.Sleep(1000);
            } while (!cancellation.IsCancellationRequested);
        }


        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show($"Hora de cierre: {this.tiempo}", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.cancellation.Cancel();
        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            formAgregar = new FormAgregar(AgregarCliente);
            formAgregar.Show();
            
        }

       
        public void ActualizarInformacionCliente()
        {
            try
            {
                this.rtbInformacionClientes.Text = "";
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
                this.DB.AgregarCliente(cliente);
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
                Pintureria<Cliente>.FondoActual = fondos;
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
                this.DB.EliminarCliente(cliente.Dni);
                ActualizarInformacionCliente();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Debe ingresar un cliente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
                this.formEliminar = new FormEliminar(EliminarCliente, BuscarCliente, this);
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
