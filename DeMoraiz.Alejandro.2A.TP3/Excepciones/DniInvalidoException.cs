using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{

    /// <summary>
    ///   /// Clase DniInvalidoException que hereda de Exception
    /// </summary>

    public class DniInvalidoException : Exception
    {


        /// <summary>
        /// Constructor con parametro excepcion
        /// </summary>
        /// <param name="e">excepcion pasada por parametro</param>

        public DniInvalidoException(Exception e)
        {

        }

        /// <summary>
        /// Constructor con parametro mensaje con sobrecarga de base añadiendo el mensaje como parametro
        /// <param name="message">mensaje de excepcion</param>
        /// </summary>

        public DniInvalidoException(string message): base(message) 
        {

        }
        /// <summary>
        /// Constructor con mensaje y Excepcion pasados por parametros y sobrecargados en base
        /// </summary>
        /// <param name="message"></param>
        /// <param name="e"></param>

        public DniInvalidoException(string message, Exception e) 
            :base(message,e)
        {

        }

        /// <summary>
        /// Constructor por defecto con sobrecarga de base añadiendo mensaje como parametro
        /// </summary>

        public DniInvalidoException()  
            :base("DNI invalido debido a error de formato")
        {

        }

       


    }
}
