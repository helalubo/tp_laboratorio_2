using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{

    /// <summary>
    ///   /// Clase SinProfesorException que hereda de Exception
    /// </summary>

    public class SinProfesorException : Exception
    {



        /// <summary>
        /// Constructor por defecto con sobrecarga de base añadiendo mensaje como parametro
        /// </summary>
        public SinProfesorException(): base("No hay profesor para la clase.")
        {

        }
    }
}
