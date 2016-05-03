using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;
using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Make> autos = new List<Make>();
            using (StreamReader r = new StreamReader("CarConfig.json"))
            {
                string json = r.ReadToEnd();
                autos = JsonConvert.DeserializeObject<List<Make>>(json);
            }

            IFactoryLoader factoryLoader = new FactoryLoader();
            foreach (var make in autos)
            {

                IAutoFactory factory = factoryLoader.LoadFactoryForGivenCarName(make);
                IAuto car = factory.CreateAutomobile();
                car.TurnOn();
                car.TurnOff();
            }
            // CreateJsonConfigFlat();
        }


        public static void CreateJsonConfigFlat()
        {
            List<Make> autos = new List<Make>();
            autos.Add(new Make() { Name = "BMW", Model = "335i", Accessory = new List<string>() { "turbo" } });
            autos.Add(new Make() { Name = "BMW", Model = "620d", Accessory = new List<string>() { "sunroof" } });
            autos.Add(new Make() { Name = "BMW", Model = "755i", Accessory = new List<string>() { "turbo", "sunroof" } });

            autos.Add(new Make() { Name = "Audi", Model = "A4", Accessory = new List<string>() { "sunroof" } });
            autos.Add(new Make() { Name = "Audi", Model = "Q7", Accessory = new List<string>() { "turbo" } });

            autos.Add(new Make() { Name = "Cooper", Model = "Mini", Accessory = new List<string>() });
             
            string json = JsonConvert.SerializeObject(autos.ToArray());
            File.WriteAllText(@"C:\TFS_Mapping\InfrastructureDesign\ConsoleApplication1\ConsoleApplication1\bin\Debug\CarConfig.json", json);
        }         
    }
}