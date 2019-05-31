using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoUML
{
    public partial class ReportExistencias : Form
    {
        public ReportExistencias()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ReportExistencias_Load(object sender, EventArgs e)
        {
            //Maximisa el formulario a pantalla completa
           this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }
    }
}
