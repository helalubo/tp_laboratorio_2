namespace Entidades
{
    /// <summary>
    /// Clase Accesorio hija de producto
    /// 
    /// </summary>
    public class Accesorio : Producto
    {

        private EGama gama;
        private ETipo tipo;

        /// <summary>
        /// Constructor vacio de clase Accesorio
        /// </summary>

        public Accesorio()
        {

        }

        /// <summary>
        /// Constructor parametrizado de la clase Accesorio
        /// </summary>
        /// <param name="id">id Accesorio</param>
        /// <param name="nombre">nombre de Accesorio</param>
        /// <param name="precio">Precio de Accesorio</param>
        /// <param name="cantidad">Cantidad con respecto al stock del Accesesorio</param>
        /// <param name="gama">Gama del accesorio</param>
        /// <param name="tipo">Tipo del accesorio</param>

        public Accesorio(int id, string nombre, float precio, int cantidad, EGama gama, ETipo tipo) : base(id, nombre, precio, cantidad)
        {
            this.gama = gama;
            this.tipo = tipo;
        }


        /// <summary>
        /// Clase anidada de enumerado EGama
        /// con respecto a la gama del Accesorio
        /// </summary>



        public enum EGama
        {
            baja,
            media,
            mediaAlta,
            alta,
            otro


        }

        /// <summary>
        /// Clase anidada de enumerado ETipo
        /// con respecto a la tipo del Accesorio
        /// </summary>

        public enum ETipo
        {
            Guitarra,
            Bateria,
            Teclado,
            Bajo,
            OTRO


        }

    }
}
