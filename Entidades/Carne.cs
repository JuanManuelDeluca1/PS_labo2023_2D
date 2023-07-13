using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Carne
    {
        protected string nombreCorte;
        protected double precioKilo;
        protected double stockKilo;

        public Carne ()
        {
            this.nombreCorte = string.Empty;

        }
        public Carne(string nombreCorte, double precioKilo, double stockKilo): this()
        {
            this.nombreCorte = nombreCorte;
            this.precioKilo = precioKilo;
            this.stockKilo = stockKilo;
        }

        public string NombreCorte
        {
            get 
            {
                return nombreCorte; 
            } 
        }

        public double PrecioKilo
        {
            get
            {
                return precioKilo;
            }
            set
            {
                this.precioKilo = value;
            }
        }

        public double StockKilo
        {
            get
            {
                return stockKilo;
            }
            set
            {
                this.stockKilo = value;
            }
        }

        public string NombrePrecioStock
        {
            get
            {
                return NombreCorte + " Precio por Kilo " + PrecioKilo.ToString() + " Quedan " + StockKilo.ToString();
            }
        }

        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.NombreCorte}");
            sb.AppendLine($" Precio por kilo: {this.PrecioKilo}");
            sb.AppendLine($" Stock: {this.StockKilo}");
            return sb.ToString();
        }

        public override string ToString()
        {
            return Mostrar();
        }
        public void AgregarStock(double newStock)
        {
            if (newStock < 0)
            {
                this.StockKilo = newStock;
            }
        }

        public static bool operator ==(Carne c, string s)
        {
            if(c.NombreCorte == s)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Carne c, string s)
        {
            return !(c == s);
        }
    }
}
