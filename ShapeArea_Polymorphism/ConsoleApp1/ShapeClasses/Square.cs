using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeArea.ShapeClasses
{
    class square : BaseShape
    {
        public override double GetArea()
        {
            return Height * Width;
     //     return (double)Height * (double)Width;
        }
    }
}
