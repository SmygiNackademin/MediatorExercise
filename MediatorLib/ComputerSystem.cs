using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorLib
{
    public class ComputerSystem
    {
        private Screen _screen;

        internal void RegisterScreen(Screen screen)
        {
            _screen = screen;
        }

        internal void ComputerSwitchedOn()
        {
            Debug.WriteLine("Copmuter is switched on");
        }

        internal void ComputerSwitchedOff()
        {
            Debug.WriteLine("Copmuter is switched off");
        }

        internal void KeyboardKeyPressed(char key)
        {
            Debug.WriteLine("Keyboard key is pressed");
            _screen.DisplayCharacter(key);
        }
    }
}
