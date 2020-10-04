using System.Collections.Generic;
using System.Text;
using Entidades;

namespace Entidades
{
    /// <summary>
    /// Clase Taller de Tipo sealed (No puede ser Heredada)
    /// </summary>
    public sealed class Taller
    {
        #region Campos

        private int espacioDisponible;
        private List<Vehiculo> vehiculos;


        #endregion


        #region "Constructores"


        /// <summary>
        /// Constructor privado de la Clase Taller el cual sirve para inicializar la la lista de Vehiculos
        /// </summary>
        private Taller()
        {
            this.vehiculos = new List<Vehiculo>();
        }


        /// <summary>
        /// Constructor que usa el Constructor privado que sirve para inicializar la lista de Vehiculos y tambien podemos ingresar como parametro
        /// el espacio disponible que tendra este el taller
        /// </summary>
        /// <param name="espacioDisponible"> Parametro que indica el espacio disponible del taller con respecto a la cantidad de vehiculos que podemos guardar</param>
        public Taller(int espacioDisponible) : this()
        {
            this.espacioDisponible = espacioDisponible;
        }
        #endregion

        #region "Sobrecargas"
        /// <summary>
        /// Muestra el estacionamiento y TODOS los vehículos dentro asi como tambien el espacio disponible que tiene segun cantidad cargada
        /// </summary>
        /// <returns>String con detaller del taller y vehiculos cargados con los datos de cada Vehiculo</returns>
        public override string ToString()
        {
            return Taller.Listar(this, ETipo.Todos);
        }
        #endregion

        #region "Métodos"

        /// <summary>
        /// Expone los datos del elemento y su lista (incluidas sus herencias)
        /// SOLO del tipo requerido
        /// </summary>
        /// <param name="taller">Elemento a exponer</param>
        /// <param name="ETipo">Tipos de ítems de la lista a mostrar</param>
        /// <returns></returns>
        public static string Listar(Taller taller, ETipo tipo)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Tenemos {0} lugares ocupados de un total de {1} disponibles", taller.vehiculos.Count, taller.espacioDisponible);
            sb.AppendLine("");
            foreach (Vehiculo v in taller.vehiculos)
            {
                switch (tipo)
                {
                    case ETipo.Ciclomotor:

                        

                        if (v is Ciclomotor)
                        {
                            sb.AppendLine(v.Mostrar());
                        }
                        break;
                    case ETipo.SUV:
                   

                        if (v is Suv)
                        {
                            sb.AppendLine(v.Mostrar());
                        }
                        break;
                    case ETipo.Sedan:
                    

                        if (v is Sedan)
                        {
                            sb.AppendLine(v.Mostrar());
                        }
                        break;
                    case ETipo.Todos:
                        sb.AppendLine(v.Mostrar());
                        break;


                }






            }

            return sb.ToString();
        }
        #endregion

        #region "Operadores"
        /// <summary>
        /// Agregará un elemento a la lista de Vehiculos
        /// </summary>
        /// <param name="taller">Taller donde se agregará el elemento</param>
        /// <param name="vehiculo">Vehiculo a agregar</param>
        /// <returns> Taller dependiendo si se pudo agregar el Vehiculo o no</returns>
        public static Taller operator +(Taller taller, Vehiculo vehiculo)
        {

            if (taller.vehiculos.Count < taller.espacioDisponible)
            {


                foreach (Vehiculo vehiculoAux in taller.vehiculos)
                {
                    if (vehiculoAux == vehiculo)
                        return taller;
                }

                taller.vehiculos.Add(vehiculo);
            }
            return taller;
        }
        /// <summary>
        /// Quitará un elemento de la lista
        /// </summary>
        /// <param name="taller">Taller donde se quitará el elemento</param>
        /// <param name="vehiculo">Vehiculo a quitar</param>
        /// <returns> Taller dependiendo si se pudo quitar el Vehiculo o no</returns>
        public static Taller operator -(Taller taller, Vehiculo vehiculo)
        {
            foreach (Vehiculo v in taller.vehiculos)
            {
                if (v == vehiculo)
                {
                    taller.vehiculos.Remove(vehiculo);
                    break;
                }
            }

            return taller;
        }
        #endregion



        /// <summary>
        /// Clase enum de Tipos de Vehiculos que estan en la lista del Taller 
        /// asi como uno por uno como un tipo general para identificar a todos.
        /// </summary>
        public enum ETipo
        {
            Ciclomotor, Sedan, SUV, Todos
        }
    }
}
