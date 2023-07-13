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
    public partial class FormVendedor : Form
    {
        private CarniceriaE ce;
        public FormVendedor(CarniceriaE c)
        {
            InitializeComponent();
            ce = c;
        }


        private void buttonHeladera_Click(object sender, EventArgs e)
        {
            if (ce.esUsuario(textBoxMail.Text, textBoxContraseña.Text))
            {
                Usuario uAux = ce.ObtenerUsuario(textBoxMail.Text, textBoxContraseña.Text);
                Empleado em = ce.ObtenerEmpleado(uAux);
                if (em is not null)
                {
                    if (Validar(em, textBoxId.Text))
                    {
                        FormHeladera heladera = new FormHeladera(ce);
                        heladera.ShowDialog();
                    }
                }
            }
            else
            {
                MensajeError();
            }
            
        }

        private void buttonVender_Click(object sender, EventArgs e)
        {

            if (ce.esUsuario(textBoxMail.Text, textBoxContraseña.Text))
            {
                Usuario uAux = ce.ObtenerUsuario(textBoxMail.Text, textBoxContraseña.Text);
                Empleado em = ce.ObtenerEmpleado(uAux);
                if (em is not null)
                {
                    if (Validar(em, textBoxId.Text))
                    {
                        FormVenderEmpleado v = new FormVenderEmpleado(ce);
                        v.ShowDialog();
                    }
                    
                }
            }
            else
            {
                MensajeError();
            }
        }

        private bool Validar(Empleado e, string Id)
        {
            bool v = false;
            StringBuilder sb = new StringBuilder();

            if(BuscarEmpleado(e, Id))
            {
                v = true;
            }

            if (v == false)
            {
                sb.AppendLine("Id del empleado incorrecto");
                MessageBox.Show(sb.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return v;
        }

        private void MensajeError()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Contraseña o mail incorrecto");
            MessageBox.Show(sb.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public bool BuscarEmpleado(Empleado e, string id)
        {
            bool retorno = true;
            if(e.Id != int.Parse(id))
            {
                retorno = false;
            }
            return retorno;
        }

       
    }
}
