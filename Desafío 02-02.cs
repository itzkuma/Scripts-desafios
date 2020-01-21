using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Desafío 02-02 por David Martínez");
            //Los datos que se ingresan son t , a (la hipotenusa y el angulo superior del triangulo)
            Console.WriteLine("Ingrese los valores de t , a");
            double t = double.Parse(Console.ReadLine()); 
            double a = double.Parse(Console.ReadLine());
            double agrados = a * (Math.PI/ 180.0);
            //calculando "y" (cateto)
            Console.WriteLine(" el cateto y del triangualo es:");
            double y = (t * (Math.Sin (agrados)));           
            Console.WriteLine(y);  //hasta aqui funciona

            //calculando "z" (cateto)
            Console.WriteLine(" el cateto z del triangualo es:");
            double z = (t * (Math.Cos(agrados)));
            Console.WriteLine(z);

            //calculando  "c" (ángulo inferior del triangulo)
            Console.WriteLine(" el ángulo c es:");
            double cgrados = Math.Acos(y / t);
            double c = cgrados * (180.0 / Math.PI);
            Console.WriteLine(c);
        }
    }
}
