using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace ProyectoIntegrador1
{
    public static class FavoritosManager
    {
        // Cadena de conexión - pon tus datos reales aquí
            private static string connectionString = "Server=localhost;Database=flower_grow;Uid=root;Pwd=root;";

        private static MySqlConnection GetConnection()
        {
            var conn = new MySqlConnection(connectionString);
            conn.Open();
            return conn;
        }

        public static List<Planta> ObtenerFavoritos()
        {
            List<Planta> favoritos = new List<Planta>();
            int idUsuario = SesionActual.UsuarioId;

            using (var conn = GetConnection())
            {
                string query = @"
    SELECT p.idPlantas, p.Nombre_Plantas, p.Descripcion_Planta, p.imagenes
    FROM favoritos f
    JOIN plantas p ON f.id_Planta = p.idPlantas
    WHERE f.id_usuario = @idUsuario";



                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idUsuario", idUsuario);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // 🟡 Leer la imagen desde el campo LONGBLOB
                        byte[] imagenBytes = null;

                        if (!reader.IsDBNull(reader.GetOrdinal("imagenes")))
                        {
                            long length = reader.GetBytes(reader.GetOrdinal("imagenes"), 0, null, 0, 0);
                            imagenBytes = new byte[length];
                            reader.GetBytes(reader.GetOrdinal("imagenes"), 0, imagenBytes, 0, (int)length);
                        }

                        // 🟢 Crear el objeto Planta
                        Planta planta = new Planta
                        {
                            Id = reader.GetInt32("idPlantas"),
                            Nombre = reader.GetString("Nombre_Plantas"),
                            Descripcion = reader.GetString("Descripcion_Planta"),
                            Imagen = imagenBytes // <- aquí lo asignas
                        };

                        favoritos.Add(planta);
                    }

                }
            }

            return favoritos;
        }

        public static void EliminarFavorito(int idPlanta)
        {
            int idUsuario = SesionActual.UsuarioId;

            using (var conn = GetConnection())
            {
                string query = "DELETE FROM favoritos WHERE id_usuario = @idUsuario AND id_Planta = @idPlanta";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                cmd.Parameters.AddWithValue("@idPlanta", idPlanta);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
