using System;

namespace ConsoleApplication1
{
    public class AudiA4 : Auto, IAuto
    {
        public AudiA4(string carName) : base(carName) { }
        public override void TurnOff()
        {
            Console.WriteLine("AudiA4 is off.");
        }

        public override void TurnOn()
        {
            Console.WriteLine("AudiA4 is running.");
        }
    }
}