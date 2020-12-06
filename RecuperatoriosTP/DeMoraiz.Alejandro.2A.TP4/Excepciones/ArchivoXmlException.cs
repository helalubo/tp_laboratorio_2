using System;
using System.Collections.Generic;
using System.Text;

namespace Excepciones
{
   public class ArchivoXmlException : Exception 
    {

        public ArchivoXmlException(Exception innerException) : base("No es posible crear archivo Xml", innerException)
        {

        }
    }
}
