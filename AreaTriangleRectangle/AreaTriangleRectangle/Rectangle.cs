using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaTriangleRectangle
{
    class Rectangle:Shape
    {
        override public double Area()
        {

            return (x*y);
        }
        override  public double Perimeter()
        {
            return (2 * (x+y));
        }
    }
}
