namespace ConsoleApplication1
{
    public interface IFactoryLoader
    {
        IAutoFactory LoadFactoryForGivenCarName(string carName,string carModel);
    }
}