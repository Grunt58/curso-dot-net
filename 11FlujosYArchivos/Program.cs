using System.IO;
using System.Text;

namespace _11FlujosYArchivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string origenDirectorio = @"C:\Users\REDACTED\Documents\CursoDotNET\11FlujosYArchivos\bin\Debug\net9.0\Mi segunda carpeta\Mi tercera carpeta";
            string destinoDirectorio = @"C:\Users\REDACTED\Documents\CursoDotNET\11FlujosYArchivos\bin\Debug\net9.0\Mi tercera carpeta";
            if (Directory.Exists(origenDirectorio))
            {
                if (!Directory.Exists(destinoDirectorio))
                {
                    Directory.Move(origenDirectorio, destinoDirectorio);
                }
                else
                {
                    Console.WriteLine("El directorio de destino ya existe");
                }

            }
            else
            {
                Console.WriteLine("Directorio de origen no fue encontrado");
            }
        }
    }
}
