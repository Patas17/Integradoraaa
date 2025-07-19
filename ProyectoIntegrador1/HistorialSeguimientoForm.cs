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

namespace ProyectoIntegrador1
{
    public partial class HistorialSeguimientoForm : Form
    {
        private int idPlanta;
        private int idUsuario;
        private coneccionMySQL conn = new coneccionMySQL();

        public HistorialSeguimientoForm(int idPlanta, int idUsuario)
        {
            InitializeComponent();
            this.idPlanta = idPlanta;
            this.idUsuario = idUsuario;
            CargarHistorial();
        }

        private void CargarHistorial()
        {
            try
            {
                string query = @"
                SELECT r.fecha_Registro, r.Ingreso_Agua, r.Ingreso_Fertilizante, 
                       r.Temperatura_Marcada, r.Ubicacion
                FROM seguimiento s
                JOIN registro r ON s.idSeguimiento = r.id_Seguimiento
                WHERE s.id_Planta = @idPlanta AND s.id_usuario = @idUsuario
                ORDER BY r.fecha_Registro DESC";

                using (MySqlCommand cmd = conn.GetConnection().CreateCommand())
                {
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@idPlanta", idPlanta);
                    cmd.Parameters.AddWithValue("@idUsuario", idUsuario);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Panel panel = new Panel
                            {
                                Width = 600,
                                Height = 130,
                                BackColor = Color.LightGreen,
                                Margin = new Padding(10),
                                BorderStyle = BorderStyle.FixedSingle
                            };

                            Label lblFecha = new Label
                            {
                                Text = $"Fecha: {Convert.ToDateTime(reader["fecha_Registro"]).ToShortDateString()}",
                                Font = new Font("Arial", 10, FontStyle.Bold),
                                Location = new Point(10, 10),
                                AutoSize = true
                            };

                            Label lblRiego = new Label
                            {
                                Text = $"Riego: {reader["Ingreso_Agua"]}",
                                Location = new Point(10, 40),
                                AutoSize = true
                            };

                            Label lblFertilizante = new Label
                            {
                                Text = $"Fertilizante: {reader["Ingreso_Fertilizante"]}",
                                Location = new Point(10, 60),
                                AutoSize = true
                            };

                            Label lblTemperatura = new Label
                            {
                                Text = $"Temperatura: {reader["Temperatura_Marcada"]}",
                                Location = new Point(200, 40),
                                AutoSize = true
                            };

                            Label lblUbicacion = new Label
                            {
                                Text = $"Ubicación: {reader["Ubicacion"]}",
                                Location = new Point(200, 60),
                                AutoSize = true
                            };

                            panel.Controls.Add(lblFecha);
                            panel.Controls.Add(lblRiego);
                            panel.Controls.Add(lblFertilizante);
                            panel.Controls.Add(lblTemperatura);
                            panel.Controls.Add(lblUbicacion);

                            flowRegistros.Controls.Add(panel);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar historial: " + ex.Message);
            }
        }

        private void flowRegistros_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
