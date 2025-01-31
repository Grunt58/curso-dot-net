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

            // Mostrando información de la clase "Biblioteca"
            Console.WriteLine("\n--------------------------\n");
            Console.WriteLine($"El nombre completo del tipo es: {tipoDatoClass.FullName}");

            // Matrices donde se guardara la información devuelta por los métodos "GetProperties" y "GetMethods"
            MethodInfo[] metodosDatoClass; // Para los métodos
            PropertyInfo[] propiedadesDatoClass; // Para las propiedades

            // Usamos a "GetProperties" para obtener la infomancíón de las propiedades de nuestra clase, y almacenamos su devolución en la matriz "propiedadesDatoClass"
            propiedadesDatoClass = tipoDatoClass.GetProperties();

            // Usamos a "GetMethods" para obtener la infomancíón de las métodos de nuestra clase, y almacenamos su devolución en la matriz "metodosDatoClass"
            metodosDatoClass = tipoDatoClass.GetMethods();

            // Recorriendo a la matriz "propiedadesDatoClass" para mostrar a las propiedades de "Biblioteca"
            Console.WriteLine("\nPropiedades del tipo:\n");
            foreach (PropertyInfo item in propiedadesDatoClass)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            // Recorriendo a la matriz "metodosDatoClass" para mostrar a los métodos de "Biblioteca"
            Console.WriteLine("Métodos del tipo:\n");
            foreach (MethodInfo item in metodosDatoClass)
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

        public Libro[] Libros { get => libros; set => libros = value; }
        public int CantidadLibros { get => cantidadLibros; set => cantidadLibros = value; }
        public string BuscarLibro1 { get => buscarLibro; set => buscarLibro = value; }
        public bool LibroEncontrado { get => libroEncontrado; set => libroEncontrado = value; }
        public int PosicionLibroEliminar { get => posicionLibroEliminar; set => posicionLibroEliminar = value; }

        // Constructor
        public Biblioteca()
        {
            Libros = new Libro[1000]; //Inicializamos la matriz con una capacidad de mil elementos
        }

        // Métodos para interactuar con los libros
        public void AgregarLibro()
        {
            if (CantidadLibros < Libros.Length) // Verificar si podemos ingresar un nuevo libro
            {
                Console.Clear();
                Console.WriteLine($"Ingresar información para el libro {CantidadLibros + 1}\n"); // Decimos +1 para mostrar un índice que el usuario entienda

                Console.Write("Ingresa el nombre del libro: ");
                Libros[CantidadLibros].Titulo = Console.ReadLine();
                Console.Write("Ingresa el Autor: ");
                Libros[CantidadLibros].Autor = Console.ReadLine();
                Console.Write("Ingresa el año: ");
                Libros[CantidadLibros].Año = Console.ReadLine();

                CantidadLibros++; // Aumentamos la cantidad de libros existentes

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

            if (CantidadLibros == 0)
            {
                // Si no existe ningún libro, mostramos el sig. mensaje
                Console.WriteLine("¡Biblioteca vacía! Agrega libros para poder visualizarlos");
            }
            else
            {
                for (int i = 0; i < CantidadLibros; i++) // Si existe al menos uno, mostramos   su información
                {
                    Console.WriteLine($"{i + 1}.- Título = {Libros[i].Titulo}, Autor = {Libros[i].Autor}, Año = {Libros[i].Año}");
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
            BuscarLibro1 = Console.ReadLine();
            LibroEncontrado = false;//Inicializamos al campo en "false" para indicar que al iniciar el recorrido por la matriz no hemos encontrado un libro

            for (int i = 0; i < CantidadLibros; i++)
            {
                if (Libros[i].Titulo.Equals(BuscarLibro1))
                {
                    Console.WriteLine($"El libro \"{Libros[i].Titulo}\" del autor(a): \"{Libros[i].Autor}\" se encuentra disponible en la biblioteca en el índice: {i + 1}");
                    LibroEncontrado = true; // Asignamos "true" para indicar que hemos encontrado el libro, y así evitar entrar en el siguiente "if"
                }
            }
            if (!LibroEncontrado) //Lo mismo que colocar if(libroEncontrado == false)
            {
                Console.WriteLine("¡Libro no encontrado!\n");
            }
        }

        public void BusquedaParcial()
        {
            Console.Clear();

            Console.Write("Ingresa al menos una parte del título o del nombre del autor de un libro para buscarlo: ");
            BuscarLibro1 = Console.ReadLine().ToLower();

            LibroEncontrado = false;//Inicializamos la variable en "false" para indicar que al iniciar el recorrido por la matriz no hemos encontrado un libro

            for (int i = 0; i < CantidadLibros; i++)
            {
                if (Libros[i].Titulo.ToLower().Contains(BuscarLibro1) || Libros[i].Autor.ToLower().Contains(BuscarLibro1))
                {
                    Console.WriteLine($"La palabra \"{BuscarLibro1}\" fue encontrada en el libro: \"{Libros[i].Titulo}\" del autor(a): \"{Libros[i].Autor}\" en el índice: {i + 1}");
                    LibroEncontrado = true; // Asignamos "true" para indicar que hemos encontrado el libro, y así evitar entrar en el siguiente "if"
                }
            }
            if (!LibroEncontrado) //Lo mismo que colocar if(encontrar == false)
            {
                Console.WriteLine("¡No se encontraron coincidencias!\n");
            }

        }

        public void EliminarLibro()
        {
            Console.Clear();

            if (CantidadLibros == 0)
            {
                Console.WriteLine("¡La biblioteca está vacía, no hay nada que eliminar!");
            }
            else
            {
                Console.Write($"Ingrese el número de libro que desea eliminar (Del 1 al {CantidadLibros}): ");
                PosicionLibroEliminar = Convert.ToInt32(Console.ReadLine()) - 1; //Decimos que es -1 para que el índice ingresado por el usuario coincida con el índice real de matriz

                // Verificamos que el número ingresado sea válido
                if (PosicionLibroEliminar >= 0 && PosicionLibroEliminar < CantidadLibros)
                {
                    //Confirmamos si el libro que ingresó es el que quiere eliminar
                    Console.Write($"¿El libro que deseas eliminar es: \"{Libros[PosicionLibroEliminar].Titulo}\"? (Sí/No): ");
                    string opcion = Console.ReadLine().ToLower();

                    if (opcion == "si")
                    {
                        // Variables para mostrar un mensaje de cuál fue el libro eliminado
                        string tituloEliminado = Libros[PosicionLibroEliminar].Titulo;
                        string autorEliminado = Libros[PosicionLibroEliminar].Autor;

                        for (int i = PosicionLibroEliminar; i < CantidadLibros; i++)
                        {
                            Libros[i] = Libros[i + 1];
                        }
                        CantidadLibros--; //Reducimos la cantidad de libros en uno, por el que acabamos de eliminar

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