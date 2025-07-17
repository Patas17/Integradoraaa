using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntegrador1
{
	internal class seguridad
	{
		public static string EncriptarSHA256(string contraseña)
		{
			using (SHA256 sha256Hash = SHA256.Create())
			{
				// Convertir string a bytes
				byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(contraseña));

				// Convertir a string hexadecimal
				StringBuilder builder = new StringBuilder();
				foreach (var b in bytes)
					builder.Append(b.ToString("x2"));

				return builder.ToString();
			}
		}
	}
}
