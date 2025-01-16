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

            // Sin distinción de MAYÚSCULAS y minúsculas
            bool coincideCorreo = correo.Equals(correoConfirmar, StringComparison.OrdinalIgnoreCase);    
            
            if (coincideCorreo)
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
