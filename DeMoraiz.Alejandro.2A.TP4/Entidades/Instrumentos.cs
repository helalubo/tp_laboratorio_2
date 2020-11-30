using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{


    /// <summary>
    /// Clase Instrumento hija de producto
    /// 
    /// </summary>
    public class Instrumentos : Producto
    {
        private string origen;
        private int modelo;

        /// <summary>
        /// Constructor vacio de clase Instrumento
        /// </summary>

        public Instrumentos()
        {

        }

        /// <summary>
        /// Constructor parametrizado de la clase Instrumento
        /// </summary>
        /// <param name="id">id del instrumento</param>
        /// <param name="nombre">Nombre del instrumento</param>
        /// <param name="precio">Precio de instrumento</param>
        /// <param name="cantidad">Cantidad con respecto al stock del instrumento</param>
        /// <param name="origen">Origen del Instrumento</param>
        /// <param name="modelo">Año de modelo del Instrumento</param>

        public Instrumentos(int id, string nombre, float precio, int cantidad, string origen, int modelo) : base(id, nombre, precio, cantidad)
        {
            this.origen = origen;
            this.modelo = modelo;
        }


    }
}
