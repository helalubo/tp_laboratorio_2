using System.Text;

namespace Entidades
{

    /// <summary>
    /// Clase Producto
    /// </summary>
    public  class Producto
    {

        #region Campos

        private int id;
        private string nombre;
        private float precio;
        private int cantidad;


        #endregion

        #region Constructores

        /// <summary>
        /// Constructor vacio de clase producto
        /// </summary>

        public Producto()
        {

        }

        /// <summary>
        /// Constructor parmetrizado de la clase Producto
        /// </summary>
        /// <param name="nombre">Nombre de Producto</param>
        /// <param name="precio">Precio de producto</param>
        /// <param name="cantidad">Cantidad con respecto al stock del producto</param>

        public Producto( string nombre, float precio, int cantidad)
        {
           
            this.nombre = nombre;
            this.precio = precio;
            this.cantidad = cantidad;

        }


        /// <summary>
        ///  Constructor parmetrizado de la clase Producto con todos sus campos
        /// </summary>
        /// <param name="id">id de producto</param>
        /// <param name="nombre">Nombre de Producto</param>
        /// <param name="precio">Precio de producto</param>
        /// <param name="cantidad">Cantidad con respecto al stock del producto</param>

        public Producto(int id, string nombre,float precio, int cantidad):this(nombre,precio, cantidad)
        {
            this.id = id;
           
        }


        #endregion


        #region Propiedades 


        /// <summary>
        /// Propiedad de lectura y escritura del campo id
        /// </summary>
        public int ID
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }

        /// <summary>
        /// Propiedad de lectura y escritura del campo nombre
        /// </summary>

        public string Nombre
        {

            get
            {
                return this.nombre;
            }

            set
            {
                this.nombre = value;
            }
        }
        /// <summary>
        /// Propiedad de lectura y escritura del campo precio
        /// </summary>

        public float Precio
        {

            get
            {
                return this.precio;
            }

            set
            {
                this.precio = value;
            }
        }

        /// <summary>
        /// Propiedad de lectura y escritura del campo Cantidad
        /// </summary>
        public int Cantidad
        {

            get
            {
                return this.cantidad;
            }

            set
            {
                this.cantidad = value;
            }
        }

        #endregion


        #region sobrecarga de Metodos


        /// <summary>
        /// Sobrecarga de metodo ToString de Producto
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"ID: {this.id} Nombre: {this.nombre} precio: {this.precio} stock {this.cantidad}");



            return sb.ToString();   
        }


        #endregion


    }
}
