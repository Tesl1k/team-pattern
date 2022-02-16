using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeLibrary
{
    public class LightOnCommand : Command
    {
        Light light;
        public string description = "Включение света";
        public LightOnCommand(Light light)
        {
            this.light = light;
            
        }
        public string Execute()
        {
            return light.On();
        }

        public string Display()
        {
            return description;
        }
    }
}
