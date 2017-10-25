using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tutorial_5;

namespace Tutorial_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal whiskers = new Animal()
            {
                Name = "Whiskers",
                Sound = "Meow"
            };

            Dog grover = new Dog()
            {
                Name = "Grover",
                Sound = "Woof",
                Sound2 = "Grrr"
            };
            grover.Sound = "Wooooof";

            whiskers.MakeSound();
            grover.MakeSound();

            whiskers.SetAnimalIDinfo(12345, "Sally Smith");

            grover.SetAnimalIDinfo(12346, "Paul Brown");

            whiskers.GetAnimalIDInfo();
            grover.GetAnimalIDInfo();

            Animal.AnimalHealth getHealth = new Animal.AnimalHealth();

            Console.WriteLine("Is my animal healthy : {0}",
            getHealth.HealtWeight(11, 146));

            Animal monkey = new Animal()
            {
                Name = "Happy",
                Sound = "Eeeeee"
            };

            Animal spot = new Dog()
            {
                Name = "Spot",
                Sound = "Wooof",
                Sound2 = "Geeerrrr"
            };

            monkey.MakeSound();
            spot.MakeSound();

            Console.ReadLine();
        }
    }
}
