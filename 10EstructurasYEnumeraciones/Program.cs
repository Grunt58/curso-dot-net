namespace _10EstructurasYEnumeraciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creamos y asignamos instnacias a la matriz en una sola sintaxis
            Producto[] televisiones = new Producto[]
            {
                new Producto { Nombre = "Samsung Neo", Precio = 25000.0, Descripcion = "Televisor OLED de 55 pulgadas" },
                new Producto { Nombre = "LG Smart TV", Precio = 19000.0, Descripcion = "Televisor Smart de 50 pulgadas" },
                new Producto { Nombre = "sony Bravia", Precio = 22000.0, Descripcion = "Televisor OLED de 65 pulgadas" }
            };

            // Mostrando la información de los elementos de la matriz
            foreach (Producto item in televisiones)
            {
                // Accede a las propiedades de cada instancia de Producto
                Console.WriteLine($"Nombre: {item.Nombre}\nPrecio: {item.Precio}\nDescripción: {item.Descripcion}\n");
            }
        }
    }

    struct Producto
    {
        // Campos
        string nombre;
        double precio;
        string descripcion;

        public string Nombre { get => nombre; set => nombre = value; }
        public double Precio { get => precio; set => precio = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}