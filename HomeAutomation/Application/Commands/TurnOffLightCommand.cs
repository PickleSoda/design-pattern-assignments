using HomeAutomation.Core.Entities;
using HomeAutomation.Core.Interfaces;
namespace HomeAutomation.Application.Commands
{
    public class TurnOffLightCommand : ICommand
    {
        private Light _light;

        public TurnOffLightCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.TurnOff();
        }
        public void Undo()
        {
            _light.TurnOn();
        }
    }
}
