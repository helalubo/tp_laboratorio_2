using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAbstractas
{

    /// <summary>
    /// Clase Abstracta de tipo Universitario que hereda de la clase Persona.
    /// </summary>
    public abstract class Universitario : Persona
    {

        #region Campos

        private int legajo;

        #endregion


        #region Constructores 

        /// <summary>
        /// Constructor por defecto de la clase Universitario
        /// </summary>
        public Universitario()
        {

        }

        /// <summary>
        /// Constructor parametrizado de la clase Universitario
        /// </summary>
        /// <param name="legajo"> Numero de Legajo del universitario</param>
        /// <param name="nombre"> Nombre del Universitario</param>
        /// <param name="apellido">Apellido del universitario</param>
        /// <param name="dni">Dni del universitario </param>
        /// <param name="nacionalidad">Nacionalidad del universitario</param>

        public Universitario(int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad) : base(nombre, apellido, dni, nacionalidad)
        {
            this.legajo = legajo;

        }

        #endregion


        #region Metodos

        /// <summary>
        /// Verifica si un universitario es igual a otro teniendo en cuenta su legajo y su DNI
        /// </summary>
        /// <param name="obj"> Objeto a verificar su igualdad</param>
        /// <returns>true en caso de ser igual, false en caso de ser diferente</returns>

        public override bool Equals(object obj)
        {
            bool rta = false;
            if (obj is Universitario)
            {

              if(this.legajo == ((Universitario)obj).legajo || this.DNI == ((Universitario)obj).DNI)
                {
                    rta = true;
                }

            }

            return rta;

        }


        /// <summary>
        /// Muestra de manera protegida los datos del Universitario
        /// </summary>
        /// <returns>string con los datos de el universitario</returns>

        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine($"LEGAJO NÚMERO: {legajo}");


            return sb.ToString();

        }


        /// <summary>
        /// Verifica si dos universitarios son diferentes
        /// </summary>
        /// <param name="pg1">primer universitario para verificar</param>
        /// <param name="pg2">segundo universitario para verificar</param>
        /// <returns>true en caso de ser diferentes </returns>

        public static bool operator !=(Universitario pg1, Universitario pg2)
        {

            return !(pg1 == pg2);


        }

        /// <summary>
        /// Verifica si dos universitarios son iguales utilizando el metodo Equals
        /// </summary>
        /// <param name="pg1">primer universitario para verificar</param>
        /// <param name="pg2">segundo universitario para verificar</param>
        /// <returns>true en caso de ser iguales</returns>

        public static bool operator ==(Universitario pg1, Universitario pg2)
        {

            return pg1.Equals(pg2);

        }

        /// <summary>
        /// Metodo abstracto que servira para retornar un string de quien participa en una clase.
        /// </summary>
        /// <returns>string con datos de quien participa en la clase.</returns>

        protected abstract string ParticiparEnClase();



  


        #endregion





    }
}
