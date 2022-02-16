using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeLibrary
{
    public class RemoteControl
    {
        Command[] onCommands;
        Command[] offCommands;
        public RemoteControl()
        {
            onCommands = new Command[7];
            offCommands = new Command[7];
            Command noCommand = new NoCommand();
            for (int i = 0; i < 7; i++)
            {
                onCommands[i] = noCommand;
                offCommands[i] = noCommand;
            }
        }
        public void setCommand(int slot, Command onCommand, Command offCommand)
        {
            onCommands[slot] = onCommand;
            offCommands[slot] = offCommand;
        }
        public string onButtonWasPushed(int slot)
        {
            return onCommands[slot].Execute();
        }
        public string offButtonWasPushed(int slot)
        {
            return offCommands[slot].Execute() + "\n";
        }


        public string toString()
        {
            string x = "------ Пульт управления -------\n";
            for (int i = 0; i < onCommands.Length; i++)
            {
                x += $"[Ячейка {i+1}] - {onCommands[i].Display()}\t{offCommands[i].Display()}\n";
            }

            return x;
        }
    }
}
