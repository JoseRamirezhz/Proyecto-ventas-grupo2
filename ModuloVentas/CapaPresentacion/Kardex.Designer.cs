namespace ProyectoUML
{
    partial class Kardex
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kardex));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSalirForm = new DevComponents.DotNetBar.ButtonX();
            this.label5 = new System.Windows.Forms.Label();
            this.btnImpriKardex = new DevComponents.DotNetBar.ButtonX();
            this.btnAgregar = new DevComponents.DotNetBar.ButtonX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLASE_DE_MOVIMIENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO_VENTAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(597, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "KARDEX";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(288, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 22);
            this.textBox1.TabIndex = 45;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnSalirForm);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnImpriKardex);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.btnAgregar);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.groupBox2.Location = new System.Drawing.Point(62, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1245, 124);
            this.groupBox2.TabIndex = 119;
            this.groupBox2.TabStop = false;
            // 
            // btnSalirForm
            // 
            this.btnSalirForm.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSalirForm.Checked = true;
            this.btnSalirForm.Image = ((System.Drawing.Image)(resources.GetObject("btnSalirForm.Image")));
            this.btnSalirForm.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnSalirForm.Location = new System.Drawing.Point(1082, 29);
            this.btnSalirForm.Name = "btnSalirForm";
            this.btnSalirForm.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(12);
            this.btnSalirForm.Size = new System.Drawing.Size(85, 69);
            this.btnSalirForm.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSalirForm.TabIndex = 138;
            this.btnSalirForm.Text = "Salir";
            this.btnSalirForm.Click += new System.EventHandler(this.btnSalirForm_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label5.Location = new System.Drawing.Point(132, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 18);
            this.label5.TabIndex = 111;
            this.label5.Text = "Codigo Producto:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnImpriKardex
            // 
            this.btnImpriKardex.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnImpriKardex.Checked = true;
            this.btnImpriKardex.Image = ((System.Drawing.Image)(resources.GetObject("btnImpriKardex.Image")));
            this.btnImpriKardex.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnImpriKardex.Location = new System.Drawing.Point(991, 29);
            this.btnImpriKardex.Name = "btnImpriKardex";
            this.btnImpriKardex.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnImpriKardex.Size = new System.Drawing.Size(85, 69);
            this.btnImpriKardex.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnImpriKardex.TabIndex = 110;
            this.btnImpriKardex.Text = "Imprimir";
            // 
            // btnAgregar
            // 
            this.btnAgregar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAgregar.Checked = true;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnAgregar.Location = new System.Drawing.Point(490, 25);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnAgregar.Size = new System.Drawing.Size(85, 66);
            this.btnAgregar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAgregar.TabIndex = 109;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(62, 265);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1245, 355);
            this.groupBox1.TabIndex = 120;
            this.groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Lavender;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FECHA,
            this.Column1,
            this.CLASE_DE_MOVIMIENTO,
            this.Column2,
            this.Column3,
            this.PRECIO_VENTAS,
            this.Column6});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dataGridView1.Location = new System.Drawing.Point(21, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1203, 297);
            this.dataGridView1.TabIndex = 43;
            // 
            // FECHA
            // 
            this.FECHA.HeaderText = "FECHA";
            this.FECHA.Name = "FECHA";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "No. DOCUMENTO";
            this.Column1.Name = "Column1";
            // 
            // CLASE_DE_MOVIMIENTO
            // 
            this.CLASE_DE_MOVIMIENTO.HeaderText = "CLASE_MOVIMIENTO";
            this.CLASE_DE_MOVIMIENTO.Name = "CLASE_DE_MOVIMIENTO";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ENTRADA";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "SALIDA";
            this.Column3.Name = "Column3";
            // 
            // PRECIO_VENTAS
            // 
            this.PRECIO_VENTAS.HeaderText = "PRECIO_VENTAS";
            this.PRECIO_VENTAS.Name = "PRECIO_VENTAS";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "COSTO PROMEDIO";
            this.Column6.Name = "Column6";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(12, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1341, 636);
            this.groupBox3.TabIndex = 157;
            this.groupBox3.TabStop = false;
            // 
            // Kardex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1365, 651);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Kardex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kardex";
            this.Load += new System.EventHandler(this.Kardex_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.ButtonX btnAgregar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private DevComponents.DotNetBar.ButtonX btnImpriKardex;
        private DevComponents.DotNetBar.ButtonX btnSalirForm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO_VENTAS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLASE_DE_MOVIMIENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}