namespace ConsoleApplication1
{
    public interface IFactoryLoader
    {
        IAutoFactory LoadFactoryForGivenCarName(Make make);
    }
}