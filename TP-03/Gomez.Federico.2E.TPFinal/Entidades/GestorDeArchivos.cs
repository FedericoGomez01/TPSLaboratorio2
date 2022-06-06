using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class GestorDeArchivos : ILeerEscribir
    {
        private static string rutaBase;

        static GestorDeArchivos()
        {
            DirectoryInfo path = Directory.CreateDirectory($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\Facturas_Pintureria\\");
            GestorDeArchivos.rutaBase = path.FullName;
        }
        public string Leer(string ruta)
        {
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(GestorDeArchivos.rutaBase + "\\"+ ruta);
                return sr.ReadToEnd();

            }
            catch (Exception ex)
            {

                throw new ArchivoException("Error al escribir", ex);
            }
            finally
            {
                if(sr != null)
                {
                    sr.Close();
                }
            }
        }

        public void Escribir(string ruta, string informacion)
        {
            StreamWriter sw = null;
            try
            {
                string nuevaRuta = $"{GestorDeArchivos.rutaBase}\\{ruta}";
                sw =  new StreamWriter(nuevaRuta, true);
                sw.Write(informacion);
                
                
            }
            catch (Exception ex)
            {

                throw new ArchivoException("Error al escribir Archivo", ex) ;
            }
            finally
            {
                if(sw != null)
                {
                    sw.Close();
                }
            }
        }
    }
}
