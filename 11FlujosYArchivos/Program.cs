using System.IO;
using System.Text;

namespace _11FlujosYArchivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Matriz para almacenar los nombre de archivos
            string[] nombresArchivos;

            // Buscamos archivos en la ruta del proyecto y asignamos la devolución a la matriz de string
            nombresArchivos = Directory.GetFiles(@"C:\Users\REDACTED\Documents\CursoDotNET\11FlujosYArchivos\bin\Debug\net9.0");

            // Recorremos a la matriz y mostramos sus elementos
            foreach (string item in nombresArchivos)
            {
                Console.WriteLine(Path.GetFileName(item));
            }
        }
    }
}
