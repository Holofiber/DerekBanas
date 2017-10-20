using System;


namespace Tutorial_5
{
    class Animal
    {

        public string name;
        public string sound;

        public Animal()
        {
            name = "No name";
            sound = "No Sound";
            numOfAnimals++;
        }

        public Animal (string name = "No Name", string sound = "No Sound")
        {
            this.name = name;
            this.sound = sound;
            numOfAnimals++;

        }

        public void MakeSound()
        {
            Console.WriteLine("{0} says {1}", name, sound);
        }

        static int numOfAnimals = 0;

        public static int GetNumAnimals()
        {
            return numOfAnimals;
        }
    }
}
