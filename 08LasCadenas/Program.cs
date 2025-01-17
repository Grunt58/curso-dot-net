using System.Globalization;
using System.Text;

namespace _08LasCadenas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CADENAS DE FORMATO

            // Formato compuesto
            int numero1 = 5, numero2 = 10;

            Console.WriteLine("El primer valor es: {0}, y el segundo valos es: {1}", numero1, numero2);

            string cadena1;

            cadena1 = String.Format("El valor es: {0}", numero1);
            Console.WriteLine(cadena1);
        }
    }
}
