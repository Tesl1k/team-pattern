using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CafeLibrary
{
    public class GarageDoorOpenCommand : Command
    {
        GarageDoor garageDoor;
        public string description = "Открытие двери";

        public GarageDoorOpenCommand(GarageDoor garageDoor)
        {
            this.garageDoor = garageDoor;
        }
        public string Execute()
        {
            return $"{garageDoor.Up()}\n{garageDoor.Stop()}\n{garageDoor.LightOn()}";
        }

        public string Display()
        {
            return description;
        }
    }
}
