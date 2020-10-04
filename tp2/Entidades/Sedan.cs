using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades
{

    /// <summary>
    /// Clase Sedan que hereda de la clase Vehiculo
    /// </summary>
   public class Sedan : Vehiculo
    {

        #region Campos

        private ETipo tipo;

        #endregion


        #region Constructores

        /// <summary>
        /// 
        /// Constructor de la clase Sedan donde se establecera Por defecto que el atributo Tipo de la Clase ETipo será Cincopuertas
        /// </summary>
        /// <param name="chasis"> String que indica el tipo de chasis que tiene el Sedan</param>
        /// <param name="marca"> Atributo marca de la clase enum Emarca que determina la marca del Sedan</param>
        /// <param name="color"> Atributo color de la clase ConsoleColor que determina el color del Sedan</param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color)
            :base(chasis, marca, color)
        {
            this.tipo = ETipo.CincoPuertas;
           
        }

        /// <summary>
        /// Constructor de la clase Sedan donde todos sus Campos deben ser ingresados
        /// </summary>
        /// <param name="chasis"> String que indica el tipo de chasis que tiene el Sedan</param>
        /// <param name="marca"> Atributo marca de la clase enum Emarca que determina la marca del Sedan</param>
        /// <param name="color"> Atributo color de la clase ConsoleColor que determina el color del Sedan</param>
        /// <param name="tipo">Atributo tipo de la Clase ETipo que determina el tipo del Sedan </param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color, ETipo tipo) : this(marca, chasis, color)
        {

        }

        #endregion

        #region Propiedades

        /// <summary>
        /// Propiedad de solo lectura : Retornará el tamaño del Sedan el cual por defecto es mediano.
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
           
                return ETamanio.Mediano;
            
            }
        }

        #endregion


        #region Metodos
        /// <summary>
        /// Publica todos los datos del Sedan, siendo este metodo una sobrecarga del metodo Mostrar de la clase Vehiculo.
        /// </summary>
        /// <returns> Retorna un string que nos muestra los campos de la clase Sedan </returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SEDAN");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"TAMAÑO : {this.Tamanio}");
            sb.AppendLine($"TIPO : {this.tipo}" );
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        #endregion

        #region Tipos anidados

        /// <summary>
        /// Clase enum de Tipos de Sedan segun su cantidad de puertas.
        /// </summary>
        public enum ETipo { 
            
            CuatroPuertas, CincoPuertas 
        
            }

        #endregion
    }
}
