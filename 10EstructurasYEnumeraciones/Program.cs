namespace _10EstructurasYEnumeraciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instanciamos a ListaReproduccion
            ListaReproduccion listaReproduccion1 = new ListaReproduccion();

            // Nombramos la lista
            listaReproduccion1.Nombre = "Clasicos";

            // Agregamos información a las canciones contenidas en la Lista de Reproducción
            listaReproduccion1.cancion1.Titulo = "Bohemian Rhapsody";
            listaReproduccion1.cancion1.Artista = "Queen";
            listaReproduccion1.cancion1.Duracion = 355;

            listaReproduccion1.cancion2.Titulo = "Viva las Vegas";
            listaReproduccion1.cancion2.Artista = "Elvis Presley";
            listaReproduccion1.cancion2.Duracion = 141;

            // Mostramos la información de la lista
            Console.WriteLine(listaReproduccion1.ToString());

        }
    }

    struct Cancion
    {
        // Campos
        string titulo;
        string artista;
        int duracion;

        // Propiedades
        public string Titulo { get => titulo; set => titulo = value; }
        public string Artista { get => artista; set => artista = value; }
        public int Duracion { get => duracion; set => duracion = value; }

        // Invalidamos el método ToString para mostrar la información de la struct
        public override string ToString()
        {
            string mensaje = $"Título: {Titulo}\nArtista: {Artista}\nDuración: {Duracion} segundos";
            return mensaje;
        }
    }

    struct ListaReproduccion
    {
        // Campos
        string nombre;

        // Propiedades
        public string Nombre { get => nombre; set => nombre = value; }

        // Anidamos a la struct "Cancion"
        public Cancion cancion1;
        public Cancion cancion2;

        public override string ToString()
        {
            string mensaje = $"Lista de reproducción: {Nombre}\n\nCanción 1:\n{cancion1.ToString()}\nCanción 2:\n{cancion2.ToString()}";
            return mensaje;
        }
    }
}