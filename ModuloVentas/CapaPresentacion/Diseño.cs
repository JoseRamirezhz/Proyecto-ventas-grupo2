using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Diseño : Form
    {
        public Diseño()
        {
            InitializeComponent();
        }
        

        private void buttonItem1_Click(object sender, EventArgs e)
        {
            Clientes clie = new Clientes();
            clie.MdiParent = this;
            clie.Show();
        }

       /* private void buttonItem28_Click(object sender, EventArgs e)
        {
            Proveedores prov = new Proveedores();
            prov.MdiParent = this;
            prov.Show();
        }*/

     

        private void Diseño_Load(object sender, EventArgs e)
        {
            //Maximisa el formulario a pantalla completa
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void Diseño_FormClosing(object sender, FormClosingEventArgs e)
        {
            GC.Collect();
            Application.Exit();
        }

        /*private void buttonItem3_Click(object sender, EventArgs e)
        {
            Usuarios usu = new Usuarios();
            usu.MdiParent = this;
            usu.Show();
        }*/

   
        private void buttonItem1_Click_1(object sender, EventArgs e)
        {

            Clientes clie = new Clientes();
            clie.MdiParent = this;
            clie.Show();

            //cierra los formularios
            FormCLos.DesecharResto(clie, this);
            FormCLos.DesecharTodo(clie, this);
        }

    
        private void buttonItem3_Click_1(object sender, EventArgs e)
        {
            Usuarios usu = new Usuarios();
            usu.MdiParent = this;
            usu.Show();

            //cierra todo el formulario
            FormCLos.DesecharResto(usu, this);
            FormCLos.DesecharTodo(usu, this);
        }

      
        private void buttonItem5_Click(object sender, EventArgs e)
        {
            Kardex Kar = new Kardex();
            Kar.MdiParent = this;
            Kar.Show();

            //cierra todo el formulario
            FormCLos.DesecharResto(Kar, this);
            FormCLos.DesecharTodo(Kar, this);
        }

       

        private void buttonItem2_Click_1(object sender, EventArgs e)
        {
            Ventas Ven = new Ventas();
            //Ven.MdiParent = this;
            Ven.Show();

            //cierra todo el formulario
            FormCLos.DesecharResto(Ven,this);
            FormCLos.DesecharTodo(Ven, this);
        }

   

      
        private void buttonItem6_Click(object sender, EventArgs e)
        {
            Usuarios usu = new Usuarios();
            usu.MdiParent = this;
            usu.Show();

            //cierra todo el formulario
            FormCLos.DesecharResto(usu, this);
            FormCLos.DesecharTodo(usu, this);
        }

        

        private void buttonItem12_Click(object sender, EventArgs e)
        {
            Usuarios usu = new Usuarios();
            usu.MdiParent = this;
            usu.Show();

            //cierra todo el formulario
            FormCLos.DesecharResto(usu, this);
            FormCLos.DesecharTodo(usu, this);
        }


        private void metroTileItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

  
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();

        }

        

        private void buttonItem3_Click_2(object sender, EventArgs e)
        {
            ReportVentasVendedor RepVent = new ReportVentasVendedor();
            RepVent.MdiParent = this;
            RepVent.Show();

            //cierra todo el formulario
            FormCLos.DesecharResto(RepVent, this);
            FormCLos.DesecharTodo(RepVent, this);
        }

  

        private void buttonItem8_Click(object sender, EventArgs e)
        {
            ReportClientes RepClie = new ReportClientes();
            RepClie.MdiParent = this;
            RepClie.Show();

            //cierra todo el formulario
            FormCLos.DesecharResto(RepClie, this);
            FormCLos.DesecharTodo(RepClie, this);
        }

   

        private void buttonX1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonItem15_Click(object sender, EventArgs e)
        {
            ReportCliente RepCliet = new ReportCliente();
            RepCliet.MdiParent = this;
            RepCliet.Show();

            //cierra todo el formulario
            FormCLos.DesecharResto(RepCliet, this);
            FormCLos.DesecharTodo(RepCliet, this);
        }

        

        private void buttonItem9_Click(object sender, EventArgs e)
        {
            ReportExistencias RepExis = new ReportExistencias();
            RepExis.MdiParent = this;
            RepExis.Show();

            //cierra todo el formulario
            FormCLos.DesecharResto(RepExis, this);
            FormCLos.DesecharTodo(RepExis, this);
        }

        private void buttonItem16_Click_1(object sender, EventArgs e)
        {
            EliminarFacViejas ElimFac = new EliminarFacViejas();
            ElimFac.MdiParent = this;
            ElimFac.Show();

            //cierra todo el formulario
            FormCLos.DesecharResto(ElimFac, this);
            FormCLos.DesecharTodo(ElimFac, this);
        }

        private void buttonItem18_Click(object sender, EventArgs e)
        {
            EliminarProdViejos Elimprod = new EliminarProdViejos();
            Elimprod.MdiParent = this;
            Elimprod.Show();

            //cierra todo el formulario
            FormCLos.DesecharResto(Elimprod, this);
            FormCLos.DesecharTodo(Elimprod, this);
        }

        private void buttonItem17_Click(object sender, EventArgs e)
        {
            EliminarCredFiscalesViejos ElimCredFis = new EliminarCredFiscalesViejos();
            ElimCredFis.MdiParent = this;
            ElimCredFis.Show();

            //cierra todo el formulario
            FormCLos.DesecharResto(ElimCredFis, this);
            FormCLos.DesecharTodo(ElimCredFis, this);
        }

        

        private void buttonItem23_Click_2(object sender, EventArgs e)
        {
            Clientes clie = new Clientes();
            clie.MdiParent = this;
            clie.Show();

            //cierra los formularios
            FormCLos.DesecharResto(clie, this);
            FormCLos.DesecharTodo(clie, this);
        }

        private void buttonItem12_Click_3(object sender, EventArgs e)
        {
            Ventas vent = new Ventas();
           vent.MdiParent = this;
            vent.Show();

            //cierra todo el formulario
            FormCLos.DesecharResto(vent, this);
            FormCLos.DesecharTodo(vent, this);
        }

        private void ribbonTabItem7_Click_1(object sender, EventArgs e)
        {

        }

        private void ribbonTabItem1_Click_2(object sender, EventArgs e)
        {

        }

        private void buttonItem10_Click_2(object sender, EventArgs e)
        {
            Kardex Kar = new Kardex();
            Kar.MdiParent = this;
            Kar.Show();

            //cierra todo el formulario
            FormCLos.DesecharResto(Kar, this);
            FormCLos.DesecharTodo(Kar, this);
        }

        private void buttonItem21_Click_1(object sender, EventArgs e)
        {
            ReportCliente RepCliet = new ReportCliente();
            RepCliet.MdiParent = this;
            RepCliet.Show();

            //cierra todo el formulario
            FormCLos.DesecharResto(RepCliet, this);
            FormCLos.DesecharTodo(RepCliet, this);
        }

        private void buttonItem20_Click_2(object sender, EventArgs e)
        {
            ReportClientes RepClie = new ReportClientes();
            RepClie.MdiParent = this;
            RepClie.Show();

            //cierra todo el formulario
            FormCLos.DesecharResto(RepClie, this);
            FormCLos.DesecharTodo(RepClie, this);
        }

        private void buttonItem19_Click_2(object sender, EventArgs e)
        {
            ReportComprasProveedor RepComp = new ReportComprasProveedor();
            RepComp.MdiParent = this;
            RepComp.Show();

            //cierra todo el formulario
            FormCLos.DesecharResto(RepComp, this);
            FormCLos.DesecharTodo(RepComp, this);
        }

        private void buttonItem22_Click_1(object sender, EventArgs e)
        {
            ReportExistencias RepExis = new ReportExistencias();
            RepExis.MdiParent = this;
            RepExis.Show();

            //cierra todo el formulario
            FormCLos.DesecharResto(RepExis, this);
            FormCLos.DesecharTodo(RepExis, this);
        }

        private void buttonItem14_Click_1(object sender, EventArgs e)
        {
            ReportVentasVendedor RepVent = new ReportVentasVendedor();
            RepVent.MdiParent = this;
            RepVent.Show();

            //cierra todo el formulario
            FormCLos.DesecharResto(RepVent, this);
            FormCLos.DesecharTodo(RepVent, this);
        }

        private void buttonItem25_Click_1(object sender, EventArgs e)
        {
            Usuarios usu = new Usuarios();
            usu.MdiParent = this;
            usu.Show();

            //cierra todo el formulario
            FormCLos.DesecharResto(usu, this);
            FormCLos.DesecharTodo(usu, this);
        }

        private void buttonItem24_Click_1(object sender, EventArgs e)
        {
            Proveedores Prov = new Proveedores();
            Prov.MdiParent = this;
            Prov.Show();

            //cierra todo el formulario
            FormCLos.DesecharResto(Prov, this);
            FormCLos.DesecharTodo(Prov, this);
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void ribbonTabItem2_Click(object sender, EventArgs e)
        {

        }

        private void buttonItem5_Click_1(object sender, EventArgs e)
        {
            Comprobante compro = new Comprobante();
            compro.MdiParent = this;
            compro.Show();

            //cierra todo el formulario
            FormCLos.DesecharResto(compro, this);
            FormCLos.DesecharTodo(compro, this);
        }

        private void ribbonTabItem5_Click(object sender, EventArgs e)
        {

        }

        private void ribbonTabItem8_Click(object sender, EventArgs e)
        {

        }

        private void ribbonPanel1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
           Producto produc = new Producto();
            produc.MdiParent = this;
            produc.Show();

            //cierra los formularios
            FormCLos.DesecharResto(produc, this);
            FormCLos.DesecharTodo(produc, this);
        }

        private void buttonItem6_Click_1(object sender, EventArgs e)
        {
            Comprobante produc = new Comprobante();
            produc.MdiParent = this;
            produc.Show();

            //cierra los formularios
            FormCLos.DesecharResto(produc, this);
            FormCLos.DesecharTodo(produc, this);
        }
    }
}
