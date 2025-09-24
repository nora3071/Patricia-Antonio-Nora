using System;

class Program
{
    static bool EsPar(int n)
    {
        return n % 2 == 0;
    }

    static void Main()
    {
        Console.Write("Ingrese un número: ");
        int n = int.Parse(Console.ReadLine());

        if (EsPar(n))
            Console.WriteLine("El número es par.");
        else
            Console.WriteLine("El número es impar.");
    }
}

