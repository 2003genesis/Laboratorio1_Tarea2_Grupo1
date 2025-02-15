using System;

class Ejercicio7_Vocales
{
    static void Main()
    {
        Console.Write("Ingrese un carácter: ");
        char c = char.ToLower(Console.ReadKey().KeyChar);
        Console.WriteLine();

        if ("aeiou".Contains(c))
            Console.WriteLine("Es una vocal.");
        else
            Console.WriteLine("No es una vocal.");
    }
}
