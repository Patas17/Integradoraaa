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
    public partial class Conocer : Form
    {
        private int idPlanta;
        public Conocer(int id)
        {
            InitializeComponent();
            idPlanta = id;
            CargarDetallesPlanta();
        }
        private void CargarDetallesPlanta()
        {
            using (coneccionMySQL conn = new coneccionMySQL())
            {
                var cmd = conn.GetConnection().CreateCommand();
                cmd.CommandText = @"
				SELECT 
					p.Nombre_Plantas, p.Descripcion_Planta, p.tamaño, 
					c.Especie, c.Genero, c.Familia, c.Orden_Cientifico, c.Clase, c.Division,
					l.Lugar_Adecuado,
					p.imagenes
				FROM plantas p
				JOIN clasificacion c ON p.id_Clasificacion = c.id_Clasificacion
				JOIN lugar l ON p.id_Lugar = l.idLugar
				WHERE p.idPlantas = @id";
                cmd.Parameters.AddWithValue("@id", idPlanta);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        lblNombre.Text = reader.GetString("Nombre_Plantas");
                        txtDescripcion.Text = reader.GetString("Descripcion_Planta");
                        txtTamaño.Text = reader.GetString("tamaño");

                        txtEspecie.Text = reader.GetString("Especie");
                        txtGenero.Text = reader.GetString("Genero");
                        txtFamilia.Text = reader.GetString("Familia");
                        txtOrden.Text = reader.GetString("Orden_Cientifico");
                        txtClase.Text = reader.GetString("Clase");
                        txtDivision.Text = reader.GetString("Division");
                        txtLugarApropiado.Text = reader.GetString("Lugar_Adecuado");

                        byte[] img = (byte[])reader["imagenes"];
                        using (MemoryStream ms = new MemoryStream(img))
                        {
                            pictureBox.Image = Image.FromStream(ms);
                        }
                    }
                }

                // Cuidados
                var cmdCuidados = conn.GetConnection().CreateCommand();
                cmdCuidados.CommandText = @"
				SELECT tc.Tipo_Cuidado, cp.descripcion
				FROM cuidados_planta cp
				JOIN planta_cuidados pc ON cp.idCuidados_Planta = pc.id_Cuidados_Planta
				JOIN tipo_cuidado tc ON cp.id_Tipo_Cuidado = tc.idTipo_Cuidado
				WHERE pc.idPlanta = @id";
                cmdCuidados.Parameters.AddWithValue("@id", idPlanta);

                using (var reader = cmdCuidados.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string tipo = reader.GetString("Tipo_Cuidado");
                        string desc = reader.GetString("descripcion");

                        switch (tipo)
                        {
                            case "Luz": txtLuz.Text = desc; break;
                            case "Riego": txtRiego.Text = desc; break;
                            case "Temperatura": txtTemperatura.Text = desc; break;
                            case "Suelo": txtSuelo.Text = desc; break;
                            case "Fertilizante": txtFertilizante.Text = desc; break;
                            case "Lugar apropiado": txtLugarApropiado.Text = desc; break;
                        }
                    }
                }
            }
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


        private void MenuUsuarios_Click(object sender, EventArgs e)
        {
            Usuario ventanaUsua = new Usuario();
            ventanaUsua.Show();
            this.Hide();
        }

        private void Conocer_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Clase_Click(object sender, EventArgs e)
        {

        }

        private void txtTemperatura_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGenero_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Catalogo ventanacatalogo = new Catalogo();
            ventanacatalogo.Show();
            this.Hide();
        }
    }
}
