using System;

namespace Excepciones
{
    public class SobrepasaStockException : Exception
    {

        public SobrepasaStockException(string eMensaje) : base(eMensaje)
        {

        }
    }
}
