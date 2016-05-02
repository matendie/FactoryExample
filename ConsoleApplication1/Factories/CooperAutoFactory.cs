using System;

namespace ConsoleApplication1
{
    public class CooperAutoFactory : AutoFactory, IAutoFactory
    {
        public CooperAutoFactory(string carName) : base(carName)
        {
            CarName = carName;
        }
        public override IAuto CreateAutomobile()
        {
            Type type = GetAutoTypeToCreate(carModel);
            if (type == null)
            {
                return new NullCar(carModel);
            }

            return Activator.CreateInstance(type, CarName) as IAuto;
        }

        private Type GetAutoTypeToCreate(string carName)
        {
            foreach (var auto in autos)
            {
                if (auto.Key.Contains(carName.ToLower() + "cooper"))
                {
                    return autos[auto.Key];
                }
            }

            return null;
        }
    }
}