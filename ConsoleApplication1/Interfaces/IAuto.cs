namespace ConsoleApplication1
{
    public interface IAuto
    {
        Make CarName
        {
            get;
            set;
        }

        void TurnOn();
        void TurnOff();
    }
}