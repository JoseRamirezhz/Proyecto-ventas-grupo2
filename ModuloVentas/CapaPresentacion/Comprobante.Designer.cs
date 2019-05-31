namespace CapaPresentacion
{
    partial class Comprobante
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Comprobante));
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnMenos = new System.Windows.Forms.Button();
            this.btnMas = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvProducto = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precioventa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label18 = new System.Windows.Forms.Label();
            this.txtivaRetenido = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtIva = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtSubtota = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnSalirForm = new DevComponents.DotNetBar.ButtonX();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCeditFiscal = new DevComponents.DotNetBar.ButtonX();
            this.btnFactura = new DevComponents.DotNetBar.ButtonX();
            this.btnTicket = new DevComponents.DotNetBar.ButtonX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblIdProducto = new System.Windows.Forms.Label();
            this.btnBuscarProducto = new DevComponents.DotNetBar.ButtonX();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnAgregarProduc = new DevComponents.DotNetBar.ButtonX();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblIdClient = new System.Windows.Forms.Label();
            this.cbTipoTarjeta = new System.Windows.Forms.ComboBox();
            this.cbFormaPago = new System.Windows.Forms.ComboBox();
            this.dtpFechaFactura = new System.Windows.Forms.DateTimePicker();
            this.btnBuscarCliente = new DevComponents.DotNetBar.ButtonX();
            this.txtNumeroDocumento = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblTipoTarjeta = new System.Windows.Forms.Label();
            this.lblNumeroTarjeta = new System.Windows.Forms.Label();
            this.txtNumeroTarjeta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNit = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNumeroRegistro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnMenos);
            this.groupBox7.Controls.Add(this.btnMas);
            this.groupBox7.Controls.Add(this.btnEliminar);
            this.groupBox7.Controls.Add(this.dgvProducto);
            this.groupBox7.Controls.Add(this.label18);
            this.groupBox7.Controls.Add(this.txtivaRetenido);
            this.groupBox7.Controls.Add(this.label16);
            this.groupBox7.Controls.Add(this.txtDescuento);
            this.groupBox7.Controls.Add(this.label19);
            this.groupBox7.Controls.Add(this.txtIva);
            this.groupBox7.Controls.Add(this.label21);
            this.groupBox7.Controls.Add(this.txtSubtota);
            this.groupBox7.Controls.Add(this.txtTotal);
            this.groupBox7.Controls.Add(this.label20);
            this.groupBox7.Controls.Add(this.groupBox5);
            this.groupBox7.Controls.Add(this.groupBox3);
            this.groupBox7.Controls.Add(this.groupBox1);
            this.groupBox7.Controls.Add(this.groupBox2);
            this.groupBox7.Location = new System.Drawing.Point(12, 7);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(1341, 636);
            this.groupBox7.TabIndex = 144;
            this.groupBox7.TabStop = false;
            // 
            // btnMenos
            // 
            this.btnMenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenos.Location = new System.Drawing.Point(838, 327);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(75, 32);
            this.btnMenos.TabIndex = 158;
            this.btnMenos.Text = "-";
            this.btnMenos.UseVisualStyleBackColor = true;
            this.btnMenos.Click += new System.EventHandler(this.btnMenos_Click);
            // 
            // btnMas
            // 
            this.btnMas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMas.Location = new System.Drawing.Point(838, 292);
            this.btnMas.Name = "btnMas";
            this.btnMas.Size = new System.Drawing.Size(75, 32);
            this.btnMas.TabIndex = 157;
            this.btnMas.Text = "+";
            this.btnMas.UseVisualStyleBackColor = true;
            this.btnMas.Click += new System.EventHandler(this.btnMas_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(838, 263);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 156;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgvProducto
            // 
            this.dgvProducto.AllowUserToAddRows = false;
            this.dgvProducto.AllowUserToDeleteRows = false;
            this.dgvProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducto.BackgroundColor = System.Drawing.Color.Lavender;
            this.dgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Cantidad,
            this.Precioventa,
            this.Total});
            this.dgvProducto.Location = new System.Drawing.Point(16, 263);
            this.dgvProducto.Name = "dgvProducto";
            this.dgvProducto.ReadOnly = true;
            this.dgvProducto.Size = new System.Drawing.Size(803, 217);
            this.dgvProducto.TabIndex = 155;
            this.dgvProducto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducto_CellContentClick);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Precioventa
            // 
            this.Precioventa.DataPropertyName = "PrecioVenta";
            this.Precioventa.HeaderText = "PrecioVenta";
            this.Precioventa.Name = "Precioventa";
            this.Precioventa.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label18.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label18.Location = new System.Drawing.Point(586, 580);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(127, 18);
            this.label18.TabIndex = 153;
            this.label18.Text = "IVA RETENIDO:";
            // 
            // txtivaRetenido
            // 
            this.txtivaRetenido.BackColor = System.Drawing.SystemColors.Window;
            this.txtivaRetenido.Location = new System.Drawing.Point(734, 576);
            this.txtivaRetenido.Multiline = true;
            this.txtivaRetenido.Name = "txtivaRetenido";
            this.txtivaRetenido.Size = new System.Drawing.Size(121, 22);
            this.txtivaRetenido.TabIndex = 154;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label16.Location = new System.Drawing.Point(586, 603);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(117, 18);
            this.label16.TabIndex = 151;
            this.label16.Text = "DESCUENTO:";
            // 
            // txtDescuento
            // 
            this.txtDescuento.BackColor = System.Drawing.SystemColors.Window;
            this.txtDescuento.Location = new System.Drawing.Point(734, 600);
            this.txtDescuento.Multiline = true;
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(121, 22);
            this.txtDescuento.TabIndex = 152;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label19.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label19.Location = new System.Drawing.Point(586, 504);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(102, 18);
            this.label19.TabIndex = 145;
            this.label19.Text = "13% DE IVA:";
            // 
            // txtIva
            // 
            this.txtIva.BackColor = System.Drawing.SystemColors.Window;
            this.txtIva.Location = new System.Drawing.Point(734, 504);
            this.txtIva.Multiline = true;
            this.txtIva.Name = "txtIva";
            this.txtIva.Size = new System.Drawing.Size(121, 22);
            this.txtIva.TabIndex = 146;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label21.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label21.Location = new System.Drawing.Point(586, 556);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(123, 18);
            this.label21.TabIndex = 149;
            this.label21.Text = "VENTA TOTAL:";
            // 
            // txtSubtota
            // 
            this.txtSubtota.BackColor = System.Drawing.SystemColors.Window;
            this.txtSubtota.Location = new System.Drawing.Point(734, 528);
            this.txtSubtota.Multiline = true;
            this.txtSubtota.Name = "txtSubtota";
            this.txtSubtota.Size = new System.Drawing.Size(121, 22);
            this.txtSubtota.TabIndex = 148;
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.Window;
            this.txtTotal.Location = new System.Drawing.Point(734, 552);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(121, 22);
            this.txtTotal.TabIndex = 150;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label20.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label20.Location = new System.Drawing.Point(586, 529);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(109, 18);
            this.label20.TabIndex = 147;
            this.label20.Text = "SUB. TOTAL:";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.btnSalirForm);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.groupBox5.ForeColor = System.Drawing.SystemColors.InfoText;
            this.groupBox5.Location = new System.Drawing.Point(915, 419);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(375, 94);
            this.groupBox5.TabIndex = 144;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Herramientas";
            // 
            // btnSalirForm
            // 
            this.btnSalirForm.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSalirForm.Checked = true;
            this.btnSalirForm.Image = ((System.Drawing.Image)(resources.GetObject("btnSalirForm.Image")));
            this.btnSalirForm.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnSalirForm.Location = new System.Drawing.Point(150, 19);
            this.btnSalirForm.Name = "btnSalirForm";
            this.btnSalirForm.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(12);
            this.btnSalirForm.Size = new System.Drawing.Size(72, 67);
            this.btnSalirForm.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSalirForm.TabIndex = 137;
            this.btnSalirForm.Text = "Salir";
            this.btnSalirForm.Click += new System.EventHandler(this.btnSalirForm_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.btnCeditFiscal);
            this.groupBox3.Controls.Add(this.btnFactura);
            this.groupBox3.Controls.Add(this.btnTicket);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.groupBox3.Location = new System.Drawing.Point(915, 304);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(375, 109);
            this.groupBox3.TabIndex = 143;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tipo de Comprobante";
            // 
            // btnCeditFiscal
            // 
            this.btnCeditFiscal.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCeditFiscal.Checked = true;
            this.btnCeditFiscal.Image = ((System.Drawing.Image)(resources.GetObject("btnCeditFiscal.Image")));
            this.btnCeditFiscal.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnCeditFiscal.Location = new System.Drawing.Point(255, 23);
            this.btnCeditFiscal.Name = "btnCeditFiscal";
            this.btnCeditFiscal.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnCeditFiscal.Size = new System.Drawing.Size(99, 74);
            this.btnCeditFiscal.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCeditFiscal.TabIndex = 83;
            this.btnCeditFiscal.Text = "Credito Fiscal";
            this.btnCeditFiscal.Click += new System.EventHandler(this.btnCeditFiscal_Click);
            // 
            // btnFactura
            // 
            this.btnFactura.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnFactura.Checked = true;
            this.btnFactura.Image = ((System.Drawing.Image)(resources.GetObject("btnFactura.Image")));
            this.btnFactura.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnFactura.Location = new System.Drawing.Point(138, 23);
            this.btnFactura.Name = "btnFactura";
            this.btnFactura.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnFactura.Size = new System.Drawing.Size(99, 74);
            this.btnFactura.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnFactura.TabIndex = 82;
            this.btnFactura.Text = "Factura";
            this.btnFactura.Click += new System.EventHandler(this.btnFactura_Click);
            // 
            // btnTicket
            // 
            this.btnTicket.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTicket.Checked = true;
            this.btnTicket.Image = ((System.Drawing.Image)(resources.GetObject("btnTicket.Image")));
            this.btnTicket.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnTicket.Location = new System.Drawing.Point(19, 23);
            this.btnTicket.Name = "btnTicket";
            this.btnTicket.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnTicket.Size = new System.Drawing.Size(99, 74);
            this.btnTicket.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTicket.TabIndex = 81;
            this.btnTicket.Text = "Ticket";
            this.btnTicket.Click += new System.EventHandler(this.btnTicket_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblIdProducto);
            this.groupBox1.Controls.Add(this.btnBuscarProducto);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSubTotal);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Controls.Add(this.btnAgregarProduc);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtCantidad);
            this.groupBox1.Controls.Add(this.txtCodigoProducto);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtNombreProducto);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.groupBox1.Location = new System.Drawing.Point(880, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 219);
            this.groupBox1.TabIndex = 140;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Producto a Vender";
            // 
            // lblIdProducto
            // 
            this.lblIdProducto.AutoSize = true;
            this.lblIdProducto.Location = new System.Drawing.Point(152, 181);
            this.lblIdProducto.Name = "lblIdProducto";
            this.lblIdProducto.Size = new System.Drawing.Size(0, 16);
            this.lblIdProducto.TabIndex = 143;
            this.lblIdProducto.Visible = false;
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBuscarProducto.Checked = true;
            this.btnBuscarProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarProducto.Image")));
            this.btnBuscarProducto.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnBuscarProducto.Location = new System.Drawing.Point(304, 29);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnBuscarProducto.Size = new System.Drawing.Size(85, 57);
            this.btnBuscarProducto.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBuscarProducto.TabIndex = 142;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label4.Location = new System.Drawing.Point(32, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 18);
            this.label4.TabIndex = 132;
            this.label4.Text = "Sub Total:";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Enabled = false;
            this.txtSubTotal.Location = new System.Drawing.Point(155, 149);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(127, 22);
            this.txtSubTotal.TabIndex = 133;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label12.Location = new System.Drawing.Point(55, 90);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 18);
            this.label12.TabIndex = 130;
            this.label12.Text = "Precio:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(155, 89);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(127, 22);
            this.txtPrecio.TabIndex = 131;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            this.txtPrecio.Leave += new System.EventHandler(this.txtPrecio_Leave);
            // 
            // btnAgregarProduc
            // 
            this.btnAgregarProduc.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAgregarProduc.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarProduc.Checked = true;
            this.btnAgregarProduc.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnAgregarProduc.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarProduc.Image")));
            this.btnAgregarProduc.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnAgregarProduc.Location = new System.Drawing.Point(304, 110);
            this.btnAgregarProduc.Name = "btnAgregarProduc";
            this.btnAgregarProduc.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnAgregarProduc.Size = new System.Drawing.Size(85, 67);
            this.btnAgregarProduc.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAgregarProduc.TabIndex = 128;
            this.btnAgregarProduc.Text = "Agregar";
            this.btnAgregarProduc.Click += new System.EventHandler(this.btnAgregarProduc_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label8.Location = new System.Drawing.Point(38, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 18);
            this.label8.TabIndex = 126;
            this.label8.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(155, 122);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(127, 22);
            this.txtCantidad.TabIndex = 127;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            this.txtCantidad.Leave += new System.EventHandler(this.txtCantidad_Leave);
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.Location = new System.Drawing.Point(155, 31);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(127, 22);
            this.txtCodigoProducto.TabIndex = 124;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label6.Location = new System.Drawing.Point(50, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 18);
            this.label6.TabIndex = 122;
            this.label6.Text = "Codigo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label7.Location = new System.Drawing.Point(35, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 18);
            this.label7.TabIndex = 123;
            this.label7.Text = "Producto:";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Enabled = false;
            this.txtNombreProducto.Location = new System.Drawing.Point(155, 61);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(127, 22);
            this.txtNombreProducto.TabIndex = 125;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lblIdClient);
            this.groupBox2.Controls.Add(this.cbTipoTarjeta);
            this.groupBox2.Controls.Add(this.cbFormaPago);
            this.groupBox2.Controls.Add(this.dtpFechaFactura);
            this.groupBox2.Controls.Add(this.btnBuscarCliente);
            this.groupBox2.Controls.Add(this.txtNumeroDocumento);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.lblTipoTarjeta);
            this.groupBox2.Controls.Add(this.lblNumeroTarjeta);
            this.groupBox2.Controls.Add(this.txtNumeroTarjeta);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtNit);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtNumeroRegistro);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtNombreCliente);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.groupBox2.Location = new System.Drawing.Point(16, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(840, 225);
            this.groupBox2.TabIndex = 138;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Generales";
            // 
            // lblIdClient
            // 
            this.lblIdClient.AutoSize = true;
            this.lblIdClient.Location = new System.Drawing.Point(507, 80);
            this.lblIdClient.Name = "lblIdClient";
            this.lblIdClient.Size = new System.Drawing.Size(0, 16);
            this.lblIdClient.TabIndex = 145;
            this.lblIdClient.Visible = false;
            // 
            // cbTipoTarjeta
            // 
            this.cbTipoTarjeta.FormattingEnabled = true;
            this.cbTipoTarjeta.Location = new System.Drawing.Point(212, 184);
            this.cbTipoTarjeta.Name = "cbTipoTarjeta";
            this.cbTipoTarjeta.Size = new System.Drawing.Size(178, 24);
            this.cbTipoTarjeta.TabIndex = 144;
            this.cbTipoTarjeta.Visible = false;
            // 
            // cbFormaPago
            // 
            this.cbFormaPago.FormattingEnabled = true;
            this.cbFormaPago.Location = new System.Drawing.Point(212, 132);
            this.cbFormaPago.Name = "cbFormaPago";
            this.cbFormaPago.Size = new System.Drawing.Size(178, 24);
            this.cbFormaPago.TabIndex = 143;
            this.cbFormaPago.SelectedIndexChanged += new System.EventHandler(this.cbFormaPago_SelectedIndexChanged);
            // 
            // dtpFechaFactura
            // 
            this.dtpFechaFactura.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFactura.Location = new System.Drawing.Point(613, 15);
            this.dtpFechaFactura.Name = "dtpFechaFactura";
            this.dtpFechaFactura.Size = new System.Drawing.Size(114, 22);
            this.dtpFechaFactura.TabIndex = 142;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBuscarCliente.Checked = true;
            this.btnBuscarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarCliente.Image")));
            this.btnBuscarCliente.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnBuscarCliente.Location = new System.Drawing.Point(416, 31);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnBuscarCliente.Size = new System.Drawing.Size(68, 57);
            this.btnBuscarCliente.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBuscarCliente.TabIndex = 141;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // txtNumeroDocumento
            // 
            this.txtNumeroDocumento.Location = new System.Drawing.Point(212, 57);
            this.txtNumeroDocumento.Name = "txtNumeroDocumento";
            this.txtNumeroDocumento.Size = new System.Drawing.Size(178, 22);
            this.txtNumeroDocumento.TabIndex = 137;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label22.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label22.Location = new System.Drawing.Point(52, 56);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(137, 18);
            this.label22.TabIndex = 136;
            this.label22.Text = "Documento No. :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label15.Location = new System.Drawing.Point(53, 134);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 18);
            this.label15.TabIndex = 131;
            this.label15.Text = "Pago:";
            // 
            // lblTipoTarjeta
            // 
            this.lblTipoTarjeta.AutoSize = true;
            this.lblTipoTarjeta.BackColor = System.Drawing.Color.Transparent;
            this.lblTipoTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblTipoTarjeta.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblTipoTarjeta.Location = new System.Drawing.Point(53, 185);
            this.lblTipoTarjeta.Name = "lblTipoTarjeta";
            this.lblTipoTarjeta.Size = new System.Drawing.Size(103, 18);
            this.lblTipoTarjeta.TabIndex = 129;
            this.lblTipoTarjeta.Text = "Tipo Tarjeta:";
            // 
            // lblNumeroTarjeta
            // 
            this.lblNumeroTarjeta.AutoSize = true;
            this.lblNumeroTarjeta.BackColor = System.Drawing.Color.Transparent;
            this.lblNumeroTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblNumeroTarjeta.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblNumeroTarjeta.Location = new System.Drawing.Point(53, 159);
            this.lblNumeroTarjeta.Name = "lblNumeroTarjeta";
            this.lblNumeroTarjeta.Size = new System.Drawing.Size(91, 18);
            this.lblNumeroTarjeta.TabIndex = 127;
            this.lblNumeroTarjeta.Text = "No. Tajeta:";
            // 
            // txtNumeroTarjeta
            // 
            this.txtNumeroTarjeta.Location = new System.Drawing.Point(212, 159);
            this.txtNumeroTarjeta.Name = "txtNumeroTarjeta";
            this.txtNumeroTarjeta.Size = new System.Drawing.Size(178, 22);
            this.txtNumeroTarjeta.TabIndex = 128;
            this.txtNumeroTarjeta.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label3.Location = new System.Drawing.Point(52, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 18);
            this.label3.TabIndex = 122;
            this.label3.Text = "NIT:";
            // 
            // txtNit
            // 
            this.txtNit.Location = new System.Drawing.Point(212, 81);
            this.txtNit.Name = "txtNit";
            this.txtNit.Size = new System.Drawing.Size(178, 22);
            this.txtNit.TabIndex = 123;
            // 
            // label9
            // 
            this.label9.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label9.Location = new System.Drawing.Point(548, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 18);
            this.label9.TabIndex = 112;
            this.label9.Text = "Fecha:";
            // 
            // txtNumeroRegistro
            // 
            this.txtNumeroRegistro.Location = new System.Drawing.Point(212, 31);
            this.txtNumeroRegistro.Name = "txtNumeroRegistro";
            this.txtNumeroRegistro.Size = new System.Drawing.Size(178, 22);
            this.txtNumeroRegistro.TabIndex = 111;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(53, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 18);
            this.label1.TabIndex = 110;
            this.label1.Text = "Registro No. :";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(212, 106);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(358, 22);
            this.txtNombreCliente.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(52, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 18);
            this.label2.TabIndex = 42;
            this.label2.Text = "Cliente:";
            // 
            // Comprobante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1365, 651);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Comprobante";
            this.Text = "Comprobante";
            this.Load += new System.EventHandler(this.Comprobante_Load);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNumeroDocumento;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblTipoTarjeta;
        private System.Windows.Forms.Label lblNumeroTarjeta;
        private System.Windows.Forms.TextBox txtNumeroTarjeta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNumeroRegistro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPrecio;
        private DevComponents.DotNetBar.ButtonX btnAgregarProduc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtCodigoProducto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevComponents.DotNetBar.ButtonX btnCeditFiscal;
        private DevComponents.DotNetBar.ButtonX btnFactura;
        private DevComponents.DotNetBar.ButtonX btnTicket;
        private System.Windows.Forms.GroupBox groupBox5;
        private DevComponents.DotNetBar.ButtonX btnSalirForm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtivaRetenido;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtIva;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtSubtota;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label20;
        private DevComponents.DotNetBar.ButtonX btnBuscarCliente;
        private System.Windows.Forms.DateTimePicker dtpFechaFactura;
        private System.Windows.Forms.ComboBox cbFormaPago;
        private System.Windows.Forms.ComboBox cbTipoTarjeta;
        private DevComponents.DotNetBar.ButtonX btnBuscarProducto;
        private System.Windows.Forms.DataGridView dgvProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precioventa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnMenos;
        private System.Windows.Forms.Button btnMas;
        private System.Windows.Forms.Label lblIdClient;
        private System.Windows.Forms.Label lblIdProducto;
    }
}