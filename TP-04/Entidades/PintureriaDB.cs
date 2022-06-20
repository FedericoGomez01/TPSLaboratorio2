using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PintureriaDB
    {

        private static string cadenaConexion;
        private static SqlConnection conexion;
        private static SqlCommand comando;
        private static SqlDataReader lector;

        static PintureriaDB()
        {
            PintureriaDB.cadenaConexion = @"Server=.;Database=PintureriaDB;Trusted_Connection=True;";

        }

        public PintureriaDB()
        {
            conexion = new SqlConnection(PintureriaDB.cadenaConexion);
        }


        public List<Cliente> ObtenerListaAlumnos()
        {
            List<Cliente> lista = new List<Cliente>();

            try
            {
                comando = new SqlCommand();

                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT * FROM dbo.Cliente";
                comando.Connection = conexion;

                conexion.Open();

                lector = comando.ExecuteReader();

                while (lector.Read())
                {

                    Cliente item = new Cliente();
                    item.Dni = int.Parse(lector["Dni"].ToString());
                    item.Nombre = lector["Nombre"].ToString();
                    item.Apellido = lector["Apellido"].ToString();
                    item.Email = lector["Email"].ToString();
                    item.TipoDeFactura = (TipoFactura)Enum.Parse(typeof(TipoFactura), lector["TipoDeFactura"].ToString());
                    lista.Add(item);
                }
                lector.Close();
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return lista;
        }

        public bool AgregarCliente(Cliente param)
        {
            bool rta = true;

            try
            {
                string sql = "INSERT INTO Cliente (Nombre, Apellido, Dni,Email,TipoDeFactura) VALUES" +
                    "('"+ param.Nombre +"',' "+ param.Apellido +"', '"+  param.Dni.ToString() + "','" + param.Email + "','" + param.TipoDeFactura.ToString() + "');";

                comando = new SqlCommand();
                comando.CommandType = CommandType.Text;

                comando.Parameters.AddWithValue("@Nombre", param.Nombre);
                comando.Parameters.AddWithValue("@Apellido", param.Apellido);
                comando.Parameters.AddWithValue("@Dni", param.Dni);
                comando.Parameters.AddWithValue("@Email", param.Email);
                comando.Parameters.AddWithValue("@TipoDeFactura", param.TipoDeFactura);

                comando.CommandText = sql;
                comando.Connection = conexion;
                conexion.Open();

                int filasAfectadas = comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rta = false;
                }
            }
            catch (Exception e)
            {
                string st = e.Message;
                rta = false;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

            return rta;
        }

        public bool EliminarCliente(int dni)
        {
            bool rta = true;

            try
            {
                comando = new SqlCommand();
                comando.Parameters.AddWithValue("@Dni", dni);
                string sql = "DELETE FROM dbo.Cliente WHERE Dni = @Dni";
                comando.CommandType = CommandType.Text;
                comando.CommandText = sql;
                comando.Connection = conexion;
                conexion.Open();

                int filasAfectadas = comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rta = false;
                }
            }
            catch (Exception e)
            {
                string st = e.Message;
                rta = false;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

            return rta;
        }

        public bool ModificarAlumno(Cliente param)
        {
            bool rta = true;

            try
            {
                comando = new SqlCommand();

                comando.Parameters.AddWithValue("@Nombre", param.Nombre);
                comando.Parameters.AddWithValue("@Apellido", param.Apellido);
                comando.Parameters.AddWithValue("@Dni", param.Dni);
                comando.Parameters.AddWithValue("@Email", param.Email);
                comando.Parameters.AddWithValue("@TipoDeFactura", param.TipoDeFactura);

                string sql = "UPDATE dbo.Cliente SET Nombre = @Nombre, Apellido = @Apellido, Email = @Email , TipoDeFactura = @TipoDeFactura WHERE Dni = @Dni";

                comando.CommandType = CommandType.Text;
                comando.CommandText = sql;
                comando.Connection = conexion;

                conexion.Open();

                int filasAfectadas = comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rta = false;
                }

            }
            catch (InvalidCastException)
            {
                rta = false;
            }
            catch (System.IO.IOException)
            {
                rta = false;
            }
            catch (ObjectDisposedException)
            {
                rta = false;
            }
            catch (InvalidOperationException)
            {
                rta = false;
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                rta = false;
            }
            catch (Exception)
            {
                rta = false;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

            return rta;
        }
    }
}
