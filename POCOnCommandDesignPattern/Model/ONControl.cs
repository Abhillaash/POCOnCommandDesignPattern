using System;
using System.Collections.Generic;
using System.Text;

namespace POCOnCommandDesignPattern.Model
{
    class ONControl : IControl
    {
        private IElectricalItem _electricalItem;

        public ONControl(IElectricalItem electricalItem)
        {
            _electricalItem = electricalItem;
        }

        public void Execute()
        {
            _electricalItem.TurnOn();
        }
    }
}
