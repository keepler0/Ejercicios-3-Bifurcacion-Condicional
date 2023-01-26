using System;

namespace ConsoleAppEjercicio22b
{
    class Program
    {
        static void Main(string[] args)
        {
            //titulacion del programa
            Console.Title = "Ejercicio22bComparar2numMayorYMenor";
            Console.WriteLine("Se comparará dos numeros y se informará el mayor y el menor");
            //definicion de las variables
            int num1, num2;
            Console.WriteLine("inserte los numeros a comparar");
            Console.Write("a: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("b: ");
            num2 = int.Parse(Console.ReadLine());
            //proceso del algoritmo
            if ((num1 > num2) || (num2 > num1))
            {
                if ((num1>num2))
                {
                    Console.WriteLine($"a={num1} es mayor y b={num2} es menor.");
                }
                else
                {
                    Console.WriteLine($"b={num2} es mayor y a={num1} es menor.");
                }
            }
            else
            {
                Console.WriteLine($"Los numeros ingresados son iguales a={num1} b={num2}");
            }
        }
    }
}
