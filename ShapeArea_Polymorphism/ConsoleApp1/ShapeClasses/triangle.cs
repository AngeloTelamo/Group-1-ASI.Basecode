using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeArea.ShapeClasses
{
    class triangle : BaseShape
    {
        public override double GetArea()
        {
            return (Height * Width) / 2;
//          return (double)Height *(double)Width / 2;
        }
    }
}
    
       
