using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface ILeerEscribir
    {

        public void Escribir(string ruta, string informacion);

        public string Leer(string ruta);

    }
}
