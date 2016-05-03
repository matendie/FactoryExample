using System;

namespace ConsoleApplication1
{
    public class CooperAutoFactory : AutoFactory, IAutoFactory
    {
        public CooperAutoFactory(Make carName) : base(carName)
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

            IAuto auto = Activator.CreateInstance(type, CarName) as IAuto;
            auto = AddAccessories(auto);
            return auto;
        }

        private Type GetAutoTypeToCreate(Make carName)
        {
            foreach (var auto in autos)
            {
                if (auto.Key.Contains(carName.Model.ToLower() + "cooper"))
                {
                    return autos[auto.Key];
                }
            }

            return null;
        }
    }
}