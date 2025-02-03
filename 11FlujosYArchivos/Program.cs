using System.IO;
using System.Text;

namespace _11FlujosYArchivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables necesarias
            int opcion;
            bool repetir = true;
            string mensajeParaCifrar, contraseñaMensaje, mensajeCifrado;

            // Creamos un flujo/stream en la memoria RAM
            MemoryStream memoryStream1 = new MemoryStream();

            // Pedimos la cadena que va a ser guardada en el flujo
            Console.Write("Ingresa el mensaje que quieres cifrar: ");
            mensajeParaCifrar = Console.ReadLine();

            // Pedimos una contraseña para porteger el mensaje cifrado
            Console.Write("Ingresa una contraseña para proteger el mensaje: ");
            contraseñaMensaje = Console.ReadLine();

            // Enviamos la cadena dada por el ususario para cifrarla
            mensajeCifrado = CifrarMensaje(mensajeParaCifrar);

            // Declaramos una matriz de bytes y le asignamos la codificación del mensaje ya cifrado para obtener una secuencia de bytes
            byte[] matrizCadenaByte = Encoding.UTF8.GetBytes(mensajeCifrado);

            // Escribimos el mensaje cifrado en el flujo
            memoryStream1.Write(matrizCadenaByte, 0, matrizCadenaByte.Length);

            // Mensaje para separa el antes y después del write
            Console.WriteLine("El mensaje está protegido, presiona cualquier tecla para continuar...");
            Console.ReadKey();

            // Empezamos a leer el string (cifrado) alacenado en el memorystream

            // Búfer para almacenar los bytes leídos por Read
            byte[] buferBytesLeidos = new byte[100];

            // Mover el puntero al inicio del flujo 
            memoryStream1.Seek(0, SeekOrigin.Begin);

            // Leemos el contenido de nuestro flujo usando el método Read
            memoryStream1.Read(buferBytesLeidos, 0, (int)memoryStream1.Length);

            // Descodificamos la matriz de bytes leída para convertirla en un string
            string cadenaDescodificadaCifrada = Encoding.UTF8.GetString(buferBytesLeidos);

            // Mostramos el menú
            do
            {
                // Limpiamos la consola
                Console.Clear();

                Console.WriteLine("[1]: Mostrar mensaje");
                Console.WriteLine("[2]: Descifrar mensaje");
                Console.WriteLine("[3]: Me rindo");

                Console.Write("Escoje una opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        // Mostramos la cadena descodificada pero todavía cifrada
                        Console.WriteLine($"Mensaje: \"{cadenaDescodificadaCifrada}\"");

                        // Mensaje de espera
                        Console.WriteLine("Presiona cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;
                        
                    case 2:
                        Console.Write("Ingresa la contraseña para descifrar el mensaje: ");
                        string posibleContraseña = Console.ReadLine();

                        if (posibleContraseña == contraseñaMensaje)
                        {
                            // Mandamos la cadena codificada al método "DescifrarMensaje" para ser descifrada, y la devolución la guardamos en una variable local
                            string mensajeDescifrado = DescifrarMensaje(cadenaDescodificadaCifrada);

                            // Mostramos la cadena descodificada y ya descifrada
                            Console.WriteLine($"Mensaje: \"{mensajeDescifrado}\"");
                            // Mensaje de espera
                            Console.WriteLine("Presiona cualquier tecla para continuar...");
                            Console.ReadKey();

                            // Cerramos el flujo
                            memoryStream1.Close();

                            // Finalizamos el programa
                            repetir = false;
                        }
                        else
                        {
                            Console.WriteLine("Constraseña incorrecta. Intenta de nuevo");
                            // Mensaje de espera
                            Console.WriteLine("Presiona cualquier tecla para continuar...");
                            Console.ReadKey();
                        }
                        break;

                    case 3:
                        // Finalizamos el programa
                        repetir = false;
                        break;

                    default:
                        break;
                }
            } while (repetir);
        }

        static string CifrarMensaje(string mensajeCifrarPa)
        {
            // Variable que va a guardar el mensaje cifrado
            string mensajeCifrado;

            // Le asignamos el mensaje original a nuestra variable local vacía
            mensajeCifrado = mensajeCifrarPa;

            // Reemplazamos las vocales por números en nuestro mensaje almacenado en la variable local
            mensajeCifrado = mensajeCifrado.Replace('a', '1');
            mensajeCifrado = mensajeCifrado.Replace('b', '2');
            mensajeCifrado = mensajeCifrado.Replace('c', '3');
            mensajeCifrado = mensajeCifrado.Replace('d', '4');
            mensajeCifrado = mensajeCifrado.Replace('e', '5');

            // Devolvemos el mensaje ya cifrado
            return mensajeCifrado;
        }

        static string DescifrarMensaje(string mensajeDescifrarPa)
        {

            // Variable que va a guardar el mensaje cifrado
            string mensajeDescifrado;

            // Le asignamos el mensaje original a nuestra variable local vacía
            mensajeDescifrado = mensajeDescifrarPa;

            // Reemplazamos las vocales por números en nuestro mensaje almacenado en la variable local
            mensajeDescifrado = mensajeDescifrado.Replace('1', 'a');
            mensajeDescifrado = mensajeDescifrado.Replace('2', 'b');
            mensajeDescifrado = mensajeDescifrado.Replace('3', 'c');
            mensajeDescifrado = mensajeDescifrado.Replace('4', 'd');
            mensajeDescifrado = mensajeDescifrado.Replace('5', 'e');

            // Devolvemos el mensaje ya cifrado
            return mensajeDescifrado;
        }
    }
}
