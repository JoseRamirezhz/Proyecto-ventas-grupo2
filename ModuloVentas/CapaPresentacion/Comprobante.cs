using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
namespace CapaPresentacion
{
    public partial class Comprobante : Form 
    {
        /*Instanciando clase forma pago*/
        FormaPagoEn forPago = new FormaPagoEn();
        /*Instanciando clase cliente*/
        ClienteEn client = new ClienteEn();
        /*Instanciando clase datos tarjeta*/
        DatosTarjetaEn datoTarjeta = new DatosTarjetaEn();
        /*Instanciando clase producto*/
        ProductoEn Prod = new ProductoEn();
        /*Instanciando encabezado de factura*/
        EncVentasEn EncVent = new EncVentasEn();
        /*Instanciando detalle de vena*/
        DetVentasEn DetVent = new DetVentasEn();

        /*Source de factura*/
        List<ProductoEn> olistProducto = new List<ProductoEn>();

        public Comprobante()
        {
            InitializeComponent();
        }

        private void Comprobante_Load(object sender, EventArgs e)
        {
            try
            {
                LLenarFormaPago();
                LLenarDatosTarjeta();
                // btnEliminar.ForeColor = Color.Black;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se genero un error: " + ex.Message.ToString(), "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //maximisa el formulario
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        /*Metodo para llenar datos tarjeta*/
        public void LLenarDatosTarjeta()
        {
            try
            {
                List<DatosTarjetaEn> olis = new List<DatosTarjetaEn>();
                string Error = "";
                olis = datoTarjeta.ComboDatosTarjeta(ref Error);
                if (string.IsNullOrWhiteSpace(Error))
                {
                    if (olis.Count > 0)
                    {
                        cbTipoTarjeta.DataSource = olis;
                        cbTipoTarjeta.ValueMember = "IdDatosTarjeta";
                        cbTipoTarjeta.DisplayMember = "TipoTarjeta";
                        cbTipoTarjeta.SelectedIndex = 0;
                    }
                }
                else
                {
                    MessageBox.Show("Se genero un error: " + Error, "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se genero un error: " + ex.Message.ToString(), "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*LLenando combo forma pago*/
        public void LLenarFormaPago()
        {
            try
            {
                List<FormaPagoEn> olis = new List<FormaPagoEn>();
                string Error = "";
                olis = forPago.ComboFormapago(ref Error);
                if (string.IsNullOrWhiteSpace(Error))
                {
                    if (olis.Count > 0)
                    {
                        cbFormaPago.DataSource = olis;
                        cbFormaPago.ValueMember = "IdFormaPago";
                        cbFormaPago.DisplayMember = "TipoFormaPago";
                        cbFormaPago.SelectedIndex = 0;
                    }
                }
                else
                {
                    MessageBox.Show("Se genero un error: " + Error, "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se genero un error: " + ex.Message.ToString(), "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /*Configuracion inicial de controles*/
        public void InicializarControles()
        {
            try
            {
                dtpFechaFactura.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se genero un error: " + ex.Message.ToString(), "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalirForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                lblIdClient.Text = "";
                txtNombreCliente.Text = "";
                txtNit.Text = "";

                ClienteEn item = new ClienteEn();
                string Error = "";
                item = client.BuscarCliente(txtNumeroRegistro.Text, ref Error);
                if (string.IsNullOrWhiteSpace(Error))
                {
                    if (item.IdCliente > 0)
                    {
                        lblIdClient.Text = item.IdCliente.ToString();
                        txtNombreCliente.Text = item.Nombre;
                        txtNit.Text = item.Nit;
                    }
                    else
                    {
                        MessageBox.Show("No se encontro el registro, intentelo nuevamente ", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Se genero un error: " + Error, "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se genero un error: " + ex.Message.ToString(), "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbFormaPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtNumeroTarjeta.Text = "";
                if (cbTipoTarjeta.DataSource != null)
                {
                    cbTipoTarjeta.SelectedIndex = 0;
                }

                if (cbFormaPago.SelectedValue.ToString() == "2")
                {
                    txtNumeroTarjeta.Visible = true;
                    cbTipoTarjeta.Visible = true;
                    lblNumeroTarjeta.Visible = true;
                    lblTipoTarjeta.Visible = true;
                }
                else
                {
                    txtNumeroTarjeta.Visible = false;
                    cbTipoTarjeta.Visible = false;
                    lblNumeroTarjeta.Visible = true;
                    lblTipoTarjeta.Visible = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Se genero un error: " + ex.Message.ToString(), "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                ProductoEn item = new ProductoEn();
                string Error = "";

                item = Prod.BuscarProducto(txtCodigoProducto.Text, ref Error);
                if (string.IsNullOrWhiteSpace(Error))
                {
                    if (item.IdProducto > 0)
                    {
                        lblIdProducto.Text = item.IdProducto.ToString();
                        txtNombreProducto.Text = item.Nombre;
                        txtPrecio.Text = item.PrecioVenta.ToString();
                        txtCantidad.Text = "1";
                        txtSubTotal.Text = item.PrecioVenta.ToString();
                    }
                    else
                    {
                        MessageBox.Show("No se encontro el registro, intentelo nuevamente ", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Se genero un error: " + Error, "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se genero un error: " + ex.Message.ToString(), "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;

                if (char.IsNumber(e.KeyChar) ||

                    e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator

                    )

                    e.Handled = false;

                else

                    e.Handled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se genero un error: " + ex.Message.ToString(), "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;

                if (char.IsNumber(e.KeyChar) ||

                    e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator

                    )

                    e.Handled = false;

                else

                    e.Handled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se genero un error: " + ex.Message.ToString(), "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /*Evento recalculo de subtotal*/
        public void RecalcularSubTotal()
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtCantidad.Text) && !string.IsNullOrWhiteSpace(txtPrecio.Text))
                {
                    decimal Cantidad = decimal.Parse(txtCantidad.Text);
                    decimal Precio = decimal.Parse(txtPrecio.Text);
                    decimal NewSubTotal = Cantidad * Precio;
                    txtSubTotal.Text = NewSubTotal.ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Se genero un error: " + ex.Message.ToString(), "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPrecio_Leave(object sender, EventArgs e)
        {
            try
            {
                RecalcularSubTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se genero un error: " + ex.Message.ToString(), "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCantidad_Leave(object sender, EventArgs e)
        {
            try
            {
                RecalcularSubTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se genero un error: " + ex.Message.ToString(), "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregarProduc_Click(object sender, EventArgs e)
        {
            try
            {


                if (ValidarProducto() == true)
                {
                    ProductoEn item = new ProductoEn();
                    item = new ProductoEn
                    {
                        IdProducto = int.Parse( lblIdProducto.Text),
                        Codigo = txtCodigoProducto.Text,
                        Nombre = txtNombreProducto.Text,
                        Cantidad = int.Parse(txtCantidad.Text),
                        PrecioVenta = decimal.Parse(txtPrecio.Text),
                        Total = int.Parse(txtCantidad.Text) * decimal.Parse(txtPrecio.Text)
                    };
                    olistProducto.Add(item);

                    CargarGrid();

                    txtCodigoProducto.Text = "";
                    txtNombreProducto.Text = "";
                    txtPrecio.Text = "";
                    txtCantidad.Text = "";
                    txtSubTotal.Text = "";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Se genero un error: " + ex.Message.ToString(), "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*Metodo para cargar grid*/
        public void CargarGrid()
        {
            try
            {
                dgvProducto.AutoGenerateColumns = false;
                dgvProducto.DefaultCellStyle.ForeColor = Color.Black;
                dgvProducto.DataSource = null;
                dgvProducto.DataSource = olistProducto;
                dgvProducto.Refresh();
                RecalculoTotales();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se genero un error: " + ex.Message.ToString(), "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*Fucion para recalculo de totales*/
        public void RecalculoTotales()
        {
            try
            {
                double Total = dgvProducto.Rows.Cast<DataGridViewRow>()
                              .AsEnumerable()
                              .Sum(x => double.Parse(x.Cells[4].Value.ToString()));
                txtIva.Text = (Total * 0.13).ToString();
                txtSubtota.Text = (Total * 0.87).ToString();
                txtTotal.Text = Total.ToString();
                txtivaRetenido.Text = (((Total * 0.13) / 3) * 2).ToString();
                txtDescuento.Text = (Total * 0.05).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se genero un error: " + ex.Message.ToString(), "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*Funcion para validar ingreso de producto*/
        public bool ValidarProducto()
        {
            bool Result = false;
            try
            {
                if (string.IsNullOrWhiteSpace(txtCodigoProducto.Text))
                {
                    MessageBox.Show("Codigo producto requerido", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (string.IsNullOrWhiteSpace(txtNombreProducto.Text))
                {
                    MessageBox.Show("Nombre producto requerido", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(txtPrecio.Text))
                {
                    MessageBox.Show("Precio requerido", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(txtCantidad.Text))
                {
                    MessageBox.Show("Cantidad requerido", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Result = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se genero un error: " + ex.Message.ToString(), "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return Result;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProducto.Rows.Count > 0)
                {
                    if (dgvProducto.SelectedRows == null)
                    {
                        MessageBox.Show("Por favor seleccione registro", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("¿Desea eliminar?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        if (result.Equals(DialogResult.OK))
                        {
                            int Index = dgvProducto.SelectedCells[0].RowIndex;
                            DataGridViewRow SelectedRow = dgvProducto.Rows[Index];
                            string Codigo = SelectedRow.Cells["Codigo"].Value.ToString();

                            var itemToRemove = olistProducto.Single(r => r.Codigo == Codigo);
                            olistProducto.Remove(itemToRemove);
                            CargarGrid();
                        }

                    }
                }
                else
                {
                    MessageBox.Show("No hay registros para eliminar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se genero un error: " + ex.Message.ToString(), "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProducto.Rows.Count > 0)
                {
                    if (dgvProducto.SelectedRows == null)
                    {
                        MessageBox.Show("Por favor seleccione registro", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {

                        int Index = dgvProducto.SelectedCells[0].RowIndex;
                        DataGridViewRow SelectedRow = dgvProducto.Rows[Index];
                        string Codigo = SelectedRow.Cells["Codigo"].Value.ToString();

                        var Item = olistProducto.Single(r => r.Codigo == Codigo);

                        Item.Cantidad = Item.Cantidad + 1;
                        Item.Total = Item.Cantidad * Item.PrecioVenta;
                        CargarGrid();


                    }
                }
                else
                {
                    MessageBox.Show("No hay registros", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se genero un error: " + ex.Message.ToString(), "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProducto.Rows.Count > 0)
                {
                    if (dgvProducto.SelectedRows == null)
                    {
                        MessageBox.Show("Por favor seleccione registro", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {

                        int Index = dgvProducto.SelectedCells[0].RowIndex;
                        DataGridViewRow SelectedRow = dgvProducto.Rows[Index];
                        string Codigo = SelectedRow.Cells["Codigo"].Value.ToString();

                        var Item = olistProducto.Single(r => r.Codigo == Codigo);
                        if (Item.Cantidad > 1)
                        {
                            Item.Cantidad = Item.Cantidad - 1;
                            Item.Total = Item.Cantidad * Item.PrecioVenta;
                            CargarGrid();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No hay registros", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se genero un error: " + ex.Message.ToString(), "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTicket_Click(object sender, EventArgs e)
        {
            try
            {
                GuardarFactura("T");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Se genero un error: " + ex.Message.ToString(), "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void btnCeditFiscal_Click(object sender, EventArgs e)
        {
            try
            {
                GuardarFactura("C");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Se genero un error: " + ex.Message.ToString(), "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnFactura_Click(object sender, EventArgs e)
        {
            try
            {
                GuardarFactura("F");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Se genero un error: " + ex.Message.ToString(), "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*Metodo para guardar factura*/
        public void GuardarFactura(string TipoDocumento)
        {
            try
            {
                bool Imprimir = false;
                int Result = 0;
                 if (ValidarVenta()  == true)
                {
                    string oError = "";
                    EncVentasEn item = new EncVentasEn
                    {
                        NumDocumento = txtNumeroDocumento.Text,
                        Fecha = dtpFechaFactura.Value,
                        IdCliente = int.Parse(lblIdClient.Text),
                        IdFormaPago = cbFormaPago.SelectedValue.ToString() == "-1" ? (int?)null : int.Parse(cbFormaPago.SelectedValue.ToString()),
                        idDatosTarjeta = cbTipoTarjeta.SelectedValue.ToString() == "-1" ? (int?)null : int.Parse(cbTipoTarjeta.SelectedValue.ToString()),
                        NumeroTarjeta = txtNumeroTarjeta.Text
                    };

                     Result = EncVent.Insert(item, ref oError);
                    if (!string.IsNullOrWhiteSpace(oError))
                    {
                        MessageBox.Show("Se genero un error: " + oError, "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (Result > 0)
                        {
                            string oErroDet = "";
                            DetVentasEn ItemDetventas = new DetVentasEn();
                            foreach (var row in olistProducto)
                            {
                                ItemDetventas = new DetVentasEn
                                {
                                    IdProducto = row.IdProducto,
                                    Cantidad = row.Cantidad,
                                    Precio = row.PrecioVenta,
                                    IdEncabezado = Result
                                };
                               int idDet =  DetVent.Insert(ItemDetventas,ref oErroDet);
                                {
                                    if (string.IsNullOrWhiteSpace(oErroDet))
                                    {
                                        if (idDet > 0)
                                        {
                                            Imprimir = true;
                                        }
                                       

                                    }
                                 
                                }
                            }
                            
                           
                        }
                        else
                        {
                            MessageBox.Show("No fue posible guardar factura intentelo nuevamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                       
                    }

                }
                if (Imprimir == true)
                {

                    MessageBox.Show("Registro insertado exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Factura formuFa = new Factura(Result, TipoDocumento);
                    formuFa.Show();
                   

                    
                }

                //switch (TipoDocumento)
                //{
                //    case "T": /*Ticked*/

                //        break;
                //    default:
                //        break;
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se genero un error: " + ex.Message.ToString(), "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        /*Funcion para validar factura*/
        public bool ValidarVenta()
        {
            bool Result = false;
            try
            {
                if (string.IsNullOrWhiteSpace(txtNumeroDocumento.Text))
                {
                    MessageBox.Show("Numero de documento requerido", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (string.IsNullOrWhiteSpace(lblIdClient.Text))
                {
                    MessageBox.Show("No ha seleccionado cliente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (cbFormaPago.SelectedValue.ToString() == "-1")
                {
                    MessageBox.Show("Por favor seleccione forma de pago", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (cbFormaPago.SelectedValue.ToString() == "2")
                {
                    if (string.IsNullOrWhiteSpace(txtNumeroTarjeta.Text))
                    {
                        MessageBox.Show("Por favor digite numero de tarjeta", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (cbTipoTarjeta.SelectedValue.ToString() == "-1")
                    {
                        MessageBox.Show("Por favor seleccione tipo tarjeta", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (!(dgvProducto.Rows.Count > 0))
                    {
                        MessageBox.Show("Agrege un producto a la factura", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        Result = true;
                    }
                }
                else if (!(dgvProducto.Rows.Count > 0))
                {
                    MessageBox.Show("Agrege un producto a la factura", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Result = true;
                }  
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se genero un error: " + ex.Message.ToString(), "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return Result;
        }

        private void dgvProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
