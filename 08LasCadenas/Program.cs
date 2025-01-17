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

            int numero = 35000;
            Console.WriteLine($"El valor es: {numero:0000000}");
            Console.WriteLine($"El valor es: {numero:0000000.00}");
            Console.WriteLine($"El valor es: {numero:0,0}");

            var numero2 = 35000.3456;
            Console.WriteLine($"El valor es: {numero2:0.0}");
            Console.WriteLine($"El valor es: {numero2:000000,0.00}");

            var numero3 = 112233;
            Console.WriteLine($"El valor es: {numero3:##-##-##}");
        }
    }
}
