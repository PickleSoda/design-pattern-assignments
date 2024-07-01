using HomeAutomation.Core.Entities;
using HomeAutomation.Core.Interfaces;
namespace HomeAutomation.Application.Commands
{
    public class TurnOnLightCommand : ICommand
    {
        private Light _light;

        public TurnOnLightCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.TurnOn();
        }
        public void Undo()
        {
            _light.TurnOff();
        }
    }
}
