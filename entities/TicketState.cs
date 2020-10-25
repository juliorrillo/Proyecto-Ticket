using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Ticket.entities
{
    [Serializable]
      abstract class TicketState 
    {
        protected Ticket ticket;

        public TicketState(Ticket X )
        {
            ticket = X;
        }

       abstract public void abiertoState();
       abstract public void enProgresoState();
       abstract public void resueltoState();
       abstract public void cerradoState();

        abstract public string EstadoTicket();

    }

    class OperacionNoPermitidaException : Exception { }
}

