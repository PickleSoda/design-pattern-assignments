using System;
namespace HomeAutomation.Core.Entities
{
    public class Thermostat
    {
        public void SetTemperature(int temperature)
        {
            Console.WriteLine($"The thermostat is set to {temperature} degrees.");
        }
    }
}
