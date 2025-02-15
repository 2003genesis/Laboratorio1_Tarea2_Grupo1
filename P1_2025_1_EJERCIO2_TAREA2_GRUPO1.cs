using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_2025_1EJERCIO2_TAREA02_GRUPO1
{
    internal class P1_2025_1_EJERCIO2_TAREA2_GRUPO1
    {
        static void Main(string[] args)
        {
        {
            {
                while (true)
                {
                    // Solicitar datos del cliente
                    Console.Write("Ingrese el número de cuenta (o -1 para terminar): ");
                    int numeroCuenta = int.Parse(Console.ReadLine());

                    if (numeroCuenta == -1)
                    {
                        break; // Salir del bucle si el usuario ingresa -1
                    }

                    Console.Write("Ingrese el saldo al inicio del mes: ");
                    decimal saldoInicial = decimal.Parse(Console.ReadLine());

                    Console.Write("Ingrese el total de artículos cargados por el cliente en el mes: ");
                    decimal cargos = decimal.Parse(Console.ReadLine());

                    Console.Write("Ingrese el total de créditos aplicados a la cuenta del cliente en el mes: ");
                    decimal creditos = decimal.Parse(Console.ReadLine());

                    Console.Write("Ingrese el límite de crédito permitido: ");
                    decimal limiteCredito = decimal.Parse(Console.ReadLine());

                    // Calcular el nuevo saldo
                    decimal nuevoSaldo = saldoInicial + cargos - creditos;

                    // Determinar si se excede el límite de crédito
                    if (nuevoSaldo > limiteCredito)
                    {
                        Console.WriteLine($"Número de cuenta: {numeroCuenta}");
                        Console.WriteLine($"Límite de crédito: {limiteCredito:C}");
                        Console.WriteLine($"Nuevo saldo: {nuevoSaldo:C}");
                        Console.WriteLine("Se excedió el límite de su crédito.");
                    }
                    else
                    {
                        Console.WriteLine("El cliente no se ha excedido del límite de crédito.");
                    }

                    Console.WriteLine(); // Línea en blanco para separar clientes
                }
            }
        }

    }
}
}
