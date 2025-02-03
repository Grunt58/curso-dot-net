using System.IO;
using System.Text;

namespace _11FlujosYArchivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (File.Exists("contraseña.txt"))
            {
                Console.WriteLine("Archivo encotrado!");
            }
            else
            {
                Console.WriteLine("No se encontró el archivo");
            }
        }
    }
}
