using System;

namespace PI_2025_I_EJERCICIO10_TAREA2_GRUPO1
{
    internal class PI_2025_I_EJERCICIO10_TAREA2_GRUPO1
    {

        // Función para convertir de Fahrenheit a Centígrados
        static double  Centigrados(double fahrenheit)
            {
                return (fahrenheit - 32) * 5 / 9;  //formula para convertir
            }

            // Función para convertir  de Centígrados a Fahrenheit
            static double Fahrenheit(double centigrados)
            {
                return (centigrados * 9 / 5) + 32; //Formula para convertir
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Conversión de temperaturas:");

            // Imprimir tabla de Fahrenheit a Centígrados
            Console.WriteLine("\nTemperaturas en grados Fahrenheit y sus equivalentes en grados Centígrados:");
            Console.WriteLine("Fahrenheit | Centígrados");
            for (int i = 32; i <= 212; i += 20)  // 32 hasta 212 de 20 en 20 grados
            {
                double celsius = Centigrados(i);
                Console.WriteLine($"{i,10} | {celsius,12:F2}");
            }

            // Separador
            Console.WriteLine("\n--------------------------------------------");

            // Aqui para imprimir tabla
            Console.WriteLine("\nTemperaturas en grados Centígrados y sus equivalentes en grados Fahrenheit:");
            Console.WriteLine("Centígrados | Fahrenheit");
            for (int i = 0; i <= 100; i += 10)  // 0 hasta 100 de 10 en 10 grados
            {
                double fahrenheit = Fahrenheit(i);
                Console.WriteLine($"{i,12} | {fahrenheit,10:F2}");
            }






        }
    }
}



