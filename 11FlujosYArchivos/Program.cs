using System.IO;
using System.Text;

namespace _11FlujosYArchivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string directorio = @"C:\Users\fredd\Desktop\Carpeta en el escritorio";

            if (Directory.Exists(directorio))
            {
                Directory.Delete(directorio);
            }
            else
            {
                Console.WriteLine("Directorio no encontrado");
            }
        }
    }
}
