using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed
{
    public abstract class Shape
    {
        public abstract double Area();
    }
    public class Square : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area()
        {
            return Width * Height;
        }
    }
    /* public class Circle: Shape
     {
         public double Radius { get; set; }
         public override double Area()
         {
             return Math.PI*Radius*Radius;
         }
     }*/
    public class AreaCalc
    {
        public double Calculate(Shape[] shapes)
        {
            double area = 0;
            foreach (Shape shape in shapes)
            {
                area += shape.Area();
            }
            return area;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[]
            {
                new Square { Width = 5, Height = 5 }
                /* new Circle{Radius=3}*/
            };
            AreaCalc calc = new AreaCalc();
            double area=calc.Calculate(shapes);
            Console.WriteLine(area);
            Console.ReadKey();
        }
    }
}

