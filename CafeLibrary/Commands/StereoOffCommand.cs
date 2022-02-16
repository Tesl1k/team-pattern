using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeLibrary
{
    public class StereoOffCommand : Command
    {
        Stereo stereo;
        public string description = "Выключение радио";

        public StereoOffCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }
        public string Execute()
        {
            return stereo.Off();
        }

        public string Display()
        {
            return description;
        }

    }
}
