using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Instrumentos : Producto
    {
        private string origen;
        private int modelo;



        public Instrumentos()
        {

        }

        public Instrumentos(int id, string nombre, float precio, int cantidad, string origen, int modelo) : base(id, nombre, precio, cantidad)
        {
            this.origen = origen;
            this.modelo = modelo;
        }


    }
}
