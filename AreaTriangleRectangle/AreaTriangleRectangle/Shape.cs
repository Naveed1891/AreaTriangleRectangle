using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaTriangleRectangle
{
    class Shape
    {
        public double x { get; set; }
        public double y { get; set; }
        
      
        public Shape()
        {
            x= 0;
            y= 0;
          
        }
      
        virtual public double Area()
        {
            
            return (x * y);
        }
        virtual public double Perimeter()
        {
            return (x + y);
        }
    }
   
}
