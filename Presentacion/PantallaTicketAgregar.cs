using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Proyecto_Ticket.entities;
using Proyecto_Ticket.Presentacion;

namespace Proyecto_Ticket.Presentacion
{
    partial class PantallaTicketAgregar : Form
    {
        public PantallaTicket Tparent;

        PantallaPrincipal form = new PantallaPrincipal();
        
        public Ticket seleccion;
        public string IDT { get; set; }

        public PantallaTicketAgregar(PantallaTicket Pant)
        {
            InitializeComponent();
            Tparent = Pant;
        }

        private void BtnSalirAgregarTicket_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PantallaTicketAgregar_Load(object sender, EventArgs e)
        {
            
            cbEstado.SelectedItem = "Abierto";
            txtTicketUsuario.Text = Program.UserConectado.Apellido + " " + Program.UserConectado.Nombre;
            
            if (Program.UserConectado.Categoria == "Administrador" && (seleccion == null || seleccion.Tecnico == "" ))
            {
                cbTicketTecnico.Visible = true;
                txtTicketTecnico.Visible = false;
            }
            else
            {
                txtTicketTecnico.Visible = true;
                cbTicketTecnico.Visible = false;
                
            }

            if (Program.UserConectado.Categoria == "Usuario")
            {
                cbEstado.Enabled = false;
                cbTicketTecnico.Enabled = false;
                txtTicketDescripcion.Enabled = false;
                txtTicketUsuario.Enabled = false;
                txtTicketTecnico.Enabled = false;
                
            }

            if (seleccion != null)
            {
                txtTicketTitulo.Text = seleccion.Titulo;
                txtTicketDetalle.Text = seleccion.Descripcion;
                cbTicketArea.Text = seleccion.Area;
                cbTicketCategoria.Text = seleccion.Tipo;
                txtTicketDescripcion.Text = seleccion.Observacion;
                txtTicketUsuario.Text = seleccion.Usuario;
                cbTicketTecnico.Text = seleccion.Tecnico;
                if (seleccion.Tecnico != null)
                {
                    txtTicketTecnico.Text = seleccion.Tecnico;
                }
                
            }

            CompletarCombox();
        }

        private void BtnAgregarTicket_Click(object sender, EventArgs e)
        {
           
            if (is_validate_agregar_ticket())
            {
                ErrorIcono.Clear();

                if (seleccion == null)
                {
                    Ticket seleccion = new Ticket();
                    CargaDatos(seleccion);
                    seleccion.ID_Ticket = Guid.NewGuid().ToString();
                    seleccion.TEstado = cbEstado.Text;
                    seleccion.CargarEstado();
                    seleccion.Usuario = Program.UserConectado.ID_Usuario;
                    


                    Tparent.AgregarTickets(seleccion);

                }
                else
                {
                    
                    CargaDatos(seleccion);
                    CambioEstado(seleccion);
                    
                    Tparent.EditarTicket();
                }

                this.Close();
            }
        }

        public void CargaDatos(Ticket T)
        {
            
            T.Titulo = txtTicketTitulo.Text;
            T.Descripcion = txtTicketDetalle.Text;
            T.Area = cbTicketArea.Text;
            T.Tipo = cbTicketCategoria.Text;
            T.Observacion = txtTicketDescripcion.Text;
            T.Fecha_Resolucion = DateTime.Now;

            if (Program.UserConectado.Categoria == "Administrador" && txtTicketTecnico.Text == "")
            {
                T.Tecnico = cbTicketTecnico.Text;
            }
            else
            {
                T.Tecnico = txtTicketTecnico.Text;
            }
        }

        private void CambioEstado(Ticket T)
        {
            try
            {
                if (cbEstado.Text == "Abierto") { T.abiertoState(); T.TEstado = cbEstado.Text; }

            }
            catch (Exception)
            {
                MessageBox.Show("No se puede cambiar al estado " + cbEstado.Text + " ya asignado el Ticket" , "Advertencia");
            }

            try
            {
                if (cbEstado.Text == "En Progreso") { T.enProgresoState(); T.TEstado = cbEstado.Text; }
                
            }
            catch (Exception)
            {
                MessageBox.Show(" No se puede cambiar al estado " + cbEstado.Text, "Advertencia");
            }

            try
            {
                if (cbEstado.Text == "Resuelto") { T.resueltoState(); T.TEstado = cbEstado.Text; }

            }
            catch (Exception)
            {
                MessageBox.Show("No se puede cambiar al estado " + cbEstado.Text , "Advertencia");
            }

            try
            {
                if (cbEstado.Text == "Cerrado") { T.cerradoState(); T.TEstado = cbEstado.Text; }

            }
            catch (Exception)
            {
                MessageBox.Show("No se puede cambiar al estado " + cbEstado.Text, "Advertencia");
            }
        }
       
        public void CompletarCombox()
        {
            _ = new List<Usuario>();

            Stream flujo = File.OpenRead("Usuarios.bin");
            BinaryFormatter deserializer = new BinaryFormatter();
            List<Usuario> ListadoUsuarios = (List<Usuario>)deserializer.Deserialize(flujo);
            flujo.Close();

            cbTicketTecnico.Items.Clear();
            

            foreach (Usuario X in ListadoUsuarios)
            {
               if (X.Categoria == "Tecnico") { cbTicketTecnico.Items.Add(X.ID_Usuario); }
            }
        }

        private bool is_validate_agregar_ticket()
        {
            bool no_error = true;

            if (txtTicketTitulo.Text == string.Empty)
            {
                ErrorIcono.SetError(txtTicketTitulo, "Ingrese el Titulo");
                no_error = false;
            }

            if (txtTicketDetalle.Text == string.Empty)
            {
                
                ErrorIcono.SetError(txtTicketDetalle, "Ingrese la Descripcion");
                no_error = false;
            }

            if (cbTicketArea.Text == string.Empty)
            {
                
                ErrorIcono.SetError(cbTicketArea, "Ingrese el Area");
                no_error = false;
            }

            return no_error;
        }
    }
}
