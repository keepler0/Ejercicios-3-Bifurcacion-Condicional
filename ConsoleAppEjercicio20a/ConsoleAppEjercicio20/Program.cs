using System;

namespace ConsoleAppEjercicio20a
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            int suma, resta, producto;
            double division;
            Console.WriteLine("seleccione el caracter que desea operar");
            Console.WriteLine("suma(+)");
            Console.WriteLine("resta(-)");
            Console.WriteLine("producto(*)");
            Console.WriteLine("Division(/)");
            Console.Write("opcion:");
            string opcion = Console.ReadLine();
            if (opcion.ToUpper() == "+" || opcion.ToUpper() == "-")
            {
                if (opcion.ToUpper() == "+")
                {
                    Console.WriteLine("ha seleccionado suma");
                    Console.WriteLine("inserte los valores a sumar");
                    Console.Write("n°1=");
                    n1 = int.Parse(Console.ReadLine());
                    Console.Write("n°2=");
                    n2 = int.Parse(Console.ReadLine());
                    suma = n1 + n2;
                    Console.WriteLine($"La suma es:{suma}");
                }
                else
                {//caso falso suma
                    Console.WriteLine("Ha seleccionado resta");
                    Console.WriteLine("Inserte los valores a restar");
                    Console.Write("n°1=");
                    n1 = int.Parse(Console.ReadLine());
                    Console.Write("n°2=");
                    n2 = int.Parse(Console.ReadLine());
                    resta = n1 - n2;
                    Console.Write($"la resta es:{resta} ");
                }
                
            }
            if (opcion.ToUpper() == "*" || opcion.ToUpper() == "/")
            {
                if (opcion.ToUpper() == "*")
                {
                    Console.WriteLine("Ha seleccionado producto");
                    Console.WriteLine("inserte los valores a multiplicar");
                    Console.Write("n°1=");
                    n1 = int.Parse(Console.ReadLine());
                    Console.Write("n°2=");
                    n2 = int.Parse(Console.ReadLine());
                    producto = n1 * n2;
                    Console.WriteLine($"La multiplicacion es: {producto}");
                }
                else
                {//caso falso producto
                    Console.WriteLine("Ha seleccionado dividir");
                    Console.WriteLine("inserte los valores a dividir");
                    Console.Write("n°1=");
                    n1 = int.Parse(Console.ReadLine());
                    Console.Write("n°2=");
                    n2 = int.Parse(Console.ReadLine());
                    division = n1 / n2;
                    Console.WriteLine($"La division es: {division}");
                }
            }
            else
            { Console.Write("El caracter ingresado es invalido"); }
        }
    }
}
