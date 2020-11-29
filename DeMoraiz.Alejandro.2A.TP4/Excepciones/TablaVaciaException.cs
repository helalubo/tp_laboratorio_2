using System;
using System.Collections.Generic;
using System.Text;

namespace Excepciones
{
    public class TablaVaciaException :Exception
    {


        public TablaVaciaException(string eMensaje) : base(eMensaje)
        {

        }
    }
}
