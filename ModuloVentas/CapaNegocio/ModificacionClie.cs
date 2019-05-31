using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
namespace CapaNegocio
{
   public class ModificacionClie
    {
        conexionbase test = new conexionbase();
        private String idCliente, numRegistro, nomCliente, dirCliente, telCliente, nitcliente,fechaCreacion ,fechaModificacion;
        CapaDatos.FormCLos FormCLo = new CapaDatos.FormCLos();
        public string IdCliente
        {
            get{ return idCliente;}
            set {idCliente = value;}
        }
        public string NumRegistro
        {
            get { return numRegistro; }
            set { numRegistro = value; }
        }

        public string NomCliente
        {
            get{return nomCliente;}
            set{nomCliente = value;}
        }

        public string DirCliente
        {
            get{ return dirCliente;}
            set{dirCliente = value;}
        }

        public string TelCliente
        {
            get{return telCliente;}
            set{ telCliente = value;}
        }

        public string Nitcliente
        {
            get{ return nitcliente;}
             set {nitcliente = value;}
        }

        public string FechaCreacion
        {
            get{return fechaCreacion; }
            set{fechaCreacion = value;}
        }

        public string FechaModificacion
        {
            get{return fechaModificacion;}
            set{fechaModificacion = value;}
        }



        // insert into CLIENTES(IdCliente, Nombre, DirCliente, Telefono, Nit) values(,)

        public void InsertarCliente()
        {
            try
            {
                String insert = @"insert into CLIENTES(IdCliente, NumRegistro, Nombre, DirCliente, Telefono, Nit, FechaCreacion, FechaModificacion)
                                  values ('" + idCliente + "','" + numRegistro + "','" + nomCliente + "','" + dirCliente + "','" + telCliente + "','" + nitcliente + "','" + fechaCreacion + "','" + fechaModificacion + "')";
                test.Conectar();
                test.consultaSQL(insert);
                test.Desconectar();
            }
            catch
            {

            }

        }
        public void deleteCliente()
        {
            try
            {
                String delete = "delete from CLIENTES where IdCliente = '";
                test.Conectar();
                test.consultaSQL(delete);
                test.Desconectar();
            }
            catch
            {

            }
        }

        public void FormularioCLos()
        {
            try
            {
                FormCLo.FormCLos();
            }
            catch
            {

            }
        }
    }
}
