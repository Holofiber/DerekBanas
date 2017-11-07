﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console = System.Console;

namespace Tutorial_10
{
    class Television : IElectronicDevice
    {
        public  int Volume { get; set; }

        public void On()
        {
            Console.WriteLine("The TV is On");
        }

        public void Off()
        {

            Console.WriteLine("The TV is Off");
        }

        public void VolumeUp()
        {
            if (Volume != 100) Volume++;
            Console.WriteLine($"The TV Volume is at {Volume}");
        }

        public void VoluneDown()
        {
            if (Volume != 0) Volume--;
            Console.WriteLine($"The TV Volume is at {Volume}");
        }
    }
}
