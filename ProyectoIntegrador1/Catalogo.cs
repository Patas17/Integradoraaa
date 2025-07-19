using System.Drawing.Drawing2D;
using Flower_Grow;
using MySql.Data.MySqlClient;

namespace ProyectoIntegrador1
{
    public partial class Catalogo : Form
    {
        private coneccionMySQL mConexion;
        public Catalogo()
        {
            InitializeComponent();
            mConexion = new coneccionMySQL();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        private void contextMenuStrip3_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void iniciarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void favoritosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
        //Menú de opciones

        //Botones de la interfaz


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

        /*private void MenuSeguimiento_Click(object sender, EventArgs e)
		{
			SeguimientoForm ventanaSegui = new SeguimientoForm();
			ventanaSegui.Show();
			this.Hide();
		}*/

        private void MenuUsuarios_Click(object sender, EventArgs e)
        {
            Usuario ventanaUsua = new Usuario();
            ventanaUsua.Show();
            this.Hide();
        }

        private void MenuCatalogo_DoubleClick(object sender, EventArgs e)
        {

        }


        private void btnIrPltaInte_Click(object sender, EventArgs e)
        {
            Plantas_Interiores irPltaInte = new Plantas_Interiores();
            irPltaInte.Show();
            this.Hide();
        }

        private void btnPltaExte_Click(object sender, EventArgs e)
        {
            Plantas_Exteriores irPltaExte = new Plantas_Exteriores();
            irPltaExte.Show();
            this.Hide();
        }

        private void lblIntro_Click(object sender, EventArgs e)
        {

        }

        private void panelPltaInto_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
