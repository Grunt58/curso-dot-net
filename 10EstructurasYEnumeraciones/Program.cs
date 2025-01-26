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
    }
}
