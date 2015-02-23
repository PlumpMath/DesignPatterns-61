using DesignPatterns.Command.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command.Commands
{
    public class CeilingFanOffCommand :ICommand
    {
        private CeilingFan ceilingFan;

        private CeilingFan.Speed previousSpeed;

        public CeilingFanOffCommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }

        public void Execute()
        {
            previousSpeed = ceilingFan.CurrentSpeed;
            ceilingFan.CurrentSpeed = CeilingFan.Speed.Off;
        }

        public void Undo()
        {
            ceilingFan.CurrentSpeed = previousSpeed;
        }
    }
}
