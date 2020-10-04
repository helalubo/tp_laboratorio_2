using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{

    /// <summary>
    /// Clase Suv que hereda de la clase Vehiculo
    /// </summary>

    public class Suv : Vehiculo
    {

        #region Constructores

        /// <summary>
        /// Constructor de la clase Suv
        /// </summary>
        /// <param name="chasis"> String que indica el tipo de chasis que tiene el Suv</param>
        /// <param name="marca"> Atributo marca de la clase enum Emarca que determina la marca del Suv</param>
        /// <param name="color"> Atributo color de la clase ConsoleColor que determina el color del Suv</param>

        public Suv(EMarca marca, string chasis, ConsoleColor color)
            : base(chasis, marca, color)
        {
        }


        #endregion

        #region Propiedades

        /// <summary>
        /// Propiedad de solo lectura : Retornará el tamaño del Suv el cual por defecto es grande
        /// </summary>
        protected override ETamanio Tamanio 
        {
            get
            {
                return ETamanio.Grande;
            }
        }


        #endregion


        #region Metodos

        /// <summary>
        /// Publica todos los datos del Suv, siendo este metodo una sobrecarga del metodo Mostrar de la clase Vehiculo.
        /// </summary>
        /// <returns> Retorna un string que nos muestra los campos de la clase Suv </returns>
        public sealed override  string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SUV");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"TAMAÑO : {this.Tamanio}");
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        #endregion
    }
}
