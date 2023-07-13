namespace Carniceria
{
    partial class FormHeladera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHeladera));
            this.labelBienvenida = new System.Windows.Forms.Label();
            this.labelCarnes = new System.Windows.Forms.Label();
            this.listBoxCarne = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.textBoxStock = new System.Windows.Forms.TextBox();
            this.textBoxCorte = new System.Windows.Forms.TextBox();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.labelStock = new System.Windows.Forms.Label();
            this.labelCorte = new System.Windows.Forms.Label();
            this.buttonAgregarr = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelBienvenida
            // 
            this.labelBienvenida.AutoSize = true;
            this.labelBienvenida.BackColor = System.Drawing.Color.Transparent;
            this.labelBienvenida.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelBienvenida.Location = new System.Drawing.Point(301, 9);
            this.labelBienvenida.Name = "labelBienvenida";
            this.labelBienvenida.Size = new System.Drawing.Size(103, 19);
            this.labelBienvenida.TabIndex = 0;
            this.labelBienvenida.Text = "labelBienvenida";
            // 
            // labelCarnes
            // 
            this.labelCarnes.AutoSize = true;
            this.labelCarnes.BackColor = System.Drawing.Color.Transparent;
            this.labelCarnes.Location = new System.Drawing.Point(12, 31);
            this.labelCarnes.Name = "labelCarnes";
            this.labelCarnes.Size = new System.Drawing.Size(49, 15);
            this.labelCarnes.TabIndex = 2;
            this.labelCarnes.Text = "Carenes";
            // 
            // listBoxCarne
            // 
            this.listBoxCarne.FormattingEnabled = true;
            this.listBoxCarne.ItemHeight = 15;
            this.listBoxCarne.Location = new System.Drawing.Point(78, 31);
            this.listBoxCarne.Name = "listBoxCarne";
            this.listBoxCarne.Size = new System.Drawing.Size(281, 184);
            this.listBoxCarne.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxPrecio);
            this.groupBox1.Controls.Add(this.textBoxStock);
            this.groupBox1.Controls.Add(this.textBoxCorte);
            this.groupBox1.Controls.Add(this.labelPrecio);
            this.groupBox1.Controls.Add(this.labelStock);
            this.groupBox1.Controls.Add(this.labelCorte);
            this.groupBox1.Location = new System.Drawing.Point(544, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 184);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(18, 141);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(100, 23);
            this.textBoxPrecio.TabIndex = 5;
            this.textBoxPrecio.Text = "Ingrese precio";
            // 
            // textBoxStock
            // 
            this.textBoxStock.Location = new System.Drawing.Point(18, 91);
            this.textBoxStock.Name = "textBoxStock";
            this.textBoxStock.Size = new System.Drawing.Size(100, 23);
            this.textBoxStock.TabIndex = 4;
            this.textBoxStock.Text = "Ingrese Stock";
            // 
            // textBoxCorte
            // 
            this.textBoxCorte.Location = new System.Drawing.Point(21, 48);
            this.textBoxCorte.Name = "textBoxCorte";
            this.textBoxCorte.Size = new System.Drawing.Size(100, 23);
            this.textBoxCorte.TabIndex = 3;
            this.textBoxCorte.Text = "Ingrese corte";
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Location = new System.Drawing.Point(18, 123);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(40, 15);
            this.labelPrecio.TabIndex = 2;
            this.labelPrecio.Text = "Precio";
            // 
            // labelStock
            // 
            this.labelStock.AutoSize = true;
            this.labelStock.Location = new System.Drawing.Point(18, 73);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(36, 15);
            this.labelStock.TabIndex = 1;
            this.labelStock.Text = "Stock";
            // 
            // labelCorte
            // 
            this.labelCorte.AutoSize = true;
            this.labelCorte.Location = new System.Drawing.Point(18, 25);
            this.labelCorte.Name = "labelCorte";
            this.labelCorte.Size = new System.Drawing.Size(36, 15);
            this.labelCorte.TabIndex = 0;
            this.labelCorte.Text = "Corte";
            // 
            // buttonAgregarr
            // 
            this.buttonAgregarr.Location = new System.Drawing.Point(390, 44);
            this.buttonAgregarr.Name = "buttonAgregarr";
            this.buttonAgregarr.Size = new System.Drawing.Size(75, 23);
            this.buttonAgregarr.TabIndex = 8;
            this.buttonAgregarr.Text = "Agregar";
            this.buttonAgregarr.UseVisualStyleBackColor = true;
            this.buttonAgregarr.Click += new System.EventHandler(this.buttonAgregarr_Click);
            // 
            // buttonModificar
            // 
            this.buttonModificar.Location = new System.Drawing.Point(390, 96);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(75, 23);
            this.buttonModificar.TabIndex = 9;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // buttonVolver
            // 
            this.buttonVolver.Location = new System.Drawing.Point(390, 138);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(75, 23);
            this.buttonVolver.TabIndex = 10;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // FormHeladera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Carniceria.Properties.Resources._318_Dibujo_540;
            this.ClientSize = new System.Drawing.Size(800, 331);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.buttonAgregarr);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBoxCarne);
            this.Controls.Add(this.labelCarnes);
            this.Controls.Add(this.labelBienvenida);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormHeladera";
            this.Text = "FormHeladera";
            this.Load += new System.EventHandler(this.FormHeladera_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelBienvenida;
        private Label labelCarnes;
        private ListBox listBoxCarne;
        private GroupBox groupBox1;
        private TextBox textBoxPrecio;
        private TextBox textBoxStock;
        private TextBox textBoxCorte;
        private Label labelPrecio;
        private Label labelStock;
        private Label labelCorte;
        private Button buttonAgregarr;
        private Button buttonModificar;
        private Button buttonVolver;
    }
}