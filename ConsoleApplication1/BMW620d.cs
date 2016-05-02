using System;

namespace ConsoleApplication1
{
    public class BMW620d : IAuto
    {
        public void TurnOff()
        {
            Console.WriteLine("BMW620d is off.");
        }

        public void TurnOn()
        {
            Console.WriteLine("BMW620d is running.");
        }
    }
}