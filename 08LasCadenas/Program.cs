namespace _08LasCadenas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Método Concat
            string[] palabras = { "Hola", "a", "todos" };

            string texto = string.Concat(palabras);
            Console.WriteLine(texto);

            string palabra1 = "Hola", palabra2 = "a", palabra3 = "todos";
            Console.WriteLine();
            Console.WriteLine(string.Concat(palabra1, palabra2, palabra3));

            // Método Join
            string textoSeparado = string.Join("-", palabras);
            Console.WriteLine(textoSeparado);
        }
    }
}
