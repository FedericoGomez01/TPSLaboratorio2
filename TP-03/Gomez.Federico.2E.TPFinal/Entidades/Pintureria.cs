using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pintureria
    {
        private static float fondoActual;
        private List<Cliente> clientes;

        public Pintureria()
            : this(0)
        {
            this.clientes = new List<Cliente>();

        }

        public Pintureria(int fondoActual)
        {
            Pintureria.fondoActual = fondoActual;
        }
        public List<Cliente> Clientes { get => clientes; set => clientes=value; }

        public static float FondoActual { get => fondoActual; set => fondoActual=value; }

        
        public static Pintureria operator +(Pintureria pintureria, Cliente cliente)
        {
            bool clienteCargado = false;
            foreach (Cliente c in pintureria.clientes)
            {
                if (c == cliente)
                {
                    clienteCargado = true;
                }
            }
            if (!clienteCargado)
            {
                pintureria.clientes.Add(cliente);
            }
            return pintureria;
        }


        public static Pintureria operator -(Pintureria pintureria, Cliente cliente)
        {
            bool clienteCargado = true;
            foreach (Cliente c in pintureria.clientes)
            {
                if (c == cliente)
                {
                    clienteCargado = false;
                }
            }
            if (!clienteCargado)
            {
                pintureria.clientes.Remove(cliente);
            }
            return pintureria;
        }

        public static float ActualizarFondos(string c, float numero)
        {
            switch (c)
            {
                case "+":
                    return Pintureria.fondoActual += numero;
                case "-":
                    return Pintureria.fondoActual -= numero;
                default:
                    return Pintureria.fondoActual;
            }
        }
    }
}
