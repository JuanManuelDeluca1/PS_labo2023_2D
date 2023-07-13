namespace Carniceria
{
    partial class FormVenderEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVenderEmpleado));
            this.listBoxCarne = new System.Windows.Forms.ListBox();
            this.listBoxCliente = new System.Windows.Forms.ListBox();
            this.Vender = new System.Windows.Forms.Button();
            this.labelCarne = new System.Windows.Forms.Label();
            this.labelClientes = new System.Windows.Forms.Label();
            this.groupBoxCarne = new System.Windows.Forms.GroupBox();
            this.buttonAgregarCarne = new System.Windows.Forms.Button();
            this.nudKilos = new System.Windows.Forms.NumericUpDown();
            this.labelKilos = new System.Windows.Forms.Label();
            this.groupBoxVenta = new System.Windows.Forms.GroupBox();
            this.labelCostoTotal = new System.Windows.Forms.Label();
            this.labelCosto = new System.Windows.Forms.Label();
            this.listBoxPedido = new System.Windows.Forms.ListBox();
            this.labelMontoPasado = new System.Windows.Forms.Label();
            this.labelMail3 = new System.Windows.Forms.Label();
            this.labelMonto = new System.Windows.Forms.Label();
            this.labelMail2 = new System.Windows.Forms.Label();
            this.Mials = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mails = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonInforme = new System.Windows.Forms.Button();
            this.groupBoxCarne.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKilos)).BeginInit();
            this.groupBoxVenta.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxCarne
            // 
            this.listBoxCarne.FormattingEnabled = true;
            this.listBoxCarne.ItemHeight = 15;
            this.listBoxCarne.Location = new System.Drawing.Point(314, 32);
            this.listBoxCarne.Name = "listBoxCarne";
            this.listBoxCarne.Size = new System.Drawing.Size(342, 124);
            this.listBoxCarne.TabIndex = 0;
            // 
            // listBoxCliente
            // 
            this.listBoxCliente.FormattingEnabled = true;
            this.listBoxCliente.ItemHeight = 15;
            this.listBoxCliente.Location = new System.Drawing.Point(12, 32);
            this.listBoxCliente.Name = "listBoxCliente";
            this.listBoxCliente.Size = new System.Drawing.Size(245, 229);
            this.listBoxCliente.TabIndex = 1;
            this.listBoxCliente.SelectedIndexChanged += new System.EventHandler(this.listBoxCliente_SelectedIndexChanged);
            // 
            // Vender
            // 
            this.Vender.Location = new System.Drawing.Point(385, 378);
            this.Vender.Name = "Vender";
            this.Vender.Size = new System.Drawing.Size(75, 23);
            this.Vender.TabIndex = 2;
            this.Vender.Text = "Vender";
            this.Vender.UseVisualStyleBackColor = true;
            this.Vender.Click += new System.EventHandler(this.Vender_Click);
            // 
            // labelCarne
            // 
            this.labelCarne.AutoSize = true;
            this.labelCarne.BackColor = System.Drawing.Color.Transparent;
            this.labelCarne.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCarne.Location = new System.Drawing.Point(314, 9);
            this.labelCarne.Name = "labelCarne";
            this.labelCarne.Size = new System.Drawing.Size(53, 20);
            this.labelCarne.TabIndex = 4;
            this.labelCarne.Text = "Carnes";
            // 
            // labelClientes
            // 
            this.labelClientes.AutoSize = true;
            this.labelClientes.BackColor = System.Drawing.Color.Transparent;
            this.labelClientes.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelClientes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelClientes.Location = new System.Drawing.Point(12, 9);
            this.labelClientes.Name = "labelClientes";
            this.labelClientes.Size = new System.Drawing.Size(61, 20);
            this.labelClientes.TabIndex = 5;
            this.labelClientes.Text = "Clientes";
            // 
            // groupBoxCarne
            // 
            this.groupBoxCarne.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxCarne.Controls.Add(this.buttonAgregarCarne);
            this.groupBoxCarne.Controls.Add(this.nudKilos);
            this.groupBoxCarne.Controls.Add(this.labelKilos);
            this.groupBoxCarne.Location = new System.Drawing.Point(314, 184);
            this.groupBoxCarne.Name = "groupBoxCarne";
            this.groupBoxCarne.Size = new System.Drawing.Size(264, 78);
            this.groupBoxCarne.TabIndex = 7;
            this.groupBoxCarne.TabStop = false;
            this.groupBoxCarne.Text = "Seleccione Kilos";
            // 
            // buttonAgregarCarne
            // 
            this.buttonAgregarCarne.Location = new System.Drawing.Point(183, 37);
            this.buttonAgregarCarne.Name = "buttonAgregarCarne";
            this.buttonAgregarCarne.Size = new System.Drawing.Size(75, 23);
            this.buttonAgregarCarne.TabIndex = 4;
            this.buttonAgregarCarne.Text = "Agregar";
            this.buttonAgregarCarne.UseVisualStyleBackColor = true;
            this.buttonAgregarCarne.Click += new System.EventHandler(this.buttonAgregarCarne_Click);
            // 
            // nudKilos
            // 
            this.nudKilos.Location = new System.Drawing.Point(71, 37);
            this.nudKilos.Name = "nudKilos";
            this.nudKilos.Size = new System.Drawing.Size(100, 23);
            this.nudKilos.TabIndex = 3;
            // 
            // labelKilos
            // 
            this.labelKilos.AutoSize = true;
            this.labelKilos.Location = new System.Drawing.Point(6, 45);
            this.labelKilos.Name = "labelKilos";
            this.labelKilos.Size = new System.Drawing.Size(32, 15);
            this.labelKilos.TabIndex = 1;
            this.labelKilos.Text = "Kilos";
            // 
            // groupBoxVenta
            // 
            this.groupBoxVenta.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxVenta.Controls.Add(this.labelCostoTotal);
            this.groupBoxVenta.Controls.Add(this.labelCosto);
            this.groupBoxVenta.Controls.Add(this.listBoxPedido);
            this.groupBoxVenta.Controls.Add(this.labelMontoPasado);
            this.groupBoxVenta.Controls.Add(this.labelMail3);
            this.groupBoxVenta.Controls.Add(this.labelMonto);
            this.groupBoxVenta.Controls.Add(this.labelMail2);
            this.groupBoxVenta.Location = new System.Drawing.Point(675, 32);
            this.groupBoxVenta.Name = "groupBoxVenta";
            this.groupBoxVenta.Size = new System.Drawing.Size(273, 392);
            this.groupBoxVenta.TabIndex = 8;
            this.groupBoxVenta.TabStop = false;
            this.groupBoxVenta.Text = "Datos Venta";
            // 
            // labelCostoTotal
            // 
            this.labelCostoTotal.AutoSize = true;
            this.labelCostoTotal.Location = new System.Drawing.Point(112, 351);
            this.labelCostoTotal.Name = "labelCostoTotal";
            this.labelCostoTotal.Size = new System.Drawing.Size(0, 15);
            this.labelCostoTotal.TabIndex = 6;
            // 
            // labelCosto
            // 
            this.labelCosto.AutoSize = true;
            this.labelCosto.Location = new System.Drawing.Point(32, 350);
            this.labelCosto.Name = "labelCosto";
            this.labelCosto.Size = new System.Drawing.Size(69, 15);
            this.labelCosto.TabIndex = 5;
            this.labelCosto.Text = "Costo Total:";
            // 
            // listBoxPedido
            // 
            this.listBoxPedido.FormattingEnabled = true;
            this.listBoxPedido.ItemHeight = 15;
            this.listBoxPedido.Location = new System.Drawing.Point(23, 144);
            this.listBoxPedido.Name = "listBoxPedido";
            this.listBoxPedido.Size = new System.Drawing.Size(235, 184);
            this.listBoxPedido.TabIndex = 4;
            // 
            // labelMontoPasado
            // 
            this.labelMontoPasado.AutoSize = true;
            this.labelMontoPasado.Location = new System.Drawing.Point(89, 81);
            this.labelMontoPasado.Name = "labelMontoPasado";
            this.labelMontoPasado.Size = new System.Drawing.Size(0, 15);
            this.labelMontoPasado.TabIndex = 3;
            // 
            // labelMail3
            // 
            this.labelMail3.AutoSize = true;
            this.labelMail3.Location = new System.Drawing.Point(78, 38);
            this.labelMail3.Name = "labelMail3";
            this.labelMail3.Size = new System.Drawing.Size(0, 15);
            this.labelMail3.TabIndex = 2;
            // 
            // labelMonto
            // 
            this.labelMonto.AutoSize = true;
            this.labelMonto.Location = new System.Drawing.Point(23, 79);
            this.labelMonto.Name = "labelMonto";
            this.labelMonto.Size = new System.Drawing.Size(49, 15);
            this.labelMonto.TabIndex = 1;
            this.labelMonto.Text = "Monto :";
            // 
            // labelMail2
            // 
            this.labelMail2.AutoSize = true;
            this.labelMail2.Location = new System.Drawing.Point(23, 38);
            this.labelMail2.Name = "labelMail2";
            this.labelMail2.Size = new System.Drawing.Size(36, 15);
            this.labelMail2.TabIndex = 0;
            this.labelMail2.Text = "Mail :";
            // 
            // Mials
            // 
            this.Mials.HeaderText = "Mials Clientes";
            this.Mials.Name = "Mials";
            // 
            // Monto
            // 
            this.Monto.HeaderText = "Monto de Dinero";
            this.Monto.Name = "Monto";
            // 
            // Mial
            // 
            this.Mial.HeaderText = "Mail Client";
            this.Mial.Name = "Mial";
            // 
            // Mails
            // 
            this.Mails.HeaderText = "Mials";
            this.Mails.Name = "Mails";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Mail";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // buttonInforme
            // 
            this.buttonInforme.Location = new System.Drawing.Point(485, 379);
            this.buttonInforme.Name = "buttonInforme";
            this.buttonInforme.Size = new System.Drawing.Size(75, 23);
            this.buttonInforme.TabIndex = 9;
            this.buttonInforme.Text = "Ver ventas";
            this.buttonInforme.UseVisualStyleBackColor = true;
            this.buttonInforme.Click += new System.EventHandler(this.buttonInforme_Click);
            // 
            // FormVenderEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BackgroundImage = global::Carniceria.Properties.Resources.seasonal_sales_shopping_cart_shopping_cart_on_bright_background_free_photo;
            this.ClientSize = new System.Drawing.Size(963, 457);
            this.Controls.Add(this.buttonInforme);
            this.Controls.Add(this.groupBoxVenta);
            this.Controls.Add(this.groupBoxCarne);
            this.Controls.Add(this.labelClientes);
            this.Controls.Add(this.labelCarne);
            this.Controls.Add(this.Vender);
            this.Controls.Add(this.listBoxCliente);
            this.Controls.Add(this.listBoxCarne);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormVenderEmpleado";
            this.Text = "FormVenderEmpleado";
            this.Load += new System.EventHandler(this.FormVenderEmpleado_Load);
            this.groupBoxCarne.ResumeLayout(false);
            this.groupBoxCarne.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKilos)).EndInit();
            this.groupBoxVenta.ResumeLayout(false);
            this.groupBoxVenta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBoxCarne;
        private ListBox listBoxCliente;
        private Button Vender;
        private Label labelCarne;
        private Label labelClientes;
        private GroupBox groupBoxCarne;
        private Button buttonAgregarCarne;
        private NumericUpDown nudKilos;
        private Label labelKilos;
        private GroupBox groupBoxVenta;
        private Label labelMonto;
        private Label labelMail2;
        private Label labelMontoPasado;
        private Label labelMail3;
        private ListBox listBoxPedido;
        private Label labelCostoTotal;
        private Label labelCosto;
        private DataGridViewTextBoxColumn Mials;
        private DataGridViewTextBoxColumn Monto;
        private DataGridViewTextBoxColumn Mial;
        private DataGridViewTextBoxColumn Mails;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private Button buttonInforme;
    }
}