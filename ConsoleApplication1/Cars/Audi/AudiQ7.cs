using System;

namespace ConsoleApplication1
{
    public class AudiQ7 : Auto, IAuto
    {
        public AudiQ7(Make carName) : base(carName) { }
        public override void TurnOff()
        {
            Console.WriteLine("AudiQ7 is off.");
        }

        public override void TurnOn()
        {
            Console.WriteLine("AudiQ7 is running.");
        }
    }
}