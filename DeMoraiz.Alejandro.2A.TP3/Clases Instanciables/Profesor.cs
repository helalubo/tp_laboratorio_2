using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;
using static Clases_Instanciables.Universidad;

namespace Clases_Instanciables
{

    /// <summary>
    /// Clase publica y sellada Profesor que hereda de Universitario
    /// </summary>

    public sealed class Profesor : Universitario
    {

        #region Campos

        private Queue<EClases> clasesDelDia;
        private  static Random random;

        #endregion

        #region Constructores


        /// <summary>
        /// Constructor por defecto de la clase Profesor que inicializa la lista de clases del dia
        /// </summary>
        private Profesor()
        {
            this.clasesDelDia = new Queue<EClases>();
            
        }


        /// <summary>
        /// Comstructor estatico que inicializa el campo random.
        /// </summary>
        static Profesor()
        {
            random = new Random();
        }


        /// <summary>
        /// Constructor parametrizado de profesor 
        /// </summary>
        /// <param name="id">id del profesor</param>
        /// <param name="nombre">Nombre del profesor</param>
        /// <param name="apellido">Apellido del profesor</param>
        /// <param name="dni">Dni del profesor</param>
        /// <param name="nacionalidad">Nacionalidad del profesor</param>

        public Profesor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            : base( id,  nombre,  apellido,  dni,  nacionalidad)
        {

            Profesor pAux = new Profesor();
            this.clasesDelDia = pAux.clasesDelDia;

            this._randomClases();



        }


        #endregion


        #region metodos

        /// <summary>
        /// Metodo que retorna de manera random la lista de clases del dia.
        /// </summary>
        private void _randomClases()
        {
            for (int i = 0; i < 2; i++)
            {

          this.clasesDelDia.Enqueue( (EClases) Profesor.random.Next(0,3));
            }

        }

        /// <summary>
        /// Devuelve un string con la participacion en la clase de manera protegida 
        /// </summary>
        /// <returns>string con participacion en clase</returns>

        protected override string ParticiparEnClase()
        {
            StringBuilder sb = new StringBuilder();

                sb.AppendLine($"CLASES DEL DIA:");

            foreach (EClases clase in clasesDelDia)
            {
                sb.AppendLine(clase.ToString());
            }
            
      

            return sb.ToString();
        }

        /// <summary>
        /// Devuelve un string de los datos de Profesor de manera protegida
        /// </summary>
        /// <returns> string de datos de profesor</returns>

        protected override string MostrarDatos()
        {

            StringBuilder sb = new StringBuilder();

            sb.Append(base.MostrarDatos());
            sb.Append(this.ParticiparEnClase());


            return sb.ToString();
        }


        /// <summary>
        /// Muestra los datos del profesor de manera publica
        /// </summary>
        /// <returns>string con datos de Profesor</returns>
        public override string ToString()
        {
            return MostrarDatos();
        }

        #endregion



        #region sobrecarga de metodos


        /// <summary>
        /// Verifica si Un profesor da una clase especifica
        /// </summary>
        /// <param name="i">Profesor a verificar</param>
        /// <param name="clase">Clase a verificar</param>
        /// <returns> true si da la clase</returns>

        public static bool operator ==(Profesor i, EClases clase)
        {

            bool rta = false;

            foreach (EClases claseAux in i.clasesDelDia)
            {

                if(clase == claseAux)
                {
                    rta = true;
                }

            }

            return rta;


        }


        /// <summary>
        /// Verifica si un Profesor no da una clase
        /// </summary>
        /// </summary>
        /// <param name="i">Profesor a verificar</param>
        /// <param name="clase">Clase a verificar</param>
        /// <returns>Retorna true en caso de que no de una clase</returns>
        public static bool operator !=(Profesor i, EClases clase)
        {
            return !(i == clase);



        }

        #endregion



    }
}
