using SmartHouse_Command_.Receiver;
using SmartHouse_Command_.Receiver.ConditionerReceiver;
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

            Console.WriteLine();

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

            Console.WriteLine();

            IConditionerResiver condTemp = new ConditionerReceiverTemp();
            IConditionerResiver condFanMode = new ConditionerReceiverFanMode();
            IConditionerResiver condOffOn = new ConditionerReceiverOffOn();
            remoteControl.SetCommand(4, new ConditionerRoom_1(condTemp));
            remoteControl.SetCommand(5, new ConditionerRoom_1(condFanMode));
            remoteControl.SetCommand(6, new ConditionerRoom_1(condOffOn));

            remoteControl.UpButton(5);
            remoteControl.UpButton(5);
            remoteControl.UpButton(5);
            remoteControl.UpButton(5);

            remoteControl.DownButton(5);
            remoteControl.DownButton(5);
            remoteControl.DownButton(5);

            Console.WriteLine();

            remoteControl.UpButton(6);
            remoteControl.DownButton(6);

            Console.WriteLine();

            remoteControl.UpButton(4);
            remoteControl.UpButton(4);
            remoteControl.UpButton(4);
            remoteControl.UpButton(4);
            remoteControl.UpButton(4);
            remoteControl.UpButton(4);
            remoteControl.UpButton(4);
            remoteControl.DownButton(4);
            remoteControl.DownButton(4);
            remoteControl.DownButton(4);
            remoteControl.DownButton(4);
            remoteControl.DownButton(4);
            remoteControl.DownButton(4);
            remoteControl.DownButton(4);
            remoteControl.DownButton(4);
            remoteControl.DownButton(4);
            remoteControl.DownButton(4);
            remoteControl.DownButton(4);
            remoteControl.DownButton(4);
            remoteControl.DownButton(4);
            remoteControl.DownButton(4);
            remoteControl.DownButton(4);
            remoteControl.DownButton(4);
            remoteControl.DownButton(4);
            remoteControl.DownButton(4);
            remoteControl.DownButton(4);
            remoteControl.DownButton(4);
            remoteControl.DownButton(4);

            Console.Read();

        }
    }
}
