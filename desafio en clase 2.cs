using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine ("Ingrese los valores b4, b3, b2, b1, b0....  valores solamente disponibles entre 0 y 1");
            double b4 = double.Parse(Console.ReadLine());

            double b3 = double.Parse(Console.ReadLine());

            double b2 = double.Parse(Console.ReadLine());

            double b1 = double.Parse(Console.ReadLine());

            double b0 = double.Parse(Console.ReadLine());

            //convertir estos valores de binario a decimal
            Console.WriteLine("el número es:");

            double numero = (b4 * Math.Pow (2, 4)) + (b3 * Math.Pow(2, 3)) + (b2 * Math.Pow(2, 2)) +(b1 * Math.Pow(2, 1)) + (b0 * Math.Pow(2, 0));
                Console.WriteLine(numero);

            

        }
    }
}
