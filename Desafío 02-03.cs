using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Desafío 02-03 por David Martínez");
            //Los datos que se ingresan son c , z (el angulo inferior del triangulo y un cateto)
            Console.WriteLine("Ingrese los valores de c , z");
            double c = double.Parse(Console.ReadLine());
            double z = double.Parse(Console.ReadLine());
            double cgrados = c * (Math.PI / 180.0);
            //calculando "t" (hipotenusa)
            Console.WriteLine("La hipotenusa del triangulo es:");
            double t = (z/Math.Sin (cgrados));
            Console.WriteLine(t);

            //calculando "y" (cateto)
            Console.WriteLine(" el cateto y del triangualo es:");
            double y = Math.Sqrt(((t) * (t)) - ((z) * (z)));
            Console.WriteLine(y);


            //calculando  "a" (ángulo superior del triangulo)
            Console.WriteLine(" el ángulo a es:");
            double agrados = Math.Acos(z / t);   
            double a = agrados * (180.0 / Math.PI);
            Console.WriteLine(a);
            //todo funciona, lo comprobé con varios ejemplos
        }
    }
}
