using System.IO;
using System.Text;

namespace _11FlujosYArchivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creando un flujo de archivo
            FileStream fs = new FileStream("contraseña.txt", FileMode.Open);

            // buffer para almacenar los bytes contenidos en el archivo
            byte[] bufferLeerDatosArchivo = new byte[1024];

            // Leemos los bytes que contiene el archivo
            fs.Read(bufferLeerDatosArchivo, 0, bufferLeerDatosArchivo.Length);

            // Descodificamos la matriz de bytes leída para convertirla en un string
            string cadenaDescodificada = Encoding.UTF8.GetString(bufferLeerDatosArchivo);

            // Mostramos la cadena descodificada (la información del archivo)
            Console.WriteLine($"Información obtenida del archivo: \"{cadenaDescodificada}\"");
        }
    }
}
