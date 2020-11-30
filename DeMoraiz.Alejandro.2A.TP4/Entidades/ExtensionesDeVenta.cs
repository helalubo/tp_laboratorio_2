using System;
using System.Text;

namespace Entidades
{

    /// <summary>
    /// Clase estatica  ExtensionesDeVenta creada para depositar los metodos 
    /// extensiones
    /// </summary>
    public static class ExtensionesDeVenta
    {

        /// <summary>
        /// Agrega la fecha y hora en formato numerico a un string, esto utilizando un metodo extension
        /// </summary>
        /// <param name="dato">String a transformar</param>
        /// <returns></returns>

        public static string AgregarFecha(this String dato)
        {

            StringBuilder sb = new StringBuilder();


            sb.Append($"{DateTime.Now.Day}{DateTime.Now.Month}{DateTime.Now.Year}{DateTime.Now.Hour}{DateTime.Now.Minute}{dato}");

         
            return sb.ToString();


        }



    }
}
