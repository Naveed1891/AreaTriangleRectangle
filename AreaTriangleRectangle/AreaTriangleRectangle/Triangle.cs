using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaTriangleRectangle
{
    class Triangle:Shape
    {
        public double z { get; set; }
        override public double Area()
        {
            return ((x * y) / 2);
        }
        override public double Perimeter()
        {
            return (x + y + z);
        }
    }
}
