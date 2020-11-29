using System;
using System.Text;

namespace Entidades
{
    public static class ExtensionesDeVenta
    {



        public static string AgregarFecha(this String dato)
        {

            StringBuilder sb = new StringBuilder();


            sb.Append($"{DateTime.Now.Day}{DateTime.Now.Month}{DateTime.Now.Year}{DateTime.Now.Hour}{DateTime.Now.Minute}{dato}");

            //string fechaAux = DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() +DateTime.Now.Hour.ToString();

           // DateTime.Now.Date.ToString();
           // return DateTime.Now.ToString() + dato;
            return sb.ToString();


        }



    }
}
