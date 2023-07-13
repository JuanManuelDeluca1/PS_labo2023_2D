using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carniceria
{
    public partial class FormVenta : Form
    {

        private CarniceriaE ce;
        private Cliente cl;
        private List<string> pedidoList;
        private List<string> carnes;
        private List<string> carnesOriginal;
        private GuardadoPubliciadad guardarPublicidad;
        private List<Publicidad> publicidadList;
        private Publicidad publicidadActual;
        public FormVenta(CarniceriaE c, Cliente clienteIngresado)
        {
            InitializeComponent();
            ce = c;
            cl = clienteIngresado;
            labelCliente.Text = MensajeComprador(cl);
            carnes = CargarCarnes();
            carnesOriginal = CargarCarnes();
            pedidoList = new List<string>();
            guardarPublicidad = new GuardadoPubliciadad();
            this.publicidadList = BaseDatocConect.ObtenerPublicidad();
            guardarPublicidad.CambioPublicidad += PublicidadManejador;
            Task.Run(CambiarPublicidad);
        }

        private List<string> CargarCarnes()
        {
            List<string> c = new List<string>();
            for (int i = 0; i < ce.Carne.Count; i++)
            {
                Carne ca = ce.Carne[i];
                if (ca is not null)
                {
                    if (ca.StockKilo > 0)
                    {
                        c.Add(ca.NombrePrecioStock);
                    }

                }
            }
            return c;
        }

        private void FormVenta_Load(object sender, EventArgs e)
        {
            comboBoxCarne.DataSource = carnes;
        }

        private void buttonComprar_Click(object sender, EventArgs e)
        {
            if (listBoxPedido.DataSource != null)
            {
                if (VerificarCompra(cl))
                {
                    CompraVerificada();
                }
            }
            else
            {
                MensajeErrorCarrito();
            }
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            string c = Convert.ToString(comboBoxCarne.Text);
            if (VerificarAgregado(ce.CarneSeleccionada(c), KilosSeleccionados()))
            {
                AgregadoVerificado(c);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private bool VerificarCompra(Cliente cl)
        {
            bool retorno = true;
            StringBuilder sb = new StringBuilder();

            if (double.Parse(textBoxTotal.Text) > cl.MontoPago)
            {
                sb.AppendLine("Tu monto no es suficiente para hacer la compra");
                retorno = false;
            }
            if (retorno == false)
            {
                MessageBox.Show(sb.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return retorno;
        }


        private static bool VerificarAgregado(Carne c, int kilos)
        {
            bool retorno = true;
            StringBuilder sb = new StringBuilder();

            if (c.StockKilo < kilos)
            {
                sb.AppendLine("Los kilos pedidos son mas de los que tenemos");
                retorno = false;
            }
            if (retorno == false)
            {
                MessageBox.Show(sb.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return retorno;
        }

        private string MensajeComprador(Cliente c)
        {
            string mensaje = c.ToString();
            return mensaje;
        }

        private double PrecioTotalCarneSeleccionada(string cS)
        {
            Carne c = ce.CarneSeleccionada(cS);
            double precio = c.PrecioKilo;
            int kilos = KilosSeleccionados();
            precio = (double)precio * kilos;
            return precio;
        }

        private int KilosSeleccionados()
        {
            return int.Parse(nudKilos.Value.ToString());
        }

        private string PrecioTotal(string cS)
        {
            double precioAnterior = 0;
            double precio = PrecioTotalCarneSeleccionada(cS);
            if (textBoxTotal.Text == "")
            {
                return PrecioTotalCarneSeleccionada(cS).ToString();
            }
            else
            {
                precioAnterior = double.Parse(textBoxTotal.Text);
                return (precio + precioAnterior).ToString();
            }
        }

        void CompraVerificada()
        {
            FormTicket t = new FormTicket(pedidoList, double.Parse(textBoxTotal.Text));
            t.ShowDialog();
            cl.MontoPago = cl.DescontarMonto(double.Parse(textBoxTotal.Text), cl.MontoPago);
            BaseDatocConect.ModificarClienteMonto(cl.Mail, (float)cl.DescontarMonto(double.Parse(textBoxTotal.Text), cl.MontoPago), cl.MetodoPago);
            labelCliente.Text = MensajeComprador(cl);
            listBoxPedido.DataSource = null;
            pedidoList.Clear();
            textBoxTotal.Text = "";
        }

        private void AgregadoVerificado(string c)
        {
            ce.DesconcarKilos(ce.CarneSeleccionada(comboBoxCarne.Text), KilosSeleccionados());
            carnes = CargarCarnes();
            comboBoxCarne.DataSource = null;
            comboBoxCarne.DataSource = carnes;
            string carne = $"{ce.CarneSeleccionada(c).NombreCorte} Kilos {KilosSeleccionados()} Precio {PrecioTotalCarneSeleccionada(c)}";
            pedidoList.Add(carne);
            listBoxPedido.DataSource = null;
            listBoxPedido.DataSource = pedidoList;
            textBoxTotal.Text = PrecioTotal(c);
        }

        private void MensajeErrorCarrito()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("No hay productos en el carrito");
            MessageBox.Show(sb.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private async Task CambiarPublicidad()
        {
            while (true)
            {
                await Task.Delay(2000);
                if (publicidadList.Count > 0)
                {
                    int indice = new Random().Next(0, publicidadList.Count);
                    Publicidad newPublicidad = publicidadList[indice];
                    publicidadActual = newPublicidad;
                    Invoke((Action)(() => guardarPublicidad.NuevaPublicidad(publicidadActual)));
                }
            }
        }

        private void PublicidadManejador(Publicidad p)
        {
            pictureBoxPublicidad.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPublicidad.ImageLocation = p.path;
        }
    }
}
