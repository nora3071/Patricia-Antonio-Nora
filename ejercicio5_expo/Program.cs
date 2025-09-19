// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        while (true) // bucle principal
        {
            Console.Write("Ingrese una palabra: ");
            string palabra = Console.ReadLine();

            if (EsPalindromo(palabra))
                Console.WriteLine($" \"{palabra}\" es un palíndromo.");
            else
                Console.WriteLine($" \"{palabra}\" no es un palíndromo.");

            // Preguntar si desea salir
            Console.Write("\n¿Desea salir? (s/n): ");
            string opcion = Console.ReadLine().ToLower();

            if (opcion == "s" || opcion == "si")
            {
                Console.WriteLine(" Programa finalizado.");
                break; // salir del bucle
            }

            Console.WriteLine(); // línea en blanco para orden
        }
    }

    // ====== FUNCIÓN ======
    static bool EsPalindromo(string texto)
    {
        // Normalizar: pasar a minúsculas y quitar espacios
        string limpio = texto.ToLower().Replace(" ", "");

        int i = 0;
        int j = limpio.Length - 1;

        while (i < j)
        {
            if (limpio[i] != limpio[j])
                return false;

            i++;
            j--;
        }

        return true;
    }
}

