using System;

namespace Excepciones
{

    /// <summary>
    /// Excepcion que se lanzara si no se puede acceder a base de datos
    /// </summary>
    public class EstableciendoConexionException : Exception
    {

        /// <summary>
        /// Constructor de clase con sobrecarga del padre con respecto al mensaje
        /// </summary>
        /// <param name="eMensaje">Mensaje de error</param>
        public EstableciendoConexionException(string eMensaje) : base(eMensaje)
        {

        }
    }
}
