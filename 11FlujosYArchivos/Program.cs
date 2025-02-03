using System.IO;
using System.Text;

namespace _11FlujosYArchivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string origenArchivo = "contraseña.txt";
            string destinoArchivo = @"C:\Users\REDACTED\Desktop\contraseña.txt";

            File.Copy(origenArchivo, destinoArchivo, true);
        }
    }
}
