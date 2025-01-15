namespace _08LasCadenas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instanciando a String por medio del alias "string"
            string cadena1 = ""; // 0 caracteres
            string cadena2 = " "; // El 'espacio' representa un caracter
            string cadena3 = "Hola mundo";

            char[] caracteres = { 'H', 'o', 'l', 'a' };
            // Creando una instancia de String
            String cadenaDeCaracteres = new string(caracteres);

            // Imprimiendo la instancia
            Console.WriteLine(cadenaDeCaracteres);
        }
    }
}
