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
    public partial class FormEliminar : Form
    {

        public delegate void EliminarCliente(Cliente cliente);
        private event EliminarCliente eliminarCliente;

        public delegate Cliente BuscarCliente(int CienteID);
        private event BuscarCliente buscarCliente;

        private FormAgregar formAgregar;
        private FormPrincipal formPrincipal;


        //private Pintureria<Cliente> pintureria;

        Cliente cliente;
        public FormEliminar()
        {
            InitializeComponent();
        }
        
        public FormEliminar(EliminarCliente eliminarCliente, BuscarCliente buscarCliente, FormPrincipal principal)
            :this()
        {
            this.eliminarCliente = eliminarCliente;
            this.buscarCliente = buscarCliente;
            this.formPrincipal = principal;   
            
        }


        private void btnBuscarEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if(buscarCliente is not null)
                {
                    this.cliente = buscarCliente.Invoke(int.Parse(this.txtDni.Text));
                    this.rtbEliminar.Text =  cliente.ToString();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Debe ingresar un DNI", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Debe ingresar un cliente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                btnBuscarEliminar_Click(sender, e);
                if(eliminarCliente is not null)
                {
                    DialogResult result = MessageBox.Show("Esta seguro que desea eliminar este cliente?\n" +
                        $"{this.cliente.Nombre}, {this.cliente.Apellido}, con Dni: {this.cliente.Dni}", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        this.eliminarCliente.Invoke(this.cliente);

                    }
                }
                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Debe ingresar un DNI", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Debe ingresar todos los datos del cliente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception)
            {
                MessageBox.Show("Algo salió mal", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                btnBuscarEliminar_Click(sender, e);
                if (this.cliente is not null && this.eliminarCliente is not null)
                {
                    this.formAgregar = new FormAgregar(formPrincipal.AgregarCliente);
                    this.formAgregar.Text = "Modificar Cliente";
                    this.formAgregar.ModificarCliente(this.cliente);
                    this.formAgregar.ShowDialog();
                    Cliente clienteAuxiliar = this.formAgregar.GetCliente;
                    if(clienteAuxiliar is not null)
                    {
                        
                        this.formPrincipal.pintureria -= this.cliente;
                        this.formPrincipal.pintureria += clienteAuxiliar;
                    }
                    this.formPrincipal.ActualizarInformacionCliente();
                    this.Close();
                }
                
            }
            catch (FormatException)
            {
                MessageBox.Show("Debe ingresar un DNI", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Debe ingresar todos los datos del cliente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception)
            {
                MessageBox.Show("Algo salio mal", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


    }
}
