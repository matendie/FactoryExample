using System;

namespace ConsoleApplication1
{
    public class AudiAutoFactory : AutoFactory, IAutoFactory
    {
        
        public AudiAutoFactory(string carName): base (carName)
        {
            this.CarName = carName;
        }

        public override IAuto CreateAutomobile()
        {
            Type type = GetAutoTypeToCreate(carModel);
            if (type == null)
            {
                return new NullCar(carModel);
            }
            IAuto auto = Activator.CreateInstance(type, CarName) as IAuto;
            auto = new TurboEngineDecorator(auto);
            return auto;
            //return Activator.CreateInstance(type, CarName) as IAuto;
        }

        private Type GetAutoTypeToCreate(string carName)
        {
            foreach (var auto in autos)
            {
                if (auto.Key.Contains("audi" + carName.ToLower()))
                {
                    return autos[auto.Key];
                }
            }

            return null;
        }
    }
}