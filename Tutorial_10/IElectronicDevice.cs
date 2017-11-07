using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_10
{
    interface IElectronicDevice
    {
        void On();
        void Off();
        void VolumeUp();
        void VoluneDown();
    }
}
