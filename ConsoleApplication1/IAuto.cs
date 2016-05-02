using System;

namespace ConsoleApplication1
{
    public interface IAuto
    {
        string CarName { get; set; }
        void TurnOn();
        void TurnOff(); 
    }

    public abstract class Auto : IAuto
    {
        public string CarName
        {
            get; set;
        }
        public Auto(string carName)
        {
            CarName = carName;
        }

        public abstract void TurnOff();
        public abstract void TurnOn();
    }
}