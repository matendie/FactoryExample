namespace ConsoleApplication1
{
    public class NullAutoFactory : AutoFactory, IAutoFactory
    {
        public NullAutoFactory(string carName) : base(carName)
        {
            CarName = carName;
        }
         
        public override IAuto CreateAutomobile()
        {
            return new NullCar(carModel);
        }
    }
}