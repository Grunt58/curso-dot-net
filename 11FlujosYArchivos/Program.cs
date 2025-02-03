using System.IO;
using System.Text;

namespace _11FlujosYArchivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string origenArchivo = "prueba.txt";
            string destinoArchivo = @"C:\Users\REDACTED\Desktop\prueba.txt";

            File.Move(origenArchivo, destinoArchivo);
        }
    }
}
