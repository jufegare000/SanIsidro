using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioHospital2
{
    static class Program
    {

        // variavles globales
        public static List<String[]> usuarios = new List<string[]>();
        public static List<String[]> datosPersonales = new List<string[]>();

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            conectarABaseDeDatos();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }

        static void conectarABaseDeDatos()
        {
            /*
            string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=True";
            SqlConnection conn = new SqlConnection(cs);

            try
            {
                conn.Open();
                Console.WriteLine("Se ha conectado a la base de datos!");
            }
            catch(Exception)
            {
                Console.WriteLine("No se ha conectado a la base de datos!");
            */
            }
        }

    }
}
