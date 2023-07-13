using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Entidades
{
    public  class Serializacion_JSON<T>: ISerializacion<T> where T : class, new()
    {
        static string ruta;
        public Serializacion_JSON()
        {
            ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ruta += @"\Archivo-Carne-Serializados";
        }

        public void Escribir(T datos, string archivo)
        {
            string completo = ruta + @"\CarnesJson" + archivo + ".json";
            try
            {
                if(!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }
                string objetJson = JsonSerializer.Serialize(datos);
                File.WriteAllText(completo, objetJson);
            }
            catch
            {
                throw new MisExepciones($"Error en el guardo del archivo: {completo}");
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
                        string archivosJson = File.ReadAllText(archivos);
                        datos = JsonSerializer.Deserialize<T>(archivosJson);
                    }
                }

                return datos;
            }
            catch
            {
                throw new MisExepciones($"Error en la lectura del archivo: {archivos}");
            }
        }
    }
    /*public class Serializacion_JSON<T> : ISerializacion<T> where T : class, new()
    {
        public StreamWriter writer;
        public StreamReader reader;

        public string path;

        /// <summary>
        ///  genera el directorio para guardar el archivo
        /// </summary>
        /// <param name="archivo"></param>
        public Serializacion_JSON(string archivo)
        {
            this.path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            this.path += $"\" + archivo";
        }

        /// <summary>
        ///  deserializa objeto q contega
        /// </summary>
        /// <returns></returns>
        public T Deserializar()
        {
            T aux = new T();
            try
            {
                using (this.reader = new StreamReader(this.path))
                {
                    string json = this.reader.ReadToEnd();

                    aux = JsonSerializer.Deserialize<T>(json);
                }
            }
            catch (Exception)
            {
                return null;
            }

            return aux;
        }

        /// <summary>
        ///  serializa cualquier objeto que reciba
        /// </summary>
        /// <param name="objeto"></param>
        /// <returns></returns>
        public bool Serializar(T objeto)
        {
            bool retorno = false;
            try
            {
                using (this.writer = new StreamWriter(this.path))
                {

                    string json = JsonSerializer.Serialize(objeto);

                    this.writer.Write(json);
                    retorno = true;
                }
            }
            catch (Exception)
            {
                retorno = false;
            }
            return retorno;
        }
    }*/
}
