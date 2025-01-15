namespace _08LasCadenas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Inmutable -> No puede cambiar
            string palabra1 = "Hola"; // Creamos un objeto y se lo asignamos a la referencia "palabra1"
            string palabra2 = palabra1; // Creamos otra referencia (palabra2) que contiene al objeto de arriba

            // Imprimimos el valor de ambas referencias
            Console.WriteLine($"Referencia 1: {palabra1}");
            Console.WriteLine($"Referencia 2: {palabra2}");

            palabra1 += " a todos";

            Console.WriteLine("\nDespués de la concatenación\n");
            // Imprimimos el valor de ambas referencias
            Console.WriteLine($"Referencia 1: {palabra1}");
            Console.WriteLine($"Referencia 2: {palabra2}");
        }
    }
}
