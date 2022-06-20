using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pintureria<T>
        where T : Cliente
    {
        private static float fondoActual;
        private List<T> clientes;
        private int clientesAtendidos;


        private delegate void AbrirPintureria();
        private delegate void Cerrar();

        private event AbrirPintureria PintureriaAbierta;
        private event Cerrar PintureriaCerrada;

        public Pintureria()
            : this(0)
        {
            this.clientes = new List<T>();
            
        }

        public Pintureria(int fondoActual)
        {
            Pintureria<T>.fondoActual = fondoActual;
        }
        public List<T> Clientes { get => clientes; set => clientes=value; }

        public static float FondoActual { get => fondoActual; set => fondoActual=value; }
        public int ClientesAtendidos { get => clientesAtendidos; set => clientesAtendidos=value; }

        public static Pintureria<T> operator +(Pintureria<T> pintureria, T item)
        {
            bool clienteCargado = false;
            foreach (T i in pintureria.clientes)
            {
                if (i == item)
                {
                    clienteCargado = true;
                }
            }
            if (!clienteCargado)
            {
                pintureria.clientes.Add(item);
            }
            return pintureria;
        }


        public static Pintureria<T> operator -(Pintureria<T> pintureria, T item)
        {
            bool clienteCargado = true;
            foreach (T c in pintureria.clientes)
            {
                if (c == item)
                {
                    clienteCargado = false;
                }
            }
            if (!clienteCargado)
            {
                pintureria.clientes.Remove(item);
            }
            return pintureria;
        }




        public static float ActualizarFondos(string c, float numero)
        {
            switch (c)
            {
                case "+":
                    return Pintureria<T>.fondoActual += numero;
                case "-":
                    return Pintureria<T>.fondoActual -= numero;
                default:
                    return Pintureria<T>.fondoActual;
            }
        }



    }
}
