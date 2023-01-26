using System;

namespace ConsoleAppEjercicio24
{
    class Program
    {
        static void Main(string[] args)
        {
            //titulacion del programa
            Console.Title = "Ejercicio24ConversorAEleccionCF";
            Console.WriteLine("Conversor de temperatura");
            Console.WriteLine("Elija la unidad de temperatura que desea convertir");
            Console.Write("inserte C para celsius y F para fahrenheit:");
            //definicion de las variables
            double celsius, fahrenheit;
            var opcion = (Console.ReadLine());
            //proceso del programa
            if ((opcion.ToUpper()== "C") || (opcion.ToUpper() == "F")) 
            {
                if (opcion.ToUpper() == "C")
                {
                    Console.WriteLine("se convertira de Celsius a Fahrenheit");
                    Console.Write("C°: ");
                    celsius = double.Parse(Console.ReadLine());
                    fahrenheit = 1.8 * celsius + 32;
                    Console.WriteLine($"{celsius} C° equivalen a {fahrenheit} F°.");
                }
                else
                {
                    Console.WriteLine("Se convertira de Fahrenheit a Celsius");
                    Console.Write("F°: ");
                    fahrenheit = double.Parse(Console.ReadLine());
                    celsius = (fahrenheit - 32) * 5 / 9;
                    Console.WriteLine($"{fahrenheit} F° equivalen a {celsius} C°.");
                }
            }
            else
            {
                Console.WriteLine("la opcion elegida es incorrecta.");
                Console.WriteLine("Debe elegir C para convertir Celsius a Fahrenheit y viceversa.");
            }
        }
    }
}
