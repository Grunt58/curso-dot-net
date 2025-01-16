using System.Text;

namespace _08LasCadenas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa tu correo: ");
            string correo = Console.ReadLine();


            Console.Write("Ingresa tu correo nuevamente: ");
            string correoConfirmar = Console.ReadLine();

            // Equals de 2 parámetros
            bool coincideCorreo = Equals(correo, correoConfirmar);        
            if (coincideCorreo)
            {
                Console.WriteLine("Registrado con éxito.");
            }
            else
            {
                Console.WriteLine("Error.");
            }

            // Equals de 1 parámetro
            if (correo.Equals(correoConfirmar))
            {
                Console.WriteLine("Registrado con éxito.");
            }
            else
            {
                Console.WriteLine("Error.");
            }
        }
    }
}
