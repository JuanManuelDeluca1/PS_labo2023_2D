namespace Carniceria
{
    partial class FormVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVenta));
            labelCliente = new Label();
            buttonComprar = new Button();
            comboBoxCarne = new ComboBox();
            label1Carne = new Label();
            labelKilos = new Label();
            nudKilos = new NumericUpDown();
            buttonCancelar = new Button();
            listBoxPedido = new ListBox();
            textBoxTotal = new TextBox();
            buttonAgregar = new Button();
            labelPrecioTotal = new Label();
            pictureBoxPublicidad = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)nudKilos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPublicidad).BeginInit();
            SuspendLayout();
            // 
            // labelCliente
            // 
            labelCliente.AutoSize = true;
            labelCliente.BackColor = Color.Transparent;
            labelCliente.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelCliente.Location = new Point(41, 19);
            labelCliente.Name = "labelCliente";
            labelCliente.Size = new Size(50, 20);
            labelCliente.TabIndex = 0;
            labelCliente.Text = "label1";
            // 
            // buttonComprar
            // 
            buttonComprar.Location = new Point(383, 342);
            buttonComprar.Name = "buttonComprar";
            buttonComprar.Size = new Size(75, 23);
            buttonComprar.TabIndex = 2;
            buttonComprar.Text = "Buy";
            buttonComprar.UseVisualStyleBackColor = true;
            buttonComprar.Click += buttonComprar_Click;
            // 
            // comboBoxCarne
            // 
            comboBoxCarne.FormattingEnabled = true;
            comboBoxCarne.Location = new Point(85, 111);
            comboBoxCarne.Name = "comboBoxCarne";
            comboBoxCarne.Size = new Size(238, 23);
            comboBoxCarne.TabIndex = 3;
            comboBoxCarne.Text = "Eliga su carne";
            // 
            // label1Carne
            // 
            label1Carne.AutoSize = true;
            label1Carne.BackColor = Color.Transparent;
            label1Carne.Location = new Point(41, 114);
            label1Carne.Name = "label1Carne";
            label1Carne.Size = new Size(38, 15);
            label1Carne.TabIndex = 5;
            label1Carne.Text = "Carne";
            // 
            // labelKilos
            // 
            labelKilos.AutoSize = true;
            labelKilos.BackColor = Color.Transparent;
            labelKilos.Location = new Point(47, 182);
            labelKilos.Name = "labelKilos";
            labelKilos.Size = new Size(32, 15);
            labelKilos.TabIndex = 7;
            labelKilos.Text = "Kilos";
            // 
            // nudKilos
            // 
            nudKilos.Location = new Point(85, 182);
            nudKilos.Name = "nudKilos";
            nudKilos.Size = new Size(120, 23);
            nudKilos.TabIndex = 8;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(477, 342);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(75, 23);
            buttonCancelar.TabIndex = 9;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // listBoxPedido
            // 
            listBoxPedido.BackColor = SystemColors.MenuHighlight;
            listBoxPedido.FormattingEnabled = true;
            listBoxPedido.ItemHeight = 15;
            listBoxPedido.Location = new Point(383, 19);
            listBoxPedido.Name = "listBoxPedido";
            listBoxPedido.Size = new Size(278, 229);
            listBoxPedido.TabIndex = 10;
            // 
            // textBoxTotal
            // 
            textBoxTotal.Location = new Point(484, 284);
            textBoxTotal.Name = "textBoxTotal";
            textBoxTotal.ReadOnly = true;
            textBoxTotal.Size = new Size(100, 23);
            textBoxTotal.TabIndex = 11;
            // 
            // buttonAgregar
            // 
            buttonAgregar.Location = new Point(88, 235);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(117, 23);
            buttonAgregar.TabIndex = 12;
            buttonAgregar.Text = "Agregar a la lista";
            buttonAgregar.UseVisualStyleBackColor = true;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // labelPrecioTotal
            // 
            labelPrecioTotal.AutoSize = true;
            labelPrecioTotal.BackColor = Color.Transparent;
            labelPrecioTotal.Location = new Point(401, 287);
            labelPrecioTotal.Name = "labelPrecioTotal";
            labelPrecioTotal.Size = new Size(68, 15);
            labelPrecioTotal.TabIndex = 13;
            labelPrecioTotal.Text = "Precio Total";
            // 
            // pictureBoxPublicidad
            // 
            pictureBoxPublicidad.BackColor = Color.Transparent;
            pictureBoxPublicidad.Location = new Point(47, 274);
            pictureBoxPublicidad.Name = "pictureBoxPublicidad";
            pictureBoxPublicidad.Size = new Size(219, 139);
            pictureBoxPublicidad.TabIndex = 14;
            pictureBoxPublicidad.TabStop = false;
            // 
            // FormVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.carniceria_stand_caricatura_18591_28542;
            ClientSize = new Size(673, 450);
            Controls.Add(pictureBoxPublicidad);
            Controls.Add(labelPrecioTotal);
            Controls.Add(buttonAgregar);
            Controls.Add(textBoxTotal);
            Controls.Add(listBoxPedido);
            Controls.Add(buttonCancelar);
            Controls.Add(nudKilos);
            Controls.Add(labelKilos);
            Controls.Add(label1Carne);
            Controls.Add(comboBoxCarne);
            Controls.Add(buttonComprar);
            Controls.Add(labelCliente);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormVenta";
            Text = "FormVenta";
            Load += FormVenta_Load;
            ((System.ComponentModel.ISupportInitialize)nudKilos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPublicidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCliente;
        private Button buttonComprar;
        private ComboBox comboBoxCarne;
        private Label label1Carne;
        private Label labelKilos;
        private NumericUpDown nudKilos;
        private Button buttonCancelar;
        private ListBox listBoxPedido;
        private TextBox textBoxTotal;
        private Button buttonAgregar;
        private Label labelPrecioTotal;
        private PictureBox pictureBoxPublicidad;
    }
}