using System.Text;

namespace _08LasCadenas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Registro para nuevo ingreso:\n");

            Console.Write("Ingreso tu nombre completo: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingresa tu correo electrónico: ");
            string email = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Verdifica tu información:\n");

            Console.WriteLine($"Nombre: {nombre.ToUpper()}");
            Console.WriteLine($"Nombre: {email.ToLower()}");
        }
    }
}
