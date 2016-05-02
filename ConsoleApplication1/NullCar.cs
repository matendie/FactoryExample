using System;

namespace ConsoleApplication1
{
    public class NullCar : IAuto
    {
        private string _carName = null;
        public NullCar(string carName)
        {
            _carName = carName;
        }
        public void TurnOff()
        {
            Console.WriteLine("No " + _carName + " car was found.");
        }

        public void TurnOn()
        {
            Console.WriteLine("No " + _carName + " car was found.");
        }
    }
}