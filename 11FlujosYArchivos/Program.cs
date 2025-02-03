using System.IO;
using System.Text;

namespace _11FlujosYArchivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instanciamos a SW para crear un flujo y poder leer el contenido del archivo
            StreamReader sr = new StreamReader("contraseña.txt");

            // ReadLine

            // Variable para almacenar la contraseña
            string contraseñaArchivo;

            // Asignamos la devolución de ReadLine a nuestro string
            contraseñaArchivo = sr.ReadLine();

            // Mostramos la información del archivo
            Console.WriteLine($"Contraseña: {contraseñaArchivo}");
        }
    }
}
