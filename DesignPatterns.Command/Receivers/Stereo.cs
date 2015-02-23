using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command.Receivers
{
    public class Stereo
    {
        public enum Mode
        {
            Off = 0,
            CD = 1,
            DVD = 2
        }

        private Mode mode = Mode.Off;

        private int volume = 0;

        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                volume = value;
                Console.WriteLine("Stereo volume = {0}", volume);
            }
        }

        public Mode CurrentMode
        {
            get 
            { 
                return mode;
            }
            set
            {
                this.mode = value;
                Console.WriteLine("Stereo mode: {0}", mode);
            }
        }
    }
}
