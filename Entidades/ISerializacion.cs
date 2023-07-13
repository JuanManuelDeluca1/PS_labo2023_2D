using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface ISerializacion<T>
    {
        public void Escribir(T obj, string archivo);
        public T Leer(string mensaje);
    }
}
