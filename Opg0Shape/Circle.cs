﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg0Shape
{
    internal class Circle : Shape
    {
        private double radius;
        public Circle(double x, double y, double radius) : base(x,y) 
        {
            this.radius = radius;
        }

        public double Radius
        { 
            get { return radius; } 
            set { radius = value; } 
        }
    }
}
