namespace ConsoleApplication1
{
    public interface IAutoFactory
    {
        Make CarName { get; set; }
        IAuto CreateAutomobile();
        IAuto AddAccessories(IAuto auto);
    }
}