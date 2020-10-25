using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Ticket.entities;

namespace Proyecto_Ticket.Presentacion
{
    public partial class PantallaPrincipal : Form
    {
        public static int FormularioActual = 0;
        public static int ActivoFormTiket = 0;
        public static int ActivoFormUser = 0;
        public static int ActivoFormReportTiket = 0;
        public Usuario UserConectado { get; set; }
        public PantallaPrincipal()
        {
            InitializeComponent();
        }  

    
        private void BtnTicket_Click(object sender, EventArgs e)
        {
            if (ActivoFormUser==0&& ActivoFormReportTiket==0)
            {
                if (FormularioActual != 1 && ActivoFormTiket == 0)
                {
                    PantallaTicket form = new PantallaTicket
                    {
                        MdiParent = this
                    };
                    form.Show();
                    FormularioActual = 1;
                    ActivoFormTiket = 1;
                }
                else
                {
                    MessageBox.Show("El Formulario de Tikets ya se encuentra abierto");
                }
            }
            else
            {
                MessageBox.Show("Otro Formulario ya se encuentra abierto.Salga del formulario actual y vuelva a intentarlo.");
            }
        }

        private void BtnSalir_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro desea salir", "Salir", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            if(ActivoFormReportTiket==0&& ActivoFormTiket==0)
            { 
                if (FormularioActual != 2&& ActivoFormUser==0)
                {
                    PantallaUsuarios form = new PantallaUsuarios() { MdiParent = this};
                    form.Show();
                    FormularioActual = 2;
                    ActivoFormUser = 1;
                }
                else
                {
                    MessageBox.Show("El Formulario de Usuarios ya se encuentra abierto");
                }
            }
            else
            {
                MessageBox.Show("Otro Formulario ya se encuentra abierto.Salga del formulario actual y vuelva a intentarlo.");
            }
}

        private void PantallaPrincipal_Load(object sender, EventArgs e)
        {

            
            textUsuario.Text = Program.UserConectado.Apellido + " " + Program.UserConectado.Nombre;
            textCategoria.Text = Program.UserConectado.Categoria;
            
            if (textCategoria.Text == "Usuario" || textCategoria.Text == "Tecnico")
              {
                  btnUsuarios.Enabled = false;
                  btnReportes.Enabled = false;
              }
        }

        

        private void BtnReportes_Click(object sender, EventArgs e)
        {

            if(btnReportesUsuarios.Visible == false)
            {
                btnReportesUsuarios.Visible = true;
                btnReporteTickets.Visible = true;

            } else
            {
                btnReportesUsuarios.Visible = false;
                btnReporteTickets.Visible = false;
            }
            
        }


        private void BtnIniciarSesion_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que desea iniciar otra sesion ", "Iniciar Sesion", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                
                InicioSesion IN = new InicioSesion();
                this.Close();
                IN.ShowDialog();
                
            }
        }

        private void BtnReporteTickets_Click(object sender, EventArgs e)
        {
            if (ActivoFormTiket == 0 && ActivoFormUser == 0)
            {
                if (FormularioActual != 3 && ActivoFormReportTiket == 0)
                {
                    ReporteTickets form = new ReporteTickets
                    {
                        MdiParent = this
                    };
                    form.Show();
                    FormularioActual = 3;
                    ActivoFormReportTiket = 1;
                }
                else
                {
                    MessageBox.Show("El Formulario de Reporte de Tikets ya se encuentra abierto");
                }
            }
            else
            {
                MessageBox.Show("Otro Formulario ya se encuentra abierto.Salga del formulario actual y vuelva a intentarlo.");
            }
        }

        private void PantallaPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
