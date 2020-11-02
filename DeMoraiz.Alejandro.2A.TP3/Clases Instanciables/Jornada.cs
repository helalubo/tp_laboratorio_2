using System.Collections.Generic;
using System.Data;
using System.Text;
using Archivos;
using static Clases_Instanciables.Universidad;

namespace Clases_Instanciables
{

    /// <summary>
    /// Clase publica Jornada
    /// </summary>
      public class Jornada
    {
        #region Campos


        private List<Alumno> alumnos;
        private EClases clase;
        private Profesor instructor;

        #endregion


        #region Propiedades

        /// <summary>
        /// Atributo de lectura y escritura que devuelve una lista de alumnos
        /// </summary>
        public List<Alumno> Alumnos
        {

            get
            {
                return this.alumnos;
            }
            set
            {
                this.alumnos = value;
            }


        }
        /// <summary>
        /// Atributo de lectura y escritura de las clases universitarias
        /// </summary>

        public EClases Clase
        {

            get
            {
                return this.clase;
            }
            set
            {
                this.clase = value;

            }

        }

        /// <summary>
        /// Atributo de lectura y escritura de isntructor  de Jornada
        /// </summary>

        public Profesor Instructor
        {

            get
            {
                return this.instructor;
            }
            set
            {
                this.instructor = value;

            }
        }

        #endregion


        #region constructores


        /// <summary>
        /// Constructor por defecto que inicializa la lista de alumnos
        /// </summary>
        public Jornada()
        {
            this.alumnos = new List<Alumno>();
        }

        /// <summary>
        /// Constructor parametrizado de la clase Jornada
        /// </summary>
        /// <param name="clase">Clase de la jornada</param>
        /// <param name="instructor">Instructor de la jornada</param>

        public Jornada(EClases clase, Profesor instructor):this()
        {
            this.clase = clase;
            this.instructor = instructor;


        }




        #endregion

        #region Metodos

        /// <summary>
        /// Metodo de clase que guarda la jornada en un archivo .txt
        /// </summary>
        /// <param name="jornada">Jornada a guardar en el txt</param>
        /// <returns>True en caso de exito al guardar, en caso contrario retornara false</returns>

        public static bool Guardar(Jornada jornada)
        {
            bool rta = false;

            Texto texto = new Texto();

            rta = texto.Guardar("ArchivoDeJornada.txt", jornada.ToString());

            



            return rta;

        }

     
        
        /// <summary>
        /// Metodo de clase que lee un archivo .txt y devuelve el string
        /// </summary>
        /// <returns>string con datos de jornada</returns>


        public static string Leer()
        {

          
            string rta = " " ;

            Texto texto = new Texto();

             texto.Leer("ArchivoDeJornada.txt", out rta);

            return rta;


        }

        /// <summary>
        /// Metodo que devuelve datos de jordana de manera publica
        /// </summary>
        /// <returns>String con datos de jornada</returns>

        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();

            sb.AppendLine("JORNADA:");
            sb.AppendLine($"CLASE DE : {this.clase} POR {instructor}");
            sb.AppendLine("ALUMNOS: ");

            foreach (Alumno alumno in this.alumnos)
            {
                sb.AppendLine(alumno.ToString());
            }



            return sb.ToString();
        }


        #endregion

        #region Sobrecarda de metodos


        /// <summary>
        /// Verifica si un alumno se encuentra en la jornada
        /// </summary>
        /// <param name="j">Jornada donde se verifica que este el alumnos</param>
        /// <param name="a">Alumno a verificar em jornnada</param>
        /// <returns> true si alumno se encuentra en jornada</returns>

        public static bool operator == (Jornada j, Alumno a)
        {

            bool rta = false;

            foreach (Alumno alumnoAux in j.alumnos)
            {
                if(alumnoAux == a)
                {
                    rta = true;
                    break;
                }
            }

            return rta;

        }

        /// <summary>
        /// Verifica si el alumno no se encuentra en jornada 
        /// </summary>
        /// <param name="j">Jornada donde se verifica que este el alumnos</param>
        /// <param name="a">Alumno a verificar em jornnada</param>
        /// <returns>ture en caso de que el alumno no se encuetre</returns>
        public static bool operator !=(Jornada j, Alumno a)
        {

            return (!(j == a));

        }


        /// <summary>
        /// Agrega un alumno en la jornada en caso de que no se encuentre en ella.
        /// </summary>
        /// <param name="j">Jornada donde se verifica que este el alumnos</param>
        /// <param name="a">Alumno a agregar</param>
        /// <returns>Jornada en caso de que se agregue o no el alumnos</returns>

        public static Jornada operator +(Jornada j, Alumno a)
        {

            if(j != a)
            {
                j.alumnos.Add(a);
            }

            return j;

        }

        #endregion

    }
}
