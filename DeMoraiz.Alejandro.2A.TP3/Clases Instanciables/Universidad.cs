using Archivos;
using System.Collections.Generic;
using System.Text;
using Excepciones;

namespace Clases_Instanciables
{

    /// <summary>
    /// Clase publica Universidad
    /// </summary>
    public class Universidad
    {

        private List<Alumno> alumnos;
        private List<Jornada> jornada;
        private List<Profesor> profesores;


        #region Propiedades

        /// <summary>
        /// Atributo de lectura y escritura de una lista de Alumnos
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
        /// Atributo de lectura y escritura de una lista de Jornadas
        /// </summary>


        public List<Jornada> Jornadas
        {
            get
            {
                return this.jornada;
            }
            set
            {
                this.jornada = value;

            }
        }

        /// <summary>
        /// Atributo de lectura y escritura de una lista de Profesores
        /// </summary>

        public List<Profesor> Instructores
        {
            get
            {
                return this.profesores;
            }
            set
            {
                this.profesores = value;

            }
        }

        /// <summary>
        /// Metodo indexador de lectura y escritura que devuelve una jornada segun el inex requerido
        /// </summary>
        /// <param name="i">Index requerido </param>
        /// <returns>Objeto de tipo jornada en un indice especifico</returns>
        public Jornada this[int i]
        {

            get
            {

                Jornada jornadaAux = new Jornada();
                if (i >= 0 && i < this.Jornadas.Count)
                {

                    jornadaAux = jornada[i];
                }
                else
                {
                    jornadaAux = null;
                }

                return jornadaAux;

            }

            set
            {

                if (i >= 0 && i < this.Jornadas.Count)
                {
                    jornada[i] = value;
                }
                else if (i == this.Jornadas.Count)
                {
                    this.Jornadas.Add(value);
                }

            }

        }

        #endregion

        #region Constructores


        /// <summary>
        /// Constructor por defecto de clase universidad que inicializa listas de alumnos,jornadas y profesores.
        /// </summary>

        public Universidad()
        {
            this.alumnos = new List<Alumno>();
            this.jornada = new List<Jornada>();
            this.profesores = new List<Profesor>();
        }



        #endregion





        #region Metodos


        /// <summary>
        /// Metodo de clase Universidad que guarda un objeto universidad en un archivo .xml
        /// </summary>
        /// <param name="uni">Universidad a guardar</param>
        /// <returns>True en caso de que se guarde correctamente.</returns>

        public static bool Guardar(Universidad uni)
        {
            bool rta = false;

            Xml<Universidad> ArchivoUniversidad = new Xml<Universidad>();
            rta = ArchivoUniversidad.Guardar("ArchivoUniversidad.xml", uni);


            return rta;


        }


        /// <summary>
        /// Metodo de clase que lee un archivo xml que contiene un objeto universidad
        /// </summary>
        /// <returns>Universidad leida</returns>

        public static Universidad Leer()
        {
            Universidad uni = new Universidad();

            Xml<Universidad> ArchivoUniversidad = new Xml<Universidad>();

            ArchivoUniversidad.Leer("ArchivoUniversidad.xml", out uni);

            return uni;



        }

        /// <summary>
        /// Metodo estatico de clase que devuelve de manera privada un string con los datos de universidad
        /// </summary>
        /// <param name="uni">Universidad a mostrar</param>
        /// <returns>string con datos de universidad</returns>

        private static string MostrarDatos(Universidad uni)
        {
            StringBuilder sb = new StringBuilder();

            

            foreach (Jornada jornadaAux in uni.jornada)
            {
                sb.Append(jornadaAux);
                sb.AppendLine("<---------------------------------------->");


            }

            return sb.ToString();
        }

        /// <summary>
        /// Metodo publico que devuelve un string de la clase universidad
        /// </summary>
        /// <returns>retorna un string de universidad</returns>


        public override string ToString()
        {
            return Universidad.MostrarDatos(this);
        }


        #endregion

        #region Sobrecarga de metodos


        /// <summary>
        /// Verifica que una universidad tenga a un alumno determinado
        /// </summary>
        /// <param name="g">Universidad a verificar</param>
        /// <param name="a">Alumno a verificar</param>
        /// <returns> true en caso de que el alumno se encuentre</returns>
        public static bool operator ==(Universidad g, Alumno a)
        {
            bool rta = false;

            foreach (Alumno alumnoAux in g.Alumnos)
            {
                if(alumnoAux == a)
                {
                    rta = true;
                }
            }
            return rta;
        }

        /// <summary>
        /// Verifica si un alumno no se encuetra en  la universidad
        /// </summary>
        /// <param name="g">Universidad a verificar</param>
        /// <param name="a">Alumno a verificar</param>
        /// <returns>true en caso de que el alumno no este</returns>

        public static bool operator !=(Universidad g, Alumno a)
        {
            return !(g == a);
        }

        /// <summary>
        /// Verifica si una universidad tiene a determinado profesor
        /// </summary>
        /// <param name="g">Universidad a verificar</param>
        /// <param name="i">Profesor a verificar</param>
        /// <returns>True si el profesor da clases en la universidad</returns>
        public static bool operator ==(Universidad g, Profesor i)
        {
            bool rta = false;

            foreach (Profesor profesorAux in g.profesores)
            {
                if (profesorAux == i)
                {
                    rta = true;
                }
            }
            return rta;
        }

        /// <summary>
        /// Verifica si un profesor no da clases en la universidad
        /// </summary>
        /// <param name="g">Universidad a verificar</param>
        /// <param name="i">Profesor a verificar</param>
        /// <returns>True en caso de que no se encuentre el profesor </returns>
        public static bool operator !=(Universidad g, Profesor i)
        {
            return !(g == i);
        }

        /// <summary>
        /// Devuelve el primero profesor que se encuentre en la universidad y de la clase que se le pase por parametro
        /// en caso de que no se encuentre se lanza la excepcion SinProfesorException
        /// </summary>
        /// <param name="u">Universidad a verificar </param>
        /// <param name="clase">Clase a verificar</param>
        /// <returns>primer profesor que de una determinada clase</returns>

        public static Profesor operator ==(Universidad u, EClases clase)
        {
          

            foreach (Profesor profesorAux in u.profesores)
            {

                if(profesorAux == clase)
                {
                    return profesorAux;
                }
            }
            throw new SinProfesorException();
        }
        /// <summary>
        /// Devuelve el primer profesor que no de una clase especificada, sino arrojara la excepcion SinProfesorException
        /// </summary>
        /// <param name="u">Universidad a verificar</param>
        /// <param name="clase">Clase a verificar</param>
        /// <returns>Primer profesor que no pueda dar la calse</returns>

        public static Profesor operator !=(Universidad u, EClases clase)
        {
            foreach (Profesor profesorAux in u.profesores)
            {

                if (profesorAux != clase)
                {
                    return profesorAux;
                }
            }
            throw new SinProfesorException();
        }


        /// <summary>
        /// Agrega una nueva jornada con la clase ingresada
        /// </summary>
        /// <param name="g">Universidad donde se agrega la clase</param>
        /// <param name="clase">Clase a agregar </param>
        /// <returns> Retorna universidad con la clase y los alumnos de la clase</returns>
        public static Universidad operator + (Universidad g, EClases clase)
        {

            Jornada nuevaJornada = new Jornada(clase, g == clase);

            foreach (Alumno alumnoAux in g.alumnos)
            {

                if(alumnoAux == clase)
                {
                    nuevaJornada.Alumnos.Add(alumnoAux);
                }

            }

            g.jornada.Add(nuevaJornada);

            return g;



        }

        /// <summary>
        /// Agrega un alumno a la universidad dependiendo si previamente no se encuentra, o arroja una exception de tipo AlumnoRepetidoException
        /// </summary>
        /// <param name="u">Universidad para ingreso</param>
        /// <param name="a">alumno a ingresar </param>
        /// <returns>Devuelve una universidad en caso de no estar incluido previamente el alumno en la universidad</returns>

        public static Universidad operator + (Universidad u, Alumno a)
        {

            if(u != a)
            {
                u.alumnos.Add(a);
                return u;
            }
             throw new AlumnoRepetidoException();

        }


        /// <summary>
        /// Añade un profesor a la universidad dependiendo si el profesor no se encuentra previamente en la universidad
        /// </summary>
        /// <param name="u">Universidad a verificar</param>
        /// <param name="i">Profesor a agregar</param>
        /// <returns>Universidad a pesar de que se cargue o no el nuevo profesor</returns>
        public static Universidad operator + (Universidad u, Profesor i)
        {
            if(u != i)
            {
                u.profesores.Add(i);
            }
            return u;
        }

        #endregion






        #region Clases Anidadas

        /// <summary>
        /// Clase enumerados con las clases que se dictan en la facultad.
        /// </summary>
        public enum EClases
        {

            Programacion,
            Laboratorio,
            Legislacion,
            SPD,

        }

        #endregion


    }
}
