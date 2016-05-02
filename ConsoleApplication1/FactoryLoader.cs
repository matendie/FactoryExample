using System;
using System.Collections.Generic;
using System.Reflection;

namespace ConsoleApplication1
{
    public class FactoryLoader : IFactoryLoader
    {
        private Dictionary<string, Type> factories = new Dictionary<string, Type>();
        public IAutoFactory LoadFactoryForGivenCarName(string carMake, string carModel)
        {
            LoadFactoryTypesToReturn();
            Type type = GetFactoryTypeToCreate(carMake);
            if (type == null)
            {
                return new NullAutoFactory(carModel);
            }

            return Activator.CreateInstance(type, carModel) as IAutoFactory;
        }

        private Type GetFactoryTypeToCreate(string carMake)
        {
            foreach (var auto in factories)
            {
                if (auto.Key.Contains(carMake.ToLower()))
                {
                    return factories[auto.Key];
                }
            }

            return null;
        }

        private void LoadFactoryTypesToReturn()
        {
            Type[] TypesInThisAssembly = Assembly.GetExecutingAssembly().GetTypes();
            foreach (var type in TypesInThisAssembly)
            {
                if (type.GetInterface(typeof (IAutoFactory).ToString()) != null)
                {
                    factories.Add(type.Name.ToLower(), type);
                }
            }
        }
    }
}