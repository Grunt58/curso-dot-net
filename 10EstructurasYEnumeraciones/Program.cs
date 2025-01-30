using System.Linq.Expressions;

namespace _10EstructurasYEnumeraciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creamos un estudiante
            Estudiante estudiante1 = new Estudiante();

            // Le asignamos nomre y apellido
            estudiante1.Nombre = "Luis";
            estudiante1.Apellido = "Dominguez";

            // Creamos la matriz
            Calificacion[] calificaciones = {
                new Calificacion { Materia = "Matemáticas", Puntaje = 9},
                new Calificacion { Materia = "Historia", Puntaje = 8.5 },
                new Calificacion { Materia = "Física", Puntaje = 7 }
            };

            // Asignamos la matriz "calificaciones" a nuestro estudiante1
            estudiante1.Calificaciones = calificaciones;

            // Mostrar los datos del estudiante y sus calificaciones
            Console.WriteLine($"Nombre: {estudiante1.Nombre} {estudiante1.Apellido}");
            foreach (Calificacion item in estudiante1.Calificaciones)
            {
                Console.WriteLine($"{item.Materia} = {item.Puntaje}");
            }
        }
    }

    struct Calificacion
    {
        // Campos
        string materia;
        double puntaje;

        // Propiedades
        public string Materia { get => materia; set => materia = value; }
        public double Puntaje { get => puntaje; set => puntaje = value; }
    }

    struct Estudiante
    {
        // Campos
        string nombre;
        string apellido;
        Calificacion[] calificaciones;

        // Campos
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public Calificacion[] Calificaciones { get => calificaciones; set => calificaciones = value; }
    } 
}