using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaNegocio;
using CapaPresentacion;


namespace CapaPresentacion
{
    public partial class Factura : Form
    {
        int IdFactura =0;
        String oError = "";
        String Documento = "";

        public Factura()
        {
            InitializeComponent();
        }
        public Factura(int Id, string Docu)
        {
            InitializeComponent();
            IdFactura = Id;
            Documento = Docu;
        }
        private void Factura_Load(object sender, EventArgs e)
        {
            FACTUR();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void btnCargarFactura_Click(object sender, EventArgs e)
        {
         
        }

        /*Metodo que muestra la factura para exportarla*/
        public void FACTUR()
        {
            ReporteFacturaEn Repfactu = new ReporteFacturaEn();
            try
            {
                string Reporte = "";
                if(Documento == "F")
                {
                    Reporte = "Factura.rdlc";
                }
                if(Documento == "C")
                {
                    Reporte = "CreditoFiscal.rdlc";
                }
                if (Documento == "T")
                {
                    Reporte = "Ticket.rdlc";
                }
                this.reportViewer1.Reset();
                this.reportViewer1.ProcessingMode = ProcessingMode.Local;
                this.reportViewer1.LocalReport.ReportPath = AppDomain.CurrentDomain.BaseDirectory + Reporte;
                //comentariar cuando se haga un instalador y se deja la de arriba
                this.reportViewer1.LocalReport.ReportPath = @"C:\Users\David Ramirez\Documents\Visual Studio 2015\Projects\Proyecto UML\ProyectoUML\ProyectoUML\Reportes\" + Reporte; // AppDomain.CurrentDomain.BaseDirectory + "Factura.rdlc";
                ReportDataSource reportDataSource = new ReportDataSource();
                // Must match the DataSet in the RDLC
                reportDataSource.Name = "dsFactura"; 
                reportDataSource.Value = Repfactu.ReporteFactura(IdFactura, ref oError);
                this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se genero un error: " + ex.Message.ToString(), "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
      

    }
}
