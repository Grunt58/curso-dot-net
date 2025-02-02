using System.IO;
using System.Text;

namespace _11FlujosYArchivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creamos un flujo/stream para trabajar con la memoria RAM
            MemoryStream ms1 = new MemoryStream();

            // Mostrando la capacidad, longitud y posición del puntero del stream
            InformacionStream(ms1);

            // Matriz de bytes para guardar a la cadena convertida
            byte[] matrizCadenaByte;


            // Codificamos a cadena1 para obtener una secuenda de bytes
            matrizCadenaByte = Encoding.UTF8.GetBytes("Hola a todos");

            // Escribiendo datos en el flujo
            ms1.Write(matrizCadenaByte, 0, matrizCadenaByte.Length);

            // Mensaje para separar el antes y despupes del write
            Console.WriteLine("Después de escribir en el stream...");
            // Mostrando la capacidad, longitud y posición del puntero del stream
            InformacionStream(ms1);

            // Búfer para almacenar los bytes leídos por Read
            byte[] buferBytesLeidos = new byte[100];

            ms1.Seek(0, SeekOrigin.Begin); // Mover el puntero al inicio del flujo

            // Leemos el contenido de nuestro flujo usando el método Read
            int bytesLeidos = ms1.Read(buferBytesLeidos, 0, (int)ms1.Length);

            // Mostramos cuántos bytes fueron leídos por Read
            Console.WriteLine($"Bytes leídos del stream: {bytesLeidos}");

            // Descodificamos la matriz de bytes leida para convertirla en un string
            string cadenaDescodificada = Encoding.UTF8.GetString(buferBytesLeidos);

            // Mostramos la cadena descodificada
            Console.WriteLine($"Información obtenida del stream: \"{cadenaDescodificada}\"");
        }

        static void InformacionStream(MemoryStream ms1Pa)
        {
            Console.WriteLine($"\nCapacidad: {ms1Pa.Capacity}");
            Console.WriteLine($"Longitud: {ms1Pa.Length}");
            Console.WriteLine($"Posición del puntero: {ms1Pa.Position}\n");
        }
    }
}
