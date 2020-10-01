using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// La clase Vehiculo no deberá permitir que se instancien elementos de este tipo.
    /// </summary>
    public abstract class Vehiculo
    {

        private string chasis;
        private ConsoleColor color;
        private EMarca marca;


        /// <summary>
        /// ReadOnly: Retornará el tamaño
        /// </summary>
        public abstract ETamanio Tamanio 
        { 
            
            get;
                
                
         }




        public Vehiculo(string chasis, EMarca marca, ConsoleColor color)
        {
            this.chasis = chasis;
            this.marca = marca;
            this.color = color;
        }

        
        /// <summary>
        /// Publica todos los datos del Vehiculo.
        /// </summary>
        /// <returns></returns>
        public virtual string Mostrar()
        {
            string rta = (string)this;

            return rta;

           
        }

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
        /// Dos vehiculos son iguales si comparten el mismo chasis
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return (v1.chasis == v2.chasis);
        }
        /// <summary>
        /// Dos vehiculos son distintos si su chasis es distinto
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {



            return !(v1.chasis == v2.chasis);
        }

         public enum EMarca
        {
            Chevrolet, Ford, Renault, Toyota, BMW, Honda, HarleyDavidson
        }
      public  enum ETamanio
        {
            Chico, Mediano, Grande
        }
      

    }
}
