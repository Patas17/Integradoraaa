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

namespace ProyectoIntegrador1
{
    public partial class Favoritos : Form
    {
        public Favoritos()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Seguimiento ventanaSeg = new Seguimiento();
            ventanaSeg.Show();
            this.Hide();
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Favoritos_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Conocer ventanaconoce = new Conocer();
            ventanaconoce.Show();
            this.Hide();

        }
    }
}
