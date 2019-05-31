using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CapaDatos;

namespace CapaNegocio
{
    public class ProductoEn:conexionbase
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal PrecioCompra { get; set; }
        public string Codigo { get; set; }
        public int Existencia { get; set; }
        public int IdCategoria { get; set; }
        public int IdProveedor { get; set; }
        public bool Estado { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }

        /*Propieades que no pertencen a la tabla*/
        public int Cantidad { get; set; }
        public decimal Total { get; set; }

        SqlCommand cmd = new SqlCommand();

        public ProductoEn BuscarProducto(string CodigoProducto, ref string oError)
        {
            ProductoEn item = new ProductoEn();
            try
            {
                Conectar();
                string SQLQuery = string.Format("SELECT TOP 1 IdProducto,Nombre,PrecioVenta,Codigo FROM PRODUCTOS  WHERE Codigo = '{0}'", CodigoProducto);
                cmd = new SqlCommand(SQLQuery, Conexion);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    item = new ProductoEn
                    {
                        IdProducto = int.Parse(reader[0].ToString()),
                        Nombre = reader[1].ToString(),
                        PrecioVenta = decimal.Parse(reader[2].ToString()),
                        Codigo = reader[3].ToString()
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
