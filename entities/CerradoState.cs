using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Ticket.entities;

namespace Proyecto_Ticket.entities
{
    [Serializable]
     class CerradoState : TicketState
    {
        public CerradoState(Ticket X) : base(X) { }
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
            throw new NotImplementedException();
        }

        public override void abiertoState()
        {
            throw new NotImplementedException();
        }

        public override string EstadoTicket()
        {
            return "Estado Cerrado";
        }
    }
}
