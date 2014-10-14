using System;
using MediatorLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MediatorTests
{
    [TestClass]
    public class ComputerTests
    {
        [TestMethod]
        public void Test_That_Computer_Works()
        {
            // ARRANGE
            ComputerSystem aComputerSystem = new ComputerSystem();
            Computer aComputer = new Computer(aComputerSystem);
            
            // ACT
            aComputer.SwitchOn();

            // ASSERT
        }
    }
}
