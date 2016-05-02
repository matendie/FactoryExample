using System;

namespace ConsoleApplication1
{
    public class MiniCooper : Auto,  IAuto
    {
        public MiniCooper(string carName) : base(carName) { }
        public override void TurnOff()
        {
            Console.WriteLine("Mini Cooper is off.");
        }

        public override void TurnOn()
        {
            Console.WriteLine("Mini Cooper is running.");
        }
    }
}