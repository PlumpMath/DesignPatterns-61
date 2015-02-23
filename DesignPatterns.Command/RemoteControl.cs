using DesignPatterns.Command.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command
{
    public class RemoteControl
    {
        private ICommand[] onCommands;

        private ICommand[] offCommands;

        private Stack<ICommand> undoCommands;

        public RemoteControl()
        {
            onCommands = new ICommand[Settings.SlotCount];
            offCommands = new ICommand[Settings.SlotCount];
            var noCommand = new NoCommand();
            for (int i = 0; i < Settings.SlotCount; i++)
            {
                onCommands[i] = noCommand;
                offCommands[i] = noCommand;
            }

            undoCommands = new Stack<ICommand>();
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            onCommands[slot] = onCommand;
            offCommands[slot] = offCommand;
        }

        public void OnButtonPressed(int slot)
        {
            onCommands[slot].Execute();
            undoCommands.Push(onCommands[slot]);
        }

        public void OffButtonPressed(int slot)
        {
            offCommands[slot].Execute();
            undoCommands.Push(offCommands[slot]);
        }

        public void OnUndoButtonPressed()
        {
            if (undoCommands.Count > 0)
            {
                undoCommands.Pop().Undo();
            }
        }
    }
}
