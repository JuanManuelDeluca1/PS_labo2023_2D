using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Entidades
{
    
    public class CarniceriaE
    {
        private string name;
        private List<Usuario> usuarios;
        private List<Carne> carneList;

        public CarniceriaE()
        {
            this.carneList = new List<Carne>();
            this.usuarios = new List<Usuario>();
            this.name = "";
        }

        public CarniceriaE(string name) : this()
        {
            this.name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public List<Usuario> Usuarios
        {
            get
            {
                return usuarios;
            }
        }
        public List<Carne> Carne
        {
            get
            {
                return carneList;
            }
            set
            {
                this.carneList = value;
            }
        }

        /*public CarniceriaE HarcodearCarnesYClienteYEmpleado()
        {
            CarniceriaE ce = new CarniceriaE();
            Carne c1 = new Carne("Vazio", 1000, 5);
            Carne c2 = new Carne("Asado", 2000, 5);
            Carne c3 = new Carne("Bife", 8000, 5);
            Carne c4 = new Carne("Milanesa", 500, 0);

            Cliente cl1 = new Cliente("pedro1998@gmail.com", "pepcity", "Credito", 3000);
            Cliente cl2 = new Cliente("sol2000@gmail.com", "ron2019", "Efectovo", 10000);
            Cliente cl3 = new Cliente("juancito2001@gmail.com", "chat2023", "Efectivo", 5000);

            Empleado e1 = new Empleado("carnicero05@gmail.com", "1597", 05);
            Empleado e2 = new Empleado("carnicero06@gmail.com", "3579", 06);
            Empleado e3 = new Empleado("carnicero07@gmail.com", "4562", 07);

            ce.Carne.Add(c1);
            ce.Carne.Add(c2);
            ce.Carne.Add(c3);
            ce.Carne.Add(c4);
            ce.Usuarios.Add(cl1);
            ce.Usuarios.Add(cl2);
            ce.Usuarios.Add(cl3);
            ce.Usuarios.Add(e1);
            ce.Usuarios.Add(e2);
            ce.Usuarios.Add(e3);

            return ce;
        }*/

        public CarniceriaE CargarDatosBase()
        {
            CarniceriaE ce = new CarniceriaE();
            List<Cliente> cl = BaseDatocConect.LeerClientes();
            List<Empleado> el = BaseDatocConect.LeerEmpleado();
            ce.Carne = BaseDatocConect.LeerCarne();

            for(int i=0; i<cl.Count; i++)
            {
                ce.Usuarios.Add(cl[i]);
            }
            for(int i=0; i<el.Count; i++)
            {
                ce.Usuarios.Add(el[i]);
            }


            return ce;
        }

        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Name}");
            foreach (Carne c in carneList)
            {
                sb.AppendLine($"{c.ToString()}");
            }
            foreach (Usuario u in usuarios)
            {
                sb.AppendLine($"{u.Mostrar()}");
            }
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public bool esUsuario(string mail, string password)
        {
            bool retorno = false;
            foreach (Usuario u in usuarios)
            {
                if (u.Mail == mail && u.Password == password)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public Usuario ObtenerUsuario(string mail, string password)
        {
            Usuario aux = null;
            for (int i = 0; i < usuarios.Count; i++)
            {
                if (usuarios[i].Mail == mail && usuarios[i].Password == password)
                {
                    aux = usuarios[i];
                }
            }
            return aux;
        }

        public Cliente CargaCliente(Cliente c)
        {
            bool flag = false;
            Usuario aux = ObtenerUsuario(c.Mail, c.Password);
            for (int i = 0; i < usuarios.Count; i++)
            {
                if (usuarios[i] == aux)
                {
                    usuarios.RemoveAt(i);
                    usuarios.Insert(i, aux);
                    flag = true;
                }
            }
            if (flag == true)
            {
                return c;
            }
            else
            {
                c = null;
                return c;
            }
        }

        public Empleado ObtenerEmpleado(Usuario u)
        {
            Empleado aux = null;
            if ((u as Empleado) is Empleado c)
            {
                return c;
            }
            else
            {
                return aux;
            }
        }

        public Cliente ObtenerCliente(Usuario u)
        {
            Cliente aux = null;
            if ((u as Cliente) is Cliente c)
            {
                return c;
            }
            else
            {
                return aux;
            }
        }

        public Cliente ClienteSeleccionada(string cS)
        {
            string aux = cS.Substring(0, cS.Length);
            for (int i = 0; i < usuarios.Count; i++)
            {
                if ((usuarios[i] as Cliente) is Cliente c)
                {
                    if (c == cS)
                    {
                        return c;
                    }
                }
            }
            return null;
        }

        public Carne CarneSeleccionada(string cS)
        {
            Carne carne = new Carne();
            string aux = cS.Substring(0, cS.IndexOf("P") - 1);
            foreach (Carne c in carneList)
            {
                if (c == aux)
                {
                    carne = c;
                }
            }
            return carne;
        }

        public Carne CarneSeleccionadaDos(string cs)
        {
            Carne carne = new Carne();
            foreach (Carne c in carneList)
            {
                if (c == cs)
                {
                    carne = c;
                }
            }
            return carne;
        }

        public double CarneSeleccionadaPrecio(string carne)
        {
            Match m = Regex.Match(carne, "(\\d+)");
            return double.Parse(m.Value);
        }

        public bool ModificarCarne(Carne c, int stock, double precio)
        {
            bool flag = false;
            c.PrecioKilo = precio;
            c.StockKilo = stock;
            BaseDatocConect.ModificarCarneStock(c.NombreCorte, stock);
            BaseDatocConect.ModificarCarnePrecio(c.NombreCorte, (float)precio);
            for (int i = 0; i < carneList.Count; i++)
            {
                if (carneList[i] == c)
                {
                    carneList.RemoveAt(i);
                    carneList.Insert(i, c);
                    flag = true;
                }
            }
            return flag;
        }

        public void DesconcarKilos(Carne c, int Kilos)
        {
            Carne cAux = c;
            c.StockKilo = c.StockKilo - Kilos;
            BaseDatocConect.ModificarCarneStock(c.NombreCorte, Convert.ToInt32(c.StockKilo));
            for (int i = 0; i < carneList.Count; i++)
            {
                if (carneList[i] == c)
                {
                    carneList.RemoveAt(i);
                    carneList.Insert(i, cAux);
                }
            }
        }


        public bool AgregarCarne(string nombre, int stock, double precio)
        {
            bool retorno = true;
            Carne c = new Carne(nombre, precio, stock);
            BaseDatocConect.GurdarCarne(nombre, (float)precio, stock);
            for (int i = 0; i < carneList.Count; i++)
            {
                if (carneList[i] == c)
                {
                    retorno = false;
                }
            }
            if (retorno == true)
            {
                carneList.Add(c);
            }
            return retorno;
        }

        public Cliente VerficarCliente(string cS)
        {
            Cliente cl = ClienteSeleccionada(cS);
            return cl;

        }
    }
}
