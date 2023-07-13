namespace Carniceria
{
    partial class FormTicket
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
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelTiket = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.BackColor = System.Drawing.Color.Transparent;
            this.labelTitulo.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitulo.Location = new System.Drawing.Point(170, 39);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(76, 31);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "label1";
            // 
            // labelTiket
            // 
            this.labelTiket.AutoSize = true;
            this.labelTiket.BackColor = System.Drawing.Color.Transparent;
            this.labelTiket.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTiket.Location = new System.Drawing.Point(170, 86);
            this.labelTiket.Name = "labelTiket";
            this.labelTiket.Size = new System.Drawing.Size(59, 25);
            this.labelTiket.TabIndex = 1;
            this.labelTiket.Text = "label1";
            // 
            // FormTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Carniceria.Properties.Resources.istockphoto_1133420301_612x612;
            this.ClientSize = new System.Drawing.Size(686, 450);
            this.Controls.Add(this.labelTiket);
            this.Controls.Add(this.labelTitulo);
            this.Name = "FormTicket";
            this.Text = "FormTicket";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelTitulo;
        private Label labelTiket;
    }
}