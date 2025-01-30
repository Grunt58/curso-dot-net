using System.Linq.Expressions;

namespace _10EstructurasYEnumeraciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaramos una variable del tipo del enum
            // Variables enumeradas, variable de enumeración, variables de tipo enumerado
            Semana diaDePago = Semana.Viernes;

            // Ejemplo de uso en una estructura de control
            if (diaDePago == Semana.Viernes)
            {
                double sueldoSemana1 = 3500;
                Console.WriteLine($"Hoy es dia de pago, recibes: ${sueldoSemana1}");
            }
            else
            {
                Console.WriteLine("Lo sentimos, hoy no es día de pago.");
            }
        }
    }

    // Declaración de una "enum"
    enum Semana
    {
        // Conjunto de constantes con nombre ("enumeradores" o "miembros de enumeración")
        Lunes, Martes, Miercoles, Jueves, Viernes, Sabado, Domingo
    }
}