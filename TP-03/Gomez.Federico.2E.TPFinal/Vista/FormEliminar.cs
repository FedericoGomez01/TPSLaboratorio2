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
        private FormPrincipal principal;
        Cliente clienteAEliminar;
        public FormEliminar(FormPrincipal principal)
        {
            InitializeComponent();
            this.principal = principal;
        }

        private void btnBuscarEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                this.clienteAEliminar = principal.BuscarCliente(int.Parse(this.txtPatenteEliminar.Text));
                this.rtbEliminar.Text =  clienteAEliminar.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Algo salió mal", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                principal.EliminarCliente(this.clienteAEliminar);
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Algo salió mal", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
