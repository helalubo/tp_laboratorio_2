using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Excepciones;

namespace Archivos
{


    /// <summary>
    /// Clase generica que implementa interface IArchivo
    /// </summary>
    /// <typeparam name="T">dato generico utilizado en la interface</typeparam>
    public class Xml<T> : IArchivo<T>
    {

        /// <summary>
        /// Guarda un objeto  en un archivo xml
        /// </summary>
        /// <param name="archivo">nombre del archivo</param>
        /// <param name="datos">datos del archivo</param>
        /// <returns>true en caso de que sea exitoso el guardado, en caso contrario arroja una excepcion</returns>
        public bool Guardar(string archivo, T datos)
        {
            try
            {
                using (XmlTextWriter archivoEscritura = new XmlTextWriter(archivo, Encoding.UTF8))
                {
                    XmlSerializer serializador = new XmlSerializer(typeof(T));
                    serializador.Serialize(archivoEscritura, datos);
                }
                return true;
            }
            catch (Exception e)
            {
                throw new ArchivosException(e);
            }
        }

        /// <summary>
        /// Lee un objeto que esta en un archivo xml
        /// </summary>
        /// <param name="archivo"> nombre del archivo</param>
        /// <param name="datos"> datos leidos del archivo</param>
        /// <returns>true en caso de lectura exitosa, en caso contrario lanza una excepcion</returns>

        public bool Leer(string archivo, out T datos)
        {
            try
            {
                using (XmlTextReader archivoLectura = new XmlTextReader(archivo))
                {
                    XmlSerializer serializador = new XmlSerializer(typeof(T));
                    datos = (T)serializador.Deserialize(archivoLectura);
                }
                return true;
            }
            catch (Exception e)
            {
                throw new ArchivosException(e);
            }
        }
    }
}
