
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CapaDatos;
namespace CapaNegocio
{
    public class EncVentasEn:conexionbase,IMantenimiento
    {
       public int IdEncabezado { get; set; }
      public string NumDocumento { get; set; }
      public DateTime Fecha { get; set; }
      public int IdCliente { get; set; }
      public int? IdFormaPago { get; set; }
      public int? idDatosTarjeta { get; set; }
      public string NumeroTarjeta { get; set; }

     SqlCommand cmd = new SqlCommand();

        public int Insert(EncVentasEn oItem, ref string oError)
        {
            int Result = 0;
            try
            {
                Conectar();
                string Fecha = string.Format("{0}-{1}-{2}", oItem.Fecha.Year.ToString(), oItem.Fecha.Month.ToString(), oItem.Fecha.Day.ToString());
                string IdDaTarjeta = oItem.idDatosTarjeta == null ? "null" : oItem.idDatosTarjeta.ToString();

                string SQLQuery = string.Format("INSERT INTO ENCABEZADOVENTA (NumDocumento ,Fecha ,IdCliente ,IdFormaPago ,idDatosTarjeta ,NumeroTarjeta) VALUES('{0}','{1}',{2},{3},{4},'{5}') ; SELECT SCOPE_IDENTITY()", oItem.NumDocumento, Fecha, oItem.IdCliente, oItem.IdFormaPago, IdDaTarjeta, oItem.NumeroTarjeta);
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
