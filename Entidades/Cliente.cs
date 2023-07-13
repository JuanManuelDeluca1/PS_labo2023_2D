using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente : Usuario
    {
        private string metodoPago;
        private double montoPago;       

        public Cliente(string mail, string password) : base(mail, password, 2)
        {
            this.metodoPago = "";
        }
        public Cliente(string mail, string password, string metodoPago, double montoPago) :this(mail, password)
        {
            this.montoPago = montoPago; 
            this.metodoPago = metodoPago;
        }

        public string MetodoPago
        {
            get
            {
                return metodoPago;
            }
            set
            {
                metodoPago = value;
            }
        }

        public double MontoPago
        {
            get 
            {
                return Montototal(montoPago, metodoPago);
            }
            set
            {
                montoPago = value;
            }
        }

        private double Montototal(double montoTotal, string metodoPago)
        {
            if (metodoPago == "Credito")
            {
                return montoTotal - montoTotal * 5 / 100;
            }
            else
            {
                return montoTotal;
            }
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Mail} ");
            sb.AppendLine($"Metodo de pago {MetodoPago}");
            if(MetodoPago ==  "Credito")
            {
                sb.AppendLine("El metodo de pago tiene un %5 de recargo");
            }
            sb.AppendLine($"Monto: {MontoPago}");

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
        
        public static bool operator == (Cliente c1, Cliente c2)
        {
            if(c1.mail == c2.mail && c1.password == c2.password)
            { 
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1 == c2);
        }

        public static bool operator ==(Cliente c1, string s)
        {
            if (c1.mail == s)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Cliente c1, string s)
        {
            return !(c1 == s);
        }

        public double DescontarMonto(double precio, double monto)
        {
            return monto - precio;
        }

        public static Cliente ClienteCompleto(string mail, string password, string metodo, double monto)
        {
            double motontoPago = monto;
            string metodoPago = "";
            if (metodo == "Efectivo")
            {
                metodoPago = "Efectivo";
            }
            else
            {
                metodoPago = "Credito";
            }
            Cliente c = new Cliente(mail, password, metodoPago, motontoPago);
            return c;
        }

    }
}
