using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Venta
    {

        public delegate void DelegadoDeVenta(List<Producto> listaDeProductos);




        public void VerificarSiElDineroAlcanza(List<Producto> listaDeProductos)
        {


            ///lanzar la exepcion, DineroInsuficienteException si el total es menor al monto total.

        }

        public void VerificarStock(List<Producto> listaDeProductos)
        {
            ///verifica el stock antes de hacer la venta, en caso de que alguna de las cantidades sea menor
            ///a las cantidades que hay de cada producto.
            ///una vez validado esto recien se modificara el stock.





        }

        public void modificarStock(List<Producto> listaDeProductos)
        {


        }


        public void TXTTicket(List<Producto> listaDeProductos)
        {


        }


        public void XMLVentasRealizadas(List<Producto> listaDeProductos)
        {


        }

    }
}
