using System;

namespace ConsoleApplication1
{
    public class BMW755i : IAuto
    {
        public void TurnOff()
        {
            Console.WriteLine("BMW755i is off.");
        }

        public void TurnOn()
        {
            Console.WriteLine("BMW755i is running.");
        }
    }
}