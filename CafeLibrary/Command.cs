using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeLibrary
{
    public interface Command
    {
        string Execute();
        string Undo();
        string Display();
        
    }
}
