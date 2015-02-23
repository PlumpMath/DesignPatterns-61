using DesignPatterns.Command.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command.Commands
{
    public class StereoOnWithCDCommand : ICommand
    {
        private Stereo stereo;

        private Stereo.Mode previousMode;

        private int previousVolume;

        public StereoOnWithCDCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }

        public void Execute()
        {
            previousMode = stereo.CurrentMode;
            previousVolume = stereo.Volume;
            stereo.CurrentMode = Stereo.Mode.CD;
            stereo.Volume = Settings.CDVolume;
        }

        public void Undo()
        {
            stereo.CurrentMode = previousMode;
            stereo.Volume = previousVolume;
        }
    }
}
