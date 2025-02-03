using System.IO;
using System.Text;

namespace _11FlujosYArchivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Cadena con la ruta completa
            string rutaInicial = @"C:\Users\REDACTED\Documents\CursoDotNET\11FlujosYArchivos\bin\Debug\net9.0\contraseña.txt";

            // El método quita el útlimo elementto de la ruta y lo almacena en la variable string
            string rutaSinUltimoElemento = Path.GetDirectoryName(rutaInicial);

            // Mostramos la cadena devuelta por el método
            Console.WriteLine(rutaSinUltimoElemento);

            // Llamo al método mandándole la última cadena que me devolvió
            Console.WriteLine(Path.GetDirectoryName(rutaSinUltimoElemento));
        }
    }
}
