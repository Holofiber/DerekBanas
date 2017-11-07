using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_9
{
    class Rectangle : Shape
    {
        public  double Lenght { get; set; }
        public double Width { get; set; }

        public Rectangle(double lenght, double width)
        {
            Name = "Rectanqle";
            Lenght = lenght;
            Width = width;
        }
        public  double Areaasd()
        {
            return Lenght * Width;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"It has a Lenght of {Lenght} and Width of {Width}");
        }

        public override double Area()
        {
            throw new NotImplementedException();
        }
    }
}
