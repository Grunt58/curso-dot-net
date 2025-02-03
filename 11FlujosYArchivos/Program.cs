using System.IO;
using System.Text;

namespace _11FlujosYArchivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variable para almacenar la contraseña
            string contraseñaArchivo;

            // Instanciamos a SW para crear un flujo y poder leer el contenido del archivo
            using (StreamReader sr = new StreamReader("contraseña.txt"))
            {
                // Asignamos la devolución de ReadLine a nuestro string
                contraseñaArchivo = sr.ReadLine();
            }

            // Mostramos la información del archivo
            Console.WriteLine($"Contraseña: {contraseñaArchivo}");
        }
    }
}
