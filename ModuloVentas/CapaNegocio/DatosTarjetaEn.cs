using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CapaDatos;
namespace CapaNegocio
{
   public class DatosTarjetaEn:conexionbase
    {
        public int IdDatosTarjeta { get; set; }
        public string TipoTarjeta { get; set; }


        SqlCommand cmd = new SqlCommand();
        public List<DatosTarjetaEn> ComboDatosTarjeta(ref string oError)
        {
            List<DatosTarjetaEn> olist = new List<DatosTarjetaEn>();
            DatosTarjetaEn item = new DatosTarjetaEn();
            try
            {
                Conectar();
                string SQLQuery = " SELECT idDatosTarjeta, tipoTarjeta FROM DATOSTARJETA";
                cmd = new SqlCommand(SQLQuery, Conexion);
                SqlDataReader reader = cmd.ExecuteReader();
                item = new DatosTarjetaEn
                {
                    IdDatosTarjeta = -1,
                    TipoTarjeta = "Seleccione"
                };
                olist.Add(item);
                while (reader.Read())
                {
                    item = new DatosTarjetaEn
                    {
                        IdDatosTarjeta = int.Parse(reader[0].ToString()),
                   
                        TipoTarjeta = reader[1].ToString(),
                     
                    };
                    olist.Add(item);
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
            return olist;
        }
    }
}

