using System;
using System.Collections.Generic;
using System.Reflection;

namespace ConsoleApplication1
{
    public abstract class AutoFactory : IAutoFactory
    {
        internal Dictionary<string, Type> autos = new Dictionary<string, Type>();
        internal Dictionary<string, Type> decorators = new Dictionary<string, Type>();
        internal Make carModel;

        public Make CarName { get; set; }

        public AutoFactory(Make carModel)
        {
            this.carModel = carModel;
            LoadCarTypesToReturn();
            LoadDecoratorTypesToReturn();
        }

        private void LoadCarTypesToReturn()
        {
            autos = new Dictionary<string, Type>();
            Type[] TypesInThisAssembly = Assembly.GetExecutingAssembly().GetTypes();
            foreach (var type in TypesInThisAssembly)
            {
                if (type.GetInterface(typeof (IAuto).ToString()) != null)
                {
                    autos.Add(type.Name.ToLower(), type);
                }
            }
        }

        private void LoadDecoratorTypesToReturn()
        {
            decorators = new Dictionary<string, Type>();
            Type[] TypesInThisAssembly = Assembly.GetExecutingAssembly().GetTypes();
            foreach (var type in TypesInThisAssembly)
            {
                if (type.BaseType == typeof(AccessoryDecorator))
                {
                    decorators.Add(type.Name.ToLower(), type);
                }
            }
        }

        private Type GetDecoratorTypeToApply(string accessory)
        {
            foreach (var auto in decorators)
            {
                if (auto.Key.Contains(accessory))
                {
                    return decorators[auto.Key];
                }
            }

            return null;
        }

        public abstract IAuto CreateAutomobile(); 

        public virtual IAuto AddAccessories(IAuto auto)
        {
            foreach (var access in CarName.Accessory)
            {
                Type decoratorType = GetDecoratorTypeToApply(access);
                auto = Activator.CreateInstance(decoratorType, auto) as AccessoryDecorator;
            }
            return auto;
        }
    }
}