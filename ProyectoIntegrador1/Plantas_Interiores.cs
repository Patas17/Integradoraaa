// ... (Usings y espacio de nombres)
using Flower_Grow;
using MySql.Data.MySqlClient;

namespace ProyectoIntegrador1
{
    public partial class Plantas_Interiores : Form
    {
        public Plantas_Interiores()
        {
            InitializeComponent();
        }

        private FlowLayoutPanel panelContenedor;

        private void Plantas_Interiores_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(237, 243, 236); // Cambia si quieres otro color

            panelContenedor = new FlowLayoutPanel
            {
                Size = new Size(900, this.ClientSize.Height),

                // Centrado con espacio para el scroll
                Location = new Point((this.ClientSize.Width - 900) / 2 - 30, 0),

                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
                AutoScroll = true,

                Padding = new Padding(10, 30, 10, 10), // Deja espacio arriba
                BackColor = Color.Transparent
            };

            // Cargar contenido (plantas)
            CargarPlantas(panelContenedor);

            // Agregar el panel al formulario
            this.Controls.Add(panelContenedor);

            // Asegurar que se mantenga centrado si cambia el tamaño del formulario
            this.Resize += Plantas_Interiores_Resize;
        }

        private void Plantas_Interiores_Resize(object sender, EventArgs e)
        {
            panelContenedor.Size = new Size(this.ClientSize.Width - 60, this.ClientSize.Height);
        }

        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }

        private void CargarPlantas(FlowLayoutPanel panelContenedor)
        {
            coneccionMySQL conn = new coneccionMySQL();
            try
            {
                MySqlCommand cmd1 = conn.GetConnection().CreateCommand();
                cmd1.CommandText = "SELECT idPlantas, Nombre_Plantas, Descripcion_Planta, imagenes FROM plantas WHERE id_Lugar=2";
                using (MySqlDataReader reader = cmd1.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int idPlanta = reader.GetInt32("idPlantas");
                        string nombre = reader.GetString("Nombre_Plantas");
                        string descripcion = reader.GetString("Descripcion_Planta");
                        byte[] imagenData = (byte[])reader["imagenes"];
                        Image imagen = ByteArrayToImage(imagenData);
                        Panel panel = CrearPanelPlanta(idPlanta, nombre, descripcion, imagen);
                        panelContenedor.Controls.Add(panel);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private Panel CrearPanelPlanta(int idPlantas, string nombre, string descripcion, Image imagen)
        {
            Panel panel = new Panel
            {
                Size = new Size(850, 450), // Altura más grande
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.FromArgb(247, 247, 247),
                Margin = new Padding(10)
            };

            // Baja todo el contenido 30 píxeles para dejar espacio arriba
            int espacioArriba = 30;

            Label lblNombre = new Label
            {
                Text = nombre,
                ForeColor = Color.FromArgb(35, 77, 50),
                Font = new Font("Segoe UI Emoji", 20, FontStyle.Bold),
                Location = new Point(20, 15 + espacioArriba),
                AutoSize = true
            };

            PictureBox pic = new PictureBox
            {
                Image = imagen,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Size = new Size(266, 220),
                Location = new Point(25, 60 + espacioArriba)
            };

            TextBox txtDesc = new TextBox
            {
                Multiline = true,
                Text = descripcion,
                Font = new Font("Segoe UI Emoji", 14, FontStyle.Bold),
                Size = new Size(504, 220),
                Location = new Point(316, 60 + espacioArriba),
                ReadOnly = true
            };

            int anchoBoton = 230;
            int espacioEntreBotones = 20;
            int totalAnchoBotones = (anchoBoton * 3) + (espacioEntreBotones * 2);
            int inicioX = (panel.Width - totalAnchoBotones) / 2;
            int posicionYBotones = 320 + espacioArriba; // Los botones también bajan

            Button btnConocer = new Button
            {
                Text = "Conocer",
                Font = new Font("Segoe UI Emoji", 16, FontStyle.Bold),
                BackColor = Color.FromArgb(59, 119, 80),
                ForeColor = Color.White,
                Size = new Size(anchoBoton, 50),
                Location = new Point(inicioX, posicionYBotones),
                FlatStyle = FlatStyle.Flat
            };
            btnConocer.Click += (sender, e) =>
            {
                Conocer detalle = new Conocer(idPlantas);
                detalle.Show();
                this.Hide();
            };

            Button btnFavoritos = new Button
            {
                Text = "Agregar a favoritos",
                Font = new Font("Segoe UI Emoji", 16, FontStyle.Bold),
                BackColor = Color.FromArgb(59, 119, 80),
                ForeColor = Color.White,
                Size = new Size(anchoBoton, 50),
                Location = new Point(inicioX + anchoBoton + espacioEntreBotones, posicionYBotones),
                FlatStyle = FlatStyle.Flat
            };
            btnFavoritos.Click += (sender, e) =>
            {
                try
                {
                    coneccionMySQL connFav = new coneccionMySQL();
                    MySqlCommand checkCmd = connFav.GetConnection().CreateCommand();
                    checkCmd.CommandText = "SELECT COUNT(*) FROM favoritos WHERE id_usuario = @id_usuario AND id_Planta = @id_Planta";
                    checkCmd.Parameters.AddWithValue("@id_usuario", SesionActual.UsuarioId);
                    checkCmd.Parameters.AddWithValue("@id_Planta", idPlantas);

                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (count > 0)
                    {
                        MessageBox.Show("Esta planta ya está en tus favoritos.");
                    }
                    else
                    {
                        MySqlCommand insertCmd = connFav.GetConnection().CreateCommand();
                        insertCmd.CommandText = "INSERT INTO favoritos (id_usuario, id_Planta) VALUES (@id_usuario, @id_Planta)";
                        insertCmd.Parameters.AddWithValue("@id_usuario", SesionActual.UsuarioId);
                        insertCmd.Parameters.AddWithValue("@id_Planta", idPlantas);
                        insertCmd.ExecuteNonQuery();

                        MessageBox.Show("Planta agregada a favoritos");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar a favoritos: " + ex.Message);
                }
            };

            Button btnIniciar = new Button
            {
                Text = "Iniciar seguimiento",
                Font = new Font("Segoe UI Emoji", 16, FontStyle.Bold),
                BackColor = Color.FromArgb(59, 119, 80),
                ForeColor = Color.White,
                Size = new Size(anchoBoton, 50),
                Location = new Point(inicioX + (anchoBoton + espacioEntreBotones) * 2, posicionYBotones),
                FlatStyle = FlatStyle.Flat
            };
            btnIniciar.Click += (sender, e) =>
            {
                SeguimientoForm seguimiento = new SeguimientoForm(idPlantas, 1);
                seguimiento.Show();
                this.Hide();
            };

            panel.Controls.Add(lblNombre);
            panel.Controls.Add(pic);
            panel.Controls.Add(txtDesc);
            panel.Controls.Add(btnConocer);
            panel.Controls.Add(btnFavoritos);
            panel.Controls.Add(btnIniciar);

            return panel;
        }




        private void MenuCatalogo_Click(object sender, EventArgs e)
        {
            Catalogo irCata = new Catalogo();
            irCata.Show();
            this.Hide();
        }

        private void MenuAgregarPlanta_Click(object sender, EventArgs e)
        {
            Agregar_Planta irAgrePlan = new Agregar_Planta();
            irAgrePlan.Show();
            this.Hide();
        }

        private void MenuFavoritos_Click(object sender, EventArgs e)
        {
            Favoritos irFav = new Favoritos();
            irFav.Show();
            this.Hide();
        }

        private void MenuUsuarios_Click(object sender, EventArgs e)
        {
            Usuario irUsuario = new Usuario();
            irUsuario.Show();
            this.Hide();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e) { }
    }
}
