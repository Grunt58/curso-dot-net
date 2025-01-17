using System.Globalization;
using System.Text;

namespace _08LasCadenas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // (es-MX)
            string cadenaFechaHora;
            DateTime dateTimeFechaHora;

            // Pedimos al usuario la fecha/hora y la guardamos en una cadena
            Console.Write("Ingrese la hora y fecha deseada: ");
            cadenaFechaHora = Console.ReadLine();

            //Convertimos la cadena como un objeto DateTime
            dateTimeFechaHora = DateTime.Parse(cadenaFechaHora);

            // Mostramos a la cadena como un objeto DateTime
            Console.WriteLine(dateTimeFechaHora);
        }
    }
}
