using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeLibrary;

namespace Cafe
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoteControl remoteControl = new RemoteControl();
            Light livingRoomLight = new Light();
            GarageDoor garageDoor = new GarageDoor();
            Stereo stereo = new Stereo();
            LightOnCommand livingRoomLightOn = new LightOnCommand(livingRoomLight);
            LightOffCommand livingRoomLightOff = new LightOffCommand(livingRoomLight);
            GarageDoorOpenCommand garageDoorOpen = new GarageDoorOpenCommand(garageDoor);
            GarageDoorCloseCommand garageDoorColse = new GarageDoorCloseCommand(garageDoor);
            StereoOnCommand radioOn = new StereoOnCommand(stereo);
            StereoOffCommand radioOff = new StereoOffCommand(stereo);

            Stereo.volume = 11;

            remoteControl.setCommand(0, livingRoomLightOn, livingRoomLightOff);
            remoteControl.setCommand(1, garageDoorOpen, garageDoorColse);
            remoteControl.setCommand(4, radioOn, radioOff);

            Console.WriteLine(remoteControl.toString());
            Console.WriteLine(remoteControl.onButtonWasPushed(0));
            Console.WriteLine(remoteControl.offButtonWasPushed(0));
            Console.WriteLine(remoteControl.undoButtonWasPushed());
            Console.WriteLine(remoteControl.toString());
            Console.WriteLine(remoteControl.onButtonWasPushed(1));
            Console.WriteLine(remoteControl.offButtonWasPushed(1));
            Console.WriteLine(remoteControl.undoButtonWasPushed());
            Console.WriteLine(remoteControl.toString());
            Console.WriteLine(remoteControl.onButtonWasPushed(4));
            Console.WriteLine(remoteControl.offButtonWasPushed(4));
            Console.WriteLine(remoteControl.undoButtonWasPushed());
            Console.WriteLine(remoteControl.toString());

            Console.ReadKey();
        }
    }
}
