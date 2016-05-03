namespace ConsoleApplication1
{
    public class NullAutoFactory : AutoFactory, IAutoFactory
    {
        public NullAutoFactory(Make car) : base(car)
        {
            CarName = car;
        }
         
        public override IAuto CreateAutomobile()
        {
            return new NullCar(carModel);
        }
    }
}