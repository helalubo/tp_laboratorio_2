using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    /// <summary>
    /// Clase AlumnoRepetidoException que hereda de Exception
    /// </summary>
    public class AlumnoRepetidoException : Exception
    {


        /// <summary>
        /// Constructor por defecto con sobrecarga de base añadiendo mensaje como parametro
        /// </summary>
        public AlumnoRepetidoException()
            : base("Alumno Repetido.")
        {

        }
    }
}
