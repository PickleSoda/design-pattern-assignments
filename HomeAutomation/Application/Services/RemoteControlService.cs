using System.Collections.Generic;
using HomeAutomation.Core.Entities;
using HomeAutomation.Core.Interfaces;

namespace HomeAutomation.Application.Services
{
    public class RemoteControlService
    {
        private ICommand _currentCommand;
        private Stack<ICommand> _commandHistory;

        public RemoteControlService()
        {
            _commandHistory = new Stack<ICommand>();
        }

        public void SetCommand(ICommand command)
        {
            _currentCommand = command;
        }

        public void PressButton()
        {
            _currentCommand.Execute();
            _commandHistory.Push(_currentCommand);
        }

        public void PressUndoButton()
        {
            if (_commandHistory.Count > 0)
            {
                ICommand lastCommand = _commandHistory.Pop();
                lastCommand.Undo();
            }
        }
    }
}
