using System.IO;
using System.Text;

namespace _11FlujosYArchivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Creamos un objeto FileStream
            //FileStream fs;

            //// Creamos un archivo
            //fs = File.Create("Archivo con file.txt");

            //// Cerramos el flujo de Create
            //fs.Close();

            // Escribimos en el archivo
            File.WriteAllText("Archivo con file.txt", "Prueba de que se escribió en el archivo");
        }
    }
}
