using System.IO;
using System.Text;

namespace _11FlujosYArchivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creamos nuestro primer directorio
            DirectoryInfo directoryInfo = Directory.CreateDirectory("Mi cuarta carpeta");

            // Mostramos información del directorio creado, a traves del objeto DirectoryInfo y sus propiedades
            Console.WriteLine($"Nombre: {directoryInfo.Name}");
            Console.WriteLine($"Ruta absoluta: {directoryInfo.FullName}");
            Console.WriteLine($"Fecha de creación: {directoryInfo.CreationTime}");
        }
    }
}
