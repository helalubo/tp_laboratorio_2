using System;
using System.Collections.Generic;
using System.Text;

namespace Excepciones
{
    public class TicketException : Exception
    {

        public TicketException(Exception innerException) : base("No es posible crear Ticket", innerException)
        {

        }
    }
}
