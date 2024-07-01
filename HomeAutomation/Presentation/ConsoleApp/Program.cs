using System;
using HomeAutomation.Application.Commands;
using HomeAutomation.Application.Services;
using HomeAutomation.Core.Entities;
using HomeAutomation.Core.Interfaces;

class Program
{
    static void Main()
    {
        // Create receivers
        Light livingRoomLight = new Light();
        Thermostat thermostat = new Thermostat();

        // Create commands
        ICommand turnOnLight = new TurnOnLightCommand(livingRoomLight);
        ICommand turnOffLight = new TurnOffLightCommand(livingRoomLight);
        ICommand adjustThermostat = new AdjustThermostatCommand(thermostat, 22);

        // Create invoker
        RemoteControlService remoteControl = new RemoteControlService();

        // Execute commands
        remoteControl.SetCommand(turnOnLight);
        remoteControl.PressButton();

        remoteControl.SetCommand(turnOffLight);
        remoteControl.PressButton();

        remoteControl.SetCommand(adjustThermostat);
        remoteControl.PressButton();
    }
}
