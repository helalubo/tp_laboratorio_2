using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{

    /// <summary>
    ///   /// Clase ArchivosException que hereda de Exception
    /// </summary>
    public class ArchivosException : Exception
    {

        /// <summary>
        /// Constructor por defecto con sobrecarga de base añadiendo mensaje como parametro y una excepcion interna
        /// </summary>

        public ArchivosException(Exception innerException):base("No es posible acceder al archivo",innerException)
        {

        }
    }
}
