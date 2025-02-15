using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_2025_I_EJERCICIO4_TAREA2_GRUPO1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        {
            {
                while (true)
                {
                    Console.WriteLine("Ingrese el nombre del empleado (o 'salir' para terminar):");
                    string nombreEmpleado = Console.ReadLine();

                    if (nombreEmpleado.ToLower() == "salir")
                        break;

                    Console.WriteLine("Ingrese el número de horas trabajadas la semana pasada:");
                    double horasTrabajadas = double.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese la tarifa por hora del empleado:");
                    double tarifaPorHora = double.Parse(Console.ReadLine());

                    double sueldoBruto;

                    if (horasTrabajadas <= 40)
                    {
                        sueldoBruto = horasTrabajadas * tarifaPorHora;
                    }
                    else
                    {
                        double horasExtras = horasTrabajadas - 40;
                        sueldoBruto = (40 * tarifaPorHora) + (horasExtras * tarifaPorHora * 1.5);
                    }

                    Console.WriteLine($"Sueldo bruto de {nombreEmpleado}: {sueldoBruto:C}");
                    Console.WriteLine();
                }
            }
        }

    }
}
}
