using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            bool exit = false;

            while (exit != true)
            {
                Console.WriteLine("Make, Model : ");
                string[] carMakeModel = Console.ReadLine().Split(',');

                if (carMakeModel.Length == 2)
                {
                    string carMake = carMakeModel[0].Trim();
                    string carModel = carMakeModel[1].Trim();

                    IFactoryLoader factoryLoader = new FactoryLoader();

                    IAutoFactory factory = factoryLoader.LoadFactoryForGivenCarName(carMake, carModel);

                    IAuto car = factory.CreateAutomobile();

                    car.TurnOn();
                    car.TurnOff();
                }
                else
                {
                    Console.WriteLine("Missing make or model.");
                }
                Console.WriteLine();
                Console.WriteLine("Exit ?");
                if (Console.ReadLine().ToLower() == "y")
                {
                    exit = true;
                }
            }
        }
    }
}