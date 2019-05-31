using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
namespace CapaDatos
{
    //metodo qu eno permite abrir mas de un formulario 
   public partial class FormCLos
    {
        public static void DesecharResto(Form formulario_hijo, Form formulario_padre)
        {
            foreach (Form formulario in formulario_padre.MdiChildren)
            {
                if (formulario.GetType() == formulario_hijo.GetType() && formulario != formulario_hijo)
                {
                    formulario.Dispose();
                    formulario.Close();
                }
            }
        }

        public static void DesecharTodo(Form formulario_hijo, Form formulario_padre)
        {
            foreach (Form formulario in formulario_padre.MdiChildren)
            {
                if (formulario.GetType() != formulario_hijo.GetType() && formulario != formulario_hijo)
                {
                    formulario.Dispose();
                    formulario.Close();
                }
            }
        }
    }
}
