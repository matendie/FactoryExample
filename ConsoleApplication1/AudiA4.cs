using System;

namespace ConsoleApplication1
{
    public class AudiA4 : IAuto
    {
        public void TurnOff()
        {
            Console.WriteLine("AudiA4 is off.");
        }

        public void TurnOn()
        {
            Console.WriteLine("AudiA4 is running.");
        }
    }
}