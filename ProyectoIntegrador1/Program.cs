using Flower_Grow;

namespace ProyectoIntegrador1
{
    internal static class Program
    {
        //Bravo Calderon Maria Jose LITIID33 Asignarura POO

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Inicio_de_sesion());
        }
    }
}