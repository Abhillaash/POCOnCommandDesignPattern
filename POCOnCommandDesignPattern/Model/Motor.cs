using System;
using System.Collections.Generic;
using System.Text;

namespace POCOnCommandDesignPattern.Model
{
    class Motor :IElectricalItem
    {
        public void TurnOn()
        {
            Console.WriteLine("Motor is ON");
        }

        public void TurnOff()
        {
            Console.WriteLine("Motor is OFF");
        }
    }
}
