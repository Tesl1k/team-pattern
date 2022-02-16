using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeLibrary
{
    public class StereoOnCommand : Command
    {
        Stereo stereo;
        public string description = "Включение радио";

        public StereoOnCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }
        public string Execute()
        {  
            return $"{stereo.On()}\n{stereo.setCD()}\n{stereo.setVolume(15)}";
        }

        public string Display()
        {
            return description;
        }

    }
}
