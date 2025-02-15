using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_2025_1_EJERCICIO1_TAREA_2_GRUPO1
{
    internal class Program
    {
        static void Main(string[] args)
        {

        {
                {
                Console.WriteLine("Ingrese el número de camisas que desea comprar:");
                int cantidadCamisas = int.Parse(Console.ReadLine());
                double precioCamisa = 100.0;
                double descuento = 0.0;

                if (cantidadCamisas > 30)
                {
                    descuento = 0.40;
                }
                else if (cantidadCamisas > 20)
                {
                    descuento = 0.20;
                }
                else if (cantidadCamisas > 10)
                {
                    descuento = 0.10;
                }

                double totalCompra = cantidadCamisas * precioCamisa;
                double totalConDescuento = totalCompra - (totalCompra * descuento);

                Console.WriteLine("El total de su compra con descuento es: " + totalConDescuento);
            }
        }

    }
}
}
