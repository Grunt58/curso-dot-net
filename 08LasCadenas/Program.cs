namespace _08LasCadenas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string parrafo = "Hola soy un párrafo en C#";

            string[] palabras = parrafo.Split(' ');

            foreach (string item in palabras)
            {
                Console.WriteLine($"Palabra sustraida: {item}");
            }
        }
    }
}
