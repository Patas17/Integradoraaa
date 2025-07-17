using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProyectoIntegrador1
{
	internal class coneccionMySQL : Conector, IDisposable
	{
		private MySqlConnection connection;
		private string cadenaConeccion;
		public coneccionMySQL()
		{
			cadenaConeccion = "Database = " + database +
				"; DataSource = " + server +
				"; User id = " + user +
				"; Password = " + password;
		 
		}
		public MySqlConnection GetConnection() 
		{
			try
			{
				if(connection == null)
				{
					connection = new MySqlConnection(cadenaConeccion);
					connection.Open();
				}
			}catch (Exception e)
			{
				MessageBox.Show(e.ToString());
			}
			
			return connection;
		}
		public void Dispose()
		{
			if (connection != null)
			{
				connection.Dispose();
				connection = null;
			}
		}
	}
}
