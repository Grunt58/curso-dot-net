namespace _08LasCadenas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Replace
            string text = "hola mundo";

            // Reemplazamos "hola" por "Hola" en una nueva cadena
            string newText = text.Replace("hola", "Hola");
            Console.WriteLine(text);
            Console.WriteLine(newText);


            // Trim
            string text2 = "---Hola Mundo---";

            string trimText2 = text2.Trim('-');
            Console.WriteLine($"Sin con Trim: {text2}");
            Console.WriteLine($"Texto con Trim: {trimText2}");

            // Remove
            string text3 = "Hola que tal";

            // Quitamos la palabra "que"
            string removeText3 = text3.Remove(5, 4);
            Console.WriteLine(text);
            Console.WriteLine(removeText3);
        }
    }
}
