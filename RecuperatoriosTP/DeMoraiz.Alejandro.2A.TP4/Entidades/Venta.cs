using CapaDatos;
using Archivos;
using Excepciones;
using System;
using System.Collections.Generic;
using System.Text;


namespace Entidades
{

    /// <summary>
    /// Clase publica de Venta
    /// </summary>

    public class Venta
    {

        /// <summary>
        /// Delegado de venta
        /// </summary>
        /// <param name="listaDeProductos">Lista de productos a manejar</param>
        public delegate void DelegadoDeVenta(List<Producto> listaDeProductos);


        /// <summary>
        /// Evento de tipo DelegadoDeVenta
        /// </summary>

        public static  event DelegadoDeVenta EventoTicket;

   
        /// <summary>
        /// Constructor vacio de venta
        /// </summary>
        public Venta()
        {

        }


        /// <summary>
        /// Verifica el stock con respecto al atributo cantidad de cada uno de los productos
        /// Si alguno de los productos se repite en la lista mas veces que la cantidad de dicho producto
        /// entonces lanzara una excepcion de tipo  SobrepasaStockException 
        /// </summary>
        /// <param name="listaDeProductos">Lista de productos a manejar</param>

        public static void VerificarStock(List<Producto> listaDeProductos)
        {
            

            int cont;

           

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


        /// <summary>
        /// modificar el stock en la base de datos SQL dependiendo si el producto es un instrumento o si es un Accesorio,
        /// agrega la funcion TXTTicket al evento 
        /// EventoTicket y lo lanza para ser ejecutado. 
        /// </summary>
        /// <param name="listaDeProductos">Lista de productos a manejar</param>

        public static  void modificarStock(List<Producto> listaDeProductos)
        {


          



            StringBuilder sbAccesorios = new StringBuilder();
            StringBuilder sbInsrumentos = new StringBuilder();
            

            AccesoDatos conexion = new AccesoDatos();

            try
            {

                conexion.Conexion.Open();


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
                Venta.EventoTicket += TXTTicket;
                EventoTicket(listaDeProductos);
            }
            catch (Exception )
            {
                
                string fallo = "No se pudo conectar la base de datos";
                throw new EstableciendoConexionException(fallo);
            }
            finally
            {
                conexion.Conexion.Close();
               
            }




      


        }

        /// <summary>
        /// Crea un ticket en formato .txt de  la compra de productos
        /// </summary>
        /// <param name="listaDeProductos">Lista de productos a manejar</param>

        public static void TXTTicket(List<Producto> listaDeProductos)
        {

            float precioTotal = 0;

          
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("                Tienda de musica                 ");
            sb.AppendLine("            ************************             ");
            sb.AppendLine("                                                 ");
            sb.AppendLine("                Factura de Venta                 ");
            sb.AppendLine("No Fac:                                          ");
            sb.AppendLine($"Fecha: {DateTime.Now}                           ");
            sb.AppendLine("Fue atendido:                                    ");
            sb.AppendLine("                                                 ");
            sb.AppendLine("-------------------------------------------------");
            sb.AppendLine("Articulo                      Cant        P.Unit ");
            sb.AppendLine("-------------------------------------------------");

            if (listaDeProductos != null)
            {

              

                foreach (Producto aux in listaDeProductos)
                {
            sb.AppendLine($"{aux.Nombre}              1        ${aux.Precio}");
                    precioTotal += aux.Precio;
                }

            }
            sb.AppendLine("-------------------------------------------------");
            sb.AppendLine($"Total                             ${precioTotal}");

            Texto archivoTicket = new Texto(); 
           

            archivoTicket.Guardar("Tickets.txt" , sb.ToString());

        }


        /// <summary>
        /// Serializa la venta en un archivo .xml poniendo en su
        /// titulo la fecha y la hora en la que fue realizada la venta, esto utilizando el metodo Extension de AgregarFecha alojado en Entidades.ExtensionesDeVenta.
        /// </summary>
        /// <param name="listaDeProductos">Lista de productos a manejar</param>
        public static void GuardarVentasEnXml(List<Producto> listaDeProductos)
        {

            
            
            
            String nombreArchivoXml = "ArticulosVendidos.xml";
            nombreArchivoXml = nombreArchivoXml.AgregarFecha();

            foreach (Producto productoAux in listaDeProductos)
            {
                productoAux.Cantidad = 1;
            }


            Xml<List<Producto>> ArchivoVenta = new Xml<List<Producto>>();
            ArchivoVenta.Guardar(nombreArchivoXml, listaDeProductos);


         









        }



    }
}
