using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg0Shape
{
    internal class Rectangle : Shape
    {
        private double length;
        private double width;

        public Rectangle(double x, double y) : base(x,y) 
        {
            this.width = x;
            this.length = y;
        }

        public double Length 
        { 
            get { return length; } 
            set { length = value; } 
        }

        public double Width
        { 
            get { return width; } 
            set { width = value; } 
        }
    }
}
