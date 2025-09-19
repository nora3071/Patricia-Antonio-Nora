using System;

class Program
{
    static void Intercambiar(ref int x, ref int y)
    {
        int temp = x;
        x = y;
        y = temp;
    }

    static void Main()
    {
        Console.Write("Ingrese el valor de x: ");
        int x = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el valor de y: ");
        int y = int.Parse(Console.ReadLine());

        Console.WriteLine($"\nAntes del intercambio: x = {x}, y = {y}");

        Intercambiar(ref x, ref y);

        Console.WriteLine($"Después del intercambio: x = {x}, y = {y}");
    }
}
