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
    public partial class SeguimientoForm : Form
    {
        private int idPlanta;
        private int idUsuario; // <- si manejas login
        private int idSeguimiento;
        private coneccionMySQL conn = new coneccionMySQL();

        public SeguimientoForm(int idPlanta, int idUsuario)
        {
            InitializeComponent();
            this.idPlanta = idPlanta;
            this.idUsuario = idUsuario;

            ObtenerOSRegistrarSeguimiento();
            CargarDatosPlanta();
        }

        private void ObtenerOSRegistrarSeguimiento()
        {
            try
            {
                string queryBuscar = @"SELECT idSeguimiento, Fecha_Inicio FROM seguimiento 
                                   WHERE id_Planta = @idPlanta AND id_usuario = @idUsuario";

                using (MySqlCommand cmd = conn.GetConnection().CreateCommand())
                {
                    cmd.CommandText = queryBuscar;
                    cmd.Parameters.AddWithValue("@idPlanta", idPlanta);
                    cmd.Parameters.AddWithValue("@idUsuario", idUsuario);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            idSeguimiento = reader.GetInt32("idSeguimiento");
                            txtFechaInicio.Text = Convert.ToDateTime(reader["Fecha_Inicio"]).ToShortDateString();
                        }
                    }
                }

                if (idSeguimiento == 0)
                {
                    string insertSeguimiento = @"INSERT INTO seguimiento (id_Planta, Fecha_Inicio, id_usuario)
                                             VALUES (@idPlanta, @fecha, @idUsuario)";
                    using (MySqlCommand cmd = conn.GetConnection().CreateCommand())
                    {
                        cmd.CommandText = insertSeguimiento;
                        cmd.Parameters.AddWithValue("@idPlanta", idPlanta);
                        cmd.Parameters.AddWithValue("@fecha", DateTime.Now);
                        cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                        cmd.ExecuteNonQuery();
                        idSeguimiento = (int)cmd.LastInsertedId;
                        txtFechaInicio.Text = DateTime.Now.ToShortDateString();
                    }
                }

                txtFechaActual.Text = DateTime.Now.ToShortDateString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en seguimiento: " + ex.Message);
            }
        }

        private void CargarDatosPlanta()
        {
            try
            {
                string query = @"
	SELECT 
        p.Nombre_Plantas, 
        p.Descripcion_Planta, 
        p.imagenes,
        -- Luz
        (SELECT cp.descripcion 
         FROM planta_cuidados pc 
         JOIN cuidados_planta cp ON cp.idCuidados_Planta = pc.id_Cuidados_Planta 
         WHERE pc.idPlanta = p.idPlantas AND cp.id_Tipo_Cuidado = 1 
         LIMIT 1) AS Luz,

        -- Riego
        (SELECT cp.descripcion 
         FROM planta_cuidados pc 
         JOIN cuidados_planta cp ON cp.idCuidados_Planta = pc.id_Cuidados_Planta 
         WHERE pc.idPlanta = p.idPlantas AND cp.id_Tipo_Cuidado = 2 
         LIMIT 1) AS Riego,

        -- Temperatura
        (SELECT cp.descripcion 
         FROM planta_cuidados pc 
         JOIN cuidados_planta cp ON cp.idCuidados_Planta = pc.id_Cuidados_Planta 
         WHERE pc.idPlanta = p.idPlantas AND cp.id_Tipo_Cuidado = 3 
         LIMIT 1) AS Temperatura,

        -- Suelo
        (SELECT cp.descripcion 
         FROM planta_cuidados pc 
         JOIN cuidados_planta cp ON cp.idCuidados_Planta = pc.id_Cuidados_Planta 
         WHERE pc.idPlanta = p.idPlantas AND cp.id_Tipo_Cuidado = 4 
         LIMIT 1) AS Suelo,

        -- Fertilizante
        (SELECT cp.descripcion 
         FROM planta_cuidados pc 
         JOIN cuidados_planta cp ON cp.idCuidados_Planta = pc.id_Cuidados_Planta 
         WHERE pc.idPlanta = p.idPlantas AND cp.id_Tipo_Cuidado = 5 
         LIMIT 1) AS Fertilizante,

        -- Lugar
        l.Lugar_Adecuado

    FROM plantas p 
    JOIN lugar l ON p.id_Lugar = l.idLugar
    WHERE p.idPlantas = @id";

                using (MySqlCommand cmd = conn.GetConnection().CreateCommand())
                {
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@id", idPlanta);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lblNombre.Text = reader["Nombre_Plantas"].ToString();
                            txtDescripcion.Text = reader["Descripcion_Planta"].ToString();
                            byte[] imgData = (byte[])reader["imagenes"];
                            picImagen.Image = ByteArrayToImage(imgData);

                            // Recomendaciones
                            txtLuz.Text = reader["Luz"]?.ToString();
                            txtRiego.Text = reader["Riego"]?.ToString();
                            txtTemp.Text = reader["Temperatura"]?.ToString();
                            txtSuelo.Text = reader["Suelo"]?.ToString();
                            txtFertilizante.Text = reader["Fertilizante"]?.ToString();
                            txtLugar.Text = reader["Lugar_Adecuado"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar planta: " + ex.Message);
            }
        }

        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                string insertRegistro = @"INSERT INTO registro (fecha_Registro, id_Seguimiento, Ingreso_Agua, Ingreso_Fertilizante, 
                                       Temperatura_Marcada, Ubicacion)
                                       VALUES (@fecha, @idSeg, @agua, @fertil, @temp, @ubi)";

                using (MySqlCommand cmd = conn.GetConnection().CreateCommand())
                {
                    cmd.CommandText = insertRegistro;
                    cmd.Parameters.AddWithValue("@fecha", DateTime.Now);
                    cmd.Parameters.AddWithValue("@idSeg", idSeguimiento);
                    cmd.Parameters.AddWithValue("@agua", rbRegadoSi.Checked ? "si" : "no");
                    cmd.Parameters.AddWithValue("@fertil", rbFertilSi.Checked ? "si" : "no");
                    cmd.Parameters.AddWithValue("@temp", txtTempMarcada.Text);
                    cmd.Parameters.AddWithValue("@ubi", txtUbicacion.Text);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Registro guardado.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el registro: " + ex.Message);
            }
        }

        private void btnHistorial_Click_1(object sender, EventArgs e)
        {
            HistorialSeguimientoForm historial = new HistorialSeguimientoForm(idPlanta, idUsuario);
            historial.Show();
        }

        //Menu
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

        private void MenuUsuarios_Click(object sender, EventArgs e)
        {
            Usuario ventanaUsua = new Usuario();
            ventanaUsua.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void SeguimientoForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Genero_Click(object sender, EventArgs e)
        {

        }
    }
}
