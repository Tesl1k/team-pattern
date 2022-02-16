using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeLibrary
{
    public class GarageDoorCloseCommand : Command
    {
        GarageDoor garageDoor;
        public string description = "Открытие двери";

        public GarageDoorCloseCommand(GarageDoor garageDoor)
        {
            this.garageDoor = garageDoor;
        }
        public string Execute()
        {
            return $"{garageDoor.Down()}\n{garageDoor.Stop()}\n{garageDoor.LightOff()}";
        }

        public string Display()
        {
            return description;
        }
    }
}
