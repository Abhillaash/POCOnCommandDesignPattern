using System;
using POCOnCommandDesignPattern.Model;
namespace POCOnCommandDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // Client code
            IElectricalItem led = new LED();
            IElectricalItem motor = new Motor();

            IControl turnOnLED = new ONControl(led);
            IControl turnOffMotor = new OFFControl(motor);

            RemoteControl remoteControl = new RemoteControl();
            remoteControl.AddCommand(turnOnLED);
            remoteControl.AddCommand(turnOffMotor);

            remoteControl.PressButton(0); // Turn on light
            remoteControl.PressButton(1); // Turn off fan
        }
    }
}
