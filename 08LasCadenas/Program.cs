using System.Globalization;
using System.Text;

namespace _08LasCadenas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cadena1 = "Hola a todos";

            Console.WriteLine(cadena1);

            // Después de PadLeft
            Console.WriteLine(cadena1.PadLeft(15));

            // Después de PadRight
            Console.WriteLine(cadena1.PadRight(15, '#'));
        }
    }
}
