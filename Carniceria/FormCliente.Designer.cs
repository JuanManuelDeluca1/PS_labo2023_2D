namespace Carniceria
{
    partial class FormCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCliente));
            this.groupBoxVendedor = new System.Windows.Forms.GroupBox();
            this.textBoxContraseña = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.labelMail = new System.Windows.Forms.Label();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.textBoxMonto = new System.Windows.Forms.TextBox();
            this.labelMonto = new System.Windows.Forms.Label();
            this.groupBoxMetodoPagoC = new System.Windows.Forms.GroupBox();
            this.radioButtoncCreditoPago = new System.Windows.Forms.RadioButton();
            this.radioButtonEfectivo = new System.Windows.Forms.RadioButton();
            this.buttonLongC = new System.Windows.Forms.Button();
            this.groupBoxVendedor.SuspendLayout();
            this.groupBoxMetodoPagoC.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxVendedor
            // 
            this.groupBoxVendedor.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxVendedor.Controls.Add(this.textBoxContraseña);
            this.groupBoxVendedor.Controls.Add(this.label1);
            this.groupBoxVendedor.Controls.Add(this.textBoxMail);
            this.groupBoxVendedor.Controls.Add(this.labelMail);
            this.groupBoxVendedor.Controls.Add(this.buttonVolver);
            this.groupBoxVendedor.Controls.Add(this.textBoxMonto);
            this.groupBoxVendedor.Controls.Add(this.labelMonto);
            this.groupBoxVendedor.Controls.Add(this.groupBoxMetodoPagoC);
            this.groupBoxVendedor.Controls.Add(this.buttonLongC);
            this.groupBoxVendedor.Location = new System.Drawing.Point(223, 29);
            this.groupBoxVendedor.Name = "groupBoxVendedor";
            this.groupBoxVendedor.Size = new System.Drawing.Size(200, 307);
            this.groupBoxVendedor.TabIndex = 0;
            this.groupBoxVendedor.TabStop = false;
            this.groupBoxVendedor.Text = "Ingrese sus datos";
            // 
            // textBoxContraseña
            // 
            this.textBoxContraseña.Location = new System.Drawing.Point(14, 102);
            this.textBoxContraseña.Name = "textBoxContraseña";
            this.textBoxContraseña.Size = new System.Drawing.Size(123, 23);
            this.textBoxContraseña.TabIndex = 2;
            this.textBoxContraseña.Text = "Ingrese Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Contraseña";
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(13, 46);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(123, 23);
            this.textBoxMail.TabIndex = 1;
            this.textBoxMail.Text = "Ingrese Mail";
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Location = new System.Drawing.Point(13, 28);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(30, 15);
            this.labelMail.TabIndex = 10;
            this.labelMail.Text = "Mail";
            // 
            // buttonVolver
            // 
            this.buttonVolver.Location = new System.Drawing.Point(119, 265);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(75, 23);
            this.buttonVolver.TabIndex = 7;
            this.buttonVolver.Text = "volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // textBoxMonto
            // 
            this.textBoxMonto.Location = new System.Drawing.Point(14, 159);
            this.textBoxMonto.Name = "textBoxMonto";
            this.textBoxMonto.Size = new System.Drawing.Size(123, 23);
            this.textBoxMonto.TabIndex = 3;
            this.textBoxMonto.Text = "Ingrese Monto";
            // 
            // labelMonto
            // 
            this.labelMonto.AutoSize = true;
            this.labelMonto.Location = new System.Drawing.Point(14, 141);
            this.labelMonto.Name = "labelMonto";
            this.labelMonto.Size = new System.Drawing.Size(43, 15);
            this.labelMonto.TabIndex = 5;
            this.labelMonto.Text = "Monto";
            // 
            // groupBoxMetodoPagoC
            // 
            this.groupBoxMetodoPagoC.Controls.Add(this.radioButtoncCreditoPago);
            this.groupBoxMetodoPagoC.Controls.Add(this.radioButtonEfectivo);
            this.groupBoxMetodoPagoC.Location = new System.Drawing.Point(13, 188);
            this.groupBoxMetodoPagoC.Name = "groupBoxMetodoPagoC";
            this.groupBoxMetodoPagoC.Size = new System.Drawing.Size(168, 71);
            this.groupBoxMetodoPagoC.TabIndex = 7;
            this.groupBoxMetodoPagoC.TabStop = false;
            this.groupBoxMetodoPagoC.Text = "Metodo de Pago";
            // 
            // radioButtoncCreditoPago
            // 
            this.radioButtoncCreditoPago.AutoSize = true;
            this.radioButtoncCreditoPago.Location = new System.Drawing.Point(10, 47);
            this.radioButtoncCreditoPago.Name = "radioButtoncCreditoPago";
            this.radioButtoncCreditoPago.Size = new System.Drawing.Size(64, 19);
            this.radioButtoncCreditoPago.TabIndex = 5;
            this.radioButtoncCreditoPago.TabStop = true;
            this.radioButtoncCreditoPago.Text = "Credito";
            this.radioButtoncCreditoPago.UseVisualStyleBackColor = true;
            // 
            // radioButtonEfectivo
            // 
            this.radioButtonEfectivo.AutoSize = true;
            this.radioButtonEfectivo.Location = new System.Drawing.Point(9, 23);
            this.radioButtonEfectivo.Name = "radioButtonEfectivo";
            this.radioButtonEfectivo.Size = new System.Drawing.Size(67, 19);
            this.radioButtonEfectivo.TabIndex = 4;
            this.radioButtonEfectivo.TabStop = true;
            this.radioButtonEfectivo.Text = "Efectivo";
            this.radioButtonEfectivo.UseVisualStyleBackColor = true;
            // 
            // buttonLongC
            // 
            this.buttonLongC.Location = new System.Drawing.Point(14, 265);
            this.buttonLongC.Name = "buttonLongC";
            this.buttonLongC.Size = new System.Drawing.Size(75, 26);
            this.buttonLongC.TabIndex = 6;
            this.buttonLongC.Text = "Ingresar";
            this.buttonLongC.UseVisualStyleBackColor = true;
            this.buttonLongC.Click += new System.EventHandler(this.buttonLongC_Click);
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Carniceria.Properties.Resources.carniceria_stand_caricatura_18591_28542;
            this.ClientSize = new System.Drawing.Size(635, 450);
            this.Controls.Add(this.groupBoxVendedor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCliente";
            this.Text = "FromComprador";
            this.groupBoxVendedor.ResumeLayout(false);
            this.groupBoxVendedor.PerformLayout();
            this.groupBoxMetodoPagoC.ResumeLayout(false);
            this.groupBoxMetodoPagoC.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBoxVendedor;
        private GroupBox groupBoxMetodoPagoC;
        private RadioButton radioButtoncCreditoPago;
        private RadioButton radioButtonEfectivo;
        private Button buttonLongC;
        private TextBox textBoxMonto;
        private Label labelMonto;
        private Button buttonVolver;
        private Label labelMail;
        private TextBox textBoxMail;
        private Label label1;
        private TextBox textBoxContraseña;
    }
}