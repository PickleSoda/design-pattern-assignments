using HomeAutomation.Core.Entities;
using HomeAutomation.Core.Interfaces;
namespace HomeAutomation.Application.Commands
{
    public class AdjustThermostatCommand : ICommand
    {
        private Thermostat _thermostat;
        private int _temperature;

        public AdjustThermostatCommand(Thermostat thermostat, int temperature)
        {
            _thermostat = thermostat;
            _temperature = temperature;
        }

        public void Execute()
        {
            _thermostat.SetTemperature(_temperature);
        }
    }
}
