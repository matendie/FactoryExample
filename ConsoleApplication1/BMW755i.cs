using System;

namespace ConsoleApplication1
{
    public class BMW755i : Auto, IAuto
    {
        public BMW755i(string carName) : base(carName) { }
        public override void TurnOff()
        {
            Console.WriteLine("BMW755i is off.");
        }

        public override void TurnOn()
        {
            Console.WriteLine("BMW755i is running.");
        }
    }
}