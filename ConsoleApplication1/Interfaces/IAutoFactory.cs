namespace ConsoleApplication1
{
    public interface IAutoFactory
    {
        string CarName { get; set; }
        IAuto CreateAutomobile();
    }
}