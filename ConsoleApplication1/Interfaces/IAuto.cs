namespace ConsoleApplication1
{
    public interface IAuto
    {
        string CarName
        {
            get;
            set;
        }

        void TurnOn();
        void TurnOff();
    }
}