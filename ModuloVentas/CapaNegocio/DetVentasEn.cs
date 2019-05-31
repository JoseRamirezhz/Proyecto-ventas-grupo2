
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CapaDatos;
namespace CapaNegocio
{
    public class DetVentasEn : conexionbase, IMantenimiento
    {
        public int IdVentas { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public int IdEncabezado { get; set; }

        SqlCommand cmd = new SqlCommand();
        public int Insert(DetVentasEn oItem, ref string oError)
        {
            int Result = 0;
            try
            {
                Conectar();
              
                string SQLQuery = string.Format("INSERT INTO DETALLEVENTAS (IdProducto,Cantidad,Precio,IdEncabezado) VALUES({0},{1},{2},{3}) ; SELECT SCOPE_IDENTITY()", oItem.IdProducto, oItem.Cantidad, oItem.Precio, oItem.IdEncabezado);
                cmd = new SqlCommand(SQLQuery, Conexion);
                int Id = 0;
                Id = int.Parse(cmd.ExecuteScalar().ToString());
                if (Id > 0)
                {
                    Result = Id;
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
            return Result;
        }

        public bool Update()
        {
            throw new NotImplementedException();
        }

        public bool Delete()
        {
            throw new NotImplementedException();
        }

        public int Insert()
        {
            throw new NotImplementedException();
        }
    }
}
