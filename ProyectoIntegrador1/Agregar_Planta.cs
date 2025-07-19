using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X509.SigI;
using ProyectoIntegrador1;

namespace Flower_Grow
{
	public partial class Agregar_Planta : Form
	{
		Planta planta = new Planta();
		int idPlanta = 0;
		private byte[] imagenBytes;
		public Agregar_Planta()
		{
			InitializeComponent();
		}
		//Botón para limpiar los campos de texto
		private void btn_Borrar_Click(object sender, EventArgs e)
		{
			limpiarCampos();
			
		}

		//Boton para guardar los datos
		private void btn_Guardar_Click(object sender, EventArgs e)
		{

			if (cmbLugar.SelectedItem != null)
			{
				string lugarSelect = cmbLugar.SelectedItem.ToString();
				planta = new Planta(
				txt_Nombre.Text,
				txt_Descripcion.Text,
				txt_Especie.Text,
				txtGenero.Text,
				txt_Familia.Text,
				txt_Orden.Text,
				txt_Clase.Text,
				txt_Division.Text,
				txt_Tamaño.Text,
				txtLuz.Text,
				txtRiego.Text,
				txtTemperatura.Text,
				txtSuelo.Text,
				txt_Fertilizante.Text,
				lugarSelect
				);
				InsertarLugares();
				InsertarTiposCuidados();
				GuardarPlanta(planta);
				limpiarCampos();
			}
			else
			{
				MessageBox.Show("Por favor selecciona un lugar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		// Botón para buscar el nombre de la planta y mostrar los datos en los textbox
		private void btn_Buscar_Click(object sender, EventArgs e)
		{
			mostrarDatosPlanta();
			mostrarCuidadosPlanta();
		}

		//Botón para actualizar los datos de una planta ya existente
		private void btn_Actualizar_Click(object sender, EventArgs e)
		{
			ActulizarDatosPlanta();
			ActualizarClasiPlanta();
			ActualizarDescTipos();
			limpiarCampos();
		}
		//Botón para borrar una planta y sus relaciones.
		private void btn_Eliminar_Click(object sender, EventArgs e)
		{
			BorrarPlanta();
			limpiarCampos();
		}
		//Bótón para cargar una imagen
		private void btnCargarImagen_Click(object sender, EventArgs e)
		{
			CargarImagen();
		}

		// Área de Métodos utilizados

		//Método para seleccionar una imagen 
		private void CargarImagen()
		{
			try
			{
				using (OpenFileDialog ofd = new OpenFileDialog())
				{
					ofd.Filter = "Imágenes (*.jpg; *.jpeg; *.png)|*.jpg;*.jpeg;*.png";
					if (ofd.ShowDialog() == DialogResult.OK)
					{
						ptbImagen.Image = Image.FromFile(ofd.FileName);
						imagenBytes = File.ReadAllBytes(ofd.FileName);
					}
				}
			}
			catch (Exception ex) 
			{
				MessageBox.Show(ex.Message);
			}
		}

		//Método para insertar los tipos de cuidados en la tabla tipo_cuidados, solo en caso de que esté vacía
		private void InsertarTiposCuidados()
		{
			using (coneccionMySQL conectar = new coneccionMySQL())
			{
				string[] tipos = { "Luz", "Riego", "Temperatura", "Suelo", "Fertilizante" };

				foreach (string cuidados in tipos)
				{
					string verificar = "SELECT COUNT(*) FROM tipo_cuidado WHERE Tipo_Cuidado= @nombreCuidado";
					using (MySqlCommand cmdverificar = new MySqlCommand(verificar, conectar.GetConnection()))
					{
						cmdverificar.Parameters.AddWithValue("@nombreCuidado", cuidados);
						int contador = Convert.ToInt32(cmdverificar.ExecuteScalar());
						if (contador == 0)
						{
							string consulta = "INSERT IGNORE INTO tipo_cuidado (Tipo_Cuidado) VALUES (@tipo)";
							using (var cmd = new MySqlCommand(consulta, conectar.GetConnection()))
							{
								cmd.Parameters.AddWithValue("@tipo", cuidados);
								cmd.ExecuteNonQuery();
							}


						}
					}
				}
			}

		}
		//Método para insertar los lugares adecuados, solo en caso de que no existan
		private void InsertarLugares()
		{
			try
			{
				using (coneccionMySQL conectar = new coneccionMySQL())
				{
					string[] LugarAdecuado = { "Exterior", "Interior" };

					foreach (string Lugares in LugarAdecuado)
					{
						string verificar = "SELECT COUNT(*) FROM lugar WHERE Lugar_Adecuado = @nombreLugar";
						using (MySqlCommand cmdverificar = new MySqlCommand(verificar, conectar.GetConnection()))
						{
							cmdverificar.Parameters.AddWithValue("@nombreLugar", Lugares);
							int contador = Convert.ToInt32(cmdverificar.ExecuteScalar());
							if (contador == 0)
							{
								string consulta = "INSERT IGNORE INTO lugar (Lugar_Adecuado) VALUES (@lugar)";
								using (MySqlCommand cmd = new MySqlCommand(consulta, conectar.GetConnection()))
								{
									cmd.Parameters.AddWithValue("@lugar", Lugares);
									cmd.ExecuteNonQuery();
								}
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error" + ex.Message);
			}

		}

		// Método para guardar los datos en la base de datos ingresados desde los textbox 
		private void GuardarPlanta(Planta planta)
		{
			using (coneccionMySQL conectar = new coneccionMySQL())
			{
				using (MySqlTransaction transaccion = conectar.GetConnection().BeginTransaction())
				{
					using (MySqlCommand cmd = conectar.GetConnection().CreateCommand())
					{
						try
						{
							cmd.Transaction = transaccion;

							// 1. Insertando cada tipo de cuidado con su descripción
							int[] idsCuidados = new int[5];
							string[] tipos = { planta.Luz, planta.Riego, planta.Temperatura, planta.Suelo, planta.Fertilizantes };
							string[] tipoCuidado = { "Luz", "Riego", "Temperatura", "Suelo", "Fertilizante" };

							for (int i = 0; i < tipos.Length; i++)
							{
								// Obtenemos el idTipo_Cuidado
								cmd.CommandText = "SELECT idTipo_Cuidado FROM tipo_cuidado WHERE Tipo_Cuidado = @tipocuidado";
								cmd.Parameters.AddWithValue("@tipocuidado", tipoCuidado[i]);
								int idTipoCuidado = Convert.ToInt32(cmd.ExecuteScalar());
								cmd.Parameters.Clear();
								// Insertamos en cuidados_planta
								cmd.CommandText = "INSERT INTO cuidados_planta (id_Tipo_Cuidado, descripcion) VALUES (@idTipo, @desc)";
								cmd.Parameters.AddWithValue("@idTipo", idTipoCuidado);
								cmd.Parameters.AddWithValue("@desc", tipos[i]);
								cmd.ExecuteNonQuery();
								idsCuidados[i] = (int)cmd.LastInsertedId;
								cmd.Parameters.Clear();
							}

							// 2. Insertar en Clasificación
							cmd.CommandText = @"INSERT INTO clasificacion (Especie, Genero, Familia, Orden_Cientifico, Clase, Division) 
                                VALUES (@especie, @genero, @familia, @orden, @clase, @division)";
							cmd.Parameters.AddWithValue("@especie", planta.Especie);
							cmd.Parameters.AddWithValue("@genero", planta.Genero);
							cmd.Parameters.AddWithValue("@familia", planta.Familia);
							cmd.Parameters.AddWithValue("@orden", planta.Orden);
							cmd.Parameters.AddWithValue("@clase", planta.Clase);
							cmd.Parameters.AddWithValue("@division", planta.Division);
							cmd.ExecuteNonQuery();
							int idClasificacion = (int)cmd.LastInsertedId;
							cmd.Parameters.Clear();

							// 3. Insertar lugar (si no existe)
							cmd.CommandText = "SELECT idLugar FROM lugar WHERE Lugar_Adecuado = @lugar";
							cmd.Parameters.AddWithValue("@lugar", planta.Lugar);
							object resultLugar = cmd.ExecuteScalar();
							int idLugar = Convert.ToInt32(resultLugar);
							cmd.Parameters.Clear();

							// 4. Insertar planta
							cmd.CommandText = "INSERT INTO plantas(Nombre_Plantas, id_Clasificacion, id_Lugar, Descripcion_Planta, tamaño, imagenes) VALUES (@nombre, @idClasificacion, @idLugar, @descripcion, @tamano, @imagen)";
							cmd.Parameters.AddWithValue("@nombre", planta.Nombre);
							cmd.Parameters.AddWithValue("@idClasificacion", idClasificacion);
							cmd.Parameters.AddWithValue("@idLugar", idLugar);
							cmd.Parameters.AddWithValue("@descripcion", planta.Descripcion);
							cmd.Parameters.AddWithValue("@tamano", planta.Crecimiento);
							cmd.Parameters.AddWithValue("@imagen", imagenBytes ?? (object)DBNull.Value);
							cmd.ExecuteNonQuery();
							idPlanta = (int)cmd.LastInsertedId;
							// 5. Relacion entre la tabla plantas y la tabla planta_cuidados
							cmd.Parameters.Clear();
							foreach (int idCuidados in idsCuidados)
							{
								cmd.CommandText = "INSERT INTO planta_cuidados(idPlanta, id_Cuidados_Planta) VALUES(@idPlant, @idCdPlant)";
								cmd.Parameters.AddWithValue("@idPlant", idPlanta);
								cmd.Parameters.AddWithValue("@idCdPlant", idCuidados);
								cmd.ExecuteNonQuery();
								cmd.Parameters.Clear();

							}

							// Confirmar transacción
							transaccion.Commit();
							MessageBox.Show("Planta registrada exitosamente.");
						}
						catch (Exception ex)
						{
							transaccion.Rollback();
							MessageBox.Show("Error al registrar la planta: " + ex.Message);
						}

					}

				}
			}

		}
		//Método para extraer los datos existentes y mostrarlos en sus respectivos textbox
		private void mostrarDatosPlanta()
		{
			try
			{
				int id_Clasi = 0;
				int id_Lugar = 0;
				//Enviamos el nombre ingresado a la clase planta y se guarda en su propiedad nombre
				planta.Nombre = txt_Nombre.Text;

				//Hacemos la conexion a la Base de Datos
				using (coneccionMySQL conn = new coneccionMySQL())
				//Creamos nuestra variable para comandos
				using (MySqlCommand cmd = conn.GetConnection().CreateCommand())
				{
					// Buscamos encontrar el id y la descripcion de la planta
					cmd.CommandText = "SELECT idPlantas,id_Clasificacion, id_Lugar, Descripcion_Planta, tamaño, imagenes FROM plantas WHERE Nombre_Plantas= @nombre";
					cmd.Parameters.AddWithValue("@nombre", planta.Nombre);
					using (MySqlDataReader leerPlantas = cmd.ExecuteReader())
					{
						if (leerPlantas.Read())
						{
							//Mostramos en los txt el id y la descripcion de la planta que coincida con el nombre
							txt_ID.Text = leerPlantas["idPlantas"].ToString();
							id_Clasi = (int)leerPlantas["id_Clasificacion"];
							id_Lugar = Convert.ToInt32(leerPlantas["id_Lugar"]);
							txt_Descripcion.Text = leerPlantas["Descripcion_Planta"].ToString();
							txt_Tamaño.Text = leerPlantas["tamaño"].ToString();

							try
							{
								if (!Convert.IsDBNull(leerPlantas["imagenes"]))
								{
									byte[] bytes = (byte[])leerPlantas["imagenes"];
									using (MemoryStream ms = new MemoryStream(bytes))
									{
										ptbImagen.Image = Image.FromStream(ms);
										imagenBytes = bytes;
									}
								}
								else
								{
									ptbImagen.Image = null;
								}
							}
							catch (Exception ex) 
							{
								MessageBox.Show("No hay imagen: "+ ex.Message);
							}
								
						}
						else
						{
							MessageBox.Show("No se encontró la planta");
						}
					}
					cmd.Parameters.Clear();
					//Con el id anterior obtenemos lo que hay en la tabla clasificación.
					cmd.CommandText = "SELECT Especie, Genero, Familia, Orden_Cientifico, Clase, Division FROM clasificacion WHERE id_Clasificacion = @idClas";
					cmd.Parameters.AddWithValue("@idClas", id_Clasi);
					using (MySqlDataReader leerClasificacion = cmd.ExecuteReader())
					{
						if (leerClasificacion.Read())
						{
							// Mostramos en los txt la Especie, Genero, etc.
							txt_Especie.Text = leerClasificacion["Especie"].ToString();
							txtGenero.Text = leerClasificacion["Genero"].ToString();
							txt_Familia.Text = leerClasificacion["Familia"].ToString();
							txt_Orden.Text = leerClasificacion["Orden_Cientifico"].ToString();
							txt_Clase.Text = leerClasificacion["Clase"].ToString();
							txt_Division.Text = leerClasificacion["Division"].ToString();
						}
						else
						{
							MessageBox.Show("Clasificacion no encontrada");
						}
					}

					cmd.CommandText = "SELECT Lugar_Adecuado FROM lugar WHERE idLugar= @idLugar";
					cmd.Parameters.AddWithValue("@idlugar", id_Lugar);
					using (MySqlDataReader leerLugar = cmd.ExecuteReader())
					{
						if (leerLugar.Read())
						{
							cmbLugar.Text = leerLugar["Lugar_Adecuado"].ToString();
						}
						else
						{
							MessageBox.Show("Lugar no encontrado");
						}
					}
					cmd.Parameters.Clear();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message);
			}
		}
		// Método para extraer los datos de la tabla cuidados_planta
		private void mostrarCuidadosPlanta()
		{
			planta.Nombre = txt_Nombre.Text;
			idPlanta = 0;
			try
			{
				using (coneccionMySQL conn = new coneccionMySQL())
				using (MySqlCommand cmd = conn.GetConnection().CreateCommand())
				{
					//Buscamos el id de la planta mediante su nombre
					cmd.CommandText = "SELECT idPlantas FROM plantas WHERE Nombre_Plantas= @nombre";
					cmd.Parameters.AddWithValue("@nombre", planta.Nombre);
					using (MySqlDataReader leeridplanta = cmd.ExecuteReader())
					{
						if (leeridplanta.Read())
						{
							idPlanta = (int)leeridplanta["idPlantas"];
						}
					}

					cmd.CommandText = @"SELECT tc.Tipo_Cuidado, cp.descripcion
                     FROM planta_cuidados pc
					 INNER JOIN cuidados_planta cp ON pc.id_Cuidados_Planta = cp.idCuidados_Planta
                     INNER JOIN tipo_cuidado tc ON cp.id_Tipo_Cuidado = tc.idTipo_Cuidado
                     WHERE pc.idPlanta = @idPlanta";
					cmd.Parameters.AddWithValue("@idPlanta", idPlanta);
					//Buscamos y extraemos la información de la tabla cuidados_planta
					using (MySqlDataReader leerTipoCuidado = cmd.ExecuteReader())
					{
						while (leerTipoCuidado.Read())
						{
							string tipo = leerTipoCuidado.GetString("Tipo_Cuidado");
							string descripcion = leerTipoCuidado.GetString("descripcion");
							switch (tipo.ToLower())
							{
								case "luz":
									txtLuz.Text = descripcion;
									break;
								case "riego":
									txtRiego.Text = descripcion;
									break;
								case "temperatura":
									txtTemperatura.Text = descripcion;
									break;
								case "suelo":
									txtSuelo.Text = descripcion;
									break;
								case "fertilizante":
									txt_Fertilizante.Text = descripcion;
									break;
							}
						}
					}
					cmd.Parameters.Clear();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error" + ex.Message);
			}

		}
		//Método para actulizar los datos de la planta
		private void ActulizarDatosPlanta()
		{
			try
			{
				idPlanta = Convert.ToInt32(txt_ID.Text);
				using (coneccionMySQL conn = new coneccionMySQL())
				using (MySqlCommand cmd = conn.GetConnection().CreateCommand())
				{
					cmd.Parameters.Clear();
					cmd.CommandText = "SELECT idLugar FROM lugar WHERE Lugar_Adecuado= @lugar ";
					cmd.Parameters.AddWithValue("@lugar", cmbLugar.Text);
					object resultado = cmd.ExecuteScalar();
					int idlugar = Convert.ToInt32(resultado);
					cmd.CommandText = @"UPDATE plantas SET Nombre_Plantas=@nombrePlanta, id_Lugar=@idLugar,
					Descripcion_Planta= @descPlanta, tamaño= @tamañoPlanta, imagenes=@imagen WHERE idPlantas= @idPlantas";
					cmd.Parameters.AddWithValue("@idPlantas", idPlanta);
					cmd.Parameters.AddWithValue("@nombrePlanta", txt_Nombre.Text);
					cmd.Parameters.AddWithValue("@idLugar", idlugar);
					cmd.Parameters.AddWithValue("@descPlanta", txt_Descripcion.Text);
					cmd.Parameters.AddWithValue("@tamañoPlanta", txt_Tamaño.Text);
					cmd.Parameters.AddWithValue("@imagen", imagenBytes ?? (object)DBNull.Value);
					int filasAfectadas = cmd.ExecuteNonQuery();
					if (filasAfectadas > 0)
					{
						MessageBox.Show("Filas actualizadas correctamente");
					}
					else
					{
						MessageBox.Show("No se encontró la planta");
					}
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show("Error" + ex.Message);
			}
		}
		//Método para actulizar la clasificación de la planta
		private void ActualizarClasiPlanta()
		{
			try
			{
				int idClass = 0;
				idPlanta = Convert.ToInt32(txt_ID.Text);
				using (coneccionMySQL conn = new coneccionMySQL())
				using (MySqlCommand cmd = conn.GetConnection().CreateCommand())
				{
					cmd.CommandText = "SELECT id_Clasificacion FROM plantas WHERE idPlantas=@idPlantas";
					cmd.Parameters.AddWithValue("@idPlantas", idPlanta);
					using (MySqlDataReader leerIdClasi = cmd.ExecuteReader())
					{
						if (leerIdClasi.Read())
						{
							idClass = (int)leerIdClasi["id_Clasificacion"];
						}

					}
					cmd.Parameters.Clear();
					cmd.CommandText = @"UPDATE clasificacion 
								  SET Especie = @Esp, Genero = @Gene, Familia = @Fam, Orden_Cientifico = @Ord, Clase = @Cla,
								  Division = @Div WHERE id_Clasificacion = @idClass";
					cmd.Parameters.AddWithValue("@Esp", txt_Especie.Text);
					cmd.Parameters.AddWithValue("@Gene", txtGenero.Text);
					cmd.Parameters.AddWithValue("@Fam", txt_Familia.Text);
					cmd.Parameters.AddWithValue("@Ord", txt_Orden.Text);
					cmd.Parameters.AddWithValue("@Cla", txt_Clase.Text);
					cmd.Parameters.AddWithValue("@Div", txt_Division.Text);
					cmd.Parameters.AddWithValue("@idClass", idClass);

					int CamposAfectados = cmd.ExecuteNonQuery();
					if (CamposAfectados > 0)
					{
					}
					else
					{
						MessageBox.Show("No se encontró la planta");
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error" + ex.Message);
			}
		}

		//Método para actualizar la descripcion de los tipos de plantas
		private void ActualizarDescTipos()
		{
			try
			{
				idPlanta = Convert.ToInt32(txt_ID.Text);
				using (coneccionMySQL conn = new coneccionMySQL())
				using (MySqlCommand cmd = conn.GetConnection().CreateCommand())
				{
					string[] tiposCuidado = { "Luz", "Riego", "Temperatura", "Suelo", "Fertilizante" };
					string[] descripciones = { txtLuz.Text, txtRiego.Text, txtTemperatura.Text, txtSuelo.Text, txt_Fertilizante.Text };
					for (int i = 0; i < tiposCuidado.Length; i++)
					{
						cmd.Parameters.Clear();
						//Obtenemos el id del tipo cuidado
						cmd.CommandText = @" SELECT cp.idCuidados_Planta
										FROM planta_Cuidados pc
										JOIN cuidados_planta cp ON pc.id_Cuidados_Planta = cp.idCuidados_Planta
										JOIN tipo_cuidado tc ON cp.id_Tipo_Cuidado = tc.idTipo_Cuidado
										WHERE pc.idPlanta = @idPlanta AND tc.Tipo_Cuidado= @tipos";
						cmd.Parameters.AddWithValue("@idPlanta", idPlanta);
						cmd.Parameters.AddWithValue("@tipos", tiposCuidado[i]);
						object resultado = cmd.ExecuteScalar();
						if (resultado != null)
						{
							int idCuidado = (int)resultado;
							cmd.CommandText = "UPDATE cuidados_planta SET descripcion= @desc WHERE idCuidados_Planta= @idCuidado";
							cmd.Parameters.AddWithValue("@desc", descripciones[i]);
							cmd.Parameters.AddWithValue("@idCuidado", idCuidado);
							cmd.ExecuteNonQuery();
						}
					}
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show("Error" + ex.Message);
			}
		}

		//Método para borrar una planta y sus relaciones
		private void BorrarPlanta()
		{
			using (coneccionMySQL conn = new coneccionMySQL())
			using (MySqlTransaction transaction = conn.GetConnection().BeginTransaction())
			{
				try
				{
					int idPlanta = Convert.ToInt32(txt_ID.Text);
					// 1. Eliminar REGISTROS de la planta
					var cmd1 = new MySqlCommand(@"DELETE FROM registro WHERE id_Seguimiento IN 
                (SELECT id_Seguimiento FROM seguimiento WHERE id_Planta = @id)", conn.GetConnection(), transaction);
					cmd1.Parameters.AddWithValue("@id", idPlanta);
					cmd1.ExecuteNonQuery();

					// 2. Eliminar SEGUIMIENTO
					var cmd2 = new MySqlCommand("DELETE FROM seguimiento WHERE id_Planta = @id", conn.GetConnection(), transaction);
					cmd2.Parameters.AddWithValue("@id", idPlanta);
					cmd2.ExecuteNonQuery();

					// 3. Eliminar de planta_cuidados
					var cmd3 = new MySqlCommand("DELETE FROM planta_cuidados WHERE idPlanta = @id", conn.GetConnection(), transaction);
					cmd3.Parameters.AddWithValue("@id", idPlanta);
					cmd3.ExecuteNonQuery();

					// 4. Eliminar CUIDADOS si ya no los usa ninguna planta (opcional)
					var cmd4 = new MySqlCommand(@"DELETE FROM Cuidados_planta WHERE idCuidados_Planta NOT IN 
                (SELECT id_Cuidados_Planta FROM planta_cuidados)", conn.GetConnection(), transaction);
					cmd4.ExecuteNonQuery();

					// 5. Eliminar CLASIFICACIÓN si ya no la usa otra planta
					var cmd5 = new MySqlCommand(@"DELETE FROM clasificacion WHERE id_Clasificacion = (SELECT id_Clasificacion FROM plantas WHERE idPlantas = @id) 
											AND id_Clasificacion NOT IN (SELECT id_Clasificacion FROM plantas WHERE idPlantas != @id)", conn.GetConnection(), transaction);
					cmd5.Parameters.AddWithValue("@id", idPlanta);
					cmd5.ExecuteNonQuery();

					// 6. Eliminar de plantas_usuario si aplica
					var cmd6 = new MySqlCommand("DELETE FROM plantas_usuario WHERE idPlantas_Usuario = @id", conn.GetConnection(), transaction);
					cmd6.Parameters.AddWithValue("@id", idPlanta);
					cmd6.ExecuteNonQuery();

					// 7. Finalmente, eliminar de PLANTAS
					var cmd7 = new MySqlCommand("DELETE FROM plantas WHERE idPlantas = @id", conn.GetConnection(), transaction);
					cmd7.Parameters.AddWithValue("@id", idPlanta);
					cmd7.ExecuteNonQuery();

					transaction.Commit();
					MessageBox.Show("Planta y toda su información relacionada han sido eliminadas correctamente.");
				}
				catch (Exception ex)
				{
					transaction.Rollback();
					MessageBox.Show("Error al eliminar planta: " + ex.Message);
				}
			}
		}
		//Método para limpiar los campos
		private void limpiarCampos()
		{
			txt_ID.Clear();
			txt_Nombre.Clear();
			txt_Descripcion.Clear();
			txt_Especie.Clear();
			txtGenero.Clear();
			txt_Familia.Clear();
			txt_Orden.Clear();
			txt_Clase.Clear();
			txt_Division.Clear();
			txt_Tamaño.Clear();
			txtLuz.Clear();
			txtRiego.Clear();
			txtTemperatura.Clear();
			txtSuelo.Clear();
			txt_Fertilizante.Clear();
			cmbLugar.SelectedIndex = -1;
			ptbImagen.Image = null;

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
			//SeguimientoForm ventanaSegui = new SeguimientoForm();
			//ventanaSegui.Show();
			this.Hide();
		}

		private void MenuUsuarios_Click(object sender, EventArgs e)
		{
			Usuario ventanaUsua = new Usuario();
			ventanaUsua.Show();
			this.Hide();
		}

		private void Agregar_Planta_Load(object sender, EventArgs e)
		{

		}

		private void txt_Nombre_TextChanged(object sender, EventArgs e)
		{

		}

		private void txt_Division_TextChanged(object sender, EventArgs e)
		{

		}

		private void lbl_Genero_Click(object sender, EventArgs e)
		{

		}

		
	}
}
