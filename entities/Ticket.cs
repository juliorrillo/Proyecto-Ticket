using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Proyecto_Ticket.entities
{
    
    [Serializable]
      class Ticket
    {
        public string ID_Ticket { get; set; }

        public string Titulo { get; set; }

        public string Descripcion { get; set; }

        public string Area { get; set; }

        public TicketState Estado { get; set; }

        public string TEstado { get; set; }

        public string Tipo { get; set; }

        public string Observacion { get; set; }

        public string Usuario { get; set; }

        public string Tecnico { get; set; }

        public DateTime Fecha_Carga { get; set; }

        public DateTime Fecha_Resolucion { get; set; }

       public Ticket()
        {
           Fecha_Carga = DateTime.Today;
          
        }

       public void CargarEstado()
        {
            Estado = new AbiertoState(this);
         
         }
    
        public void CambiarEstado(TicketState E)
        {
            Estado = E;
        }

        public string GetEstado()
        {
            return Estado.EstadoTicket();
        }
        public void enProgresoState()
        {
            Estado.enProgresoState();
        }

        public void resueltoState()
        {
            Estado.resueltoState();
        }

        public void cerradoState()
        {
            Estado.cerradoState();
        }

        public void abiertoState()
        {
            Estado.abiertoState();
        }

    }
}
