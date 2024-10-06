using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            Console.WriteLine("Введите длинны сторон прямоугольного параллелепипеда:");
             
         double A = Double.Parse(Console.ReadLine());
         double B = Double.Parse(Console.ReadLine());
         double C = Double.Parse(Console.ReadLine());
            Console.WriteLine("");
            double volume = A * B * C;
            double SurfaceArea = 2*(A * B + B * C + C * A);

            Console.WriteLine("Объём:" + volume);
            Console.WriteLine("");
            Console.WriteLine("Площадь поверхности:" + SurfaceArea);


            Console.ReadKey();

         


           
        }
    }
}
