namespace ConsoleApplication1
{
    public abstract class Auto : IAuto
    {
        public Make CarName
        {
            get;
            set;
        }

        public Auto(Make carName)
        {
            CarName = carName;
        }

        public abstract void TurnOff();
        public abstract void TurnOn();
    }
}