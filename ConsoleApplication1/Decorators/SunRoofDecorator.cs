using System;

namespace ConsoleApplication1
{
    public class SunRoofDecorator : AccessoryDecorator
    {
        IAuto _auto;
        public SunRoofDecorator(IAuto auto): base (auto)
        {
            _auto = auto;
        }

        public override void TurnOff()
        {
            Console.WriteLine(CarName + " is off, left with sun roof open.");
        }

        public override void TurnOn()
        {
            Console.WriteLine(CarName + " is off. Sunroof opening now.");
        }
    }
}