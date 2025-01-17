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
            string cadenaFechaHora = fechaHora.ToString("ddd dd MMMM yyyy h:m:s tt");

            // Imprimiendo la representación en cadena del objeto DateTime según la referencia cultural actual (es-MX)
            Console.WriteLine($"La representación en cadena (ddd dd MMMM yyyy h m tt) es: {cadenaFechaHora}");

            cadenaFechaHora = fechaHora.ToString("ddd dd/MM/yy h:m:s tt");
            Console.WriteLine($"La representación en cadena (ddd dd/MM/yy h m tt) es: {cadenaFechaHora}");

            cadenaFechaHora = fechaHora.ToString("ddd dd \\de MMMM \\de yyyy h:m:s tt");
            Console.WriteLine($"La representación en cadena (ddd dd \\de MMMM \\de yyyy h:m:s tt) es: {cadenaFechaHora}");

            cadenaFechaHora = fechaHora.ToString("ddd dd \"de\" MMMM \"de\" yyyy h:m:s tt");
            Console.WriteLine($"La representación en cadena (ddd dd \"de\" MMMM \"de\" yyyy h:m:s tt) es: {cadenaFechaHora}");
        }
    }
}
