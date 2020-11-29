using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Archivos
{
    public class Xml<T> : IArchivo<T>
    {
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
