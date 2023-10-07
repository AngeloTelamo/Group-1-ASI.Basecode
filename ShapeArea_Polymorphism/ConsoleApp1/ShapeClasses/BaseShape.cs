///////////////////////////////////////////////////////////////////////////////
//
// !!! DO NOT modify this file. For reference only.
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeArea.ShapeClasses
{
    internal abstract class BaseShape
    {
        private double _height;
        private double _width;

        public double Height
        {
            get
            {
                return _height; 
            }
            set
            {
                _height = value;
            }
        }

        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value;
            }
        }

        public BaseShape()
        {
            _height = default;
            _width = default;
        }

        public abstract double GetArea();

    }
}
