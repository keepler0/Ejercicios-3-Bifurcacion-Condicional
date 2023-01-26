using System;

namespace ConsoleAppEjercicio25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio25ConversorCentimetrosPulgadas";
            Console.WriteLine("Conversor Centimetros, pulgadas y viceversa");
            Console.Write("Ingrese el caracter que desea convertir C=centimetros P=pulgadas :");
            double centimetros, pulgadas;
            string opcion = Console.ReadLine();
            if ((opcion.ToUpper()=="C")||(opcion.ToUpper()=="P"))
            {
                if (opcion.ToUpper() == "C") 
                {
                    Console.WriteLine("Ha seleccionado Centimetros a Pulgadas");
                    Console.Write("Cms: ");
                    centimetros = double.Parse(Console.ReadLine());
                    if (centimetros >= 0)
                    {
                        pulgadas = centimetros * 0.39370;
                        Console.WriteLine($"{centimetros} cms equivalen a {pulgadas} p.");
                    }
                    else
                    {
                        Console.WriteLine("El valor pulgadas tiene que ser mayor a cero");
                    }
                }
                else
                {
                    Console.WriteLine("Ha seleccionado Pulgadas a Centimetros");
                    Console.Write("Pulgadas: ");
                    pulgadas = double.Parse(Console.ReadLine());
                    if (pulgadas >= 0)
                    {
                        centimetros = pulgadas / 0.39370;
                        Console.WriteLine($"{pulgadas} p equivalen a {centimetros} cms.");
                    }
                    else
                    {
                        Console.WriteLine("El valor Pulgadas debe ser mayor a cero");
                    }
                }
            }
            else 
            {
                Console.WriteLine("la opcion ingresada es incorrecta");
                Console.WriteLine("debe introducir C para centimetros o P para pulgadas");
            }
        }
    }
}
