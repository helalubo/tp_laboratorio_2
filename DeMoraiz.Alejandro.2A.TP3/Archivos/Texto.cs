using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Excepciones;

namespace Archivos
{
    /// <summary>
    /// Clase publica Texto que implementa interface IArchivo con tipo de dato String
    /// </summary>
    public class Texto : IArchivo<string>
    {


        /// <summary>
        /// Guarda un archivo string en un archivo de texto
        /// </summary>
        /// <param name="archivo">nombre del archivo</param>
        /// <param name="datos">datos del archivo</param>
        /// <returns>true en caso de que sea exitoso el guardado, en caso contrario arroja una excepcion</returns>
        public bool Guardar(string archivo, string datos)
        {

            bool rta = false;
            try
            {
                using (StreamWriter archivoEscritura = new StreamWriter(archivo, true))
                {
                    archivoEscritura.WriteLine(datos);
                    rta=  true;
                }
            }
            catch (Exception e)
            {
                throw new ArchivosException(e);
            }

            return rta;
        }


        /// <summary>
        /// Lee un string de un archivo
        /// </summary>
        /// <param name="archivo"> nombre del archivo</param>
        /// <param name="datos"> datos leidos del archivo</param>
        /// <returns>true en caso de lectura exitosa, en caso contrario lanza una excepcion</returns>
        public bool Leer(string archivo, out string datos)
        {
            try
            {
                using (StreamReader archivoLectura = new StreamReader(archivo))
                {
                    datos = archivoLectura.ReadToEnd();
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
