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
    public partial class FormHeladera : Form
    {
        private CarniceriaE ce;
        public FormHeladera(CarniceriaE c)
        {
            InitializeComponent();
            labelBienvenida.Text = "Bienvenido a la Heladea";
            ce = c;
        }

        private void FormHeladera_Load(object sender, EventArgs e)
        {
            listBoxCarne.DataSource = ce.Carne;

        }

        private void buttonAgregarr_Click(object sender, EventArgs e)
        {
            if (ce.AgregarCarne(textBoxCorte.Text, int.Parse(textBoxStock.Text), double.Parse(textBoxPrecio.Text)))
            {
                listBoxCarne.DataSource = null;
                listBoxCarne.DataSource = ce.Carne;
                MensajeAgregar();
            }
            else
            {
                MensajeError();
            }
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            if(ce.ModificarCarne(ce.CarneSeleccionadaDos(textBoxCorte.Text), int.Parse(textBoxStock.Text), double.Parse(textBoxPrecio.Text)))
            {
                listBoxCarne.DataSource = null;
                listBoxCarne.DataSource = ce.Carne;
                MensajeModificar();
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

        private void MensajeAgregar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("La carne se agreo correcta mente");
            MessageBox.Show(sb.ToString(), "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MensajeModificar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("La carne se modifico correcta mente");
            MessageBox.Show(sb.ToString(), "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MensajeError()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Ocurrio un error");
            MessageBox.Show(sb.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
