using System;

namespace ConsoleAppEjercicio26
{
    class Program
    {
        static void Main(string[] args)
        {
            //titulacion del programa
            Console.Title = "Ejercicio26MultiploDelPrimerNum";
            Console.WriteLine("Se verificara si los dos numeros ingresados son multiplos");
            //definicion de los valores a calcular y definicion de variables 
            Console.WriteLine("ingrese los valores");
            Console.Write("numero 1: ");
            var num1 = int.Parse(Console.ReadLine());
            Console.Write("numero 2: ");
            var num2 = int.Parse(Console.ReadLine());
            //proceso del programa y muestra del resultado
            if ((num1 % num2== 0) || (num2 %num1 == 0))
            {
                Console.WriteLine($"{num1} y {num2} son multiplos entre si");
            }
            else
            {
                Console.WriteLine("Los numeros ingresados no son multiplos");
            }

        }
    }
}
