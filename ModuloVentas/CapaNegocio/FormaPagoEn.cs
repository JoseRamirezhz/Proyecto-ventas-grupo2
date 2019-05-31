using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CapaDatos;
namespace CapaNegocio
{
    public class FormaPagoEn :conexionbase,IMantenimiento
    {
        public int IdFormaPago { get; set; }
        public string TipoFormaPago { get; set; }
        public bool IdForEstadomaPago { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }

        SqlCommand cmd = new SqlCommand();
        public List<FormaPagoEn> ComboFormapago( ref string oError)
        {
            List<FormaPagoEn> olist = new List<FormaPagoEn>();
            FormaPagoEn item = new FormaPagoEn();
            try
            {
                Conectar();
                string SQLQuery = "SELECT IdFormaPago, TipoFormaPago FROM FORMASPAGOS WHERE Estado = 1";
                cmd = new SqlCommand(SQLQuery, Conexion);
                SqlDataReader reader = cmd.ExecuteReader();
                item = new FormaPagoEn
                {
                    IdFormaPago = -1,
                    TipoFormaPago = "Seleccione"
                };
                olist.Add(item);
                while (reader.Read())
                {
                    item = new FormaPagoEn
                    {
                        IdFormaPago = int.Parse(reader[0].ToString()),
                        TipoFormaPago = reader[1].ToString()
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

        public int Insert()
        {
            throw new NotImplementedException();
        }

        public bool Update()
        {
            throw new NotImplementedException();
        }

        public bool Delete()
        {
            throw new NotImplementedException();
        }

        int IMantenimiento.Insert()
        {
            throw new NotImplementedException();
        }
    }
}


