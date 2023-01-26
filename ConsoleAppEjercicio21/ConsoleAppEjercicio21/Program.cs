using System;

namespace ConsoleAppEjercicio21
{
    class Program
    {
        static void Main(string[] args)
        {
            //titulacion del programa
            Console.Title = "Ejercicio21CelsiusAReaumurOFahrenheit";
            Console.WriteLine("Convrsor Celsius a Reaumur o Fahrenheit");
            //definicion de las variables y valores a calcular
            double reaumur, fahrenheit;
            Console.Write("Inserte valor en Celsius a calcular: ");
            var celsius = double.Parse(Console.ReadLine());

            //proceso del programa
            if (celsius >= 30)
            {
                reaumur = (0.8) * celsius;
                Console.WriteLine($"{celsius} C° equivalen a {reaumur} Reaumur");
            }
            else 
            {
                fahrenheit= (1.8) * celsius + 32;
                Console.WriteLine($"{celsius} C° equivalen a {fahrenheit} Fahrenheit");
            }

        }
    }
}
