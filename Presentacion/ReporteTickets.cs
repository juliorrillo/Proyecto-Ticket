using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Ticket.entities;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Proyecto_Ticket.Presentacion
{
    [Serializable]
    partial class ReporteTickets : Form
    {
        List<Ticket> ListaTickets = new List<Ticket>();
        private int contador = 0, contadorTotal = 0;
        string[] Estados = { "Abierto", "En Progreso", "Resuelto", "Cerrado" };

        public ReporteTickets()
        {
            InitializeComponent();
        }

        private void BtnAbierto_Click(object sender, EventArgs e)
        {
            Filtrador("Abierto");
        }

        private void BtnEnProgreso_Click(object sender, EventArgs e)
        {
            Filtrador("En Progreso");
        }

        private void BtnResuelto_Click(object sender, EventArgs e)
        {
            Filtrador("Resuelto");
        }

        private void BtnCerrado_Click(object sender, EventArgs e)
        {
            Filtrador("Cerrado");
        }

        public void Filtrador(string estado)
        {
            LvReporte.Items.Clear();

            foreach (Ticket tickets in ListaTickets)
            {
                if (Equals(estado, tickets.TEstado))
                {  
                   if (tickets.Fecha_Carga >= dateCreacionDesde.Value)
                    {
                        if (tickets.Fecha_Carga <= dateCreacionHasta.Value)
                        {
                            if (Equals(tickets.Tipo, comboCategoria.SelectedItem))
                            {
                                if (Equals(tickets.Area, comboArea.SelectedItem))
                                {
                                    contador = contador + 1;
                                    CargarListview(estado, tickets);
                                }
                            }
                        }
                    }
                }
            }
            txtCantidadTickets.Text = contador.ToString();
            contador = 0;
            
        }

        public void CargarListview(string setEstado, Ticket ticketsito) 
        {
                ListViewItem item = new ListViewItem();
                item = LvReporte.Items.Add(ticketsito.ID_Ticket);
                item.SubItems.Add(setEstado);
                item.SubItems.Add(ticketsito.Observacion);
                item.SubItems.Add(ticketsito.Descripcion);
                item.SubItems.Add(ticketsito.Usuario);
                item.SubItems.Add(ticketsito.Tecnico);
        }

        public void CargarTotalTickets(string [] estadosTicket)
        {
            foreach(string E in estadosTicket)
            {
                contadorTotal = 0;
                foreach(Ticket T in ListaTickets)
                {
                    if(Equals(E,T.TEstado))
                    {
                        contadorTotal = contadorTotal + 1;
                    }
                }
                if (Equals(E,"Abierto")) { txtCantidadAbierto.Text = contadorTotal.ToString(); }
                if (Equals(E, "En Progreso")) { txtCantidadEnProgreso.Text = contadorTotal.ToString(); }
                if (Equals(E, "Resuelto")) { txtCantidadResuelto.Text = contadorTotal.ToString(); }
                if (Equals(E, "Cerrado")) { txtCantidadCerrado.Text = contadorTotal.ToString(); }
            }
        }

        private void ReporteTickets_Load(object sender, EventArgs e)
        {
            Stream flujo = File.OpenRead("Tickets.bin");
            BinaryFormatter deserializer = new BinaryFormatter();
            ListaTickets = (List<Ticket>)deserializer.Deserialize(flujo);
            flujo.Close();

            CargarTotalTickets(Estados);

            dateCreacionDesde.Refresh();
            dateCreacionDesde.Format = DateTimePickerFormat.Custom;
            dateCreacionDesde.CustomFormat = "dd/MM/yyyy";
            dateCreacionDesde.Value = DateTime.Today;
            dateCreacionDesde.ShowUpDown = false;

            dateCreacionHasta.Refresh();
            dateCreacionHasta.Format = DateTimePickerFormat.Custom;
            dateCreacionHasta.CustomFormat = "dd/MM/yyyy";
            dateCreacionHasta.Value = DateTime.Today;
            dateCreacionHasta.ShowUpDown = false;
        }


        private void BtnReporteSalir_Click(object sender, EventArgs e)
        {
            PantallaPrincipal.ActivoFormReportTiket = 0;
            PantallaPrincipal.FormularioActual = 0;

            this.Close();
        }
    }
}
