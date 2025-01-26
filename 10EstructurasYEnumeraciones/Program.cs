namespace _10EstructurasYEnumeraciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear instancias de la estructura Cliente
            Cliente cliente1 = new Cliente();
            cliente1.nombre = "Juan";
            cliente1.edad = 30;
            cliente1.direccion = "Calle Lirios 5";

            Cliente cliente2 = new Cliente();
            cliente2.nombre = "Maria";
            cliente2.edad = 25;
            cliente2.direccion = "Av. Reforma 354";

            // Instanciamos a la clase
            RegistroClientes registro1 = new RegistroClientes();

            // Registrar clientes a traves del método
            registro1.RegistrarCliente(cliente1);
            registro1.RegistrarCliente(cliente2);

            // Mostrar lista de clientes registrados
            registro1.MostrarClientesRegistrados();
            
        }
    }
    
    struct Cliente
    {
        public string nombre;
        public int edad;
        public string direccion;
    }

    class RegistroClientes
    {
        // Declaramos una lista generica para guardar a los clientes
        List<Cliente> listaClientes = new List<Cliente>();

        // Método para registrar clientes
        public void RegistrarCliente(Cliente cliente)
        {
            listaClientes.Add(cliente);
        }

        // Método para mostrar clientes
        public void MostrarClientesRegistrados()
        {
            Console.WriteLine("Lista de clientes registrados:\n");
            foreach (var cliente in listaClientes)
            {
                Console.WriteLine($"Nombre: {cliente.nombre}");
                Console.WriteLine($"Edad: {cliente.edad}");
                Console.WriteLine($"Dirección: {cliente.direccion}");
                Console.WriteLine("----------------------------");

            }
        }
    }
}
