using DesignPatterns.Command.Commands;
using DesignPatterns.Command.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command
{
    /// <summary>
    /// The command pattern encapsulates a request as an object,
    /// thereby letting you parameterize other objects with different requests, queue or log requests and support undoable operations.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var remoteControl = new RemoteControl();

            var light = new Light();
            var stereo = new Stereo();
            var garageDoor = new GarageDoor();
            var ceilingFan = new CeilingFan();

            var lightOnCommand = new LightOnCommand(light);
            var lightOffCommand = new LightOffCommand(light);
            var stereoOnWithCdCommand = new StereoOnWithCDCommand(stereo);
            var stereoOnWithDvdCommand = new StereoOnWithDVDCommand(stereo);
            var stereoOffCommand = new StereoOffCommand(stereo);
            var garageDoorOpenCommand = new GarageDoorOpenCommand(garageDoor);
            var garageDoorCloseCommand = new GarageDoorCloseCommand(garageDoor);
            var ceilingFanHighCommand = new CeilingFanHighCommand(ceilingFan);
            var ceilingFanLowCommand = new CeilingFanLowCommand(ceilingFan);
            var ceilingFanOffCommand = new CeilingFanOffCommand(ceilingFan);
            var partyOnCommand = new MacroCommand(lightOnCommand, stereoOnWithDvdCommand, ceilingFanHighCommand, garageDoorOpenCommand);
            var partyOffCommand = new MacroCommand(lightOffCommand, stereoOffCommand, ceilingFanOffCommand, garageDoorCloseCommand);

            remoteControl.SetCommand(0, lightOnCommand, lightOffCommand); 
            remoteControl.SetCommand(1, garageDoorOpenCommand, garageDoorCloseCommand);
            remoteControl.SetCommand(2, stereoOnWithCdCommand, stereoOffCommand);
            remoteControl.SetCommand(3, stereoOnWithDvdCommand, stereoOffCommand);
            
            remoteControl.OnButtonPressed(0);
            remoteControl.OffButtonPressed(0);
            remoteControl.OnUndoButtonPressed();
            remoteControl.OnButtonPressed(1);
            remoteControl.OffButtonPressed(1);
            remoteControl.OnButtonPressed(2);
            remoteControl.OffButtonPressed(2);
            remoteControl.OnUndoButtonPressed();
            remoteControl.OnButtonPressed(3);
            remoteControl.OnUndoButtonPressed();
            remoteControl.OffButtonPressed(3);

            remoteControl.OnUndoButtonPressed();
            remoteControl.OnUndoButtonPressed();
            remoteControl.OnUndoButtonPressed();
            remoteControl.OnUndoButtonPressed();

            Console.WriteLine();

            remoteControl.SetCommand(2, ceilingFanLowCommand, ceilingFanOffCommand);
            remoteControl.SetCommand(3, ceilingFanHighCommand, ceilingFanOffCommand);
            remoteControl.SetCommand(4, partyOnCommand, partyOffCommand);

            remoteControl.OnButtonPressed(2);
            remoteControl.OnButtonPressed(3);
            remoteControl.OnUndoButtonPressed();
            remoteControl.OffButtonPressed(3);
            remoteControl.OnButtonPressed(4);
            remoteControl.OffButtonPressed(4);
            remoteControl.OnUndoButtonPressed();

            Console.ReadLine();
        }
    }
}
