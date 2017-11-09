using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Tutorial_11
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ArrayList Code

            ArrayList arrayList = new ArrayList();

            arrayList.Add("Bob");
            arrayList.Add(40);

            Console.WriteLine("Count: {0}", arrayList.Count);

            Console.WriteLine("Capacity: {0}", arrayList.Capacity);
            

            ArrayList arrayList2 = new ArrayList();

            arrayList2.AddRange(new object[] { "Mike", "Sally", "Egg" });

            arrayList.AddRange(arrayList2);

            arrayList2.Sort();
            arrayList2.Reverse();

            arrayList2.Insert(1, "Turkey");

            ArrayList range = arrayList2.GetRange(0, 2);

            foreach (object o in range)
            {
                Console.WriteLine(o);
            }

            #endregion


            Console.ReadLine();
        }
    }
}
