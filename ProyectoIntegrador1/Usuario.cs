using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flower_Grow;
using MySql.Data.MySqlClient;

namespace ProyectoIntegrador1
{
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
        }
        //Menú
        private void MenuCatalogo_Click(object sender, EventArgs e)
        {
            Catalogo ventanaCata = new Catalogo();
            ventanaCata.Show();
            this.Hide();
        }

        private void MenuAgregarPlanta_Click(object sender, EventArgs e)
        {
            Agregar_Planta ventanaAgreg = new Agregar_Planta();
            ventanaAgreg.Show();
            this.Hide();
        }

        private void MenuFavoritos_Click(object sender, EventArgs e)
        {
            Favoritos ventanaFav = new Favoritos();
            ventanaFav.Show();
            this.Hide();
        }

        private void MenuSeguimiento_Click(object sender, EventArgs e)
        {
            Seguimiento ventanaSegui = new Seguimiento();
            ventanaSegui.Show();
            this.Hide();
        }

        private void MenuUsuarios_Click(object sender, EventArgs e)
        {
            Usuario ventanaUsua = new Usuario();
            ventanaUsua.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string actualHash = seguridad.EncriptarSHA256(txtActual.Text.Trim());
            string nuevaHash = seguridad.EncriptarSHA256(txtNueva.Text.Trim());

            if (actualHash != Sesion.Contraseña)
            {
                MessageBox.Show("La contraseña actual no es correcta.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNueva.Text))
            {
                MessageBox.Show("La nueva contraseña no puede estar vacía.");
                return;
            }

            using (coneccionMySQL con = new coneccionMySQL())
            {
                string sql = "UPDATE Usuarios SET contraseña=@Nueva WHERE id=@Id";   // usa la misma columna
                MySqlCommand cmd = new MySqlCommand(sql, con.GetConnection());
                cmd.Parameters.AddWithValue("@Nueva", nuevaHash);
                cmd.Parameters.AddWithValue("@Id", Sesion.IdUsuario);

                int filas = cmd.ExecuteNonQuery();
                if (filas > 0)
                {
                    MessageBox.Show("¡Contraseña actualizada!");
                    Sesion.Contraseña = nuevaHash;          // refresca la sesión
                    txtActual.Clear();
                    txtNueva.Clear();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar.");
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Usuario_Load(object sender, EventArgs e)
        {
            lblNombre.Text = "Nombre: " + Sesion.Nombre;
            lblCorreo.Text = "Correo: " + Sesion.Correo;
        }

        private void txtActual_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
