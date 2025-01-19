using System.Globalization;
using System.Security;
using System.Text;

namespace _08LasCadenas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa que le pida al ususario la fecha de su nacimiento, y nosotros le diremos que día de la semana era.

            // Variables necesarias

            string cadenaFechaNacimiento;
            DateTime dateTimeFechaNacimiento;

            // Pedimos la fecha de nacimiento
            Console.Write("Dime la decha de tu nacimiento (día, mes y año) y te diré que día de la semana era: ");
            cadenaFechaNacimiento = Console.ReadLine();

            // Convertimos la cadena en un objeto DateTime
            dateTimeFechaNacimiento = DateTime.Parse(cadenaFechaNacimiento);

            // Aplicamos formato de fecha personalizado ("dddd") para mostrar el día de la semana
            Console.WriteLine($"Naciste un {dateTimeFechaNacimiento.ToString("dddd")}");
        }
    }
}