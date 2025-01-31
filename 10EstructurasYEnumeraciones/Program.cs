using System.Reflection;

namespace _10EstructurasYEnumeraciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables de tipo "Type"
            Type tipoDatoStruct = typeof(Libro);
            Type tipoDatoClass = typeof(Biblioteca);

            // Propiedad "Name"
            Console.WriteLine($"Nombre del tipo: {tipoDatoStruct.Name}");

            // Propiedad "Fullname"
            Console.WriteLine($"Namespace del tipo: {tipoDatoStruct.Namespace}");


            Console.WriteLine();

            // "FieldInfo", "MethodInfo" y "PropertyInfo"

            // Declaramos una matriz de tipo "FieldInfo"
            FieldInfo[] camposDatoStruct;

            // Asignamos la devolución del método "GetFields" (una matriz con información de los campos) a nuestra matriz "camposDatoStruct"
            camposDatoStruct = tipoDatoStruct.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

            // Recorriendo a la matriz "camposDatoStruct" para mostrar a los campos de "Libro"
            Console.WriteLine("Campos del tip:\n");
            foreach (FieldInfo item in camposDatoStruct)
            {
                Console.WriteLine(item);
            }
        }
    }

    class Biblioteca
    {
        // Campos
        Libro[] libros; //Declaramos una matriz de tipo struct "Libro"
        int cantidadLibros = 0; // No existen libros al inicio del programa
        string buscarLibro;
        bool libroEncontrado;
        int posicionLibroEliminar;

        // Constructor
        public Biblioteca()
        {
            libros = new Libro[1000]; //Inicializamos la matriz con una capacidad de mil elementos
        }

        // Métodos para interactuar con los libros
        public void AgregarLibro()
        {
            if (cantidadLibros < libros.Length) // Verificar si podemos ingresar un nuevo libro
            {
                Console.Clear();
                Console.WriteLine($"Ingresar información para el libro {cantidadLibros + 1}\n"); // Decimos +1 para mostrar un índice que el usuario entienda

                Console.Write("Ingresa el nombre del libro: ");
                libros[cantidadLibros].Titulo = Console.ReadLine();
                Console.Write("Ingresa el Autor: ");
                libros[cantidadLibros].Autor = Console.ReadLine();
                Console.Write("Ingresa el año: ");
                libros[cantidadLibros].Año = Console.ReadLine();

                cantidadLibros++; // Aumentamos la cantidad de libros existentes

                Console.Clear();
                Console.WriteLine("¡Libro agregado correctamente!\n");
            }
            else
            {
                // En caso de que excedamos el número de libros, mostramos este mensaje
                Console.WriteLine("¡Biblioteca llena! Intenta eliminar un libro");
            }
        }

        public void MostrarLibros()
        {
            Console.Clear();

            if (cantidadLibros == 0)
            {
                // Si no existe ningún libro, mostramos el sig. mensaje
                Console.WriteLine("¡Biblioteca vacía! Agrega libros para poder visualizarlos");
            }
            else
            {
                for (int i = 0; i < cantidadLibros; i++) // Si existe al menos uno, mostramos   su información
                {
                    Console.WriteLine($"{i + 1}.- Título = {libros[i].Titulo}, Autor = {libros[i].Autor}, Año = {libros[i].Año}");
                }

                Console.Write("\nPresiona cualquier tecla para continuar... ");
                Console.ReadKey();
                Console.WriteLine(); //Espacio en blanco
            }
        }

        public void BuscarLibro()
        {
            Console.Clear();

            Console.Write("Ingresa el nombre exacto del libro para buscarlo: ");
            buscarLibro = Console.ReadLine();
            libroEncontrado = false;//Inicializamos al campo en "false" para indicar que al iniciar el recorrido por la matriz no hemos encontrado un libro

            for (int i = 0; i < cantidadLibros; i++)
            {
                if (libros[i].Titulo.Equals(buscarLibro))
                {
                    Console.WriteLine($"El libro \"{libros[i].Titulo}\" del autor(a): \"{libros[i].Autor}\" se encuentra disponible en la biblioteca en el índice: {i + 1}");
                    libroEncontrado = true; // Asignamos "true" para indicar que hemos encontrado el libro, y así evitar entrar en el siguiente "if"
                }
            }
            if (!libroEncontrado) //Lo mismo que colocar if(libroEncontrado == false)
            {
                Console.WriteLine("¡Libro no encontrado!\n");
            }
        }

        public void BusquedaParcial()
        {
            Console.Clear();

            Console.Write("Ingresa al menos una parte del título o del nombre del autor de un libro para buscarlo: ");
            buscarLibro = Console.ReadLine().ToLower();

            libroEncontrado = false;//Inicializamos la variable en "false" para indicar que al iniciar el recorrido por la matriz no hemos encontrado un libro

            for (int i = 0; i < cantidadLibros; i++)
            {
                if (libros[i].Titulo.ToLower().Contains(buscarLibro) || libros[i].Autor.ToLower().Contains(buscarLibro))
                {
                    Console.WriteLine($"La palabra \"{buscarLibro}\" fue encontrada en el libro: \"{libros[i].Titulo}\" del autor(a): \"{libros[i].Autor}\" en el índice: {i + 1}");
                    libroEncontrado = true; // Asignamos "true" para indicar que hemos encontrado el libro, y así evitar entrar en el siguiente "if"
                }
            }
            if (!libroEncontrado) //Lo mismo que colocar if(encontrar == false)
            {
                Console.WriteLine("¡No se encontraron coincidencias!\n");
            }

        }

        public void EliminarLibro()
        {
            Console.Clear();

            if (cantidadLibros == 0)
            {
                Console.WriteLine("¡La biblioteca está vacía, no hay nada que eliminar!");
            }
            else
            {
                Console.Write($"Ingrese el número de libro que desea eliminar (Del 1 al {cantidadLibros}): ");
                posicionLibroEliminar = Convert.ToInt32(Console.ReadLine()) - 1; //Decimos que es -1 para que el índice ingresado por el usuario coincida con el índice real de matriz

                // Verificamos que el número ingresado sea válido
                if (posicionLibroEliminar >= 0 && posicionLibroEliminar < cantidadLibros)
                {
                    //Confirmamos si el libro que ingresó es el que quiere eliminar
                    Console.Write($"¿El libro que deseas eliminar es: \"{libros[posicionLibroEliminar].Titulo}\"? (Sí/No): ");
                    string opcion = Console.ReadLine().ToLower();

                    if (opcion == "si")
                    {
                        // Variables para mostrar un mensaje de cuál fue el libro eliminado
                        string tituloEliminado = libros[posicionLibroEliminar].Titulo;
                        string autorEliminado = libros[posicionLibroEliminar].Autor;

                        for (int i = posicionLibroEliminar; i < cantidadLibros; i++)
                        {
                            libros[i] = libros[i + 1];
                        }
                        cantidadLibros--; //Reducimos la cantidad de libros en uno, por el que acabamos de eliminar

                        // Le mostramos al usuario el libro que se eliminó
                        Console.WriteLine($"\n¡El libro \"{tituloEliminado}\" del autor(a): \"{autorEliminado}\" fue eliminado!");
                    }
                    else
                    {
                        Console.WriteLine("Operación \"eliminar libro\" cancelada");
                    }


                }
                else
                {
                    Console.WriteLine("¡El número de libro no es válido!");
                }
            }
        }
    }
    struct Libro
    {
            //Campos
            string titulo;
            string autor;
            string año;

            // Propiedades
            public string Titulo { get => titulo; set => titulo = value; }
            public string Autor { get => autor; set => autor = value; }
            public string Año { get => año; set => año = value; }
    }
}