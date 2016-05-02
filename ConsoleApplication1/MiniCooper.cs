using System;

namespace ConsoleApplication1
{
    public class MiniCooper : IAuto
    {
        public void TurnOff()
        {
            Console.WriteLine("Mini Cooper is off.");
        }

        public void TurnOn()
        {
            Console.WriteLine("Mini Cooper is running.");
        }
    }
}