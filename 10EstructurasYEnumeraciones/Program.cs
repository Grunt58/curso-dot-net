namespace _10EstructurasYEnumeraciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instanciamos a la estructura
            Alumno alumno1 = new Alumno();

            // Asignandole valor a un campo
            alumno1.Nombre = "Luis";
            // Mostrando el valor del campo "nombre"
            Console.WriteLine($"El nombre del alumno es: {alumno1.Nombre}");

            // Instanciamos nuevamente a la estructura
            Alumno alumno2 = alumno1;

            // Asignandole un nuevo valor al campo "nombre"
            alumno1.Nombre = "Eric";

            // Mostrando el valor del campo "nombre" para ambas instancias
            Console.WriteLine($"El nombre del alumno en la primera instancia es : {alumno1.Nombre}, y en la segunda instancia es: {alumno2.Nombre}");
        }
    }

    class Alumno
    {
        // Campos
        string nombre;
        string apellido;
        double calificacion;
        bool alergias;
        string numeroTelefono;

        // Creamos una propiedad para Nombre
        public string Nombre { get => nombre; set => nombre = value; } 
    }
}
