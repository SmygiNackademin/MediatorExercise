using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorLib
{
    public class Screen
    {
        public Screen(ComputerSystem mediator)
        {

        }

        public void TurnOn()
        {
            Debug.WriteLine("Screen is turned on");
        }

        public void TurnOff()
        {
            Debug.WriteLine("Screen is turned off");
        }
    }
}
