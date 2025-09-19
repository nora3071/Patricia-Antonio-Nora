using System;

class Program
{
    static double CalcularIVA(double cantidad, double precioUnitario)
    {
        return cantidad * precioUnitario * 0.15;
    }

    static double CalcularTotal(double cantidad, double precioUnitario)
    {
        double subtotal = cantidad * precioUnitario;
        double iva = CalcularIVA(cantidad, precioUnitario);
        return subtotal + iva;
    }

    static void Main()
    {
        Console.Write("Ingrese la cantidad de productos: ");
        double cantidad = double.Parse(Console.ReadLine());

        Console.Write("Ingrese el precio unitario: ");
        double precio = double.Parse(Console.ReadLine());

        double iva = CalcularIVA(cantidad, precio);
        double total = CalcularTotal(cantidad, precio);

        Console.WriteLine($"IVA (15%): {iva}");
        Console.WriteLine($"Total a pagar: {total}");
    }
}
