using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    public class Serializacion_XML<T> : ISerializacion<T> where T : class, new()
    {
        static string ruta;
        public Serializacion_XML()
        {
            ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ruta += @"\Archivo-Carne-Serializados";
        }

        public void Escribir(T datos, string archivo)
        {
            string completo = ruta + @"\CarnesXML" + archivo + ".xml";
            try
            {
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }
                using (StreamWriter sw = new StreamWriter(completo))
                {
                    XmlSerializer xmlSerialLazer = new XmlSerializer(typeof(T));
                    xmlSerialLazer.Serialize(sw, datos);
                }
            }
            catch
            {
                throw new Exception($"Error en el guardado del archivo: {completo}");
            }
        }

        public T Leer(string nombre)
        {
            string archivos = string.Empty;
            T datos = default;
            try
            {
                if (Directory.Exists(ruta))
                {
                    string[] archivosEnRuta = Directory.GetFiles(ruta);

                    foreach (string archivoEnRuta in archivosEnRuta)
                    {
                        if (archivoEnRuta.Contains(nombre))
                        {
                            archivos = archivoEnRuta;
                            break;
                        }
                    }

                    if (archivos != null)
                    {
                        using (StreamReader sr = new StreamReader(archivos))
                        {
                            XmlSerializer xmlSerialLazer = new XmlSerializer(typeof(T));
                            datos = (T)xmlSerialLazer.Deserialize(sr);
                        }
                    }
                }

                return datos;
            }
            catch
            {
                throw new Exception($"Error en la lectura del archivo: {archivos}");
            }
        }
    }
}
