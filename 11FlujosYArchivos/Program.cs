using System.IO;
using System.Text;

namespace _11FlujosYArchivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creamos un flujo/stream para trabajar con la memoria RAM
            MemoryStream ms1 = new MemoryStream();

            // Le pedimos al ususario una cadena para guardar en el stream
            Console.Write("Ingresa un texto para guardarlo en el stream: ");
            string cadena1 = Console.ReadLine();

            byte[] matrizCadenaByte;

            // Codificar: string -> secuencia de bytes
            // Descodificar: secuencia de bytes -> string

            // Codificamos a cadena1 para obtener una secuenda de bytes
            matrizCadenaByte = Encoding.UTF8.GetBytes(cadena1);
        }
    }
}
