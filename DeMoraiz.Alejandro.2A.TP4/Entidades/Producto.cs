namespace Entidades
{
    public  class Producto
    {

        #region Campos

        private int id;
        private string nombre;
        private float precio;
        private int cantidad;


        #endregion

        #region Constructores


        public Producto()
        {

        }


        public Producto( string nombre, float precio, int cantidad)
        {
           
            this.nombre = nombre;
            this.precio = precio;
            this.cantidad = cantidad;

        }


        public Producto(int id, string nombre,float precio, int cantidad):this(nombre,precio, cantidad)
        {
            this.id = id;
           
        }


        #endregion


        #region Propiedades 

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





    }
}
