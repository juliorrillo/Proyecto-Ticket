using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Ticket.entities;
namespace Proyecto_Ticket.entities
{
       [Serializable]
      class AbiertoState : TicketState
    {
        public AbiertoState(Ticket X) : base(X) { }

        public override void abiertoState()
        {
            throw new NotImplementedException();
        }
        public override void cerradoState()
        {
            throw new NotImplementedException();
        }

        public override void enProgresoState()
        {
            ticket.CambiarEstado(new EnProgresoState(ticket));
        }

        public override void resueltoState()
        {
            throw new NotImplementedException();
        }

        public override string EstadoTicket()
        {
            return "Estado Abierto";
        }
    }
}
