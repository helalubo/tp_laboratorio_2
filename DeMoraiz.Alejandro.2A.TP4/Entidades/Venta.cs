using CapaDatos;
using Archivos;
using Excepciones;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Venta
    {

        public delegate void DelegadoDeVenta(List<Producto> listaDeProductos);


        public static  event DelegadoDeVenta EventoTicket;

       

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
                //Console.Write(ex.Message);
                string fallo = "No se pudo conectar la base de datos";
                throw new Exception(fallo);
            }
            finally
            {
                conexion.Conexion.Close();
                EventoTicket(listaDeProductos);
            }




      


        }


        public static void TXTTicket(List<Producto> listaDeProductos)
        {

            float precioTotal = 0;

          
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("                  Empresa xxxxx                  ");
            sb.AppendLine("            ****************************         ");
            sb.AppendLine("                                                 ");
            sb.AppendLine("                Factura de Venta                 ");
            sb.AppendLine("No Fac:                                          ");
            sb.AppendLine($"Fecha: {DateTime.Now}                           ");
            sb.AppendLine("Fue atendido:                                    ");
            sb.AppendLine("                                                 ");
            sb.AppendLine("-------------------------------------------------");
            sb.AppendLine("Articulo               Cant        P.Unit        ");
            sb.AppendLine("-------------------------------------------------");

            if (listaDeProductos != null)
            {

              

                foreach (Producto aux in listaDeProductos)
                {
            sb.AppendLine($"{aux.Nombre}       1        ${aux.Precio}        "); 
                }

            }
            sb.AppendLine("-------------------------------------------------");
            sb.AppendLine($"Total                             ${precioTotal}");

            Texto archivoTicket = new Texto(); 
            string nombreArchivo = DateTime.Now.ToString();

            archivoTicket.Guardar("Tickets.txt" , sb.ToString());

        }
        /// C:\Users\User\Desktop\UTN\tp_laboratorio_2\DeMoraiz.Alejandro.2A.TP4\vista\bin\Debug


        public void XMLVentasRealizadas(List<Producto> listaDeProductos)
        {


        }

    }
}
