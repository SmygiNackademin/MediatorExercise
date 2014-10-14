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
        private Keyboard _keyboard;
        private Screen _screen;

        internal void RegisterKeyboard(Keyboard keyboard)
        {
            _keyboard = keyboard;
        }

        internal void RegisterScreen(Screen screen)
        {
            _screen = screen;
        }

        internal void ComputerSwitchedOn()
        {
            _keyboard.Enabled();
            _screen.TurnOn();
            Debug.WriteLine("Copmuter is switched on");
        }

        internal void ComputerSwitchedOff()
        {
            _keyboard.Disabled();
            _screen.TurnOff();
            Debug.WriteLine("Copmuter is switched off");
        }

        internal void KeyboardKeyPressed(char key)
        {
            Debug.WriteLine("Keyboard key is pressed");
            _screen.DisplayCharacter(key);
        }
    }
}
