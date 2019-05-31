using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CapaDatos;
namespace CapaNegocio
{
    public class ClienteEn: conexionbase
    {

        public int IdCliente { get; set; }
        public string NumRegistro { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dui { get; set; }
        public string Nit { get; set; }
        public string DirCliente { get; set; }
        public string Telefono { get; set; }
        public string Sexo { get; set; }
        public bool Estado { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }


        SqlCommand cmd = new SqlCommand();
        public ClienteEn BuscarCliente(string NumRegistro, ref string oError)
        {
            ClienteEn item = new ClienteEn();
            try
            {
                Conectar();
                string SQLQuery = string.Format("SELECT TOP 1 IdCliente, Nombre, Nit  FROM CLIENTES  WHERE NumRegistro = '{0}' ", NumRegistro);
                cmd = new SqlCommand(SQLQuery, Conexion);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    item = new ClienteEn
                    {
                        IdCliente  = int.Parse(reader[0].ToString()),
                        Nombre = reader[1].ToString(),
                        Nit = reader[2].ToString()
                    };
                    
                }
            }
            catch (Exception ex)
            {
                oError = ex.Message.ToString();
            }
            finally
            {
                Desconectar();
            }
            return item;
        }
    }
}
