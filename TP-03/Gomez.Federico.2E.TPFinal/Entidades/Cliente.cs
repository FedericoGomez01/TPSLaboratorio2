using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        public enum TipoFactura { A, B, C };
        private int dni;
        private string nombre;
        private string apellido;
        private string email;
        private TipoFactura tipoFactura;

        public int Dni { get => dni; set => dni=value; }
        public string Nombre { get => nombre; set => nombre=value; }
        public string Apellido { get => apellido; set => apellido=value; }
        public string Email { get => email; set => email=value; }
        public TipoFactura TipoDeFactura { get => tipoFactura; set => tipoFactura=value; }

        public Cliente(string nombre, string apellido, string email,  TipoFactura tipo)
        {
            this.Nombre=nombre;
            this.Apellido=apellido;
            this.Email=email;
            this.TipoDeFactura=tipo;
        }
        public Cliente(int dni, string nombre, string apellido, string email, TipoFactura tipo)
            : this(nombre, apellido, email, tipo)
        {
            this.Dni=dni;
        }

        public Cliente() { }

        public static bool operator ==(Cliente c1, Cliente c2)
        {

            return c1.Dni == c2.Dni;

        }

        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1 == c2);
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("-------------------------------");
            sb.AppendLine("Nombre: " + this.Nombre);
            sb.AppendLine("Apellido: " + this.Apellido);
            sb.AppendLine("Email: " + this.Email);
            sb.AppendLine("Tipo: " + this.TipoDeFactura);
            sb.AppendLine("Dni: " + this.Dni);
            sb.AppendLine("-------------------------------");
            return sb.ToString();
        }
    }
}
