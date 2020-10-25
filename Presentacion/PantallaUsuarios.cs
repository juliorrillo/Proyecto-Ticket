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
    public partial class PantallaUsuarios : Form
    {
        List<Usuario> ListadoUsuarios = new List<Usuario>();

        public PantallaUsuarios()
        {
            InitializeComponent();
        }

        public void AgregarUsuario(Usuario U)
        {

            ListadoUsuarios.Add(U);

            CargarListViewU();
        }

        public void EditarUsuario(Usuario U)
        {

            lvUsuarios.SelectedItems[0].Remove();
            BorrarDeLaLista(U.ID_Usuario);
            ListadoUsuarios.Add(U);


            CargarListViewU();
        }

        private void PantallaUsuarios_Load(object sender, EventArgs e)
        {
            
            Stream flujo = File.OpenRead("Usuarios.bin");
            BinaryFormatter deserializer = new BinaryFormatter();
            ListadoUsuarios = (List<Usuario>)deserializer.Deserialize(flujo);
            flujo.Close();

            CargarListViewU();
        }
        private void BntAgregar_Click(object sender, EventArgs e)
        {
            PantallaUsuarioAgregar form = new PantallaUsuarioAgregar(this);
            form.Show();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvUsuarios.SelectedItems[0] != null) { editarU(); }

            }
            catch (Exception)
            {
                MessageBox.Show("No se ha seleccionado un elemento de la lista ", "Advertencia");
            }
            
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvUsuarios.SelectedItems[0] != null) { borrarU(); }

            }
            catch (Exception)
            {
                MessageBox.Show("No se ha seleccionado un elemento de la lista ", "Advertencia");
            }
         }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Stream flujo2 = File.Create("Usuarios.bin");
            BinaryFormatter serializer = new BinaryFormatter();
            serializer.Serialize(flujo2, ListadoUsuarios);
            flujo2.Close();
            PantallaPrincipal.ActivoFormUser = 0;
            PantallaPrincipal.FormularioActual = 0;

            this.Close();
        }

        public void CargarListViewU()
        {
            lvUsuarios.Items.Clear();

            foreach (Usuario U in ListadoUsuarios)
            {
                ListViewItem item = new ListViewItem();
                item.Checked = true;
                item.Text = U.ID_Usuario.ToString();
                item.SubItems.Add(U.Nombre);
                item.SubItems.Add(U.Apellido);
                item.SubItems.Add(U.Correo);
                item.SubItems.Add(U.Telefono);
                item.SubItems.Add(U.Area);
                item.SubItems.Add(U.Categoria);
                item.SubItems.Add(U.User);
                item.SubItems.Add(U.Contraseña);

                lvUsuarios.Items.Add(item);
            }
        }

        public void BorrarDeLaLista(string X)
        {
            for (int i = 0; i < ListadoUsuarios.Count; i++) // lo borro de la lista de colecciones
            {
                if (ListadoUsuarios[i].ID_Usuario.ToString() == X)
                {
                    ListadoUsuarios.Remove(ListadoUsuarios[i]);
                }
            }
        }

        private void LvUsuarios_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            editarU();
        }

        private void editarU()
        {
                PantallaUsuarioAgregar formAgregar = new PantallaUsuarioAgregar(this);

                string SeleccionU = lvUsuarios.SelectedItems[0].Text; // tomo el id del elemento seleccionado y lo guardo en selleccion

                formAgregar.lUsuarios = ListadoUsuarios;
                formAgregar.parent = this;
                formAgregar.ID = SeleccionU.ToString();
                formAgregar.Show();
        }

        private void borrarU()
        {
            DialogResult result = MessageBox.Show("Seguro que desea BORRAR este usuario ", "Borrar Usuario", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                string SeleccionU = lvUsuarios.SelectedItems[0].Text; // tomo el id del elemento seleccionado y lo guardo en selleccion

                lvUsuarios.SelectedItems[0].Remove(); // lo borro del listview
                BorrarDeLaLista(SeleccionU);
            }
        }

        private void PantallaUsuarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            Stream flujo2 = File.Create("Usuarios.bin");
            BinaryFormatter serializer = new BinaryFormatter();
            serializer.Serialize(flujo2, ListadoUsuarios);
            flujo2.Close();

            
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}