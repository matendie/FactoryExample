using System;

namespace ConsoleApplication1
{
    public class BMW335i : Auto, IAuto
    {
        public BMW335i(string carName) : base(carName) { }
        public override void TurnOff()
        {
            Console.WriteLine("BMW335i is off.");
        }

        public override void TurnOn()
        {
            Console.WriteLine("BMW335i is running.");
        }
    }
}