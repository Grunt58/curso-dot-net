using System.IO;
using System.Text;

namespace _11FlujosYArchivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Cadena con la ruta
            string ruta = @"C:\Users\REDACTED\Desktop\Prueba\Subcarpeta1";

            // Llamamos al método y le asignamos la extensión al string
            string extension = Path.GetExtension(ruta);

            // Mostramos la extensión
            Console.WriteLine($"La extensión del archivo es: {extension}");            
        }
    }
}
