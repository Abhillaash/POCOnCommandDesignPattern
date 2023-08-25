using System;
using System.Collections.Generic;
using System.Text;

namespace POCOnCommandDesignPattern.Model
{
    class LED : IElectricalItem
    {
        public void TurnOn()
        {
            Console.WriteLine("LED is ON");
        }

        public void TurnOff()
        {
            Console.WriteLine("LED is OFF");
        }
    }
}
