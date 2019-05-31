namespace ProyectoUML
{
    partial class Producto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Producto));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtgDatosCliente = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbFormaPago = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtNumRegistro = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtFecModificacion = new System.Windows.Forms.TextBox();
            this.txtFecCreacion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDocClient = new System.Windows.Forms.TextBox();
            this.txtTelClien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreCli = new System.Windows.Forms.TextBox();
            this.txtidCliente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnImpriCliente = new DevComponents.DotNetBar.ButtonX();
            this.btnInsertarUsu = new DevComponents.DotNetBar.ButtonX();
            this.buttonX4 = new DevComponents.DotNetBar.ButtonX();
            this.btnAgregar = new DevComponents.DotNetBar.ButtonX();
            this.buttonX6 = new DevComponents.DotNetBar.ButtonX();
            this.txtBucar = new System.Windows.Forms.TextBox();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX3 = new DevComponents.DotNetBar.ButtonX();
            this.label11 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO_COMPRA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO_VENTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CATEGORIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROVEEDOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USUARIO_CREACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USUARIO_MODIFICACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_MODIFICACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_CREACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatosCliente)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtgDatosCliente);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(12, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1341, 636);
            this.groupBox1.TabIndex = 122;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label5.Location = new System.Drawing.Point(545, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(262, 34);
            this.label5.TabIndex = 144;
            this.label5.Text = "Agregar Producto";
            // 
            // dtgDatosCliente
            // 
            this.dtgDatosCliente.AllowDrop = true;
            this.dtgDatosCliente.AllowUserToOrderColumns = true;
            this.dtgDatosCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgDatosCliente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dtgDatosCliente.BackgroundColor = System.Drawing.Color.Lavender;
            this.dtgDatosCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgDatosCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDatosCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.CODIGO,
            this.NOMBRE,
            this.PRECIO_COMPRA,
            this.PRECIO_VENTA,
            this.CATEGORIA,
            this.PROVEEDOR,
            this.ESTADO,
            this.USUARIO_CREACION,
            this.USUARIO_MODIFICACION,
            this.FECHA_MODIFICACION,
            this.FECHA_CREACION});
            this.dtgDatosCliente.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgDatosCliente.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dtgDatosCliente.Location = new System.Drawing.Point(17, 234);
            this.dtgDatosCliente.Name = "dtgDatosCliente";
            this.dtgDatosCliente.Size = new System.Drawing.Size(575, 381);
            this.dtgDatosCliente.TabIndex = 143;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cbFormaPago);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.txtNumRegistro);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtFecModificacion);
            this.groupBox2.Controls.Add(this.txtFecCreacion);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtDocClient);
            this.groupBox2.Controls.Add(this.txtTelClien);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtNombreCli);
            this.groupBox2.Controls.Add(this.txtidCliente);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.groupBox2.Location = new System.Drawing.Point(616, 234);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(713, 381);
            this.groupBox2.TabIndex = 142;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Generales";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label15.Location = new System.Drawing.Point(325, 250);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(81, 16);
            this.label15.TabIndex = 153;
            this.label15.Text = "Proveedor";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(413, 244);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(279, 22);
            this.textBox4.TabIndex = 152;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label14.Location = new System.Drawing.Point(329, 200);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 16);
            this.label14.TabIndex = 151;
            this.label14.Text = "Estado";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(411, 194);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(165, 24);
            this.comboBox1.TabIndex = 150;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(191, 288);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(157, 22);
            this.textBox2.TabIndex = 149;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(542, 288);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(144, 22);
            this.textBox3.TabIndex = 148;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label6.Location = new System.Drawing.Point(23, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 16);
            this.label6.TabIndex = 147;
            this.label6.Text = "Usuario Creacion";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label13.Location = new System.Drawing.Point(374, 294);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(154, 16);
            this.label13.TabIndex = 146;
            this.label13.Text = "Usuario Modificacion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label4.Location = new System.Drawing.Point(329, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 145;
            this.label4.Text = "Categoria";
            // 
            // cbFormaPago
            // 
            this.cbFormaPago.FormattingEnabled = true;
            this.cbFormaPago.Location = new System.Drawing.Point(411, 154);
            this.cbFormaPago.Name = "cbFormaPago";
            this.cbFormaPago.Size = new System.Drawing.Size(165, 24);
            this.cbFormaPago.TabIndex = 144;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label3.Location = new System.Drawing.Point(25, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 16);
            this.label3.TabIndex = 67;
            this.label3.Text = "Codigo Producto";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(169, 244);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 22);
            this.textBox1.TabIndex = 66;
            // 
            // txtNumRegistro
            // 
            this.txtNumRegistro.Location = new System.Drawing.Point(169, 82);
            this.txtNumRegistro.Name = "txtNumRegistro";
            this.txtNumRegistro.Size = new System.Drawing.Size(374, 22);
            this.txtNumRegistro.TabIndex = 65;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label12.Location = new System.Drawing.Point(25, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 16);
            this.label12.TabIndex = 64;
            this.label12.Text = "Nombre";
            // 
            // txtFecModificacion
            // 
            this.txtFecModificacion.Location = new System.Drawing.Point(191, 316);
            this.txtFecModificacion.Name = "txtFecModificacion";
            this.txtFecModificacion.Size = new System.Drawing.Size(157, 22);
            this.txtFecModificacion.TabIndex = 62;
            // 
            // txtFecCreacion
            // 
            this.txtFecCreacion.Location = new System.Drawing.Point(542, 316);
            this.txtFecCreacion.Name = "txtFecCreacion";
            this.txtFecCreacion.Size = new System.Drawing.Size(144, 22);
            this.txtFecCreacion.TabIndex = 61;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label8.Location = new System.Drawing.Point(25, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 16);
            this.label8.TabIndex = 60;
            this.label8.Text = "Precio Compra";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label10.Location = new System.Drawing.Point(23, 322);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(165, 16);
            this.label10.TabIndex = 59;
            this.label10.Text = "Fecha de Modificación";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label9.Location = new System.Drawing.Point(374, 322);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 16);
            this.label9.TabIndex = 58;
            this.label9.Text = "Fecha de Creación";
            // 
            // txtDocClient
            // 
            this.txtDocClient.Location = new System.Drawing.Point(169, 197);
            this.txtDocClient.Name = "txtDocClient";
            this.txtDocClient.Size = new System.Drawing.Size(130, 22);
            this.txtDocClient.TabIndex = 57;
            // 
            // txtTelClien
            // 
            this.txtTelClien.Location = new System.Drawing.Point(169, 156);
            this.txtTelClien.Name = "txtTelClien";
            this.txtTelClien.Size = new System.Drawing.Size(130, 22);
            this.txtTelClien.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(25, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 51;
            this.label2.Text = "Precio Venta";
            // 
            // txtNombreCli
            // 
            this.txtNombreCli.Location = new System.Drawing.Point(169, 118);
            this.txtNombreCli.Name = "txtNombreCli";
            this.txtNombreCli.Size = new System.Drawing.Size(523, 22);
            this.txtNombreCli.TabIndex = 48;
            // 
            // txtidCliente
            // 
            this.txtidCliente.Location = new System.Drawing.Point(169, 47);
            this.txtidCliente.Name = "txtidCliente";
            this.txtidCliente.Size = new System.Drawing.Size(110, 22);
            this.txtidCliente.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label7.Location = new System.Drawing.Point(25, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 16);
            this.label7.TabIndex = 46;
            this.label7.Text = "Descripcion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(25, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 45;
            this.label1.Text = "ID Producto";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.CausesValidation = false;
            this.groupBox3.Controls.Add(this.btnImpriCliente);
            this.groupBox3.Controls.Add(this.btnInsertarUsu);
            this.groupBox3.Controls.Add(this.buttonX4);
            this.groupBox3.Controls.Add(this.btnAgregar);
            this.groupBox3.Controls.Add(this.buttonX6);
            this.groupBox3.Controls.Add(this.txtBucar);
            this.groupBox3.Controls.Add(this.buttonX2);
            this.groupBox3.Controls.Add(this.buttonX3);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(17, 100);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1312, 105);
            this.groupBox3.TabIndex = 141;
            this.groupBox3.TabStop = false;
            // 
            // btnImpriCliente
            // 
            this.btnImpriCliente.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnImpriCliente.Checked = true;
            this.btnImpriCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnImpriCliente.Image")));
            this.btnImpriCliente.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnImpriCliente.Location = new System.Drawing.Point(222, 24);
            this.btnImpriCliente.Name = "btnImpriCliente";
            this.btnImpriCliente.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(12);
            this.btnImpriCliente.Size = new System.Drawing.Size(85, 65);
            this.btnImpriCliente.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnImpriCliente.TabIndex = 141;
            this.btnImpriCliente.Text = "Imprimir";
            // 
            // btnInsertarUsu
            // 
            this.btnInsertarUsu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnInsertarUsu.Checked = true;
            this.btnInsertarUsu.Image = ((System.Drawing.Image)(resources.GetObject("btnInsertarUsu.Image")));
            this.btnInsertarUsu.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnInsertarUsu.Location = new System.Drawing.Point(315, 24);
            this.btnInsertarUsu.Name = "btnInsertarUsu";
            this.btnInsertarUsu.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnInsertarUsu.Size = new System.Drawing.Size(84, 65);
            this.btnInsertarUsu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnInsertarUsu.TabIndex = 140;
            this.btnInsertarUsu.Text = "Insertar";
            // 
            // buttonX4
            // 
            this.buttonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX4.Checked = true;
            this.buttonX4.Image = ((System.Drawing.Image)(resources.GetObject("buttonX4.Image")));
            this.buttonX4.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonX4.Location = new System.Drawing.Point(931, 24);
            this.buttonX4.Name = "buttonX4";
            this.buttonX4.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.buttonX4.Size = new System.Drawing.Size(68, 57);
            this.buttonX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX4.TabIndex = 139;
            // 
            // btnAgregar
            // 
            this.btnAgregar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAgregar.Checked = true;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnAgregar.Location = new System.Drawing.Point(39, 24);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnAgregar.Size = new System.Drawing.Size(85, 65);
            this.btnAgregar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAgregar.TabIndex = 112;
            this.btnAgregar.Text = "Nuevo";
            // 
            // buttonX6
            // 
            this.buttonX6.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX6.Checked = true;
            this.buttonX6.Image = ((System.Drawing.Image)(resources.GetObject("buttonX6.Image")));
            this.buttonX6.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonX6.Location = new System.Drawing.Point(497, 24);
            this.buttonX6.Name = "buttonX6";
            this.buttonX6.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.buttonX6.Size = new System.Drawing.Size(84, 65);
            this.buttonX6.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX6.TabIndex = 138;
            this.buttonX6.Text = "Salir";
            // 
            // txtBucar
            // 
            this.txtBucar.Location = new System.Drawing.Point(737, 42);
            this.txtBucar.Name = "txtBucar";
            this.txtBucar.Size = new System.Drawing.Size(170, 20);
            this.txtBucar.TabIndex = 25;
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.Checked = true;
            this.buttonX2.Image = ((System.Drawing.Image)(resources.GetObject("buttonX2.Image")));
            this.buttonX2.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonX2.Location = new System.Drawing.Point(131, 24);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.buttonX2.Size = new System.Drawing.Size(85, 65);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.TabIndex = 114;
            this.buttonX2.Text = "Modificar";
            // 
            // buttonX3
            // 
            this.buttonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX3.Checked = true;
            this.buttonX3.Image = ((System.Drawing.Image)(resources.GetObject("buttonX3.Image")));
            this.buttonX3.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonX3.Location = new System.Drawing.Point(406, 24);
            this.buttonX3.Name = "buttonX3";
            this.buttonX3.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.buttonX3.Size = new System.Drawing.Size(84, 65);
            this.buttonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX3.TabIndex = 115;
            this.buttonX3.Text = "Eliminar";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label11.Location = new System.Drawing.Point(663, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 16);
            this.label11.TabIndex = 24;
            this.label11.Text = "Buscar";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID PRODUCTO";
            this.Column1.Name = "Column1";
            this.Column1.Width = 98;
            // 
            // CODIGO
            // 
            this.CODIGO.HeaderText = "CODIGO";
            this.CODIGO.Name = "CODIGO";
            this.CODIGO.Width = 74;
            // 
            // NOMBRE
            // 
            this.NOMBRE.HeaderText = "NOMBRE";
            this.NOMBRE.Name = "NOMBRE";
            this.NOMBRE.Width = 79;
            // 
            // PRECIO_COMPRA
            // 
            this.PRECIO_COMPRA.HeaderText = "PRECIO_COMPRA";
            this.PRECIO_COMPRA.Name = "PRECIO_COMPRA";
            this.PRECIO_COMPRA.Width = 124;
            // 
            // PRECIO_VENTA
            // 
            this.PRECIO_VENTA.HeaderText = "PRECIO_VENTA";
            this.PRECIO_VENTA.Name = "PRECIO_VENTA";
            this.PRECIO_VENTA.Width = 114;
            // 
            // CATEGORIA
            // 
            this.CATEGORIA.HeaderText = "CATEGORIA";
            this.CATEGORIA.Name = "CATEGORIA";
            this.CATEGORIA.Width = 94;
            // 
            // PROVEEDOR
            // 
            this.PROVEEDOR.HeaderText = "PROVEEDOR";
            this.PROVEEDOR.Name = "PROVEEDOR";
            // 
            // ESTADO
            // 
            this.ESTADO.HeaderText = "ESTADO";
            this.ESTADO.Name = "ESTADO";
            this.ESTADO.Width = 76;
            // 
            // USUARIO_CREACION
            // 
            this.USUARIO_CREACION.HeaderText = "USUARIO_CREACION";
            this.USUARIO_CREACION.Name = "USUARIO_CREACION";
            this.USUARIO_CREACION.Width = 142;
            // 
            // USUARIO_MODIFICACION
            // 
            this.USUARIO_MODIFICACION.HeaderText = "USUARIO_MODIFICACION";
            this.USUARIO_MODIFICACION.Name = "USUARIO_MODIFICACION";
            this.USUARIO_MODIFICACION.Width = 164;
            // 
            // FECHA_MODIFICACION
            // 
            this.FECHA_MODIFICACION.HeaderText = "FECHA_MODIFICACION";
            this.FECHA_MODIFICACION.Name = "FECHA_MODIFICACION";
            this.FECHA_MODIFICACION.Width = 150;
            // 
            // FECHA_CREACION
            // 
            this.FECHA_CREACION.HeaderText = "FECHA_CREACION";
            this.FECHA_CREACION.Name = "FECHA_CREACION";
            this.FECHA_CREACION.Width = 128;
            // 
            // Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1365, 651);
            this.Controls.Add(this.groupBox1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Producto";
            this.Load += new System.EventHandler(this.Producto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatosCliente)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtgDatosCliente;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNumRegistro;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtFecModificacion;
        private System.Windows.Forms.TextBox txtFecCreacion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDocClient;
        private System.Windows.Forms.TextBox txtTelClien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreCli;
        private System.Windows.Forms.TextBox txtidCliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevComponents.DotNetBar.ButtonX btnImpriCliente;
        private DevComponents.DotNetBar.ButtonX btnInsertarUsu;
        private DevComponents.DotNetBar.ButtonX buttonX4;
        private DevComponents.DotNetBar.ButtonX btnAgregar;
        private DevComponents.DotNetBar.ButtonX buttonX6;
        private System.Windows.Forms.TextBox txtBucar;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.ButtonX buttonX3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbFormaPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO_COMPRA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO_VENTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CATEGORIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROVEEDOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn USUARIO_CREACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn USUARIO_MODIFICACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_MODIFICACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_CREACION;
    }
}