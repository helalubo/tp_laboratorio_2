using System;
using System.Collections.Generic;
using System.Text;

namespace Excepciones
{
   public class SeleccionInvalidaException : Exception
    {

        /// <summary>
        /// Constructor de clase con sobrecarga del padre con respecto al mensaje
        /// </summary>
        /// <param name="eMensaje">Mensaje de error</param>
        public SeleccionInvalidaException(string eMensaje) : base(eMensaje)
        {

        }
    }


}
