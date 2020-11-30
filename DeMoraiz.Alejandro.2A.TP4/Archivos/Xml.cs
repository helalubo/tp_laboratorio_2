using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Archivos
{

    /// <summary>
    /// Clase encargada de crear archivos .xml de un tipo de dato generico
    /// implementa interface IArchivo
    /// </summary>
    /// <typeparam name="T">Dato generico</typeparam>

    public class Xml<T> : IArchivo<T>
    {

        /// <summary>
        /// Metodo para guardar un tipo de dato generico em formato .xml
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns></returns>

        public bool Guardar(string archivo, T datos)
        {

            bool rta = false;
            try
            {
                using (XmlTextWriter archivoEscritura = new XmlTextWriter(archivo, Encoding.UTF8))
                {
                    XmlSerializer serializador = new XmlSerializer(typeof(T));
                    serializador.Serialize(archivoEscritura, datos);
                }
                rta = true;
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }

            return rta;
        }
    }
}
