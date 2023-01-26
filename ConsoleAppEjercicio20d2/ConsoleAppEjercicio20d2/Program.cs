using System;

namespace ConsoleAppEjercicio20d2
{
    class Program
    {
        static void Main(string[] args)
        {
            //titulacion del programa
            Console.Title = "Ejercicio20DIIElejir2Ejercicios";
            Console.WriteLine("Se calculará las notas de un alumno");
            Console.WriteLine("Inserte las notas: ");
            //definicion de las variables y valores a calcular
            double mediaAritmetica, ponderada;
            Console.Write("Primera nota: ");
            var nota1 = int.Parse(Console.ReadLine());
            Console.Write("Segunda nota: ");
            var nota2 = int.Parse(Console.ReadLine());
            Console.Write("Tercera nota: ");
            var nota3 = int.Parse(Console.ReadLine());
            //proceso del programa
            //bifurcacion condicional y anidamiento de bifurcacion
            if ((nota1 > 0) && (nota2 > 0) && (nota3 > 0))
            {
                mediaAritmetica = (nota1 + nota2 + nota3) / 3;
                ponderada = (nota1 * 0.3) + (nota2 * 0.45) + (nota3 * 0.25);
                if ((mediaAritmetica >= 6) && (ponderada >= 6))
                {
                    Console.WriteLine($"El alumno con la primera nota: {nota1}");
                    Console.WriteLine($"Segunda nota: {nota2}");
                    Console.WriteLine($"Tercera nota: {nota3}");
                    Console.WriteLine($"El alumno está aprobado, aprobó con: {mediaAritmetica}");
                    Console.WriteLine($"Aprobó con un promedio de: {ponderada}");
                }
                else
                {
                    Console.WriteLine($"El alumno con la primera nota: {nota1}");
                    Console.WriteLine($"Segunda nota: {nota2}");
                    Console.WriteLine($"Tercera nota: {nota3}");
                    Console.WriteLine($"El alumno está desaprobado, desaprobó con: {mediaAritmetica}");
                    Console.WriteLine($"Desaprobó con un promedio de: {ponderada}");
                }
            }
            else 
            {
                Console.WriteLine("los valores introducidos son incorrectos");
            }
        }
    }
}
