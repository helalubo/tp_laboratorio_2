using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Entidades;
using Excepciones;
using System.Collections.Generic;
using static Entidades.Accesorio;

namespace TestUnitarios
{
    [TestClass]
    public class TestUnitarios
    {
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
            catch (SobrepasaStockException e )
            {

                Assert.IsInstanceOfType(e, typeof(SobrepasaStockException));
           
            }

        }
    }
}
