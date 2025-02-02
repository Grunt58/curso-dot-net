﻿using System.IO;
using System.Text;

namespace _11FlujosYArchivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creamos un flujo/stream para trabajar con la memoria RAM
            MemoryStream ms1 = new MemoryStream();

            // Mostrando la capacidad, longitud y posición del puntero del stream
            InformacionStream(ms1);

            // Le pedimos al ususario una cadena para guardar en el stream
            Console.Write("Ingresa un texto para guardarlo en el stream: ");
            string cadena1 = Console.ReadLine();

            byte[] matrizCadenaByte;

            // Codificar: string -> secuencia de bytes
            // Descodificar: secuencia de bytes -> string

            // Codificamos a cadena1 para obtener una secuenda de bytes
            matrizCadenaByte = Encoding.UTF8.GetBytes(cadena1);

            // Escribiendo datos en el flujo
            ms1.Write(matrizCadenaByte, 0, matrizCadenaByte.Length);

            // Mostrando la capacidad, longitud y posición del puntero del stream
            InformacionStream(ms1);

            // Cambiamos la posición del puntero
            ms1.Seek(-4, SeekOrigin.End);

            // Mostramos la posición del puntero
            Console.WriteLine($"\tLa nueva posición del puntero después de usar Seek, es: {ms1.Position}\n");

            // Creamos una nueva matriz de bytes para que guarde la codificación de una cadena
            byte[] nuevaMatrizCadenaByte = Encoding.UTF8.GetBytes("llena");

            // Escribimos la nueva cadena ya codificada en el flujo
            ms1.Write(nuevaMatrizCadenaByte, 0, nuevaMatrizCadenaByte.Length);

            // Indicamos que ya fue escrita la segunda cadena
            Console.WriteLine("Después de escribir la segunda cadena...");

            // Mostramos la capacidad, longitud,y posición del puntero del stream
            InformacionStream(ms1);
        }

        static void InformacionStream(MemoryStream ms1Pa)
        {
            Console.WriteLine($"\nCapacidad: {ms1Pa.Capacity}");
            Console.WriteLine($"Longitud: {ms1Pa.Length}");
            Console.WriteLine($"Posición del puntero: {ms1Pa.Position}\n");
        }
    }
}
