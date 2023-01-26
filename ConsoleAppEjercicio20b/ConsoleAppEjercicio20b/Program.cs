using System;

namespace ConsoleAppEjercicio20b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("modificamos el ejercicio 3");
            //definicion delas variables
            double gradosSexagesimal, radianes;
           
            //proceso
            Console.Write("inserte el valor de Grado sexagesimal a calcular: ");
            gradosSexagesimal = double.Parse(Console.ReadLine());
            if (gradosSexagesimal>0)
            {
                radianes = gradosSexagesimal * 0.0174532925;
                Console.WriteLine($"Los grados sexagesimales: {gradosSexagesimal}, Equivalen en Radianes: {radianes}");
            }
            else
            {
                Console.WriteLine("El valor de los grados sexagesimal debe ser mayor que cero.");
            }

        }
    }
}
