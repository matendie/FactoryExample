using System;

namespace ConsoleApplication1
{
    public class BMWAutoFactory : AutoFactory, IAutoFactory
    {
        public BMWAutoFactory(string carName): base (carName)
        {
        }

        public override IAuto CreateAutomobile()
        {
            Type type = GetAutoTypeToCreate(carModel);
            if (type == null)
            {
                return new NullCar(carModel);
            }

            return Activator.CreateInstance(type) as IAuto;
        }

        private Type GetAutoTypeToCreate(string carName)
        {
            foreach (var auto in autos)
            {
                if (auto.Key.Contains("bmw" + carName.ToLower()))
                {
                    return autos[auto.Key];
                }
            }

            return null;
        }
    }
}