using SmartHouse_Command_.Receiver.LightReceiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse_Command_
{
    public class LightRoom_2 : ILightCommand
    {
        public ILightReceiver LResiver { get; set; }
        LightReceiverLov lov;
        LightReceiverOffOn offOn;
        public LightRoom_2(ILightReceiver lResiver)
        {
            LResiver = lResiver;
            if (lResiver is LightReceiverOffOn)
                offOn = new LightReceiverOffOn();
            if (lResiver is LightReceiverLov)
                lov = new LightReceiverLov();
        }

        public void Execute()
        {
            if (LResiver is LightReceiverLov)
                lov.UpLight();
            else if (LResiver is LightReceiverOffOn)
                offOn.OnLight();
        }

        public void Undo()
        {
            if (LResiver is LightReceiverLov)
                lov.DownLight();
            else if (LResiver is LightReceiverOffOn)
                offOn.OffLight();
        }
    }
}