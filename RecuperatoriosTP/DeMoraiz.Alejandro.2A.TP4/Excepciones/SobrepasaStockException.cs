using System;

namespace Excepciones
{

    /// <summary>
    /// Excepcion que se lanzara si se Sobrepasa el stock a la hora de querer
    /// realizar una venta
    /// </summary>
    public class SobrepasaStockException : Exception
    {


        /// <summary>
        /// Constructor de clase con sobrecarga del padre con respecto al mensaje
        /// </summary>
        /// <param name="eMensaje">Mensaje de error</param>
        public SobrepasaStockException(string eMensaje) : base(eMensaje)
        {

        }
    }
}
