namespace _10EstructurasYEnumeraciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empresa empresa1 = new Empresa();
        }
    }

    // Estructura anidada incrustada
    struct EstructuraPrincipal
    {
        struct EstructuraAnidada
        {

        }
    }

    // Estructura anidada separada
    struct Empleado
    {

    }

    struct Empresa
    {
        // Usamos una estructura como miembro de otra, esto también es una estructura anidada (separada)
        Empleado empleado1;
    }
}
