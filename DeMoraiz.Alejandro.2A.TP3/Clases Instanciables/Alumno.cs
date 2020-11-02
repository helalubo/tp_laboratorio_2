using EntidadesAbstractas;
using System.Text;
using static Clases_Instanciables.Universidad;

namespace Clases_Instanciables
{

    /// <summary>
    /// Clase publica y Sealed de tipo Alumno que hereda de clase Universitario
    /// </summary>
    public sealed class Alumno : Universitario
    {

        #region Campos

        private EClases claseQueToma;
        private EEstadoCuenta estadoCuenta;

        #endregion


        #region Constructores

        /// <summary>
        /// Constructor por defecto de la clase Alumno
        /// </summary>

        public Alumno()
        {

        }


        /// <summary>
        /// Constructor parametrizado de la clase Alumno
        /// </summary>
        /// <param name="id">Id del alumno</param>
        /// <param name="nombre">Nombre del alumno</param>
        /// <param name="apellido">Apellido del alumno</param>
        /// <param name="dni">DNI del alumno</param>
        /// <param name="nacionalidad">Nacionalidad del alumno</param>
        /// <param name="claseQueToma">Clase que toma el alumno</param>

        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, EClases claseQueToma) : base(id, nombre, apellido, dni, nacionalidad)
        {
            this.claseQueToma = claseQueToma;
        }

        /// <summary>
        /// Constructor parametrizado de la clase Alumno
        /// </summary>
        /// <param name="id">Id del alumno</param>
        /// <param name="nombre">Nombre del alumno</param>
        /// <param name="apellido">Apellido del alumno</param>
        /// <param name="dni">DNI del alumno</param>
        /// <param name="nacionalidad">Nacionalidad del alumno</param>
        /// <param name="claseQueToma">Clase que toma el alumno</param>
        /// <param name="estadoCuenta">Estado de la cuenta con respecto al pago</param>

        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, EClases claseQueToma, EEstadoCuenta estadoCuenta) : this(id, nombre, apellido, dni, nacionalidad, claseQueToma)
        {
            this.estadoCuenta = estadoCuenta;
        }


        #endregion


        #region Metodos


        /// <summary>
        /// Muestra los datos de forma protegida de la clase Alumno
        /// </summary>
        /// <returns>String con los datos del alumno</returns>


        protected override string MostrarDatos()
        {

            StringBuilder sb = new StringBuilder();
            StringBuilder estado = new StringBuilder();

            sb.AppendLine(base.MostrarDatos());


            switch (this.estadoCuenta)
            {
                case EEstadoCuenta.AlDia:
                    estado.Append("Cuota al dia");
                    break;
                case EEstadoCuenta.Deudor:
                    estado.Append("Deudor");
                    break;
                case EEstadoCuenta.Becado:
                    estado.Append("Becado");
                    break;
             
            }



            sb.AppendLine($"ESTADO DE CUENTA: {estado.ToString()}");



            return sb.ToString();
        }

        /// <summary>
        /// Verifica si un alumno toma la clase
        /// </summary>
        /// <param name="a">Alumno a corroborar</param>
        /// <param name="clase"> Clase a corroborar con respecto a si la toma el alumno</param>
        /// <returns>true en caso de que el alumno solo tome esa clase, de lo contrario false </returns>
        public static bool operator !=(Alumno a, EClases clase)
        {
            bool rta = false;

            if (a.claseQueToma != clase)
            {
                rta = true;
            }


            return rta;


        }

        /// <summary>
        /// Verifica si el alumno se encuentra en la clase y tambien tiene en cuenta si su estado es diferente a Deudor
        /// </summary>
        /// <param name="a">Alumno a verificar</param>
        /// <param name="clase">Clase a verificar con respecto al alumno </param>
        /// <returns>devuelve true en caso de que el alumno tome la clase y no sea deudor </returns>

        public static bool operator ==(Alumno a, EClases clase)
        {
            bool rta = false;

            if (a.claseQueToma == clase && a.estadoCuenta != EEstadoCuenta.Deudor)
            {
                rta = true;
            }


            return rta;

        }

        /// <summary>
        /// Devuelve un string indicando en que clase participa el alumno
        /// </summary>
        /// <returns>string con dato de que clase toma el alumno</returns>

        protected override string ParticiparEnClase()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"TOMA CLASE DE {claseQueToma}");

            return sb.ToString();
        }

        /// <summary>
        /// Devuelve los datos de manera publica del alumno
        /// </summary>
        /// <returns>string con datos del Alumno</returns>

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(MostrarDatos());
            sb.Append(ParticiparEnClase());




            return sb.ToString();
        }


        #endregion


        #region Clases Anidadas

        /// <summary>
        /// Clase Enumerado con el estado de la cuenta del Alumno
        /// </summary>
        public enum EEstadoCuenta
        {
            AlDia,
            Deudor,
            Becado,



        }

        #endregion
    }





}
