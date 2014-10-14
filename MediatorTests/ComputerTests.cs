using System;
using MediatorLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MediatorTests
{
    [TestClass]
    public class ComputerTests
    {
        [TestMethod]
        public void Mediator_tests()
        {
            // ARRANGE
            ComputerSystem aComputerSystem = new ComputerSystem();
            Computer aComputer = new Computer(aComputerSystem);
            Keyboard aKeyboard = new Keyboard(aComputerSystem);
            Screen aScreen = new Screen(aComputerSystem);

            // ACT
            aComputer.SwitchOn();
            aKeyboard.KeyPressed('e');
            aComputer.SwitchOff();

            // ASSERT
        }
    }
}
