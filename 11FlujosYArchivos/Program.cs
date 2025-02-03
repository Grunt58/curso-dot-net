using System.IO;
using System.Text;

namespace _11FlujosYArchivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creamos un flujo/stream para trabajar con la memoria RAM
            using (MemoryStream ms1 = new MemoryStream())
            {
                // Codificamos a cadena1 para obtener una secuencia de bytes
                byte[] matrizCadenaByte = Encoding.UTF8.GetBytes("Texto para el stream");

                // Escribiendo datos en el flujo
                ms1.Write(matrizCadenaByte, 0, matrizCadenaByte.Length);
            }
        }
    }
}
