using System;
using System.Collections.Generic;
using System.Text;

namespace POCOnCommandDesignPattern.Model
{
    class OFFControl : IControl
    {
        private IElectricalItem _electricalItem;

        public OFFControl(IElectricalItem electricalItem)
        {
            _electricalItem = electricalItem;
        }

        public void Execute()
        {
            _electricalItem.TurnOff();
        }
    }
}
