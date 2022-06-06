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
    public partial class FormFactura : Form
    {
        private FormPrincipal principal;
        private Cliente clienteAFacturar;
        private GestorDeArchivos gda;
        public FormFactura(FormPrincipal principal)
        {
            InitializeComponent();
            this.principal = principal;
            this.gda = new GestorDeArchivos();

        }

        private void btnBuscarEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                clienteAFacturar = principal.BuscarCliente(int.Parse(this.txtDniFacturar.Text));
                this.rtbFacturar.Text = clienteAFacturar.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Algo salió mal", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            try
            {
                gda.Escribir($"FacturaPara{clienteAFacturar.Nombre}.txt", InformacionDeFactura());
                principal.ActualizarFondos(float.Parse(this.txtMontoAFacturar.Text));                
                MessageBox.Show("Se realizo la facura correctamente", "Factura Generada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Algo salió mal", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string InformacionDeFactura()
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                sb.AppendLine("Factura Tipo " + clienteAFacturar.TipoDeFactura.ToString());
                sb.AppendLine("Cliente: " + clienteAFacturar.Nombre +", " +clienteAFacturar.Apellido);
                sb.AppendLine("Descripcion dela compra : \n" + this.rtbDescripcion.Text);
                sb.AppendLine("Monto total: " + (int.Parse(txtMontoAFacturar.Text)).ToString());

            }
            catch (Exception)
            {
                MessageBox.Show("Algo salió mal", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return sb.ToString();
        }


    }
}
