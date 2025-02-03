using System.IO;
using System.Text;

namespace _11FlujosYArchivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creamos un objeto FileStream
            FileStream fs;

            // Creamos un archivo
            fs = File.Create("Archivo con file.txt");
        }
    }
}
