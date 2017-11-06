using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = {new Circle(5), new Rectangle(4, 5)};

            foreach (Shape s in shapes)
            {
                s.GetInfo();
                Console.WriteLine("{0} Area : {1:f2}", s.Name, s.Area());
                Circle tesCircle = s as Circle;
                if (tesCircle == null)
                {
                    Console.WriteLine("This isn't a Circle");
                }
                if (s is Circle)
                {
                    Console.WriteLine("This isn't a Rectangle");
                }
                Console.WriteLine();
                object circl1 = new Circle(4);
                Circle circl2 = (Circle) circl1;

                Console.WriteLine("The {0} Area is {1:f2}", circl2.Name, circl2.Area());
            }

            Console.ReadLine();
        }

    }
        
    
}
