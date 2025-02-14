using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_2025_I_EJERCICIO12_TAREA2_GRUPO1
{
    internal class PI_2025_I_EJERCICIO12_TAREA2_GRUPO1
    {
        static void Main(string[] args)
        {
            
            Random rand = new Random(); //para que genere numeros alertorios
            int numeroAdivinar = rand.Next(1, 1001);
            int intento = 0;

            
            Console.WriteLine("Holaaaa, Jugaremos a Adivina el número");
            Console.WriteLine("Adivina un Numero del 1 al 1000, Cual essss:");

            while (intento != numeroAdivinar)
            {
                Console.Write("Introduce tu numero: ");
                intento = Convert.ToInt32(Console.ReadLine());

                if (intento < numeroAdivinar)
                {
                    Console.WriteLine("Demasiado bajo, Vamos Intenta de nuevo");
                }
                else if (intento > numeroAdivinar)
                {
                    Console.WriteLine("Demasiado alto, Vamos Intenta de nuevo");
                }
                else
                {
                    Console.WriteLine("Muy Bien,  Adivinaste el número");
                }
            }
        }
    }
}
