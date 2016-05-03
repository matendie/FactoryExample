using System;
using System.Collections.Generic;
using System.Reflection;

namespace ConsoleApplication1
{
    public abstract class AutoFactory : IAutoFactory
    {
        internal Dictionary<string, Type> autos = new Dictionary<string, Type>();
        internal Make carModel;

        public Make CarName { get; set; }

        public AutoFactory(Make carModel)
        {
            this.carModel = carModel;
            LoadCarTypesToReturn();
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

        public abstract IAuto CreateAutomobile();
         
    }
}