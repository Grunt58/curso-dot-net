namespace _10EstructurasYEnumeraciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    class Jugador
    {
        string nombre;
        int vida;
        int puntaje;
        List<Item> inventario;
    }

    struct Item
    {
        string nombre;
        int tipo;
        int daño;
        int vida;
    }
}
