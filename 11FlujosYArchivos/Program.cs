using System.IO;
using System.Text;

namespace _11FlujosYArchivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creando un flujo de archivo
            FileStream fs = new FileStream("mi_primer_archivo.txt", FileMode.Create);

            // Indicando que el archivo se ha creado
            Console.WriteLine("Archivo creado con exito");

            // Cadena para guardar la información que será escrita en el archivo txt
            string textoParaArchivo = "Texto de prueba para el archivo";

            // Matriz de bytes para almacenar la cadena
            byte[] bufferCadenaABytes;

            // Codificamos la cadena
            bufferCadenaABytes = Encoding.UTF8.GetBytes(textoParaArchivo);

            // Escribimos a la cadena codificada en nuestro archivo de texto
            fs.Write(bufferCadenaABytes, 0, bufferCadenaABytes.Length);
            fs.Close();
        }
    }
}
