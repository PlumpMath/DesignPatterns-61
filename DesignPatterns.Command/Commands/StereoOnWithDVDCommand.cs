using DesignPatterns.Command.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command.Commands
{
    public class StereoOnWithDVDCommand : ICommand
    {
        private Stereo stereo;

        private Stereo.Mode previousMode;

        private int previousVolume;

        public StereoOnWithDVDCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }

        public void Execute()
        {
            previousMode = stereo.CurrentMode;
            previousVolume = stereo.Volume;
            stereo.CurrentMode = Stereo.Mode.DVD;
            stereo.Volume = Settings.DVDVolume;
        }

        public void Undo()
        {
            stereo.CurrentMode = previousMode;
            stereo.Volume = previousVolume;
        }
    }
}
