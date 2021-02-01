using SmartHouse_Command_.Receiver;
using SmartHouse_Command_.Receiver.TVReceiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse_Command_
{
    public class TVRoom_1 : ITV
    {
        public ITVReceiver tVResiver { get; set; }
        TVReceiverOffOn offOn;
        TVReceiverLov lov;

        public TVRoom_1(ITVReceiver tV)
        {
            tVResiver = tV;
            if (tV is TVReceiverOffOn)
                offOn = new TVReceiverOffOn();
            if (tV is TVReceiverLov)
                lov = new TVReceiverLov();
        }

        public void Execute()
        {
            if (tVResiver is TVReceiverOffOn)
                offOn.OnTV();
            else if (tVResiver is TVReceiverLov)
                lov.UpLov();
        }

        public void Undo()
        {
            if (tVResiver is TVReceiverOffOn)
                offOn.OffTV();
            else if (tVResiver is TVReceiverLov)
                lov.DownLov();
        }
    }
}