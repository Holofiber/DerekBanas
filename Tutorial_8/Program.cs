using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior maximus = new Warrior("Maximus", 10,3,1);

            Warrior bob =  new Warrior("Bob", 10, 3,1);

            Battle.StartFight(maximus, bob);


            Console.ReadLine();
        }
    }
}
