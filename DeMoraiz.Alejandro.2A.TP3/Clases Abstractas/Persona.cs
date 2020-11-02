using System;
using System.Text;
using Excepciones;

namespace EntidadesAbstractas
{

    /// <summary>
    /// Clase Abstracta de Persona
    /// </summary>
    public abstract class Persona
    {

        #region Campos

        private string apellido;
        private int dni;
        private ENacionalidad nacionalidad;
        private string nombre;


        #endregion


        #region Propiedades



        /// <summary>
        /// Propiedad de lectura y escritura del campo apellido de tipo string donde
        /// tambien se valida con el metodo ValidadNombreApellido
        /// </summary>



        public string Apellido
        {
            get
            {
                return this.apellido; 
            }

            set
            {
                if(ValidarNombreApellido(value) != null)
                {

                    this.apellido = value;

                }


            }

        }

        /// <summary>
        /// Propiedad de lectura y escritura del campo dni de tipo int en donde se valida si el dni es valido o no
        /// con el metodo ValidadDni.
        /// </summary>

        public int DNI
        {
            get
            {
                return this.dni; 
            }

            set
            {
                this.dni = ValidarDni(this.nacionalidad, value);  

            }

        }

        /// <summary>
        /// Propiedad de lectura y escritura del campo nacionalidad de tipo ENacionalidad
        /// </summary>


        public ENacionalidad Nacionalidad
        {
            get
            {
                return this.nacionalidad; 
            }

            set
            {
                this.nacionalidad = value; 

            }

        }

        /// <summary>
        /// Propiedad de lectura y escritura del campo nombre de tipo string donde
        /// tambien se valida con el metodo ValidadNombreApellido
        /// </summary>

        public string Nombre
        {
            get
            {
                return this.nombre; 
            }

            set
            {
                if (ValidarNombreApellido(value) != null)
                {

                    this.nombre = value;

                }

            }

        }

        /// <summary>
        /// Propiedad StringToDNI que utiliza ValidadDni para verificar que sea valido,
        /// en este caso se recibira un string con valor
        /// </summary>

        public string StringToDNI
        {


            set
            {
                this.dni = ValidarDni(this.nacionalidad, value);

            }

        }

        #endregion


        #region metodos


        /// <summary>
        /// Constructor por defecto de clase persona
        /// </summary>
        public Persona()
        {

        }

        /// <summary>
        /// Constructor parametrizado de clase Persona 
        /// </summary>
        /// <param name="nombre"> Nombre de Persona</param>
        /// <param name="apellido"> Apellido de persona </param>
        /// <param name="nacionalidad"> Nacionalidad de persona</param>

        public Persona(string nombre, string apellido, ENacionalidad nacionalidad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.nacionalidad = nacionalidad;
        }

        /// <summary>
        /// Constructor parametrizado de clase Persona 
        /// </summary>
        /// <param name="nombre"> Nombre de Persona</param>
        /// <param name="apellido"> Apellido de persona </param>
        /// <param name="nacionalidad"> Nacionalidad de persona</param>
        /// <param name="dni">DNI de persona de tipo int</param>
     

 

        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad) : this(nombre, apellido, nacionalidad)
        {
            this.DNI = dni;
        }
        /// <summary>
        /// Constructor parametrizado de clase Persona 
        /// </summary>
        /// <param name="nombre"> Nombre de Persona</param>
        /// <param name="apellido"> Apellido de persona </param>
        /// <param name="nacionalidad"> Nacionalidad de persona</param>
        /// <param name="dni">DNI de persona de tipo string</param>
        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad) : this(nombre, apellido, nacionalidad)
        {
            this.StringToDNI = dni;
        }

        /// <summary>
        /// Metodo toString que nos muestra los datos de la clase persona
        /// </summary>
        /// <returns>string con datos de persona</returns>

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"NOMBRE COMPLETO: {Apellido} ,{Nombre}");
            sb.AppendLine($"NACIONALIDAD: {Nacionalidad}");


            return sb.ToString();


        }



        /// <summary>
        /// Valida el DNI dependiendo de si es Extranjero, Argentino o el DNI este fuera de formato.
        /// </summary>
        /// <param name="nacionalidad">Nacionalidad de Persona</param>
        /// <param name="dato"> DNI de persona de tipo entero</param>
        /// <returns>DNI de tipo persona en caso de no caer en una excepcion</returns>
        private int ValidarDni(ENacionalidad nacionalidad, int dato)
        {

           


            if(nacionalidad == ENacionalidad.Extranjero && dato < 90000000)
            {
                throw new NacionalidadInvalidaException();
            }
            if(nacionalidad == ENacionalidad.Argentino && dato > 89999999 )
            {
                throw new NacionalidadInvalidaException();
            }

            if(dato < 1 || dato > 99999999)
            {
                throw new DniInvalidoException();
            }

            return dato;

            




           


        }

        /// <summary>
        /// Valida el DNI dependiendo de si es Extranjero, Argentino o el DNI este fuera de formato.
        /// </summary>
        /// <param name="nacionalidad">Nacionalidad de Persona</param>
        /// <param name="dato"> DNI de persona de tipo string</param>
        /// <returns>DNI de tipo persona en caso de no caer en una excepcion</returns>


        private int ValidarDni(ENacionalidad nacionalidad, string dato)
        {
            int dniValido = 0;

            if (dato.Length >= 1 && dato.Length <= 8)
            {
                for (int i = 0; i < dato.Length; i++)
                {
                    if (!char.IsDigit(dato[i]))
                    {
                          throw new DniInvalidoException("El DNI debe contener solo digitos");
                    }
                }
                dniValido = ValidarDni(nacionalidad, Convert.ToInt32(dato));
            }
            else
            {
                 throw new DniInvalidoException();
            }


            return dniValido;

        }



        /// <summary>
        /// Verifica si el nombre o el apellido de la persona tienen un formato valido 
        /// </summary>
        /// <param name="dato"> nombre de Persona de tipo string</param>
        /// <returns> nombre de persona en caso de ser valido o cadena vacia en caso de que no sea valido</returns>


        private string ValidarNombreApellido(string dato)
        {
           

            StringBuilder nombre =  new StringBuilder();

            foreach (char letra in dato)
            {

                if (!(letra >= 65 && letra <= 122))
                {

                    nombre.Append($"{letra}");

                }
                else
                {
                    nombre.Clear();
                    break;
                }
            }





            return nombre.ToString();





        }


        #endregion




        #region Clases Anidadas

        /// <summary>
        /// Clase Enumerado que nos otorga las nacionalidades de las Personas.
        /// </summary>


        public enum ENacionalidad
        {

            Argentino,
            Extranjero

        }
        #endregion

    }
}

