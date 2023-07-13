using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carniceria
{
    public partial class FormCliente : Form
    {
        private CarniceriaE ce;
        public FormCliente(CarniceriaE c)
        {
            InitializeComponent();
            this.ce = c;
        }

        private void buttonLongC_Click(object sender, EventArgs e)
        {
            if (ce.esUsuario(textBoxMail.Text, textBoxContraseña.Text))
            {
                Usuario uAux = ce.ObtenerUsuario(textBoxMail.Text, textBoxContraseña.Text);
                if ((uAux as Cliente) is not null)
                {
                    string metodoPago;
                    if (radioButtoncCreditoPago.Checked)
                    {
                        metodoPago = radioButtoncCreditoPago.Text;
                    }
                    else
                    {
                        metodoPago = radioButtonEfectivo.Text;
                    }
                    Cliente c = Cliente.ClienteCompleto(textBoxMail.Text, textBoxContraseña.Text, metodoPago, double.Parse(textBoxMonto.Text));
                    if ((ce.CargaCliente(c)) is null)
                    {
                        MensajeError();
                    }
                    else
                    {
                        FormVenta venta = new FormVenta(ce, c);
                        BaseDatocConect.ModificarClienteMonto(c.Mail, (float)c.MontoPago, c.MetodoPago);
                        BaseDatocConect.ModificarClienteMetodoPago(c.Mail, c.MetodoPago);
                        venta.ShowDialog();
                    }
                }
            }
            else
            {
                MensajeError();
            }
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        /*private Cliente ClienteCompleto()
        {
            double motontoPago =  double.Parse(textBoxMonto.Text);
            string metodoPago = ""; 
            if(radioButtoncCreditoPago.Checked) 
            {
                metodoPago = radioButtoncCreditoPago.Text;
            }
            else
            {
                metodoPago = radioButtonEfectivo.Text;
            }
            Cliente c = new Cliente(textBoxMail.Text, textBoxContraseña.Text, metodoPago, motontoPago);
            return c;
        }*/

        private void MensajeError()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Contraseña o mail incorrecto");
            MessageBox.Show(sb.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        
    }
}
