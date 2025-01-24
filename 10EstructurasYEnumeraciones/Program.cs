namespace _10EstructurasYEnumeraciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Conjunto de datos pequeños y específicos
            // Datos formen parte de un objeto aún más grandes

            Transferencia transferencia1 = new Transferencia();
            transferencia1.fecha = DateTime.Now;
            transferencia1.monto = 1000;
            transferencia1.destinatario = "José Enrique";
            transferencia1.numeroCuenta = "3498309888";
            transferencia1.concepto = "Pago del préstamo";

            Console.WriteLine(transferencia1.ToString());
        }
    }

    struct Transferencia
    {
        public DateTime fecha;
        public double monto;
        public string destinatario;
        public string numeroCuenta;
        public string concepto;

        public override string ToString()
        {
            string mensaje;

            mensaje = $"Fecha: {fecha.ToString()} \nMonto: ${monto} \nDestinatario: {destinatario} \nNúmero de cuenta: {numeroCuenta} \nConcepto: {concepto}";

            return mensaje;
        }
    }
}
