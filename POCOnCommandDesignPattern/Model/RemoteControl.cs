using System;
using System.Collections.Generic;
using System.Text;

namespace POCOnCommandDesignPattern.Model
{
    class RemoteControl
    {
        private List<IControl> _control = new List<IControl>();

        public void AddCommand(IControl control)
        {
            _control.Add(control);
        }

        public void PressButton(int index)
        {
            if (index >= 0 && index < _control.Count)
            {
                _control[index].Execute();
            }
        }
    }
}
