using System;
namespace HomeAutomation.Core.Entities
{
    public class Light
    {
        public void TurnOn()
        {
            Console.WriteLine("The light is on.");
        }

        public void TurnOff()
        {
            Console.WriteLine("The light is off.");
        }
    }
}
