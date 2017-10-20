using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int? randNum = null;

            if (randNum == null)
            {
                Console.WriteLine("randNum is null");
            }

            if (!randNum.HasValue)
            {
                Console.WriteLine("randNum is null");
            }


            Console.WriteLine("Area of Rectangle : {0}", ShapeMath.GetArea("rectangle", 5, 6));

            
            Animal fox = new Animal()
            {
                name = "Red",
                sound = "Raww"
            };

            fox.MakeSound();


            Console.WriteLine("# of Animals : {0}", Animal.GetNumAnimals());

            Rectangle rect1;
            rect1.lenght = 200;
            rect1.width = 50;
            Console.WriteLine("Area of rect1 : {0}", rect1.Area());

            Rectangle rect2 = new Rectangle(100, 40);

            rect2 = rect1;
            rect1.lenght = 33;

            Console.WriteLine("rect2.lenght : {0}", rect2.lenght);

            Console.ReadLine();
        }

        struct Rectangle
        {
            public double lenght;
            public double width;

            public Rectangle(double l = 1, double w = 1)
            {
                lenght = l;
                width = w;
            }

            public double Area()
            {
                return lenght * width;
            }
        }
    }
}
