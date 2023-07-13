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
    public partial class FormTicket : Form
    {
        private List<string> compra;
        private double total;
        public FormTicket(List<string> l, double t)
        {
            InitializeComponent();
            this.compra = l;
            this.total = t;
            labelTitulo.Text = "Su compra es:";
            labelTiket.Text = MensajeTiket(compra, total);
            Archivo.Crear(MensajeTiket(compra, total));
        }

        private string MensajeTiket(List<string> l, double t)
        {
            StringBuilder sb = new StringBuilder();
            foreach(string s in l)
            {
                sb.AppendLine($"{s}");
            }
            sb.AppendLine($"El gasto total fue de: {t}");
            return sb.ToString();
            
        }
    }
}
