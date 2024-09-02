using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg0Shape
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();

            shapes.Add(new Circle(1,1,1));
            shapes.Add(new Rectangle(1, 1));

            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape.X);
            }
            Console.ReadLine();
        }
    }
}
