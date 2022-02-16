using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeLibrary
{
    public class GarageDoor
    {
        public string Up()
        {
            return "Дверь открывается";
        }

        public string Down()
        {
            return "Дверь закрывается";
        }

        public string Stop()
        {
            return "Стоп";
        }

        public string LightOn()
        {
            return "Свет включен";
        }

        public string LightOff()
        {
            return "Свет выключен";
        }
    }
}
