using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command.Commands
{
    public class MacroCommand : ICommand
    {
        private ICommand[] commands;

        public MacroCommand(params ICommand[] commands)
        {
            this.commands = commands;
        }

        public void Execute()
        {
            foreach (var command in commands)
            {
                command.Execute();
            }
        }

        public void Undo()
        {
            foreach (var command in commands)
            {
                command.Undo();
            }
        }
    }
}
