using System.IO;

namespace _11FlujosYArchivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creando un flujo de archivo
            FileStream fs = new FileStream("mi_primer_archivo.txt", FileMode.Create);
        }
    }
}
