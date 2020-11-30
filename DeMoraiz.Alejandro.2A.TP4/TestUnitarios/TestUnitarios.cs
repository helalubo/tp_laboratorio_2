using Entidades;
using Excepciones;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using static Entidades.Accesorio;

namespace TestUnitarios
{

    /// <summary>
    /// Clase de test unitarios 
    /// </summary>
    [TestClass]
    public class TestUnitarios
    {
        /// <summary>
        /// Verifica si se sobrepasa el stock con respecto a su cantidad
        /// </summary>

        [TestMethod]
        public void VerificarSiSobrepasaStock()
        {
            //Creo lista de Producto 
            List<Producto> pruebaDeProductos = new List<Producto>();



            //HardcodeoProductos
            Instrumentos i1 = new Instrumentos(6, "Teclado Yamaha", 55000, 5, "China", 2007);
            Instrumentos i2 = new Instrumentos(8, "Bateria  Ludwig ", 90000, 5, "EEUU", 1999);

            Accesorio a1 = new Accesorio(10001, "Puas Fender *24 ", 550, 28, 0, 0);
            Accesorio a2 = new Accesorio(10005, "Palillos Logan ", 350, 34, (EGama)2, (ETipo)1);
            Accesorio a3 = new Accesorio(10005, "Palillos Logan ", 350, 34, (EGama)2, (ETipo)1);

            ///Agrego los diferentes productos a la lista
            pruebaDeProductos.Add(i1);
            pruebaDeProductos.Add(i2);
            pruebaDeProductos.Add(a1);
            pruebaDeProductos.Add(a2);
            pruebaDeProductos.Add(a3);


            try
            {
                Venta.VerificarStock(pruebaDeProductos);

            }
            catch (SobrepasaStockException e)
            {

                Assert.IsInstanceOfType(e, typeof(SobrepasaStockException));

            }

        }




        /// <summary>
        /// Verifica si el formato del titulo del archivo sea el requerido
        /// con respecto al formato de la fecha
        /// </summary>

        [TestMethod]

        public void VerificarFormatoDeTituloDeArchivo()
        {
            bool rta = false;

            StringBuilder sb = new StringBuilder();
            string corroboracion = "NombreArchivo";

            sb.Append($"{DateTime.Now.Day}{DateTime.Now.Month}{DateTime.Now.Year}{DateTime.Now.Hour}{DateTime.Now.Minute}{corroboracion}");

            corroboracion= corroboracion.AgregarFecha();

            rta = String.Equals(corroboracion, sb.ToString()) ;

            Assert.IsTrue(rta);








        }




    }
}
