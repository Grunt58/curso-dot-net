namespace _08LasCadenas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //"Contains", "StartWith", "EndsWith", "IndexOf" y "LastIndexOf"

            string text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";

            Console.WriteLine($"Texto: {text}");

            Console.Write($"\nIngresa el texto a buscar: ");
            string searchText = Console.ReadLine();

            // Contains
            if (text.Contains(searchText))
            {
                Console.WriteLine($"\n[Contains]El texto {searchText} fue econtrado");
            }
            else
            {
                Console.WriteLine($"\n[Contains]El texto {searchText} no fue econtrado");
            }

            // StartWith
            if (text.StartsWith(searchText))
            {
                Console.WriteLine($"\n[StartWith]El texto inicia con: {searchText}");
            }
            else
            {
                Console.WriteLine($"\n[StartWith]El texto no inicia con: {searchText}");
            }

            // EndsWith
            if (text.EndsWith(searchText))
            {
                Console.WriteLine($"\n[EndsWith]El texto termina con: {searchText}");
            }
            else
            {
                Console.WriteLine($"\n[EndsWith]El texto no termina con: {searchText}");
            }

            string screen = "Pantalla";
            char caracterBuscado = 'a';

            // IndexOf
            int primeraAparicion = screen.IndexOf(caracterBuscado);
            // LastIndexOf
            int ultimaAparicion = screen.LastIndexOf(caracterBuscado);

            Console.WriteLine($"\n[IndexOf] Primer aparición de ({caracterBuscado}) en ({screen}) es en la posición: {primeraAparicion}");
            Console.WriteLine($"\n[LastIndexOf] Última aparición de ({caracterBuscado}) en ({screen}) es en la posición: {ultimaAparicion}");
        }
    }
}
