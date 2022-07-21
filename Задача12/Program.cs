using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача12
{
    class Program
    {
        static void Main(string[] args)
        {
            double Radius = Convert.ToDouble(Console.ReadLine());
            double mx = Convert.ToDouble(Console.ReadLine());
            double my = Convert.ToDouble(Console.ReadLine());
            double x0 = Convert.ToDouble(Console.ReadLine());
            double y0 = Convert.ToDouble(Console.ReadLine());
            double lenght = Rectangle.GetLenght(Radius);
            double square = Rectangle.GetSquare(Radius);
            double f = Rectangle.Getf(Radius, mx, my, x0, y0);
            Console.WriteLine($"{lenght} \n{square} \n{f}");
            Console.ReadKey();
        }
    }
}
