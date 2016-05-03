using System;

namespace ConsoleApplication1
{
    public class BMW620d : Auto, IAuto
    {
        public BMW620d(Make carName) : base(carName) { }
        public override void TurnOff()
        {
            Console.WriteLine("BMW620d is off.");
        }

        public override void TurnOn()
        {
            Console.WriteLine("BMW620d is running.");
        }
    }
}