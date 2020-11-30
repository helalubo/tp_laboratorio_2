using System;

namespace Entidades
{


    /// <summary>
    /// Clase de numero
    /// </summary>
    public class Numero
    {
        private double numero;


        /// <summary>
        /// Constructor por defecto de la clase.
        /// </summary>
        public Numero()
        {
            this.numero = 0;

        }
        /// <summary>
        /// Constructor con parametro numero de tipo entero
        /// </summary>
        /// <param name="numero"></param>
        public Numero(double numero)
        {
            this.numero = numero;

        }
        /// <summary>
        /// Constructor con parametro numero de tipo string
        /// </summary>
        /// <param name="strNumero"></param>
        public Numero(string strNumero)
        {
            SetNumero = strNumero;

        }


        /// <summary>
        /// Atributo que valida el numero
        /// </summary>

        public string SetNumero
        {



            set
            {

                double aux;
                aux = ValidarNumero(value);

                if (aux != 0)
                {

                    numero = aux;
                }





            }
        }
        /// <summary>
        /// Resta n1 con n2
        /// </summary>
        /// <param name="n1">Numero para operar</param>
        /// <param name="n2">segundo numero para operar</param>
        /// <returns>resultado de la operacion</returns>

        public static double operator -(Numero n1, Numero n2)
        {
            return n1.numero - n2.numero;


        }
        /// <summary>
        /// Suma n1 con n2
        /// </summary>
        /// <param name="n1">Numero para operar</param>
        /// <param name="n2">segundo numero para operar</param>
        /// <returns>resultado de la operacion</returns>
        public static double operator +(Numero n1, Numero n2)
        {
            return n1.numero + n2.numero;


        }

        /// <summary>
        /// Multiplica n1 con n2
        /// </summary>
        /// <param name="n1">Numero para operar</param>
        /// <param name="n2">segundo numero para operar</param>
        /// <returns>resultado de la operacion</returns>
        public static double operator *(Numero n1, Numero n2)
        {
            return n1.numero * n2.numero;


        }
        /// <summary>
        /// divide n1 con n2
        /// </summary>
        /// <param name="n1">Numero para operar</param>
        /// <param name="n2">segundo numero para operar</param>
        /// <returns>resultado de la operacion</returns>
        public static double operator /(Numero n1, Numero n2)
        {
            double rta;

            if (n2.numero == 0)
            {
                rta = double.MinValue;
            }
            else
            {

                rta = n1.numero / n2.numero;


            }

            return rta;


        }





        /// <summary>
        /// Valida el numero ingresado como string
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns></returns>


        private static double ValidarNumero(string strNumero)
        {

            double aux;

            if (!double.TryParse(strNumero, out aux))
            {
                aux = 0;
            }
            return aux;

        }

        /// <summary>
        /// Verifica si es binario
        /// </summary>
        /// <param name="binario"></param>
        /// <returns>true en caso de ser valido, false en caso de que no</returns>

        private bool EsBinario(string binario)
        {

            bool rta = false;

            foreach (char digito in binario)
            {
                if (digito == '1' || digito == '0')
                {
                    rta = true;
                }
                else
                {
                    rta = false;
                    break;
                }

            }

            return rta;


        }
        /// <summary>
        /// Pasa el numero de Binario a decimal
        /// </summary>
        /// <param name="binario">Cadena de caracteres que sera pasada a binario</param>
        /// <returns>Cadena de caracteres en decimal</returns>

        public string BinarioDecimal(string binario)
        {

            double entero = 0;
            string rta;

            if (EsBinario(binario))
            {



                int len = binario.Length;



                for (int i = 0; i < binario.Length; i++)
                {
                    char letra = binario[i];
                    len = len - 1;
                    if (letra == '1' && len != 0)
                    {




                        entero += (double)Math.Pow(2, len);
                    }

                }

            }
            rta = Convert.ToString(entero);

            if (rta == "0")
            {
                rta = "Valor invalido";

            }

            return rta;

        }

        /// <summary>
        /// Pasa el numero de decimal a binario
        /// </summary>
        /// <param name="numero">numero a pasar a binario</param>
        /// <returns>cadena de caracteres de numero que fue transformado en binario</returns>
        public string DecimalBinario(double numero)
        {
            string bin = "";




            if (numero >= 1 && ValidarNumero(Convert.ToString(numero)) != 0)
            {




                while (numero >= 1)
                {
                    if (numero % 2 == 0)
                    {
                        bin = "0" + bin;

                    }

                    else
                    {

                        bin = "1" + bin;
                    }


                    numero = (int)numero / 2;

                }

            }
            else
            {

                bin = "Valor invalido";

            }

            return bin;






        }

        /// <summary>
        /// Pasa de decimal a binario
        /// </summary>
        /// <param name="numero">Numero en formato cadena de caracteres a ser transformado a Binario</param>
        /// <returns></returns>
        public string decimalBinario(string numero)
        {
            string bin = "";

            double auxNum;
            auxNum = double.Parse(numero);



            if (auxNum >= 1 && ValidarNumero(numero) != 0)
            {




                while (auxNum >= 1)
                {
                    if (auxNum % 2 == 0)
                    {
                        bin = "0" + bin;

                    }

                    else
                    {

                        bin = "1" + bin;
                    }


                    auxNum = (int)auxNum / 2;

                }

            }
            else
            {

                bin = "Valor invalido";

            }

            return bin;






        }

    }

}
