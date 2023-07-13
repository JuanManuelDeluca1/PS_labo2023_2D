namespace Carniceria
{
    partial class FormVendedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVendedor));
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.buttonHeladera = new System.Windows.Forms.Button();
            this.buttonVender = new System.Windows.Forms.Button();
            this.groupBoxUsuario = new System.Windows.Forms.GroupBox();
            this.textBoxContraseña = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.labelContraseña = new System.Windows.Forms.Label();
            this.labelMail = new System.Windows.Forms.Label();
            this.groupBoxUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(16, 164);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 23);
            this.textBoxId.TabIndex = 6;
            this.textBoxId.Text = "Ingrese id";
            // 
            // buttonHeladera
            // 
            this.buttonHeladera.Location = new System.Drawing.Point(218, 258);
            this.buttonHeladera.Name = "buttonHeladera";
            this.buttonHeladera.Size = new System.Drawing.Size(127, 23);
            this.buttonHeladera.TabIndex = 8;
            this.buttonHeladera.Text = "Ir a Heleadera";
            this.buttonHeladera.UseVisualStyleBackColor = true;
            this.buttonHeladera.Click += new System.EventHandler(this.buttonHeladera_Click);
            // 
            // buttonVender
            // 
            this.buttonVender.Location = new System.Drawing.Point(117, 258);
            this.buttonVender.Name = "buttonVender";
            this.buttonVender.Size = new System.Drawing.Size(75, 23);
            this.buttonVender.TabIndex = 7;
            this.buttonVender.Text = "Vender";
            this.buttonVender.UseVisualStyleBackColor = true;
            this.buttonVender.Click += new System.EventHandler(this.buttonVender_Click);
            // 
            // groupBoxUsuario
            // 
            this.groupBoxUsuario.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxUsuario.Controls.Add(this.textBoxContraseña);
            this.groupBoxUsuario.Controls.Add(this.labelId);
            this.groupBoxUsuario.Controls.Add(this.textBoxMail);
            this.groupBoxUsuario.Controls.Add(this.labelContraseña);
            this.groupBoxUsuario.Controls.Add(this.textBoxId);
            this.groupBoxUsuario.Controls.Add(this.labelMail);
            this.groupBoxUsuario.Location = new System.Drawing.Point(117, 46);
            this.groupBoxUsuario.Name = "groupBoxUsuario";
            this.groupBoxUsuario.Size = new System.Drawing.Size(228, 206);
            this.groupBoxUsuario.TabIndex = 4;
            this.groupBoxUsuario.TabStop = false;
            this.groupBoxUsuario.Text = "Ingrese sus datos";
            // 
            // textBoxContraseña
            // 
            this.textBoxContraseña.Location = new System.Drawing.Point(16, 107);
            this.textBoxContraseña.Name = "textBoxContraseña";
            this.textBoxContraseña.Size = new System.Drawing.Size(123, 23);
            this.textBoxContraseña.TabIndex = 5;
            this.textBoxContraseña.Text = "Ingrese Contraseña";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.BackColor = System.Drawing.Color.Transparent;
            this.labelId.Location = new System.Drawing.Point(16, 146);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(17, 15);
            this.labelId.TabIndex = 2;
            this.labelId.Text = "Id";
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(16, 50);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(123, 23);
            this.textBoxMail.TabIndex = 4;
            this.textBoxMail.Text = "Ingrese Mail";
            // 
            // labelContraseña
            // 
            this.labelContraseña.AutoSize = true;
            this.labelContraseña.Location = new System.Drawing.Point(16, 89);
            this.labelContraseña.Name = "labelContraseña";
            this.labelContraseña.Size = new System.Drawing.Size(67, 15);
            this.labelContraseña.TabIndex = 1;
            this.labelContraseña.Text = "Contraseña";
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Location = new System.Drawing.Point(16, 32);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(30, 15);
            this.labelMail.TabIndex = 0;
            this.labelMail.Text = "Mail";
            // 
            // FormVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Carniceria.Properties.Resources.pngtree_butcher_character_vector_classic_professional_butcher_man_with_knife_for_steak_png_image_188;
            this.ClientSize = new System.Drawing.Size(768, 449);
            this.Controls.Add(this.groupBoxUsuario);
            this.Controls.Add(this.buttonVender);
            this.Controls.Add(this.buttonHeladera);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormVendedor";
            this.Text = "FromVendedor";
            this.groupBoxUsuario.ResumeLayout(false);
            this.groupBoxUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox textBoxId;
        private Button buttonHeladera;
        private Button buttonVender;
        private GroupBox groupBoxUsuario;
        private TextBox textBoxContraseña;
        private Label labelId;
        private TextBox textBoxMail;
        private Label labelContraseña;
        private Label labelMail;
    }
}