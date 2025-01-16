using System.Globalization;
using System.Text;

namespace _08LasCadenas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Entero negativo (Primera cadena < Segunda cadena)
            // Cero (Primera cadena == Segunda cadena)
            // Entrero positivo (Primera cadena > Segunda cadena)

            string cadena1 = "z";
            string cadena2 = "ö";

            int ordenar;

            ordenar = String.Compare(cadena1, cadena2, new CultureInfo("de-DE"), CompareOptions.None);

            switch (ordenar)
            {
                case -1:
                    Console.WriteLine($"({cadena1}) es menor que ({cadena2}) según el criterio de ordenación");
                    break;

                case 0:
                    Console.WriteLine($"({cadena1}) y ({cadena2}) son iguales según el criterio de ordenación");
                    break;

                case 1:
                    Console.WriteLine($"({cadena1}) es mayor que ({cadena2}) seúng el criterio de ordenación");
                    break;
            }
        }
    }
}
