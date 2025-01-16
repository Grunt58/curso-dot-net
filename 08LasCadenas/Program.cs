using System.Text;

namespace _08LasCadenas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder numeros = new StringBuilder();
            for (int i = 1; i <= 100; i++)
            {
                numeros.Append(i);
                numeros.Append(", ");
            }

            string cadenaNumeros = numeros.ToString();
            Console.WriteLine(cadenaNumeros);
        }
    }
}
