// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        MostrarTablaMultiplicar(); // Llamada al procedimiento
        Console.ReadKey();
    }

    // Procedimiento: pide datos y muestra la tabla
    static void MostrarTablaMultiplicar()
    {
        Console.Write("Ingrese un número para generar la tabla de multiplicar con el numero asignado: ");
        int numero = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el límite hasta donde desea que termine la tabla de multiplicar: ");
        int limite = int.Parse(Console.ReadLine());

        Console.WriteLine($"\nTabla de multiplicar del {numero} hasta {limite}:");

        for (int i = 1; i <= limite; i++)
        {
            Console.WriteLine($"{numero} x {i} = {numero * i}");
        }
    }
}

