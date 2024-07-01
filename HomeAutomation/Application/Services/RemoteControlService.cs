using HomeAutomation.Core.Entities;
using HomeAutomation.Core.Interfaces;
namespace HomeAutomation.Application.Services
{
    public class RemoteControlService
    {
        private ICommand _command;

        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public void PressButton()
        {
            _command.Execute();
        }
    }
}
