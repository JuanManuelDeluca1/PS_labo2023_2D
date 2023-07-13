using System;
using System.Text;
using Entidades;
namespace Carniceria
{
    public partial class FormLog : Form
    {
        private CarniceriaE ce;
        public FormLog()
        {
            InitializeComponent();
            this.ce = new CarniceriaE("Carinceria Pep");
            labelTitulo.Text = ce.ToString();
            ce = ce.CargarDatosBase();
            Serializacion_JSON<List<Carne>> json = new Serializacion_JSON<List<Carne>>();
            Serializacion_XML<List<Carne>> xml = new Serializacion_XML<List<Carne>>();
            json.Escribir(ce.Carne, "CarneJson");
            xml.Escribir(ce.Carne, "CarneXML");
        }

        private void buttonCliente_Click(object sender, EventArgs e)
        {
            FormCliente c = new FormCliente(ce);
            c.ShowDialog();
        }

        private void buttonEmpleado_Click(object sender, EventArgs e)
        {
            FormVendedor v = new FormVendedor(ce);
            v.ShowDialog();
        }
       
    }
}