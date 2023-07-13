using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Usuario
    { 
        protected string mail;
        protected string password;
        protected int tipoUsuario;

        public Usuario(string mail, string password, int tipoUsuario)
        {
            this.mail = mail;
            this.password = password;
            this.tipoUsuario = tipoUsuario;
        }

        public string Mail
        {
            get 
            {
                return mail; 
            }
        }

        public string Password
        {
            get 
            {
                return password;
            }
        }

        public int TipoUsuario
        {
            get
            { 
                return tipoUsuario; 
            }
        }

        public static bool operator ==(Usuario a, Usuario b)
        {
            if (a.Equals(b))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Usuario a, Usuario b)
        {
            return !(a == b);
        }
        public abstract string Mostrar();
    }
}
