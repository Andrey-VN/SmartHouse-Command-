using SmartHouse_Command_.Receiver;
using SmartHouse_Command_.Receiver.LightReceiver;
using SmartHouse_Command_.Receiver.TVReceiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHouse_Command_
{
    class Program
    {
        static void Main(string[] args)
        {

            RemoteControl remoteControl = new RemoteControl();
            ITVReceiver tVOffOn = new TVReceiverOffOn();
            ITVReceiver tVLov = new TVReceiverLov();
            remoteControl.SetCommand(0, new TVRoom_1(tVOffOn));

            remoteControl.UpButton(0);
            remoteControl.SetCommand(1, new TVRoom_1(tVLov));

            remoteControl.UpButton(1);
            remoteControl.UpButton(1);
            remoteControl.UpButton(1);
            remoteControl.UpButton(1);
            remoteControl.UpButton(1);
            remoteControl.UpButton(1);
            remoteControl.UpButton(1);
            remoteControl.UpButton(1);
            remoteControl.UpButton(1);
            remoteControl.UpButton(1);


            remoteControl.DownButton(0);



            ILightReceiver lightResiverLOV = new LightReceiverLov();
            ILightReceiver lightResiverOffOn = new LightReceiverOffOn();
            remoteControl.SetCommand(2, new LightHallway(lightResiverLOV));
            remoteControl.SetCommand(3, new LightHallway(lightResiverOffOn));

            remoteControl.UpButton(2);
            remoteControl.UpButton(2);
            remoteControl.UpButton(2);
            remoteControl.UpButton(2);
            remoteControl.DownButton(2);
            remoteControl.DownButton(2);
            remoteControl.DownButton(2);
            remoteControl.DownButton(2);
            remoteControl.UpButton(3);
            remoteControl.DownButton(3);



            //Console.WriteLine();

            //remoteControl.DownButton();
            //remoteControl.DownButton();
            //remoteControl.DownButton();
            //remoteControl.DownButton();





            Console.Read();

        }
    }
}
