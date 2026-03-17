using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Triangle : Shape
    {
        public double BaseLength { get; set; }
        public double Height { get; set; }

        public Triangle(double baselength, double height) 
        {
            this.BaseLength = baselength;
            this.Height = height;
        }
        public override double CalculateArea()
        {
            return (BaseLength * Height) / 2;
        }
    }
}
