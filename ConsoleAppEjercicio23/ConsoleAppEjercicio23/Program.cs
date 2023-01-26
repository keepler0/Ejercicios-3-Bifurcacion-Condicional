using System;

namespace ConsoleAppEjercicio23
{
    class Program
    {
        static void Main(string[] args)
        {
            //titulacion del programa
            Console.Title = "Ejercicio23EquilateroIsoselesEscaleno";
            Console.WriteLine("Al ingrersar los 3 lados se informara el tipo de triangulo");
            
            //definicion de las variables y definicion de los valores a calcular
            Console.WriteLine("Inserte los valores a calcular.");
            Console.Write("lado A: ");
            var ladoA = double.Parse(Console.ReadLine());
            Console.Write("lado B: ");
            var ladoB = double.Parse(Console.ReadLine());
            Console.Write("lado C: ");
            var ladoC = double.Parse(Console.ReadLine());

            //proceso del programa
            if ((ladoA + ladoB > ladoC) && (ladoA + ladoC > ladoB) && (ladoB + ladoC > ladoA))
            {
                if ((ladoA==ladoB)&&(ladoA==ladoC))
                {
                    Console.WriteLine("El triangulo con:");
                    Console.WriteLine($"lado A:{ladoA}");
                    Console.WriteLine($"lado B:{ladoB}");
                    Console.WriteLine($"lado C:{ladoC}");
                    Console.WriteLine("Se trata de un triangulo equilatero ya que este tiene todos sus lados iguales.");
                }
                else
                {
                    if ((ladoA != ladoB) && (ladoA != ladoC) && (ladoB != ladoC))
                    {
                        Console.WriteLine("El triangulo con:");
                        Console.WriteLine($"lado A:{ladoA}");
                        Console.WriteLine($"lado B:{ladoB}");
                        Console.WriteLine($"lado C:{ladoC}");
                        Console.WriteLine("Se trata de un triangulo escaleno ya que este tiene todos sus lados desiguales.");
                    }
                    else
                    {
                        Console.WriteLine("El triangulo con:");
                        Console.WriteLine($"lado A:{ladoA}");
                        Console.WriteLine($"lado B:{ladoB}");
                        Console.WriteLine($"lado C:{ladoC}");
                        Console.WriteLine("Se trata de un triangulo isosceles ya que este tiene dos de sus lados iguales.");
                    }
                }
            }
            else
            {
                Console.WriteLine("los valores introducidos no conforman un triangulo");
            }
        }
    }
}
