using System.Globalization;
using System.Text;

namespace _08LasCadenas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime fechaHora = new DateTime(2002, 1, 5, 13, 54, 10);
            Console.WriteLine($"El valor del objketo DateTime es: {fechaHora}");

            // Convirtiendo el objeto DateTime en una cadena
            string cadenaFechaHora = fechaHora.ToString("d");

            // Imprimiendo la representación en cadena del objeto DateTime según la referencia cultural actual (es-MX)
            Console.WriteLine($"La representación en cadena (d) es: {cadenaFechaHora}");

            cadenaFechaHora = fechaHora.ToString("D");
            Console.WriteLine($"La representación en cadena (D) es: {cadenaFechaHora}");

            cadenaFechaHora = fechaHora.ToString("f");
            Console.WriteLine($"La representación en cadena (f) es: {cadenaFechaHora}");

            cadenaFechaHora = fechaHora.ToString("F");
            Console.WriteLine($"La representación en cadena (F) es: {cadenaFechaHora}");
        }
    }
}
