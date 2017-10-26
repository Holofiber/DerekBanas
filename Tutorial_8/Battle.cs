using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_8
{
    class Battle
    {
        public static void StartFight(Warrior warrior1, Warrior warrior2)
        {
            while (true)
            {
                if (GetAttackResult(warrior1, warrior2) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }

                if (GetAttackResult(warrior2, warrior1) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }
            }


        }

        public static string GetAttackResult(Warrior warriorA, Warrior warriorB)
        {
            double warAAttkAmt = warriorA.Attack();
            double warBBlockAmt = warriorB.Block();
            double dmg2WarB = warAAttkAmt - warBBlockAmt;

            if (dmg2WarB > 0)
            {
                warriorB.Health = warriorB.Health - dmg2WarB;
            }
            else dmg2WarB = 0;
            {
                Console.WriteLine("{0} Attacks {1} and Deals {2} Demage", warriorA.Name, warriorB.Name, dmg2WarB);
            }

            Console.WriteLine("{0} Has {1} Health \n", warriorB.Name, warriorB.Health);

            if (warriorB.Health <= 0)
            {
                Console.WriteLine("{0} has Died and {1} is Victorius \n", warriorB.Name, warriorA.Name);
                return "Game Over";
            }
            else return "Fight Again";
        }
    }
}
