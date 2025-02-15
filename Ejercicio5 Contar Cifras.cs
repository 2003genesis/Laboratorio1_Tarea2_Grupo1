using System;

class Ejercicio5 Contar Cifras
{
    static void Main()
    {
        Console.Write("Ingrese un número: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero >= 0 && numero < 10)
            Console.WriteLine("1");
        else if (numero >= 10 && numero < 100)
            Console.WriteLine("2");
        else if (numero >= 100 && numero < 1000)
            Console.WriteLine("3");
        else if (numero >= 1000 && numero < 10000)
            Console.WriteLine("4");
        else
            Console.WriteLine("Mayor a 5");
    }
}
