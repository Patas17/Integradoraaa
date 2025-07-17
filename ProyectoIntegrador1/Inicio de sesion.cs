using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProyectoIntegrador1
{
    public partial class Inicio_de_sesion : Form
    {
        public Inicio_de_sesion()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        //Botones para cambiar entre ventanas
        private void btnLogin_Click(object sender, EventArgs e)
        {
            tbCuenta.SelectedIndex = 1;
        }

        private void btnSinCuenta_Click(object sender, EventArgs e)
        {
            tbCuenta.SelectedIndex = 0;
        }

        //Boton de Inicio de sesion
        //Boton de Registro
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nombre = txtName.Text;
            string correo = txtEmail.Text;
            string contraseña = seguridad.EncriptarSHA256(txtPass.Text);
            coneccionMySQL con = new coneccionMySQL();
            con.GetConnection();
            try
            {
                string Consulta = "INSERT INTO Usuarios (nombre, correo, contraseña) VALUES (@Nombre, @Correo, @Contraseña)";
                MySqlCommand cmd = new MySqlCommand(Consulta, con.GetConnection());
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Correo", correo);
                cmd.Parameters.AddWithValue("@Contraseña", contraseña);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuario registrado correctamente.");
                txtName.Clear();
                txtEmail.Clear();
                txtPass.Clear();


            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }



        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string correo = txtCorreo.Text.Trim();
            string contraseñaH = seguridad.EncriptarSHA256(txtContra.Text.Trim());

            using (coneccionMySQL con = new coneccionMySQL())
            {
                string sql = "SELECT idusuarios, nombre, correo, contraseña FROM usuarios " +
                             "WHERE correo=@Correo AND contraseña=@Contraseña";
                MySqlCommand cmd = new MySqlCommand(sql, con.GetConnection());
                cmd.Parameters.AddWithValue("@Correo", correo);
                cmd.Parameters.AddWithValue("@Contraseña", contraseñaH);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // ───►  Guarda todo en Sesion
                        Sesion.IdUsuario = Convert.ToInt32(reader["idusuarios"]);
                        Sesion.Nombre = reader["nombre"].ToString();
                        Sesion.Correo = reader["correo"].ToString();
                        Sesion.Contraseña = reader["contraseña"].ToString();

                        MessageBox.Show($"¡Bienvenido {Sesion.Nombre}!");

                        Catalogo cat = new Catalogo();
                        cat.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Correo o contraseña incorrectos.");
                    }
                }
            }
        }


        private void Iniciar_Sesion_Click(object sender, EventArgs e)
        {

        }

        private void lblRegistro_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tbCuenta.SelectedIndex = 1;
        }

        private void lbl_InicioSesion_Click(object sender, EventArgs e)
        {

        }

        private void txtContra_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tbCuenta.SelectedIndex = 0;
        }

        private void Registrarse_Click(object sender, EventArgs e)
        {

        }
    }
}
