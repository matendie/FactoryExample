using System;

namespace ConsoleApplication1
{
    public class AudiAutoFactory : AutoFactory, IAutoFactory
    {
        
        public AudiAutoFactory(Make car): base (car)
        {
            this.CarName = car;
        }

        public override IAuto CreateAutomobile()
        {
            Type type = GetAutoTypeToCreate(carModel);
            if (type == null)
            {
                return new NullCar(carModel);
            }
            IAuto auto = Activator.CreateInstance(type, CarName) as IAuto;
            //auto = new TurboEngineDecorator(auto);
            return auto;
            //return Activator.CreateInstance(type, CarName) as IAuto;
        }

        private Type GetAutoTypeToCreate(Make car)
        {
            foreach (var auto in autos)
            {
                if (auto.Key.Contains("audi" + car.Model.ToLower()))
                {
                    return autos[auto.Key];
                }
            }

            return null;
        }
    }
}