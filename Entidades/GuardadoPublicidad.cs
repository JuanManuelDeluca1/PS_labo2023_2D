using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class GuardadoPubliciadad
    {
        public event Action<Publicidad> CambioPublicidad;

        public void NuevaPublicidad(Publicidad publicidad)
        {
            CambioPublicidad?.Invoke(publicidad);
        }
    }
}
