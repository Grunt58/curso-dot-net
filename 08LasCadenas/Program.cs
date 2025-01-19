using System.Globalization;
using System.Security;
using System.Text;

namespace _08LasCadenas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * De entre 8-20 caracteres
             * Van a contener al menos una letra minúscula
             * Una letra mayúscula
             * Un número
             * Y un carácter especial de entre seis posibles opciones
             */

            // Variables necesarias
            string nombreUsuario, opcion, contraseña;
            // Declaramos un tupla de nombre "verificarContraseña" para que reciba dos valores del método que valida la contraseña
            (bool contraseñaValida, string mensajeError) verificarContraseña;

            // Un título para el programa
            Console.WriteLine("\t\tRegistro\n\n");

            // Pedimos el nobre de usuario
            Console.Write("Ingrese un nombre de usuario: ");
            nombreUsuario = Console.ReadLine();

            // Preguntamos si se desea hacer uso del generador de contraseñas o escribir una nosotros mismos
            Console.Write("¿Desdea que le generemos una contraseña segura? (si/no)");
            opcion = Console.ReadLine();
            opcion = opcion.ToLower(); // Convertimos a minúscula la respuesta del usuario (en caso de que use mayúscula o una combinación de ambas)

            // Seguimos una de las sdos posible rutas
            switch (opcion)
            {
                case "si":
                    // Instanciamos a la clase Contraseña para poder hacer uso de ella
                    Contraseña contraseña1 = new Contraseña();

                    // Llamos a su método "GenerarContraseña" y le asignamos lo que devuelve a nuestra variable local "contraseña1"
                    contraseña = contraseña1.GenerarContraseña();

                    Console.WriteLine($"Esta es la contraseña que generamos para ti, guárdala en un lugar seguro: {contraseña}");

                    Console.Write("\nPresiona cualquier tecla para termianr tu registro ");
                    Console.ReadKey();
                    Console.Clear();

                    // Mostramos un resumen de los datos
                    Console.WriteLine($"\nTus datos de acceso son los siguientes:\n\tususario: {nombreUsuario}\n\tcontraseña: {contraseña}");

                    break;

                case "no":
                    Console.Write("\nIngrese una contraseña segura (La contraseña debe contener entre 8-20 caracteres, incluido un número, una mayúscula, una minúscula y uno de los siguientes caracteres especiales: $%#&!?): ");
                    contraseña = Console.ReadLine();

                    // Instanciamos a la clase Contraseña para poder hacer uso de ella
                    Contraseña contraseña2 = new Contraseña();

                    // Le asignamos a la tupla lo que devuelva el método "Compobar contraseña" y también le mandamos como argumento a la variable local "contraseña"
                    verificarContraseña = contraseña2.ComprobarContraseña(contraseña);
                    
                    // Si el primer elemento de la tupla (bool contraseñavalida) es "true", entonces ingresamos al "if"
                    if (verificarContraseña.contraseñaValida)
                    {
                        Console.Write("\nPresiona cualquier tecla para termianr tu registro ");
                        Console.ReadKey();
                        Console.Clear();

                        // Mostramos un resumen de los datos
                        Console.WriteLine($"\nTus datos de acceso son los siguientes:\n\tususario: {nombreUsuario}\n\tcontraseña: {contraseña}");
                    }
                    // De lo contrario mostramos el mensaje de error devuelto por el método y agregamos uno extra
                    else
                    {
                        // Usamos al segundo elemento de la tupla (mensajeError) al que se le asigno una de las devoluciones del método, para después mostrarlo
                        Console.WriteLine($"{verificarContraseña.mensajeError}. Ingresa una contraseña válida.");
                    }
                    break;
            }
        }
    }

    // Se crea una clase específicamente para manejar los campos y métodos que van a generar la contraseña
    class Contraseña
    {
        // CAMPOS
        // 4 colecciones de caracteres para escoger y generar la contraseña
        string numeros = "0123456789";
        string letrasMin = "abcdefghijklmnopqrstuvwxyz";
        string letrasMay = "ABCDEFGHIJKLMNOPQRSTUVWXY";
        string caracterEspecial = "$%#&!?";
        // Contadores para verificar el número de caracteres de cada grupo
        int numContiene = 0, minContiene = 0, mayContiene = 0, espContiene = 0;

        // Método para generar la contraseña
        public string GenerarContraseña()
        {
            // Aquí guardaremos la contraseña
            string contraseñaGenerada = "";

            // Instanciamos a la clase Random para usarla más adelante
            Random random = new Random();

            // Declaramos una variable que guarda el tamaño que tendrá la contraseña, generamos un número aleatorio para determinar una longitud de entre 8 y 20 caracteres y se lo asignamos a la variable
            int longtudContraseña = random.Next(8, 21);

            double numTener = longtudContraseña * .15; // El 15% de los carácteres serán números
            double minTener = longtudContraseña * .35;
            double mayTener = longtudContraseña * .35;
            double espTener = longtudContraseña * .15;

            // Variable de tipo char que va a almacenar a cada uno de los caracteres que van a conformar a la contraseña
            char caracterEscogido;

            // Usamos una iteración while para ir colocando un carácter (de los 4 del grupo) hasta que completemos la longitud que se estableció anteriormente
            while (contraseñaGenerada.Length < longtudContraseña)
            {
                // Volvemos a usar un número aleatorio, esta vez para seleccionar uno de los 4 grupos de string que tenemos
                switch (random.Next(0, 4))
                {
                    case 0:
                        // Se los caracteres numéricos que contiene la contraseña son menores a los que debe contener, entonces ingresa al bloque de código y los genera.
                        if (numContiene < numTener)
                        {
                            /*
                             * A "caracterEscogido" se le va a asignar un carácter aleatorio de los contenidos en el string "numeros", basandose en el índice y apoyándose de la propiedad "Length". Ejem:
                             * caracterEscogido = numeros[random.Next(10)] // Porque son diez elemenros
                             * caracterEscogido = numeros[3] // Tomaría el cuarto carácter
                             */
                            caracterEscogido = numeros[random.Next(numeros.Length)];
                            // Se le acumula el carácter escogido por Random a la contraseña generada
                            contraseñaGenerada += caracterEscogido;
                            // Se acumula en 1 a los caracteres numéricos que contiene la contraseña
                            numContiene++;
                        }
                    break;

                    case 1:                        
                        if (minContiene < minTener)
                        {
                            caracterEscogido = letrasMin[random.Next(letrasMin.Length)];
                            contraseñaGenerada += caracterEscogido;
                            minContiene++;
                        }
                        break;

                    case 2:
                        if (mayContiene < mayTener)
                        {
                            caracterEscogido = letrasMay[random.Next(letrasMay.Length)];
                            contraseñaGenerada += caracterEscogido;
                            mayContiene++;
                        }
                    break;

                    case 3:
                        if (espContiene < espTener)
                        {
                            caracterEscogido = caracterEspecial[random.Next(caracterEspecial.Length)];
                            contraseñaGenerada += caracterEscogido;
                            espContiene++;
                        }
                     break;
                }
            }
            return contraseñaGenerada;
        }

        // Método para comprobar contraseña
        public (bool, string) ComprobarContraseña(string contraseñaPa)
        {
            // Variable que guardará el valor bool cuando compruebe todas las caracteristicas de la contraseña
            bool contraseñaValida = false;

            // Variables para cada criterio de la contraseña
            bool hayNumero = false, hayMinuscula = false, hayMayuscula = false, hayEspecial = false;

            // Variable que contendrá el mensaje de error
            string mensajeError = "";

            // Verificar primero que se cumple la longitud
            if (contraseñaPa.Length >= 8 && contraseñaPa.Length <= 20)
            {
                // Verificamos que contengaal menos un número
                foreach (char elemento in numeros)
                {
                    // Si el elemento de "números" se encuentra en la contraseña dede por el usuario, entonces se ingresa al "if" y "esNumero" se convierte en "true"
                    if (contraseñaPa.IndexOf(elemento) >= 0)
                    {
                        hayNumero = true;
                        break; // La instrucción "break" fuerza la terminación del foreach en el momento en que se encuentra un número, lo que significa que el "if" se cumple
                    }
                    else
                    {
                        hayNumero = false;
                        mensajeError = "La contraseña debe contener al menos un número";
                    }
                }
                // Verificamos que haya existido un número en la contraseña
                if (hayNumero)
                {
                    // Verificamos que contenga al menos una letra minúscula
                    foreach (char elemento in letrasMin)
                    {
                        if (contraseñaPa.IndexOf(elemento) >= 0)
                        {
                            hayMinuscula = true;
                            break;
                        }
                        else
                        {
                            hayMinuscula = false;
                            mensajeError = "La contraseña debe contener al menos una letra minúscula";
                        }
                    }
                    if (hayMinuscula)
                    {
                        // Verificamos que contenga al menos una letra mayúscula
                        foreach (char elemento in letrasMay)
                        {
                            if (contraseñaPa.IndexOf(elemento) >= 0)
                            {
                                hayMayuscula = true;
                                break;
                            }
                            else
                            {
                                hayMayuscula = false;
                                mensajeError = "La contraseña debe contener al menos una letra mayúscula";
                            }
                        }
                        if (hayMayuscula)
                        {
                            // Verificamos que contenga al menos un carácter especial
                            foreach (char elemento in caracterEspecial)
                            {
                                if (contraseñaPa.IndexOf(elemento) >= 0)
                                {
                                    hayEspecial = true;
                                    break;
                                }
                                else
                                {
                                    hayEspecial = false;
                                    mensajeError = "La contraseña debe contener al menos un carácter especial ($%#&!?)";
                                }
                            }
                        }
                    }
                }
                // Verificamos que exista un número, una letra minúscula, una mayúscula y un carácter especial
                if (hayNumero && hayMinuscula && hayMayuscula && hayEspecial)
                {
                    // Si la contraseña cumple con todos los requisitos, entonces devolvemos un "true"
                    contraseñaValida = true;
                }
                else
                {
                    // Si la contraseña no cumple con los requisitos mínimos, entonces devolvemos un "false"
                    contraseñaValida = false;
                }
            }
            else
            {
                // Si al contraseña no cumple si quiera con la longitud requerida, entonces se lo indicamos al usuario
                mensajeError = "La contraseña debe contener entre 8-20 caracteres";
                contraseñaValida = false;
            }
            // Devolvemos una tupla conformada por el booleano de la contraseña y por el mensaje de error
            return (contraseñaValida, mensajeError);
        }
    }
}
