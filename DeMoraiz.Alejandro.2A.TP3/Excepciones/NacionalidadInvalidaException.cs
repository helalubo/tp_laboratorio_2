using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{


    /// <summary>
    ///   /// Clase NacionalidadInvalidaException que hereda de Exception
    /// </summary>

    public class NacionalidadInvalidaException : Exception
    {


        /// <summary>
        /// Constructor con parametro mensaje con sobrecarga de base añadiendo el mensaje como parametro
        /// <param name="message">mensaje de excepcion</param>
        /// </summary>

        public NacionalidadInvalidaException(string messege):base(messege)
        {

        }

        /// <summary>
        /// Constructor por defecto con sobrecarga de this añadiendo mensaje como parametro
        /// </summary>

        public NacionalidadInvalidaException() : this("La nacionalidad no coincide con el numero de DNI")
        {

        }
    }
}
