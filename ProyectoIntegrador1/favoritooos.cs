using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntegrador1
{
    public partial class favoritooos : Form
    {
        private List<Planta> favoritos;

        public favoritooos(List<Planta> favoritos)
        {
            InitializeComponent();
            this.favoritos = favoritos;
            MostrarFavoritos();
        }

        private void MostrarFavoritos()
        {
            // Limpiar el panel antes de mostrar las plantas
            flowLayoutPanel1.Controls.Clear();

            foreach (var planta in favoritos)
            {
                Panel panel = new Panel();
                panel.Width = 150;
                panel.Height = 200;
                panel.Margin = new Padding(10);

                // Imagen de la planta
                PictureBox pictureBox = new PictureBox();
               // pictureBox.Image = Image.FromFile(planta.ImagenRuta);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Width = 130;
                pictureBox.Height = 100;
                pictureBox.Top = 10;
                pictureBox.Left = 10;

                // Nombre de la planta
                Label label = new Label();
                label.Text = planta.Nombre;
                label.Top = 120;
                label.Left = 10;
                label.Width = 130;

                // Añadir controles al panel
                panel.Controls.Add(pictureBox);
                panel.Controls.Add(label);

                // Añadir el panel al flowLayoutPanel
                flowLayoutPanel1.Controls.Add(panel);
            }
        }

        // Método público para actualizar favoritos desde otro formulario
        public void ActualizarFavoritos()
        {
            MostrarFavoritos();
        }

        // Puedes ignorar este evento si no lo usas
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void favoritooos_Load(object sender, EventArgs e)
        {

        }
    }
}
