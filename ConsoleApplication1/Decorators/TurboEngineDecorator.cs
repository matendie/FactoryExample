using System;

namespace ConsoleApplication1
{
    public class TurboEngineDecorator : AccessoryDecorator
    {
        IAuto _auto;
        public TurboEngineDecorator(IAuto auto): base (auto)
        {
            _auto = auto;
        }

        public override void TurnOff()
        {
            //Console.WriteLine(CarName.Name + " " + CarName.Model + "{0} {1} {3} is off.");
            Console.WriteLine(string.Format("{0} {1} {2} is off.", CarName.Name, CarName.Model, string.Join(",", CarName.Accessory)));

        }

        public override void TurnOn()
        {
            //Console.WriteLine(CarName + " is off. Turbo Charge Engaged.");
           
            Console.WriteLine(string.Format("{0} {1} {2} is On." ,   CarName.Name, CarName.Model, string.Join(",", CarName.Accessory)));
        }
    }
}