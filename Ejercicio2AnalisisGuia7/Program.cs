using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2AnalisisGuia7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "Programa que muestra la cantidad ingresada en asteriscos.";

            Double num;

            do
            {
            Console.WriteLine("Digite un número entre 1 y 15:");
            num = Double.Parse(Console.ReadLine());

           if (num == 1)
            {
                Console.WriteLine("*");
            }
            if (num == 2)
            {
                Console.WriteLine("* *");
            }
            if (num == 3)
            {
                Console.WriteLine("* * *");
            }
            if (num == 4)
            {
                Console.WriteLine("* * * *");
            }
            if (num == 5)
            {
                Console.WriteLine("* * * * *");
            }
            if (num == 6)
            {
                Console.WriteLine("* * * * * *");
            }
            if (num == 7)
            {
                Console.WriteLine("* * * * * * *");
            }
            if (num == 8)
            {
                Console.WriteLine("* * * * * * * *");
            }
            if (num == 9)
            {
                Console.WriteLine("* * * * * * * * *");
            }
            if (num == 10)
            {
                Console.WriteLine("* * * * * * * * * *");
            }
            if (num == 11)
            {
                Console.WriteLine("* * * * * * * * * * *");
            }
            if (num == 12)
            {
                Console.WriteLine("* * * * * * * * * * * *");
            }
            if (num == 13)
            {
                Console.WriteLine("* * * * * * * * * * * * *");
            }
            if (num == 14)
            {
                Console.WriteLine("* * * * * * * * * * * * * *");
            }
            if (num == 15)
            {
                Console.WriteLine("* * * * * * * * * * * * * * *");
            }
            } while (num >= 1 && num <= 15);

            {
                Console.WriteLine("El número ingresado debe estar dentro del rango del 1 al 15.");
            }

            Console.ReadKey();
        }
    }
}
