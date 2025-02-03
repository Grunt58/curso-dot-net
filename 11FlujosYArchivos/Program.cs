using System.IO;
using System.Text;

namespace _11FlujosYArchivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // String que contiene el nombre de la ruta base
            string rutaBase = @"C:\Users\REDACTED\Documents\CursoDotNET\11FlujosYArchivos\bin\Debug\net9.0";

            // String para almacenar la cadena ya concatendada
            string rutaCompleta;

            // Pedimos el nombre del directorio que queremos crear
            Console.Write("Ingresa el nombre del directorio a crear: ");
            string nombreDirectorio = Console.ReadLine();

            // Concatenamos los nombres
            rutaCompleta = Path.Combine(rutaBase, nombreDirectorio);

            // Creamos el directorio y le mostramos al usuario la ruta donde fue creado
            Directory.CreateDirectory(rutaCompleta);
            Console.WriteLine($"El directorio se creó en: {rutaCompleta}");
        }
    }
}
