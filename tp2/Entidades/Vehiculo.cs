using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
 
    /// <summary>
    /// Clase abstracta Vehiculo
    /// </summary>
    
    public abstract class Vehiculo
    {


        #region Campos
        private string chasis;
        private ConsoleColor color;
        private EMarca marca;

        #endregion

        #region Propiedades

        /// <summary>
        /// atributo de solo lectura : Retornará el tamaño del Vehiculo
        /// </summary>
        protected abstract ETamanio Tamanio 
        { 
            
            get;
                
                
         }

        #endregion

        #region Constructores

        /// <summary>
        /// Constructor de la Clase Vehiculo
        /// </summary>
        /// <param name="chasis"> String que indica el tipo de chasis que tiene el vehiculo</param>
        /// <param name="marca"> Atributo marca de la clase enum Emarca que determina la marca del vehiculo</param>
        /// <param name="color"> Atributo color de la clase ConsoleColor que determina el color del vehiculo</param>

        public Vehiculo(string chasis, EMarca marca, ConsoleColor color)
        {
            this.chasis = chasis;
            this.marca = marca;
            this.color = color;
        }


        #endregion


        #region Metodos

        /// <summary>
        /// Publica todos los datos del Vehiculo.
        /// </summary>
        /// <returns> Retorna un string que nos muestra los campos de la clase Vehiculo </returns>
        public virtual string Mostrar()
        {
            string rta = (string)this;

            return rta;

           
        }

        #endregion


        #region Sobrecarga de metodos

        /// <summary>
        /// Metodo de Clase Vehiculo que permite que de forma explicita se devuelva un string con los campos de vehiculo pasado por parametro
        /// </summary>
        /// <param name="vehiculo"> Vehiculo de donde se deben extraer los campos</param>


        public static explicit operator string(Vehiculo vehiculo)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append( $"CHASIS: { vehiculo.chasis}\r\n");
            sb.Append( $"MARCA : {vehiculo.marca}\r\n");
            sb.Append($"COLOR : {vehiculo.color.ToString()}\r\n");
            sb.Append("---------------------");

            return sb.ToString();
        }

        /// <summary>
        /// Sobrecarga de operador == que permite comparar Dos vehiculos,  son iguales si comparten el mismo chasis.
        /// </summary>
        /// <param name="v1">Vehiculo a comparar.</param>
        /// <param name="v2">Vehiculo a comparar.</param>
        /// <returns> devuelve true en caso de que sean iguales.</returns>
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return (v1.chasis == v2.chasis);
        }
        /// <summary>
        /// Dos vehiculos son distintos si su chasis es distinto.
        /// </summary>
        /// <param name="v1">Vehiculo a comparar.</param>
        /// <param name="v2">Vehiculo a comparar.</param>
        /// <returns>devuelve false en caso de que sean diferentes.</returns>
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {



            return !(v1.chasis == v2.chasis);
        }


        #endregion


        #region Tipos anidados

        /// <summary>
        /// Tipo enum de marcas de Vehiculos
        /// </summary>
        public enum EMarca
        {
            Chevrolet, Ford, Renault, Toyota, BMW, Honda, HarleyDavidson
        }

        /// <summary>
        /// Clase enum de Tamanios de Vehiculos
        /// </summary>
        public enum ETamanio
        {
            Chico, Mediano, Grande
        }

        #endregion

    }
}
