using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeLibrary
{
    public class LightOffCommand : Command
    {
        Light light;
        public string description = "Выключение света";

        public LightOffCommand(Light light)
        {
            this.light = light;
        }
        public string Execute()
        {
            return light.Off();
        }

        public string Display()
        {
            return description;
        }

    }
}
