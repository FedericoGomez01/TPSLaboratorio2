using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Entidades
{
    public class Serializadora
    {
        private static string rutaBase;
        static Serializadora()
        {
            DirectoryInfo path = Directory.CreateDirectory($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\Archivos_Pintureria\\");
            Serializadora.rutaBase = path.FullName;
        }
        public static void Serializar_JSON(string nombreArchivo, List<Cliente> clientes)
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter($"{Serializadora.rutaBase}{nombreArchivo}"))
                {
                    JsonSerializerOptions options = new JsonSerializerOptions();
                    options.WriteIndented = true;
                    string ser = JsonSerializer.Serialize(clientes);
                    streamWriter.WriteLine(ser);
                }
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }
        }

        public static List<Cliente> DesSerializar_JSON(string nombreArchivo)
        {
            try
            {
                using (StreamReader streamReader = new StreamReader($"{nombreArchivo}"))
                {
                    string json = streamReader.ReadToEnd();
                    return JsonSerializer.Deserialize<List<Cliente>>(json);
                }
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }
        }
    }
}
