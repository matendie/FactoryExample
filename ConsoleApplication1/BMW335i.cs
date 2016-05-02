using System;

namespace ConsoleApplication1
{
    public class BMW335i : IAuto
    {
        public void TurnOff()
        {
            Console.WriteLine("BMW335i is off.");
        }

        public void TurnOn()
        {
            Console.WriteLine("BMW335i is running.");
        }
    }
}