using System;

namespace Entidades
{
    public class Numero
    {
        private double numero;

        public Numero()
        {
            this.numero = 0;

        }

        public Numero(double numero)
        {
            this.numero = numero;

        }

        public Numero(string strNumero)
        {
            SetNumero = strNumero;

        }

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


        public static double operator - (Numero n1, Numero n2)
        {
            return n1.numero - n2.numero;


        }

        public static double operator +(Numero n1, Numero n2)
        {
            return n1.numero +  n2.numero;


        }
        public static double operator *(Numero n1, Numero n2)
        {
            return n1.numero * n2.numero;


        }

        public static double operator /(Numero n1, Numero n2)
        {
            double rta;

            if(n2.numero == 0 )
            {
                rta = double.MinValue;
            }
            else
            {

                rta =  n1.numero / n2.numero;


            }

            return rta;


        }








        private static double ValidarNumero(string strNumero)
        {

            double aux;

            if(!double.TryParse(strNumero, out aux))
            {
                aux = 0;
            }
            return aux;

        }

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
