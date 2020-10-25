using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Ticket.Presentacion;
using Proyecto_Ticket.entities;
namespace Proyecto_Ticket
{
    static class Program
    {

        public static Usuario UserConectado;

       
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new InicioSesion());

            

        }
        
    }
}
