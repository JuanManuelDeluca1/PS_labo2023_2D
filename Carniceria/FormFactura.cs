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
    public partial class FormFactura : Form
    {
        private List<string> pedidoList;
        private List<string> clientesList;
        private List<string> preciosList;
        public FormFactura(List<string> pedidoList, List<string> clientes, List<string> precicos)
        {
            InitializeComponent();
            this.pedidoList = pedidoList;
            this.clientesList = clientes;
            this.preciosList = precicos;
        }

        private void FormFactura_Load(object sender, EventArgs e)
        {
            
            for(int i=0;i<pedidoList.Count;i++) 
            {
                int n = dgvFactura.Rows.Add();
                dgvFactura.Rows[n].Cells[0].Value = clientesList[i].ToString();
                dgvFactura.Rows[n].Cells[1].Value = pedidoList[i].ToString();
                dgvFactura.Rows[n].Cells[2].Value = preciosList[i].ToString();
            }
           

        }
    }
}
