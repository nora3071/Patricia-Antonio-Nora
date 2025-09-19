using System;

class Program
{
    static double CalcularAreaTriangulo(double b, double h)
    {
        return (b * h) / 2;
    }

    static void Main()
    {
        Console.Write("Ingrese la base del triángulo: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Ingrese la altura del triángulo: ");
        double h = double.Parse(Console.ReadLine());

        double area = CalcularAreaTriangulo(b, h);
        Console.WriteLine($"El área del triángulo es: {area}");
    }
}

