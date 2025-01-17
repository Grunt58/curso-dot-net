using System.Globalization;
using System.Text;

namespace _08LasCadenas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// CADENAS DE FORMATO

            //// Interpolación de cadenas
            //// Carácter de cadenas interpolada $
            //int numero1 = 5, numero2 = 10;

            //// Una "literal de cadena entre comillas", es la típica cadena encerrada entre comillas dobles.
            //Console.WriteLine($"El primer valor es: {numero1}, y el segundo valor es: {numero2}");

            //{expresiónDeInterpolación, alineación: cadenaDeFormato}
            string nombre = "Luis";
            int edad = 33;
            Console.WriteLine($"Hola, soy {nombre,10} y tengo {edad} años");
        }
    }
}
