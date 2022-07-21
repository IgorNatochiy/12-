using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача12
{
    class Rectangle
    {
            static public double GetLenght(double Radius)
            {
                return 2 * 3.14 * Radius;
            }
            static public double GetSquare(double Radius)
            {
                return 3.14 * (Radius * Radius);
            }
            static public double Getf(double Radius, double mx, double my, double x0, double y0)
            {
                return 2 * (x0 - mx) + 2 * (y0 - my);

            }
    }
}
