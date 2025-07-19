using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProyectoIntegrador1
{
    public class Planta
    {
        // VARIABLES PRIVADAS
        //datos de la planta
        private byte[] _imagen; // Imagen de la planta, almacenada como un arreglo de bytes
        private string _nombre;
        private string _descripcion;
        // Clasificación de la planta
        private string _especie;
        private string _genero;
        private string _familia;
        private string _orden;
        private string _clase;
        private string _division;
        //Características de la planta
        private string _crecimiento;
        //Tipos de cuidado
        private string _luz;
        private string _riego;
        private string _temperatura;
        private string _suelo;
        private string _fertilizantes;
        private string _lugar;

        // ✅ Propiedad pública para identificar la planta (clave primaria)
        public int Id { get; set; }

        //Constructor sin argumentos
        public Planta() { }

        public Planta(string nombre, string descripcion, string especie, string genero, string familia, string orden, string clase,
                        string division, string crecimiento, string luz, string riego, string temperatura, string suelo, string fertilizante, string lugar)
        {
            this._nombre = nombre;
            this._descripcion = descripcion;
            this._especie = especie;
            this._genero = genero;
            this._familia = familia;
            this._orden = orden;
            this._clase = clase;
            this._division = division;
            this._crecimiento = crecimiento;
            this._luz = luz;
            this._riego = riego;
            this._temperatura = temperatura;
            this._suelo = suelo;
            this._fertilizantes = fertilizante;
            this._lugar = lugar;
        }

        //VARIABLES DE ACCESO
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }
        public string Especie
        {
            get { return _especie; }
            set { _especie = value; }
        }
        public string Genero
        {
            get { return _genero; }
            set { _genero = value; }
        }
        public string Familia
        {
            get { return _familia; }
            set { _familia = value; }
        }
        public string Orden
        {
            get { return _orden; }
            set { _orden = value; }
        }
        public string Clase
        {
            get { return _clase; }
            set { _clase = value; }
        }
        public string Division
        {
            get { return _division; }
            set { _division = value; }
        }
        public string Crecimiento
        {
            get { return _crecimiento; }
            set { _crecimiento = value; }
        }
        public string Luz
        {
            get { return _luz; }
            set { _luz = value; }
        }
        public string Riego
        {
            get { return _riego; }
            set { _riego = value; }
        }
        public string Temperatura
        {
            get { return _temperatura; }
            set { _temperatura = value; }
        }
        public string Suelo
        {
            get { return _suelo; }
            set { _suelo = value; }
        }
        public string Fertilizantes
        {
            get { return _fertilizantes; }
            set { _fertilizantes = value; }
        }
        public string Lugar
        {
            get { return _lugar; }
            set { _lugar = value; }
        }

        public byte[] Imagen
        {
            get { return _imagen; }
            set { _imagen = value; }
        }


        // Métodos
        public void MostraInfo()
        {
            Console.WriteLine($"Nombre: {Nombre}\n Descripcion: {Descripcion} \n Especie: {Especie} \n " +
                                $"Genero: {Genero}\n Familia: {Familia} \n Orden: {Orden}\n Clase: {Clase}\n Division: {Division}\n" +
                                $"Crecimiento: {Crecimiento}\n Temperatura: {Temperatura}\n ");
        }
    }
}
