using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg0Shape
{
    internal class Shape
    {
        private double x;
        private double y;

        public double X 
        { 
            get { return x; } 
            set { x = value; } 
        }
        public double Y 
        { 
            get { return y; } 
            set { y = value; } 
        }

        public Shape(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public Shape()
        {
            
        }
    }
}
