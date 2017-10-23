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
            Animal cat = new Animal();

            cat.SetName("Whiskers");
            cat.Sound = "Meow";

            Console.WriteLine("The cat is named {0} and says {1}", cat.GetName(), cat.Sound);

            cat.Owner = "Derek";

            Console.WriteLine("{0} owner is {1}", cat.GetName(), cat.Owner);
            Console.WriteLine("{0} shelter is {1}", cat.GetName(), cat.idNum);

            Animal fox = new Animal("Oscar", "Raweerr");

            Console.WriteLine("# of Animals : {0}", Animal.NumOfAnimals);

            Console.Read();

        }
    }
}
