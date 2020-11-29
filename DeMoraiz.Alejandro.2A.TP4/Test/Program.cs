using Entidades;
using Excepciones;
using System;
using System.Collections.Generic;
using static Entidades.Accesorio;

namespace Test
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Creo lista de Producto 
            List<Producto> productos = new List<Producto>();



            //HardcodeoProductos
            Instrumentos i1 = new Instrumentos(2, "Bateria Sonor", 100000, 5, "China", 1999);
            Instrumentos i2 = new Instrumentos(3, "Bajo Gibson", 50000, 5, "Otro", 2005);

            Accesorio a1 = new Accesorio(10002, "Correa Guitarra classic ", 550, 5, 0, 0);
            Accesorio a2 = new Accesorio(10005, "banquillo Yamaha ", 8500, 4, (EGama)2, (ETipo)1);
            Accesorio a3 = new Accesorio(10005, "banquillo Yamaha ", 8500, 4, (EGama)2, (ETipo)1);

            ///Agrego los diferentes productos a la lista
            productos.Add(i1);
            productos.Add(i2);
            productos.Add(a1);
            productos.Add(a2);
            productos.Add(a3);


            ///muestro lista de productos

            foreach (Producto producto in productos)
            {
                Console.Write(producto);
            }


            ///muestro que el stock sea mayor a la venta
            try
            {

                Venta.VerificarStock(productos);
                Console.Write("Se verifico el stock correctamente \n");

            }
            catch (SobrepasaStockException e)
            {
                Console.Write(e.Message);
            }

            ///Modifica el stock
            try
            {

                Venta.modificarStock(productos);
                Console.Write("Se modifico el stock correctamente \n");

            }
            catch (SobrepasaStockException e)
            {
                Console.Write(e.Message);
            }

            ///Hago ticket de la venta
            try
            {

                Venta.TXTTicket(productos);
                Console.Write("Se creo el ticket correctamente \n");

            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }


           




            Console.ReadLine();



        }
    }
}
