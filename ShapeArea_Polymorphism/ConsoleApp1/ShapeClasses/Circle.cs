using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ShapeArea.ShapeClasses
{
    class Circle : BaseShape
    {
        public override double GetArea()
        {
            return (radius * radius) / pi;
        }

        const double pi = 3.14;

        public double radius { get; set; }
    }

}
