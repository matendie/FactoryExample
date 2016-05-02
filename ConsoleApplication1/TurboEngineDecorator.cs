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
            Console.WriteLine(CarName + " is off, Turbo Charge just reduces its life by half.");
        }

        public override void TurnOn()
        {
            Console.WriteLine(CarName + " is off. Turbo Charge Engaged.");
        }
    }
}