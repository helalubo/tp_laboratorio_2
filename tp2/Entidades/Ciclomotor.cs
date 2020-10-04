using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{

    /// <summary>
    /// Clase Ciclomotor que Hereda de la Clase Vehiculo
    /// </summary>
    public class Ciclomotor : Vehiculo
    {


        #region Constructores

        /// <summary>
        /// 
        /// Constructor de la clase Sedan donde se establecera Por defecto que el atributo Tipo de la Clase ETipo será Cincopuertas
        /// </summary>
        /// <param name="chasis"> String que indica el tipo de chasis que tiene el Ciclomotor</param>
        /// <param name="marca"> Atributo marca de la clase enum Emarca que determina la marca del Ciclomotor</param>
        /// <param name="color"> Atributo color de la clase ConsoleColor que determina el color del Ciclomotor</param>

        public Ciclomotor(EMarca marca, string chasis, ConsoleColor color)
                  : base(chasis, marca, color)
        {
        }


        #endregion


        #region Propiedaes

        /// <summary>
        /// Propiedad de solo lectura : Retornará el tamaño del Ciclomotor el cual por defecto es Chico.
        /// </summary>
        protected override ETamanio Tamanio 
        {
            get
            {
                return ETamanio.Chico;
            }
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Publica todos los datos del Ciclomotor, siendo este metodo una sobrecarga del metodo Mostrar de la clase Vehiculo.
        /// </summary>
        /// <returns> Retorna un string que nos muestra los campos de la clase Ciclomotor </returns>

        public sealed override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CICLOMOTOR");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"TAMAÑO : {this.Tamanio}");
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        #endregion
    }
}
