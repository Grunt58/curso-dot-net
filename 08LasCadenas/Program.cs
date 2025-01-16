using System.Globalization;
using System.Text;

namespace _08LasCadenas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Secuencias de escape de carácteres

            // Secuencia de escape "Nueva línea" /n (Hace un salto de línea)
            Console.WriteLine("[\\n]: Hola\n mundo!");

            // Secuencia de escape "Tabulación" /t (Genera una tabulación)
            Console.WriteLine("[\\t]: Hola\t mundo!");

            // Secuencia de escape "Null" /0 (No es un espacio, es nada)
            Console.WriteLine("[\\0]: Ho\0la mundo!");

            // Secuencia de escape "Alerta" /a (Genera un sonido de alerta)
            Console.Write("Presiona cualquier tecla para confirmar: ");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("[\\a]: \aHola mundo!");

            // Secuencia de escape "Retorno de carro" /r (Regresa el cursor al inicio y esvribe lo que faltaba)
            Console.WriteLine("[\\r]:");
            Console.WriteLine("Hola mun\rdo!");

            // Secuencia de escape "Retroceso" /b (Regresar el cursos 1 lugar)
            Console.WriteLine("[\\b]: Hola mun\bdo!");

            // Secuencia de escape "Comilla doble" \" (Permite colocar comillas simples (""))
            Console.WriteLine("[\\\"]: \"Hola mundo!\"");

            // Secuencia de escape "Comilla simple" \' (Permite colocar comillas simples (''))
            Console.WriteLine("[\\\']: \'Hola mundo!\'");

            // Secuencia de escape "Barra diagonal invertida" (Permite colocar barra diganol invertida (\))
            Console.WriteLine("[\\\\]: \\Hola mundo!");
        }
    }
}
