using System.Globalization;
using System.Text;

namespace _08LasCadenas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declarando un objeto DateTime

            DateTime fechaHoraPredeterminados = new DateTime();
            DateTime fecha = new DateTime(2004, 01, 23);
            DateTime fechaHora = new DateTime(2001, 06, 15, 23, 11, 5);


            Console.WriteLine(fechaHoraPredeterminados);
            Console.WriteLine(fecha);
            Console.WriteLine(fechaHora);
        }
    }
}
