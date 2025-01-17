using System.Globalization;
using System.Text;

namespace _08LasCadenas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Literales de cadena entre comillas
            string cadena1 = "Hola a todos";

            // Literal de cadena textual
            // Carácter "identificador textual" @

            string rutaDirectorio = @"C:\Windows\Fonts";

            string cadena2 = @"La aclamada serie ""Breaking Bad"" ganó tres premios Emmy";

            // Para escribir una cadena de varias líneas
            string cadena3 = @"Este es un mensaje
                              Hola a todos 
                              Hola otra vez";

            Console.WriteLine(rutaDirectorio);
            Console.WriteLine(cadena2);
            Console.WriteLine(cadena3);

            // Keyword: int, for, double, switch, etc...

            int @int;
        }
    }
}
