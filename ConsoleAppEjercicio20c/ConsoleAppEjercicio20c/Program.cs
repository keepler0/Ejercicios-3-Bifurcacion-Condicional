using System;

namespace ConsoleAppEjercicio20c
{
    class Program
    {
        static void Main(string[] args)
        {
            double perimetro;
            double superficie;
            Console.WriteLine("calcular la superficie y el perimetro de un cuadrado");
            Console.Write("inserte el valor del Lado:");
            var lado = int.Parse(Console.ReadLine());
            if (lado>0)
            {
                perimetro = lado * 4;
                superficie =Math.Pow(lado,2);
                Console.WriteLine($"El valor del lado: {lado}, su superficie es: {superficie}, y su perimetro es: {perimetro}");
            }
            else
            {
                Console.WriteLine("el numero debe ser mayor que cero");
            }
        }
    }
}
