using System;

namespace ConsoleAppEjercicio18EsPositivoONegativo
{
    class Program
    {
        static void Main(string[] args)
        {
            //titulacion
            Console.Title = "Ejercicio 18 el numero es positivo o negativo?";
            Console.WriteLine ("El numero es Positivo o Negativo?");
            Console.Write("Ingrese el Numero: ");

            //asignacion de valores
            var num=int.Parse(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine($"El número:{num} es positivo");

            }
            else
            {
                Console.WriteLine($"El número:{num} es Negativo");
            }
            Console.ReadLine();
        }
    }
}
