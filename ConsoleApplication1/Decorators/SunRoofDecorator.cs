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
            //Console.WriteLine(CarName.Name + " " + CarName.Model + "{0} {1} {3} is off.");
            Console.WriteLine(string.Format("{0} {1} with {2} is off.", CarName.Name, CarName.Model, string.Join(" and ", CarName.Accessory)));

        }

        public override void TurnOn()
        {
            //Console.WriteLine(CarName + " is off. Turbo Charge Engaged.");

            Console.WriteLine(string.Format("{0} {1} with {2} is On.", CarName.Name, CarName.Model, string.Join(" and ", CarName.Accessory)));
        }
    }
}