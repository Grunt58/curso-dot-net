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
            // Especificadores de formato personalizado: ("d", "f", "F", "g", "h", "H", "K", "m", "M", "s", "t", "y", "z", ":" o "/")
            string cadenaFechaHora = fechaHora.ToString("%d");

            // Imprimiendo la representación en cadena del objeto DateTime según la referencia cultural actual (es-MX)
            Console.WriteLine($"La representación en cadena (%d) es: {cadenaFechaHora}");

            cadenaFechaHora = fechaHora.ToString("ddd");
            Console.WriteLine($"La representación en cadena (ddd) es: {cadenaFechaHora}");

            cadenaFechaHora = fechaHora.ToString("ddd dd");
            Console.WriteLine($"La representación en cadena (ddd dd) es: {cadenaFechaHora}");

            cadenaFechaHora = fechaHora.ToString("ddd dd MMMM");
            Console.WriteLine($"La representación en cadena (ddd dd MMMM) es: {cadenaFechaHora}");

            cadenaFechaHora = fechaHora.ToString("ddd dd MMMM yyyy");
            Console.WriteLine($"La representación en cadena (ddd dd MMMM yyyy) es: {cadenaFechaHora}");

            cadenaFechaHora = fechaHora.ToString("ddd dd MMMM yyyy h m tt");
            Console.WriteLine($"La representación en cadena (ddd dd MMMM yyyy h m tt) es: {cadenaFechaHora}");
        }
    }
}
