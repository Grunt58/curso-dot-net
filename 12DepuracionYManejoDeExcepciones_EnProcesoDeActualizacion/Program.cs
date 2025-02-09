namespace _12DepuracionYManejoDeExcepciones_EnProcesoDeActualizacion
{
    internal class Program
    {






        static void Main(string[] args)
        {
            int opcion;

            do
            {
                // Menú
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");

                Console.Write("Escoge una opción: ");
                try
                {
                    // Código que puede generar una excepción (se intentará ejecutar)
                    opcion = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    // Código para controlar la excepción de TipoDeExcepcion
                    Console.WriteLine("¡Solo es posible ingrear el número 1 o 2!");
                    opcion = 5;
                }
                catch (OverflowException e)
                {
                    // Código para controlar la excepción de OverflowException
                    Console.WriteLine($"El número es muy grande o pequeño ¡Sólo es posible ingresar el número 1 o 2!");

                    // Asignamos un valor a la variable "opcion" porque "try" no pudo hacerlo
                    opcion = 5;
                }

            } while (opcion < 1 || opcion > 2); 


            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Sumar");
                    break;
                case 2:
                    Console.WriteLine("Restar");
                    break;
                default:
                    Console.WriteLine("El número ingresado no es válido");
                    break;
            }
        }
    }
}
