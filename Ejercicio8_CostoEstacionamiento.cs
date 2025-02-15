using System;

class Ejercicio8_CostoEstacionamiento
{
    static void Main()
    {
        Console.Write("Ingrese el número de horas estacionado: ");
        int horas = int.Parse(Console.ReadLine());

        double total = CalcularCargos(horas);
        Console.WriteLine($"El total a pagar es: ${total:F2}");
    }

    static double CalcularCargos(int horas)
    {
        if (horas <= 3)
            return 2.00;
        else if (horas < 24)
            return 2.00 + (horas - 3) * 0.50;
        else
            return 10.00;
    }
}

