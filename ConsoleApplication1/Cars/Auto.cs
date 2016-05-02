namespace ConsoleApplication1
{
    public abstract class Auto : IAuto
    {
        public string CarName
        {
            get;
            set;
        }

        public Auto(string carName)
        {
            CarName = carName;
        }

        public abstract void TurnOff();
        public abstract void TurnOn();
    }
}