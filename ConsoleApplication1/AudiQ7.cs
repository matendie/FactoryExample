using System;

namespace ConsoleApplication1
{
    public class AudiQ7 : IAuto
    {
        public void TurnOff()
        {
            Console.WriteLine("AudiQ7 is off.");
        }

        public void TurnOn()
        {
            Console.WriteLine("AudiQ7 is running.");
        }
    }
}