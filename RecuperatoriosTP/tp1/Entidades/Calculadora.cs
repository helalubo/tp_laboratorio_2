using System;

namespace Entidades
{


    /// <summary>
    /// Clase calculadora
    /// </summary>
    public class Calculadora
    {


        /// <summary>
        /// Opera los numeros con respecto al operador que le pasemos
        /// </summary>
        /// <param name="num1">primer numero a operar</param>
        /// <param name="num2">Segundo numero a operar </param>
        /// <param name="operador">Simbolo para la operacion</param>
        /// <returns></returns>
        public static double Operar(Numero num1, Numero num2, string operador)
        {

            double rta = 0;
            string operadorValidado;



            if (operador == "")
            {
                operador = "+";
            }

     
            operadorValidado = Calculadora.ValidarOperador(char.Parse(operador));

            switch (operadorValidado)
            {

                case "+":
                    rta = num1 + num2;
                    break;

                case "-":
                    rta = num1 - num2;
                    break;
                case "*":
                    rta = num1 * num2;
                    break;
                case "/":
                    rta = num1 / num2;
                    break;

              



            }

            return rta;


        }


        /// <summary>
        /// Valida el operador pasado por parametro
        /// </summary>
        /// <param name="operador">Operador a validar</param>
        /// <returns></returns>
        private static string ValidarOperador(char operador)
        {
            string rta = "+";

        






            if (operador == '-' || operador == '*' || operador == '/')
            {

                rta = operador.ToString();
            }



            return rta;


        }

    }
}
