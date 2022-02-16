using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeLibrary
{
    public class Stereo
    {
        public string On()
        {
            return "Радио включено";
        }

        public string Off()
        {
            return "Радио выключено";
        }

        public string setCD()
        {
            return "Воспроизводиться диск";
        }

        public string setVolume(int volume)
        {
            return $"Громкость звука: {volume}";
        }
    }
}
