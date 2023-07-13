using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Archivo
    {
        static string ruta;
        static Archivo()
        {
            ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ruta += @"\Archviso-Ticket";
        }
        public static void Crear(string mensaje)
        {
            string completo = ruta + @"\Ticket.txt";

            try
            {
                if (!Directory.Exists(ruta))//Valida que la ruta sea valida
                {
                    Directory.CreateDirectory(ruta); //Crea la carpeta si no existe 
                }
                using (StreamWriter sw = new StreamWriter(completo))//Cuando salgamos del using se "cierra automatico"
                {
                    sw.WriteLine($"{mensaje}");
                }
            }
            catch 
            {
                throw new MisExepciones($"Error en el archivo {completo}");
            }
        }
    }
}
