using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_2025_I_EJERCICIO3_TAREA2_GRUPO1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        {
      
                {
                Console.WriteLine("Ingrese el total de la compra:");
                double totalCompra = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el tipo de membresía (A, B, C):");
                char tipoMembresía = char.ToUpper(Console.ReadLine()[0]);

                double descuento = 0.0;

                switch (tipoMembresía)
                {
                    case 'A':
                        descuento = 0.10;
                        break;
                    case 'B':
                        descuento = 0.15;
                        break;
                    case 'C':
                        descuento = 0.20;
                        break;
                    default:
                        Console.WriteLine("Tipo de membresía no válido. No se aplicará descuento.");
                        break;
                }

                double totalConDescuento = totalCompra - (totalCompra * descuento);

                Console.WriteLine($"Total de la compra: {totalCompra:C}");
                Console.WriteLine($"Descuento aplicado: {descuento * 100}%");
                Console.WriteLine($"Total a pagar: {totalConDescuento:C}");
            }
        }

    }
}
}
