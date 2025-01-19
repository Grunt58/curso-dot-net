using System.Globalization;
using System.Security;
using System.Text;

namespace _08LasCadenas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Introducir una cadena de caracteres e indicar si es un palíndromo. Una palabra palíndroma es aquella que se lee igual adelante que atrás. Por ejemplo: ojo, rayar, solos, rapar, rotomotor, sedes.

            string palabraUsuario, palabraInvertida = "";

            // Pedimos la palabra
            Console.Write("Ingresa una palabra y veamos si es un palíndromo: ");
            palabraUsuario = Console.ReadLine();

            foreach (char letra in palabraUsuario)
            {
                palabraInvertida = letra + palabraInvertida;
            }

            if (palabraUsuario.Equals(palabraInvertida, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"\"{palabraUsuario}\" es una palabra palíndroma");
            }
            else
            {
                Console.WriteLine($"\"{palabraUsuario}\" no es una palabra palíndroma");
            }
        }
    }
}