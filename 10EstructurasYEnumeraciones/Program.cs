﻿using System.Reflection;

namespace _10EstructurasYEnumeraciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 2;
            // Variable que va a guardar la opción del menú
            OpcionesMenu opcion;

            Console.WriteLine("[1]: Suma");
            Console.WriteLine("[2]: Resta");
            Console.WriteLine("[3]: Multiplicacion");
            Console.WriteLine("[4]: División");

            Console.Write("Elige una opción: ");
            opcion = (OpcionesMenu)Enum.Parse(typeof(OpcionesMenu), Console.ReadLine());

            switch (opcion)
            {
                case OpcionesMenu.Suma:
                    Console.WriteLine($"{a} + {b} = {a + b}");
                    break;
                case OpcionesMenu.Resta:
                    Console.WriteLine($"{a} - {b} = {a - b}");
                    break;
                case OpcionesMenu.Multiplicacion:
                    Console.WriteLine($"{a} * {b} = {a * b}");
                    break;
                case OpcionesMenu.Division:
                    Console.WriteLine($"{a} / {b} = {a / b}");
                    break;
            }
        }
    }

    enum OpcionesMenu
    {
        Suma = 1,
        Resta,
        Multiplicacion,
        Division
    }
}