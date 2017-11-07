using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_10
{
    class PowerButton : ICommand
    {
        private IElectronicDevice device;

        public PowerButton(IElectronicDevice device)
        {
            this.device = device;
        }
        public void Execute()
        {
            device.On();
        }

        public void Undo()
        {
            device.Off();
        }
    }
}
