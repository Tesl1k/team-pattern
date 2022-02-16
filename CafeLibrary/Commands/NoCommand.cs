using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeLibrary
{
    public class NoCommand : Command
    {
        public string description = "Пусто";
        public string Execute()
        {
            return Display();
        }

        public string Display()
        {
            return description;
        }
    }
}
