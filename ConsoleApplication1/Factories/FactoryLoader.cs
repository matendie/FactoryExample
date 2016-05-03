using System;
using System.Collections.Generic;
using System.Reflection;

namespace ConsoleApplication1
{
    public class FactoryLoader : IFactoryLoader
    {
        private Dictionary<string, Type> factories = new Dictionary<string, Type>();
        public IAutoFactory LoadFactoryForGivenCarName(Make make)
        {
            LoadFactoryTypesToReturn();
            Type type = GetFactoryTypeToCreate(make);
            if (type == null)
            {
                return new NullAutoFactory(make);
            }

            return Activator.CreateInstance(type, make) as IAutoFactory;
        }

        private Type GetFactoryTypeToCreate(Make carMake)
        {
            foreach (var auto in factories)
            {
                if (auto.Key.Contains(carMake.Name.ToLower()))
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
                if (type.GetInterface(typeof (IAutoFactory).ToString()) != null && !factories.ContainsKey(type.Name.ToLower()))
                {
                    factories.Add(type.Name.ToLower(), type);
                }
            }
        }
    }
}