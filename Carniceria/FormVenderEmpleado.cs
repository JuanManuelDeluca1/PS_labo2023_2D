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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Carniceria
{
    public partial class FormVenderEmpleado : Form
    {
        private CarniceriaE ce;
        private List<string> clientes;
        private List<string> pedidoList;
        private List<string> carnes;
        private List<string> venta;
        private List<string> auxClientes;
        private List<string> preciosTotal;
        public FormVenderEmpleado(CarniceriaE ce)
        {
            InitializeComponent();
            this.ce = ce;
            clientes = CargarCliente();
            carnes = CargarCarnes();
            pedidoList = new List<string>();
            venta = new List<string>();
            auxClientes = new List<string>();
            preciosTotal = new List<string>();
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

        private List<string> CargarCliente()
        {
            List<string> clientes = new List<string>();
            for (int i = 0; i < ce.Usuarios.Count; i++)
            {
                Cliente c = ce.ObtenerCliente(ce.Usuarios[i]);
                if (c is not null)
                {
                    clientes.Add(c.Mail);
                }
            }
            return clientes;
        }

        private List<string> EliminarCliente(string cS)
        {
            List<string> aux = new List<string>();
            foreach (string s in clientes)
            {
                if (s != cS)
                {
                    aux.Add(s);
                }
            }
            return aux;
        }

        private string CargarVentas(List<string> pedidos)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < pedidos.Count; i++)
            {
                sb.Append($" {pedidos[i]}");
            }
            return sb.ToString();
        }

        private void FormVenderEmpleado_Load(object sender, EventArgs e)
        {
            listBoxCliente.DataSource = clientes = CargarCliente();
            listBoxCarne.DataSource = carnes = CargarCarnes();

        }

        private void Vender_Click(object sender, EventArgs e)
        {
            if (listBoxPedido.Items.Count > 0)
            {
                if (listBoxCliente.Items.Count > 0)
                {
                    if (labelMail3.Text != "")
                    {
                        Cliente cl = ce.VerficarCliente(listBoxCliente.Text);
                        if (VerificarCompra(cl))
                        {
                            LimpioInformacion();
                            MensajeVendido();
                        }
                    }
                    else
                    {
                        MensajeErrorEligirCliente();
                    }
                }
                else
                {
                    MensajeErrorCliente();
                }
            }
            else
            {
                MensajeErrorCarrito();
            }
        }

        private void LimpioInformacion()
        {
            auxClientes.Add(labelMail3.Text);
            preciosTotal.Add(labelCostoTotal.Text);
            venta.Add(CargarVentas(pedidoList));
            ce.DesconcarKilos(ce.CarneSeleccionada(listBoxCarne.Text), KilosSeleccionados());
            carnes = CargarCarnes();
            listBoxCarne.DataSource = null;
            listBoxCarne.DataSource = carnes;
            clientes = EliminarCliente(listBoxCliente.Text);
            listBoxCliente.DataSource = null;
            listBoxCliente.DataSource = clientes;
            listBoxPedido.DataSource = null;
            pedidoList.Clear();
            labelCostoTotal.Text = "";
            labelMail3.Text = "";
            labelMontoPasado.Text = "";
        }

        private void buttonInforme_Click(object sender, EventArgs e)
        {
            FormFactura f = new FormFactura(venta, auxClientes, preciosTotal);
            f.ShowDialog();
        }

        private void buttonAgregarCarne_Click(object sender, EventArgs e)
        {
            string c = Convert.ToString(listBoxCarne.Text);
            if (VerificarAgregado(ce.CarneSeleccionada(c), KilosSeleccionados()))
            {
                string carne = $"{ce.CarneSeleccionada(c).NombreCorte} Kilos {KilosSeleccionados()} Precio {PrecioTotalCarneSeleccionada(c)}";
                pedidoList.Add(carne);
                listBoxPedido.DataSource = null;
                listBoxPedido.DataSource = pedidoList;
                labelCostoTotal.Text = PrecioTotal(c);
            }
            else
            {
                listBoxPedido.DataSource = null;
            }
        }

        private void listBoxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente cl = ce.VerficarCliente(listBoxCliente.Text);
            if (cl is not null)
            {
                labelMail3.Text = cl.Mail;
                labelMontoPasado.Text = cl.MontoPago.ToString();
            }
        }

        private bool VerificarCompra(Cliente cl)
        {
            bool retorno = true;
            StringBuilder sb = new StringBuilder();
            if (double.Parse(labelCostoTotal.Text) > cl.MontoPago)
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

        private int KilosSeleccionados()
        {
            return int.Parse(nudKilos.Value.ToString());
        }

        private double PrecioTotalCarneSeleccionada(string cS)
        {
            Carne c = ce.CarneSeleccionada(cS);
            double precio = c.PrecioKilo;
            int kilos = KilosSeleccionados();
            precio = (double)precio * kilos;
            return precio;
        }

        private string PrecioTotal(string cS)
        {
            double precioAnterior = 0;
            double precio = PrecioTotalCarneSeleccionada(cS);
            if (labelCostoTotal.Text == "")
            {
                return PrecioTotalCarneSeleccionada(cS).ToString();
            }
            else
            {
                precioAnterior = double.Parse(labelCostoTotal.Text);
                return (precio + precioAnterior).ToString();
            }
        }

        private void MensajeVendido()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("El cliente se fue contento");
            MessageBox.Show(sb.ToString(), "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MensajeErrorCliente()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("No hay mas clientes");
            MessageBox.Show(sb.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeErrorEligirCliente()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("No eligioCliente");
            MessageBox.Show(sb.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeErrorCarrito()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("No hay productos en el carrito");
            MessageBox.Show(sb.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
