using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado : Usuario
    {
        protected int id;

        public Empleado(string mail, string password, int id) : base(mail, password, 1)
        {
            this.id = id;
        }

        public int Id
        {
            get
            {
                return id;
            }
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Mail}");
            sb.AppendLine($"Su id es: {Id}");
            return sb.ToString();
        }



    }
}
