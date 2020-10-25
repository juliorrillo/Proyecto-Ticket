using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Ticket.entities;

namespace Proyecto_Ticket.entities
{
    [Serializable]
    class EnProgresoState : TicketState
    {
        public EnProgresoState(Ticket X) : base(X) { }

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
            throw new NotImplementedException();
        }

        public override void resueltoState()
        {
            ticket.CambiarEstado(new ResueltoState(ticket));
        }

        public override string EstadoTicket()
        {
            return "Estado En Progreso";
        }
    }
}
