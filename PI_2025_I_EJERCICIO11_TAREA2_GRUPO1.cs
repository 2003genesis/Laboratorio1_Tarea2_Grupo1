using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_2025_I_EJERCICIO11_TAREA2_GRUPO1
{
    internal class PI_2025_I_EJERCICIO11_TAREA2_GRUPO1
    {
        static void Main(string[] args)
        {
            // Pedimos al usuario que ingrese las 3 notas del estudiante
            Console.Write("Introduce la primera nota: ");
            double nota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Introduce la segunda nota: ");
            double nota2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Introduce la tercera nota: ");
            double nota3 = Convert.ToDouble(Console.ReadLine());

         
            double promedio = (nota1 + nota2 + nota3) / 3; // Calculamos promedio de 3 notas

            
            Console.WriteLine($"\nEl promedio de las notas es: {promedio:F2}"); // para promedio
            string resultado = "";

            switch (promedio)  // Creamos el switch
            {
                case double n when (n < 0 || n > 100):
                    resultado = "Valor invalido";  //Si el valor no esta entre o y 100 para que tire el error aqui
                    break;
                case double n when (n < 70):
                    resultado = "Alumno Reprueba";
                    break;
                case double n when (n <= 80):
                    resultado = "Alumno Bueno";
                    break;
                case double n when (n <= 90):
                    resultado = "Alumno Muy bueno";
                    break;
                case double n when (n <= 100):
                    resultado = "Alumno Sobresaliente";
                    break;
            }

           
            Console.WriteLine($"El estudiante ha obtenido una calificación: {resultado}"); //Mostrar el resultado
        }
    }
    }

