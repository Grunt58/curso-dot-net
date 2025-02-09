namespace _12DepuracionYManejoDeExcepciones_EnProcesoDeActualizacion
{
    internal class Program
    {






        static void Main(string[] args)
        {
            // Variables
            int num1 = 10, num2 = 5, resultado;

            try
            {
                //Realizamos la división
                resultado = num1 / num2;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("No es posible dividir entre cero");
            }
            finally
            {
                Console.WriteLine("Operación finalizada.");
            }
        }
    }
}
