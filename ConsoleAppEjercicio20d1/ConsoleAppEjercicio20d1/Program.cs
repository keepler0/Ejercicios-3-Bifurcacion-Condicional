using System;

namespace ConsoleAppEjercicio20d1
{
    class Program
    {
        static void Main(string[] args)
        {
            //titulacion del programa
            //introduccion a la aplicacion
            Console.WriteLine("Calcular la distancia recorrida porun movil");
            Console.WriteLine("Inserte los valores a calcular");
            //definicion de las variables
            //definicion de los valores o imput
            int distancia;
            Console.Write("velocidad m/s: ");
            var velocidad = int.Parse(Console.ReadLine());
            Console.Write("tiempo en seg.: ");
            var tiempo = int.Parse(Console.ReadLine());
            //proceso
            if ((tiempo >= 0) && (velocidad >= 0))
            {
                distancia = velocidad * tiempo;
                Console.WriteLine($"El objeto movil con velocidad:{velocidad} m/s.");
                Console.WriteLine($"durante un tiempo de:{tiempo} seg.");
                Console.WriteLine($"A recorrido una distancia de:{distancia} mts");
            }
            else
            {
                Console.WriteLine("los valores introducidos son incorrectos");
            }
        }
    }
}
