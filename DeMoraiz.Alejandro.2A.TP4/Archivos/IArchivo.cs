using System;

namespace Archivos
{

    /// <summary>
    /// Clase Interface para guardado y lectura de archivos
    /// </summary>
    /// <typeparam name="T">Tipo de dato generico para utilizacion de interface</typeparam>
    public interface IArchivo<T>
    {


        /// <summary>
        /// Firma de metodo para guardar datos de forma  generica
        /// </summary>
        /// <param name="archivo">nombre de archivo</param>
        /// <param name="datos">datos a guardar</param>
        /// <returns>true en caso de exito o lanza excepcion</returns>
        bool Guardar(string archivo, T datos);



    }
}
