using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Flower_Grow;
using ProyectoIntegrador1;

namespace ProyectoIntegrador1
{
    public partial class Favoritos : Form
    {
        public Favoritos()
        {
            InitializeComponent();

            // Configuración del FlowLayoutPanel
            flwFavoritos.AutoScroll = true;
            flwFavoritos.FlowDirection = FlowDirection.TopDown;
            flwFavoritos.WrapContents = false;
            flwFavoritos.Dock = DockStyle.Fill; // Ocupa todo el espacio disponible
        }

        private void Favoritos_Load(object sender, EventArgs e)
        {
            MostrarFavoritos();
        }
        private void MostrarFavoritos()
        {
            flwFavoritos.Controls.Clear();

            List<Planta> favoritos = FavoritosManager.ObtenerFavoritos();

            foreach (var planta in favoritos)
            {
                Panel panel = new Panel
                {
                    Size = new Size(750, 160),
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = Color.FromArgb(249, 251, 247),
                    Margin = new Padding(10)
                };

                PictureBox picImagen = new PictureBox
                {
                    Size = new Size(120, 120),
                    Location = new Point(15, 20),
                    SizeMode = PictureBoxSizeMode.Zoom
                };

                if (planta.Imagen != null)
                {
                    using (var ms = new System.IO.MemoryStream(planta.Imagen))
                    {
                        picImagen.Image = Image.FromStream(ms);
                    }
                }

                Label lblNombre = new Label
                {
                    Text = planta.Nombre,
                    Font = new Font("Segoe UI Emoji", 14, FontStyle.Bold),
                    ForeColor = Color.FromArgb(59, 119, 80),
                    Location = new Point(150, 15),
                    AutoSize = true
                };

                Label lblDescripcion = new Label
                {
                    Text = planta.Descripcion,
                    Font = new Font("Segoe UI", 11),
                    Location = new Point(150, 50),
                    Size = new Size(550, 40)
                };

                int btnWidth = 160;
                int btnHeight = 35;
                int btnSpacing = 15;
                int btnStartX = 150;
                int btnY = 100;

                Button btnEliminar = new Button
                {
                    Text = "Quitar de favoritos",
                    Font = new Font("Segoe UI Emoji", 10, FontStyle.Bold),
                    BackColor = Color.FromArgb(192, 57, 43),
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Size = new Size(btnWidth, btnHeight),
                    Location = new Point(btnStartX, btnY)
                };

                btnEliminar.Click += (s, ev) =>
                {
                    DialogResult result = MessageBox.Show(
                        "¿Seguro que quieres quitar esta planta de favoritos?",
                        "Confirmar eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        FavoritosManager.EliminarFavorito(planta.Id);
                        MostrarFavoritos();
                    }
                };

                Button btnConocer = new Button
                {
                    Text = "Conocer",
                    Font = new Font("Segoe UI Emoji", 10, FontStyle.Bold),
                    BackColor = Color.FromArgb(59, 119, 80),
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Size = new Size(btnWidth, btnHeight),
                    Location = new Point(btnStartX + btnWidth + btnSpacing, btnY)
                };

                btnConocer.Click += (s, ev) =>
                {
                    Conocer detalle = new Conocer(planta.Id);
                    detalle.Show();
                    this.Hide();
                };

                Button btnSeguimiento = new Button
                {
                    Text = "Iniciar seguimiento",
                    Font = new Font("Segoe UI Emoji", 10, FontStyle.Bold),
                    BackColor = Color.FromArgb(59, 119, 80),
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Size = new Size(btnWidth, btnHeight),
                    Location = new Point(btnStartX + (btnWidth + btnSpacing) * 2, btnY)
                };

                btnSeguimiento.Click += (s, ev) =>
                {
                    SeguimientoForm seguimiento = new SeguimientoForm(planta.Id, SesionActual.UsuarioId);
                    seguimiento.Show();
                    this.Hide();
                };

                panel.Controls.Add(picImagen);
                panel.Controls.Add(lblNombre);
                panel.Controls.Add(lblDescripcion);
                panel.Controls.Add(btnEliminar);
                panel.Controls.Add(btnConocer);
                panel.Controls.Add(btnSeguimiento);

                flwFavoritos.Controls.Add(panel);
            }

            flwFavoritos.VerticalScroll.Value = 0;
            flwFavoritos.PerformLayout();
            flwFavoritos.Refresh();
        }

        // Navegación

        private void MenuCatalogo_Click(object sender, EventArgs e)
        {
            new Catalogo().Show();
            this.Hide();
        }

        private void MenuAgregarPlanta_Click(object sender, EventArgs e)
        {
            new Agregar_Planta().Show();
            this.Hide();
        }

        private void MenuFavoritos_Click(object sender, EventArgs e)
        {
            // Ya estás aquí
        }

        private void MenuUsuarios_Click(object sender, EventArgs e)
        {
            new Usuario().Show();
            this.Hide();
        }

        private void flwFavoritos_Paint(object sender, PaintEventArgs e)
        {
            // No se usa
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
