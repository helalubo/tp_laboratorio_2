using Excepciones;
using System.Collections.Generic;

namespace Entidades
{
    public class Venta
    {

        public delegate void DelegadoDeVenta(List<Producto> listaDeProductos);






        public static void VerificarStock(List<Producto> listaDeProductos)
        {
            ///verifica el stock antes de hacer la venta, en caso de que alguna de las cantidades sea menor
            ///a las cantidades que hay de cada producto.
            ///una vez validado esto recien se modificara el stock.

            int cont;

            //ya tengo el dato del stock de cada producto en la lista, tengo que hacer una verificacion con cantidad

            for (int i = 0; i < listaDeProductos.Count; i++)
            {
                cont = 0;


                for (int j = 0; j < listaDeProductos.Count; j++)
                {

                    if (listaDeProductos[i].ID == listaDeProductos[j].ID)
                    {
                        cont++;

                    }

                }


               
                    if (listaDeProductos[i].Cantidad < cont)
                    {
                        string fallo = "uno de los articulos sobrepasa el stock";


                        throw new SobrepasaStockException(fallo);

                    }

              

            }


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
