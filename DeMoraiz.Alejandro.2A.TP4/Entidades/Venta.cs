﻿using CapaDatos;
using Excepciones;
using System;
using System.Collections.Generic;
using System.Text;

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

        public static  void modificarStock(List<Producto> listaDeProductos)
        {


            ///crear objetos para entrar a base de datos asi puedo configurar la cantidad. 
            /////verificar si el id es menor de 10000, si lo es entonces hacer query de instrumentos, sino hara query de Accesorios
            /////agregar or id = {producto.id}
            ///



            StringBuilder sbAccesorios = new StringBuilder();
            StringBuilder sbInsrumentos = new StringBuilder();
            //sbAccesorios.Append(" UPDATE [Producto].[dbo].[Accesorios]SET cantidad = cantidad - 1 WHERE  id = ");
            //sbInsrumentos.Append(" UPDATE [Producto].[dbo].[Instrumento]SET cantidad = cantidad - 1 WHERE  id = ");

            AccesoDatos conexion = new AccesoDatos();

            try
            {

                conexion.Conexion.Open();




                /////


                foreach (Producto producoAux in listaDeProductos)
                {
                    sbAccesorios.Append(" UPDATE [Producto].[dbo].[Accesorios]SET cantidad = cantidad - 1 WHERE  id = ");
                    sbInsrumentos.Append(" UPDATE [Producto].[dbo].[Instrumento]SET cantidad = cantidad - 1 WHERE  id = ");

                    if (producoAux.ID < 10000)
                    {
                        sbInsrumentos.Append($"{producoAux.ID};");
                        conexion.Comando.CommandText = sbInsrumentos.ToString();

                    }
                    else
                    {
                        sbAccesorios.Append($"{ producoAux.ID}; ");
                        conexion.Comando.CommandText = sbAccesorios.ToString();
                    }

                    conexion.Comando.ExecuteNonQuery();
                    sbInsrumentos.Clear();
                    sbAccesorios.Clear();
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            finally
            {
                conexion.Conexion.Close();
            }




            //recorro todo con un for each, pregunto si el id del objeto es menor o mayor a 10000 y lo agrego en listas diferentes.
            //luego estas listas las uso para pasar los id = { accesorio.id}; el ultimo ////String cadena = "123456789";
            //cadena = cadena.substring(0, cadena.length() - 2);


        }


        public void TXTTicket(List<Producto> listaDeProductos)
        {


        }


        public void XMLVentasRealizadas(List<Producto> listaDeProductos)
        {


        }

    }
}
