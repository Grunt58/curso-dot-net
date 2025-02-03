using System.IO;
using System.Text;

namespace _11FlujosYArchivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instanciamos a SW y le mandamos el archivo a su constructor
            StreamWriter sw = new StreamWriter("Archivo con file.txt", false);

            // Write WriteLine

            sw.WriteLine("texto nuevo");

            // Cerramos el flujo
            sw.Close();
        }
    }
}
