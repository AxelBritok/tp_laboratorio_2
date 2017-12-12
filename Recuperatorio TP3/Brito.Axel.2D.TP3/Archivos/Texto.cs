using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    public class Texto : IArchivo<string>
    {

        /// <summary>
        /// Escribe la secuencia. Guarda el archivo.
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns name= "aux" ></returns>

        public bool guardar(string archivo, string datos)
        {
            bool aux = true;
            try
            {
                using (StreamWriter writer = new StreamWriter(archivo, true))
                {
                    writer.WriteLine(datos);
                   
                }
            }
            catch
            {
                aux = false;
                throw new Exception("No se pudo guardar en el archivo");
            }
            return aux;
        }

        /// <summary>
        /// Lectura de secuencia.
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns name= "aux" ></returns>
        public bool leer(string archivo, out string datos)
        {
            StringBuilder sb = new StringBuilder();

            bool aux = true;
            try
            {
                using (StreamReader reader = new StreamReader(archivo))
                    sb.Append(reader.ReadToEnd());
               
            }
            catch
            {
                aux = false;
                throw new Exception("No se pudo leer del archivo");

            }
            datos = sb.ToString();
            return aux;
        }
    }
}
