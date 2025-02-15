using System;

class Ejercicio6_Totalproductos
{
    static void Main()
    {
        double[] precios = { 2.98, 4.50, 9.98, 4.49, 6.87 };
        double total = 0;

        while (true)
        {
            Console.Write("Ingrese el número del producto (1-5) o 0 para salir: ");
            int producto = int.Parse(Console.ReadLine());

            if (producto == 0)
                break;

            Console.Write("Ingrese la cantidad vendida: ");
            int cantidad = int.Parse(Console.ReadLine());

            if (producto >= 1 && producto <= 5)
                total += precios[producto - 1] * cantidad;
            else
                Console.WriteLine("Producto no válido.");
        }

        Console.WriteLine($"El total de ventas es: ${total:F2}");
    }
}

