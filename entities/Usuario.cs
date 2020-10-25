using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Ticket.entities
{
    [Serializable]
    public class Usuario
    {
        public string ID_Usuario { get; set; }
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Telefono { get; set; }

        public string Correo { get; set; }

        public string Area { get; set; }

        public string Categoria { get; set; }

        public string User { get; set; }

        public string Contraseña { get; set; }

     
        
       public Usuario()
        {

        }
    }
}
