using System.Reflection;

namespace _10EstructurasYEnumeraciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaramos una variable de tipo "Type" y le asignamos nuestra enumeración
            Type tipoEnumeracion = typeof(Continentes);

            // Matroz para almacenar la devolución de "GetValues"
            Continentes[] constantesContientes;

            // Le asignamos la devolución del método "GetValues" a nuestra matriz "constantesContientes"
            constantesContientes = (Continentes[])Enum.GetValues(tipoEnumeracion);

            // Recorremos a la matriz
            foreach (Continentes item in constantesContientes)
            {
                Console.WriteLine(item);
            }
        }
    }

    enum Continentes
    {
        Africa,
        America,
        Asia,
        Europa,
        Oceania
    }
}