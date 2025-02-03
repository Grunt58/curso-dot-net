using System.IO;
using System.Text;

namespace _11FlujosYArchivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Cadena con la ruta
            string ruta = @"C:\Users\REDACTED\Desktop\Prueba";

            // Llamamos al método y le asignamos la devolución a una matriz de string
            string[] archivosDirectorios = Directory.GetFileSystemEntries(ruta, "Doc?.txt");

            // Recorremos la matriz y mostramos sus elementos
            foreach (string item in archivosDirectorios)
            {
                Console.WriteLine(item);
            }
        }
    }
}
