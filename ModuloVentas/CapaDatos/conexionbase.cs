using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Data.Sql;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class conexionbase
    {
        //Properties.Settings.Default.BaseVentasConnectionString
        //"Data Source=LAPTOP-ONPRB48O;Initial Catalog=BaseVentas;Integrated Security=True";
        String conexBD = "Data Source=LAPTOP-ONPRB48O;Initial Catalog=BaseVentas;Integrated Security=True";
        SqlConnection conexion = new SqlConnection();

        SqlDataAdapter adaptador;
        SqlCommandBuilder comm;

        SqlCommand comando;

        public SqlConnection Conexion
        {
            get { return conexion; }
            set { conexion = value; }
        }

        /*Metodo para conectar a base de datos*/
        public bool Conectar()
        {
            bool conn = false;
            try
            {
                conexion.ConnectionString = conexBD;
                conexion.Open();
                conn = true;
            }
            catch (Exception ex)
            {
                conn = false;
            }
            return conn;
        }

        public bool Desconectar()
        {
            bool Result = false;
            try
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
                Result = true;
            }
            catch (Exception)
            {
                Result = false;
            }
            return Result;
        }
        public void consultaSQL(String consulta)
        {
            String mensaje = "Error";
            try
            {
                comando = new SqlCommand(consulta, conexion);
                comando.ExecuteNonQuery();
                mensaje = " La consulta se realizo correctamente";
            }
            catch
            {
                mensaje = "Error en la consulta";
            }
        }
    }
}
