using System.Reflection;

namespace _10EstructurasYEnumeraciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Declaramos una variable de tipo "Type" y le asignamos nuestra enumeración
            //Type tipoEnumeracioan = typeof(Continentes);

            //// Matriz para almacenar la devolución de "GetValues"
            //Continentes[] constantesContientes;

            //// Le asignamos la devolución del método "GetValues" a nuestra matriz "constantesContientes"
            //constantesContientes = (Continentes[])Enum.GetValues(typeof(Continentes));

            // Recorremos a la matriz
            foreach (Continentes item in Enum.GetValues(typeof(Continentes)))
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