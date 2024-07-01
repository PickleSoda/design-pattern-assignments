using System;
namespace HomeAutomation.Core.Entities
{
    public class Thermostat
    {
        public int CurrentTemperature { get; private set; }
        public void SetTemperature(int temperature)
        {
            CurrentTemperature = temperature;
            Console.WriteLine($"The thermostat is set to {temperature} degrees.");
        }
    }
}
