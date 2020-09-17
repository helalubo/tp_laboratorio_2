using System;

namespace Entidades
{
    public class Calculadora
    {
        public static double Operar(Numero num1, Numero num2, string operador)
        {

            double rta = 0;
            string operadorValidado;



            if (operador == "")
            {
                operador = "+";
            }

            // operadorValidado = Calculadora.ValidarOperador(Convert.ToChar(operador));
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
