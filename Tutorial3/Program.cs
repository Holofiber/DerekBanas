using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 17;

                if ((age >= 5)&&(age <=7))
            {
                Console.WriteLine("Go to Elemebntary Shcool");
            }
                else if ((age >7)&&(age <13))
            {
                Console.WriteLine( "Go to Middel shcool");
            }
                else if ((age>13)&&(age <19))
            {
                Console.WriteLine("Go to High shcool");
            }
                else
            {
                Console.WriteLine("Go to College");
            }

                if ((age<14)||(age <19))
            {
                Console.WriteLine("You Shouldn't Work");
            }

            Console.WriteLine( "! true = " + (!true));


            Console.ReadLine();
        }
    }
}
