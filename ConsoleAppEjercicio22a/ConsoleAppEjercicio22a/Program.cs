using System;

namespace ConsoleAppEjercicio22a
{
    class Program
    {
        static void Main(string[] args)
        {
            //titulacion del programa
            Console.Title = "Ejercicio22aComparar2numMayorYMenor";
            Console.WriteLine("Se compará los numeros ingresados y se identificará el mayor y el menor");
            
            //definicion de las variables y tambien definicion de los valores a calcular
            Console.WriteLine("inserte los numeros:");
            Console.Write("a: ");
            var num1 = int.Parse(Console.ReadLine());
            Console.Write("b: ");
            var num2 = int.Parse(Console.ReadLine());
            //proceso del programa bifurcacion con operador "or" 
            if ((num1 > num2) || (num2 > num1))
            {
                //muestra de la informacion
                if (num1 > num2)
                {
                    Console.WriteLine($"a={num1} es el mayor y b={num2} es el menor");
                }
                else
                {
                    Console.WriteLine($"b={num2} es el mayor y a={num1} es el menor");
                }
            }
            //mensaje de error o proceso incorrecto
            else
            {
                Console.WriteLine("Los numeros no deben ser iguales");
            }
        }
    }
}
