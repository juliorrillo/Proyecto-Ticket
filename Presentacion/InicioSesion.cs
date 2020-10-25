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

namespace Proyecto_Ticket.Presentacion
{   
    [Serializable]
    public partial class InicioSesion : Form
    {
        List<Usuario> ListadoUsuarios = new List<Usuario>();
        private int bandera;



        public InicioSesion()
        {
            InitializeComponent();
        }

        private void BtnSalirIngreso_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnIngreso_Click(object sender, EventArgs e)
        {
            Stream flujo = File.OpenRead("Usuarios.bin");
            BinaryFormatter deserializer = new BinaryFormatter();
            ListadoUsuarios = (List<Usuario>)deserializer.Deserialize(flujo);
            flujo.Close();

            PantallaPrincipal PP = new PantallaPrincipal();
            bandera = 1;

            foreach (Usuario Buscar in ListadoUsuarios)
            {
                if (Buscar.Contraseña == txtPasswordIngreso.Text && Buscar.User == txtUsuarioIngreso.Text)
                {
                  
                    Program.UserConectado = Buscar;
                    bandera = 0;
                    
                }

            }
            


            if (bandera == 1)
            {
                    MessageBox.Show("Usuario y/o contraseña incorrectos");
                    txtUsuarioIngreso.Focus();
                    txtUsuarioIngreso.Text = "";
                    txtPasswordIngreso.Text = "";

            }
            else
            {
                PP.Show();
                this.Hide();
            }
            
        }

        

        private void InicioSesion_Load(object sender, EventArgs e) //agrego usuario y contraseña al txtbox
        {
            
            txtUsuarioIngreso.Text = "Usuario";
            txtPasswordIngreso.Text = "Contraseña";
        }

        private void TxtUsuarioIngreso_Enter(object sender, EventArgs e) // cuando hago click lo vacio para poder escribir
        {
           if(txtUsuarioIngreso.Text == "Usuario")
            {
                txtUsuarioIngreso.Text = "";
            }
        }

        private void TxtUsuarioIngreso_Leave(object sender, EventArgs e) // si salgo sin escribir le vuelvo a poner usuario
        {
            if (txtUsuarioIngreso.Text == "")
            {
                txtUsuarioIngreso.Text = "Usuario";
            }
        }

        private void TxtPasswordIngreso_Enter(object sender, EventArgs e) // cuando hago click lo vacio para poder escribir y activo el caracter password
        {
            if (txtPasswordIngreso.Text == "Contraseña")
            {
                txtPasswordIngreso.Text = "";
                txtPasswordIngreso.UseSystemPasswordChar = true;
            }
        }

        private void TxtPasswordIngreso_Leave(object sender, EventArgs e) // si salgo sin escribir le vuelvo a poner contraseña y desactivo el caracter password para que aparesca contraseña
        {
            if (txtPasswordIngreso.Text == "")
            {
                txtPasswordIngreso.Text = "Contraseña";
                txtPasswordIngreso.UseSystemPasswordChar = false;
            }
        }

        private void txtPasswordIngreso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                BtnIngreso_Click(sender, e);
            }
        }

        private void txtUsuarioIngreso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                txtPasswordIngreso.Focus();
            }
        }
    }
}
