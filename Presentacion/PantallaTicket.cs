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
    partial class PantallaTicket : Form
    {
        List<Ticket> ListadoTickets = new List<Ticket>();
        PantallaPrincipal PP = new PantallaPrincipal();

        public PantallaTicket()
        {
            InitializeComponent();
        }

        private void BtnSalirTicket_Click(object sender, EventArgs e)
        {
            Stream flujo2 = File.Create("Tickets.bin");
            BinaryFormatter serializer = new BinaryFormatter();
            serializer.Serialize(flujo2, ListadoTickets);
            flujo2.Close();
            PantallaPrincipal.ActivoFormTiket = 0;
            PantallaPrincipal.FormularioActual = 0;
            this.Close();
        }

        private void BtnNuevoTicket_Click(object sender, EventArgs e)
        {
            PantallaTicketAgregar formu = new PantallaTicketAgregar(this);
            formu.Show();
        }

        public void AgregarTickets(Ticket Ti)
        {
            ListadoTickets.Add(Ti);
            CargarListview("Todos");
        }

        public void EditarTicket()
        {

            CargarListview("Todos");
        }

        private void PantallaTicket_Load_1(object sender, EventArgs e)
        {
           

            Stream flujo = File.OpenRead("Tickets.bin");
            BinaryFormatter deserializer = new BinaryFormatter();
            ListadoTickets = (List<Ticket>)deserializer.Deserialize(flujo);
            flujo.Close();

           
            LvTickets.Items.Clear();

           
            CargarListview("Todos");
        }

        private void BtnEditarTicket_Click(object sender, EventArgs e)
        {
            try
            {
                if (LvTickets.SelectedItems != null) { EditarT(); }

            }
            catch (Exception)
            {
                MessageBox.Show("No se ha seleccionado un elemento de la lista ", "Advertencia");
            }
            
        }
        private void BtnBorrarTicket_Click(object sender, EventArgs e)
        {

            try
            {
                if (LvTickets.SelectedItems[0] != null) { borrarT(); }

            }
            catch (Exception)
            {
                MessageBox.Show("No se ha seleccionado un elemento de la lista ", "Advertencia");
            }              
        }

        private void PantallaTicket_FormClosed(object sender, FormClosedEventArgs e)
        {
            Stream flujo2 = File.Create("Tickets.bin");
            BinaryFormatter serializer = new BinaryFormatter();
            serializer.Serialize(flujo2, ListadoTickets);
            flujo2.Close();
        }

        private void BtnTodos_Click(object sender, EventArgs e)
        {
            CargarListview("Todos");
        }

        private void BtnAbiertos_Click(object sender, EventArgs e)
        {
            CargarListview("Abierto");
        }

        private void BtnEnProgreso_Click(object sender, EventArgs e)
        {
            CargarListview("En Progreso");
        }

        private void BtnResuelto_Click(object sender, EventArgs e)
        {
            CargarListview("Resuelto");
        }
        
        private void BtnCerrados_Click(object sender, EventArgs e)
        {
            CargarListview("Cerrado");
        }

        public void CargarListview(string X)
        {
            List<Usuario> ListadoUsuarios = new List<Usuario>();
            Stream flujo = File.OpenRead("Usuarios.bin");
            BinaryFormatter deserializer = new BinaryFormatter();
            ListadoUsuarios = (List<Usuario>)deserializer.Deserialize(flujo);
            flujo.Close();

            LvTickets.Items.Clear();
            foreach (Ticket T in ListadoTickets)
            {
                if ((T.TEstado == X || X == "Todos") && (Program.UserConectado.ID_Usuario == T.Usuario || Program.UserConectado.Categoria == "Administrador" || Program.UserConectado.ID_Usuario == T.Tecnico) )
                {
                    ListViewItem item = new ListViewItem
                    {
                        Checked = true,
                        Text = T.ID_Ticket.ToString()
                    };
                    item.SubItems.Add(T.TEstado);
                    item.SubItems.Add(T.Titulo);
                    item.SubItems.Add(T.Descripcion);
                    item.SubItems.Add(T.Area);
                    item.SubItems.Add(T.Tipo);
                    item.SubItems.Add(T.Observacion);
                    foreach (Usuario U in ListadoUsuarios)
                    {
                        if (T.Usuario == U.ID_Usuario) { item.SubItems.Add(U.Nombre + " " + U.Apellido); }
                        if (T.Tecnico == U.ID_Usuario) { item.SubItems.Add(U.Nombre + " " + U.Apellido); }
                        
                        {
                            if (T.Tecnico == "") { item.SubItems.Add(""); }
                        }

                    }
                    

                    item.SubItems.Add(T.Fecha_Carga.ToString("dd/MM/yyyy"));
                    item.SubItems.Add(T.Fecha_Resolucion.ToString("dd/MM/yyyy"));

                    
                    LvTickets.Items.Add(item);
                }
             }
        }
        
        public void BorrarDeLaLista(string X)
        {
            for (int i = 0; i < ListadoTickets.Count; i++) // lo borro de la lista de colecciones
            {
                if (ListadoTickets[i].ID_Ticket.ToString() == X)
                {
                    ListadoTickets.Remove(ListadoTickets[i]);
                }
            }
        }

        private void BtnTicketEstado_Click(object sender, EventArgs e)
        {
            try
            {
                if (LvTickets.SelectedItems[0] != null)
                {
                    string sele = LvTickets.SelectedItems[0].Text;
                    foreach (Ticket T in ListadoTickets)
                    {
                        if (sele == T.ID_Ticket)
                        {
                            MessageBox.Show(T.GetEstado());
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("No se ha seleccionado un elemento de la lista ", "Advertencia");
            }
        }

        private void LvTickets_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            EditarT();
        }

        private void EditarT()
        {
                PantallaTicketAgregar formAgregar = new PantallaTicketAgregar(this);

                string SeleccionT = LvTickets.SelectedItems[0].Text; // tomo el id del elemento seleccionado y lo guardo en seleccion

                foreach (Ticket X in ListadoTickets)
                {
                    if (X.ID_Ticket == SeleccionT)
                    {
                        formAgregar.seleccion = X;
                        formAgregar.Tparent = this;
                        formAgregar.IDT = SeleccionT;
                        formAgregar.Show();

                    }
                }
        }

        private void borrarT()
        {
            DialogResult result = MessageBox.Show("Seguro que desea BORRAR este usuario ", "Borrar Usuario", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                string SeleccionU = LvTickets.SelectedItems[0].Text; // tomo el id del elemento seleccionado y lo guardo en selleccion
                LvTickets.SelectedItems[0].Remove(); // lo borro del listview
                BorrarDeLaLista(SeleccionU);
            }
        }
    }
}