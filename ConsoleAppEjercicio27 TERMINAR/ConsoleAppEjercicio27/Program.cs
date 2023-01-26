using System;

namespace ConsoleAppEjercicio27
{
    class Program
    {
        static void Main(string[] args)
        {
            //titulacion del programa
            Console.Title = "Ejercicio27OrdenarLos3NumerosIngresados";
            Console.WriteLine("Se ordenará los siguientes numeros ingresados");
            //definicion de las variables
            int num1, num2, num3;
            int menor=0, mayor=0, medio=0;
            //definicion Opcion como string a eleccion del orden de los numeros
            Console.Write("ingrese la opcion deseada (menor)=menor a mayor o (mayor)=mayor a menor");
            string opcion = Console.ReadLine();
            if ((opcion.ToUpper() = "MENOR") || (opcion.ToUpper() = "MAYOR"))
            {
                //espacio para la definicion de los valores a calcular
                if (opcion.ToUpper() = "MENOR")
                {
                    Console.WriteLine("A seleccionado Menor A Mayor");
                    Console.WriteLine("Ingrese los numeros");
                    Console.Write("numero 1: ");
                    num1 = int.Parse(Console.ReadLine());
                    Console.Write("numero 2: ");
                    num2 = int.Parse(Console.ReadLine());
                    Console.Write("numero 3: ");
                    num3 = int.Parse(Console.ReadLine());
                    if (num1 > num2)
                    {
                        if (num1 > num3)
                        {
                            mayor = num1;
                            if (num2 > num3)
                            {
                                medio = num2;
                                menor = num3;
                            }
                            else
                            {
                                medio = num3;
                                menor = num2;
                            }
                        }
                        else
                        {
                            mayor = num3;
                            medio = num1;
                            menor = num2;
                        }
                    }
                    else
                    {
                        if (num2 > num3)
                        {
                            mayor = num2;
                            if (num1 > num3)
                            {
                                medio = num1;
                                menor = num3;
                            }
                            else
                            {
                                medio = num3;
                                menor = num1;
                            }
                        }
                        else
                        {
                            mayor = num3;
                            medio = num2;
                            menor = num1;
                        }
                    }
                } 
                Console.WriteLine($"{menor} , {medio} , {mayor}");
                else
                {   
                    Console.WriteLine("A seleccionado Mayor A Menor");
                    Console.WriteLine("Ingrese los numeros");
                    Console.Write("numero 1: ");
                    num1 = int.Parse(Console.ReadLine());
                    Console.Write("numero 2: ");
                    num2 = int.Parse(Console.ReadLine());
                    Console.Write("numero 3: ");
                    num3 = int.Parse(Console.ReadLine());
                    if (num1 > num2)
                    {
                        if (num1 > num3)
                        {
                            mayor = num1;
                            if (num2 > num3)
                            {
                                medio = num2;
                                menor = num3;
                            }
                            else
                            {
                                medio = num3;
                                menor = num2;
                            }
                        }
                        else
                        {
                            mayor = num3;
                            medio = num1;
                            menor = num2;
                        }
                    }
                    else
                    {
                        if (num2 > num3)
                        {
                            mayor = num2;
                            if (num1 > num3)
                            {
                                medio = num1;
                                menor = num3;
                            }
                            else
                            {
                                medio = num3;
                                menor = num1;
                            }
                        }
                        else
                        {
                            mayor = num3;
                            medio = num2;
                            menor = num1;
                        }
                    }
                 Console.WriteLine($"{mayor} , {medio} , {menor}");
                    
                }
            }
            else
            {
                Console.WriteLine("opcion incorrecta");
                Console.WriteLine("Debe introducir (Menor) para menor a mayor y (Mayor) para mayor a menor");

            }
           
           


        }
    }
}
