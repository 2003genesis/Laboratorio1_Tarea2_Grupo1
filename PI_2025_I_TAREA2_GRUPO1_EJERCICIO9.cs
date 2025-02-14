using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_2025_I_TAREA2_GRUPO1_EJERCICIO9
{
    internal class PI_2025_I_TAREA2_GRUPO1_EJERCICIO9
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa su salario:");
            double salario = Convert.ToDouble(Console.ReadLine());
            double aumento = 0;

            if (salario >= 0 && salario <= 4999)
            {
                aumento = salario * 0.20;  // Su sueldo aumentara un 20%
            }
            else if (salario >= 5000 && salario <= 9999)
            {
                aumento = salario * 0.10;  // Su sueldo aumentara un 10%
            }
            else if (salario >= 10000 && salario <= 14999)
            {
                aumento = salario * 0.05;  // Su sueldo aumentara un 5%
            }
            else if (salario >= 15000)
            {
                aumento = salario * 0.03;  // Su sueldo aumentara un 3%
            }
            else
            {
                Console.WriteLine("El salario ingresado no es válido.");
                return;
            }

            //Calculando el sueldo final

            double salarioFinal = salario + aumento;
            Console.WriteLine("El aumento es: " + aumento);
            Console.WriteLine("El salario final después del aumento es: " + salarioFinal);

        }
    }
    }
}
