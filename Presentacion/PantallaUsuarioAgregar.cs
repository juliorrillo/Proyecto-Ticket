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
using System.Text.RegularExpressions; //clase para validar el correo

namespace Proyecto_Ticket.Presentacion
{
     partial class PantallaUsuarioAgregar : Form
    {
        public PantallaUsuarios parent;

        public List<Usuario> lUsuarios;
        public string ID { get; set; }
        

        public PantallaUsuarioAgregar(PantallaUsuarios Pant)
        {
            InitializeComponent();
            parent = Pant;
        }

        private void BtnCerrarUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PantallaUsuarioAgregar_Load(object sender, EventArgs e)
        {
            if(ID != null)
            {
                foreach (Usuario U in lUsuarios)
                {
                    if (U.ID_Usuario == ID)
                    {
                        txtNombreUsuario.Text = U.Nombre;
                        txtApellidoUsuario.Text = U.Apellido;
                        txtCorreoUsuario.Text = U.Correo;
                        txtTelefonoUsuario.Text = U.Telefono;
                        cbArea.Text = U.Area;
                        cbCategoria.Text = U.Categoria;
                        txtUsuarioUsuario.Text = U.User;
                        txtContraseñaUsuario.Text = U.Contraseña;


                    }
                }
            }
        }

        private void BtnAgregarUsaurio_Click(object sender, EventArgs e)
        {
            if (Is_validate_agregar_usuario())
            {
                ErrorAgregarUsuario.Clear();

                if (ID == null)
                {
                    Usuario U = new Usuario
                    {
                        ID_Usuario = Guid.NewGuid().ToString(),
                        Nombre = txtNombreUsuario.Text,
                        Apellido = txtApellidoUsuario.Text,
                        Correo = txtCorreoUsuario.Text,
                        Area = cbArea.Text,
                        Categoria = cbCategoria.Text,
                        Telefono = txtTelefonoUsuario.Text,
                        User = txtUsuarioUsuario.Text,
                        Contraseña = txtContraseñaUsuario.Text
                    };

                    parent.AgregarUsuario(U);

                }
                else
                {
                    Usuario U = new Usuario
                    {
                        ID_Usuario = ID,
                        Nombre = txtNombreUsuario.Text,
                        Apellido = txtApellidoUsuario.Text,
                        Correo = txtCorreoUsuario.Text,
                        Area = cbArea.Text,
                        Categoria = cbCategoria.Text,
                        Telefono = txtTelefonoUsuario.Text,
                        User = txtUsuarioUsuario.Text,
                        Contraseña = txtContraseñaUsuario.Text
                    };

                    parent.EditarUsuario(U);
                }
                this.Close();
            }
        }

        private bool Is_validate_agregar_usuario()
        {
            bool no_error = true;

            if (txtNombreUsuario.Text == string.Empty)
            {
                ErrorAgregarUsuario.SetError(txtNombreUsuario, "Ingrese el Titulo");
                no_error = false;
            }

            if (txtApellidoUsuario.Text == string.Empty)
            {

                ErrorAgregarUsuario.SetError(txtApellidoUsuario, "Ingrese la Descripcion");
                no_error = false;
            }

            if (cbArea.Text == string.Empty)
            {
                ErrorAgregarUsuario.SetError(cbArea, "Ingrese el Area");
                no_error = false;
            }

            if (cbCategoria.Text == string.Empty)
            {
                ErrorAgregarUsuario.SetError(cbCategoria, "Ingrese el Area");
                no_error = false;
            }

            if (txtUsuarioUsuario.Text == string.Empty)
            {
                ErrorAgregarUsuario.SetError(txtUsuarioUsuario, "Ingrese el Area");
                no_error = false;
            }

            if (txtContraseñaUsuario.Text == string.Empty)
            {
                ErrorAgregarUsuario.SetError(txtContraseñaUsuario, "Ingrese el Area");
                no_error = false;
            }

            if (txtCorreoUsuario.Text == string.Empty)
            {
                ErrorAgregarUsuario.SetError(txtCorreoUsuario, "ingrese el correo");
                no_error = false;
            }
            else
            {
                if(Email_bien_escrito(txtCorreoUsuario.Text) == false)
                {
                    ErrorAgregarUsuario.SetError(txtCorreoUsuario, "El correo no es valido");
                    no_error = false;
                }   
            }

            if (txtTelefonoUsuario.Text == string.Empty)
            {
                ErrorAgregarUsuario.SetError(txtTelefonoUsuario, "Ingrese el Telefono");
                no_error = false;
            }
            return no_error;
         }

        private bool Email_bien_escrito(string email)
        {
           
            string expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, string.Empty).Length == 0) {    return true; }
                else { return false; }
            }
            else
            {
                return false;
            }
        }

        private void TxtTelefonoUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Si no es número Y NO ES
            //la tecla borrar
            if (!Char.IsNumber(e.KeyChar) &&
                e.KeyChar != Convert.ToChar(Keys.Back))
            {
                e.Handled = true;
            }
        }
    }
}
