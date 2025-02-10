namespace _13ProyectoFinal_VideojuegoGato
{
    internal class Program
    {
        // Creamos un arreglo bidimensional para el tablero del juego
        static int[,] tablero = new int[3, 3]; // 3 filas - 3 columnas

        // Creamos un arreglo para los símbolos del tablero: Espacio en blanco, jug.1, jug.2
        static char[] simbolo = { ' ', 'O', 'X' };

        static void Main(string[] args)
        {
            // Dibujamos al tablero inicial
            DibujarTablero();
            Console.WriteLine("Jugador 1 = O\nJugador 2 = X");

        } // Cierre de Main

        static void DibujarTablero()
        {
            // Variables de conteo del ciclo
            int fila = 0;
            int columna = 0;

            Console.WriteLine(); // Espacio antes de dibujar el tablero
            Console.WriteLine("-------------"); // Dibujar el tablero línea horiozontal

            for(fila = 0; fila < 3; fila++)
            {
                Console.Write("|"); // Dibujar la primera línea vertical

                for(columna = 0; columna < 3; columna++)
                {
                    // Asigna un: Espacio, O, X según corresponda
                    Console.Write($" {simbolo[tablero[fila, columna]]} |");
                }
                Console.WriteLine();
                Console.WriteLine("-------------"); // Dibujala primer linea horizontal
            }
        }
    }
}
