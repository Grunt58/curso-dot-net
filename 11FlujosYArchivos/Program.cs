using System.IO;
using System.Text;

namespace _11FlujosYArchivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creamos un archivo
            FileStream fs = File.Create("Archivo con file.txt");

            // Codificamos una cadena para escribirla en el archivo
            byte[] buffer = Encoding.UTF8.GetBytes("Prueba de texto");

            // Escribirmos en el archivo
            fs.Write(buffer, 0, buffer.Length);

            // Cerramos el flujo de Create
            fs.Close();

            // Escribimos/anexamos texto a nuesto archivo
            File.AppendAllText("Archivo con file.txt", "Texto anexado");
        }
    }
}
