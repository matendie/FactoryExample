using System;

namespace ConsoleApplication1
{
    public class NullCar : Auto, IAuto
    {
        public NullCar(string carName) : base(carName) { }
         
        public override void TurnOff()
        {
            Console.WriteLine("No " + CarName + " car was found.");
        }

        public override void TurnOn()
        {
            Console.WriteLine("No " + CarName + " car was found.");
        }
    }
}