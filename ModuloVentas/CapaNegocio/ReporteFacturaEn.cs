using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CapaDatos;
using CapaNegocio;
namespace CapaNegocio
{
    public class ReporteFacturaEn : conexionbase
    {
        public int IdEncabezado { get; set; }
        public string NumDocumento { get; set; }
        public DateTime Fecha { get; set; }
        public string Cliente { get; set; }
        public string Producto { get; set; }
        public int Cantidad { get; set; }
        public Decimal Precio { get; set; }
        public Decimal Total { get; set; }

        SqlCommand cmd = new SqlCommand();
        public List<ReporteFacturaEn> ReporteFactura(int IdEncabezado, ref string oError)
        {
            List<ReporteFacturaEn> olist = new List<ReporteFacturaEn>();
            ReporteFacturaEn item = new ReporteFacturaEn();
            try
            {
                /*Consulta factura*/
                Conectar();
                string SQLQuery = string.Format(@"SELECT CAB.IdEncabezado,CAB.NumDocumento,CAB.Fecha,CLI.Nombre AS Cliente,
                                  PRO.Nombre AS Producto,DET.Cantidad,DET.Precio, (DET.Cantidad * DET.Precio) AS Total 
                                  FROM ENCABEZADOVENTA AS CAB INNER JOIN DETALLEVENTAS AS DET ON CAB.IdEncabezado = DET.IdEncabezado
                                  INNER JOIN CLIENTES AS CLI ON CAB.IdCliente = CLI.IdCliente INNER JOIN PRODUCTOS AS PRO ON DET.IdProducto = PRO.IdProducto 
                                  WHERE CAB.IdEncabezado ={0}", IdEncabezado);

                cmd = new SqlCommand(SQLQuery, Conexion);
                SqlDataReader reader = cmd.ExecuteReader();

               
                while (reader.Read())
                {
                    item = new ReporteFacturaEn
                    {
                        IdEncabezado = int.Parse(reader[0].ToString()),
                        NumDocumento = reader[1].ToString(),
                        Fecha = DateTime.Parse(reader[2].ToString()),
                        Cliente = reader[3].ToString(),
                        Producto = reader[4].ToString(),
                        Cantidad = int.Parse(reader[5].ToString()),
                        Precio = Decimal.Parse(reader[6].ToString()),
                        Total = Decimal.Parse(reader[7].ToString())
                    };
                    olist.Add(item);
                }
            }
            catch(Exception ex)
            {
                oError = ex.Message.ToString();
            }
            finally
            {
                Desconectar();
            }
            return olist;


        }
    }
}
