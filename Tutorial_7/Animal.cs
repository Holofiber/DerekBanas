using System;
using System.Linq;
using Tutorial_7;


namespace Tutorial_5
{
    class Animal
    {

        private string name;
        protected string sound;

        protected AnimalIDInfo animalIdInfo = new AnimalIDInfo();

        public void SetAnimalIDinfo(int idNum, string owner)
        {
            animalIdInfo.IDNum = idNum;
            animalIdInfo.Owner = owner;
        }

        public void GetAnimalIDInfo()
        {
            Console.WriteLine($"{Name} had the ID of {animalIdInfo.IDNum} and is owned by {animalIdInfo.Owner}");
        }

        public virtual void MakeSound()
        {
            Console.WriteLine($"{Name} says {Sound}");
        }

        public Animal():this ("No Name", "No Sound") { }

        public Animal(string name):this(name, "No sound") { }

        public Animal(string name, string sound)
        {
            Name = name;
            Sound = sound;
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (!value.Any(char.IsDigit))
                {
                    name = "No Name";
                }
                name = value;
            }
        }
        public string Sound
        {
            get { return sound; }
            set
            {
                if (value.Length >10)
                {
                    name = "No Sound";
                }
                sound = value;
            }
        }

        public class AnimalHealth
        {
            public bool HealtWeight(double height, double weight)
            {
                double calc = height / weight;

                if ((calc >= .18) && (calc <= .27))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
