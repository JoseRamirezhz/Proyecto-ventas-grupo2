using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
namespace CapaPresentacion 
{
    public partial class Clientes : Form
    {
        ModificacionClie modClie = new ModificacionClie();
        public Clientes()
        {
            InitializeComponent();
        }
        //conexionbase bdConex = new conexionbase();

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void dtgDatosCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            //conexionbase bdConex = new conexionbase();
            //maximisa el formulario
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            
        }

        private void buttonX6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnImpriCliente_Click(object sender, EventArgs e)
        {
            Form ReporC = new Form();
            ReporC.ShowDialog();
        }

        private void btnInsertarUsu_Click(object sender, EventArgs e)
        {
            modClie.IdCliente = txtidCliente.Text;
            modClie.NumRegistro = txtNumRegistro.Text;
            modClie.NomCliente = txtNombreCli.Text;
            modClie.DirCliente = txtDirClien.Text;
            modClie.TelCliente = txtTelClien.Text; 
            modClie.Nitcliente = txtDocClient.Text;
            modClie.FechaCreacion = txtFecModificacion.Text;
            modClie.FechaModificacion = txtFecCreacion.Text;

            modClie.InsertarCliente();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void buttonX3_Click_1(object sender, EventArgs e)
        {
            modClie.IdCliente = txtidCliente.Text;
            modClie.NumRegistro = txtNumRegistro.Text;
            modClie.NomCliente = txtNombreCli.Text;
            modClie.DirCliente = txtDirClien.Text;
            modClie.TelCliente = txtTelClien.Text;
            modClie.Nitcliente = txtDocClient.Text;
            modClie.FechaCreacion = txtFecModificacion.Text;
            modClie.FechaModificacion = txtFecCreacion.Text;
            modClie.deleteCliente();
        }

        private void dtgDatosCliente_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
