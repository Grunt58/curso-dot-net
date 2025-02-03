using System.IO;
using System.Text;

namespace _11FlujosYArchivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (Directory.Exists("Mi segunda carpeta"))
            {
                Console.WriteLine("Se encontró el directorio");
            }
            else
            {
                Console.WriteLine("Directorio no encontrado");
            }
        }
    }
}
