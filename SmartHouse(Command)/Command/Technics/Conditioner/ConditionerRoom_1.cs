using SmartHouse_Command_.Receiver;
using SmartHouse_Command_.Receiver.ConditionerReceiver;
using SmartHouse_Command_.Receiver.LightReceiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse_Command_
{
    public class ConditionerRoom_1 : IConditionerCommand
    {
        public IConditionerResiver conditionerResiver { get; set; }
        ConditionerReceiverTemp temp;
        ConditionerReceiverOffOn offOn;
        ConditionerReceiverFanMode fanMode;

        public ConditionerRoom_1(IConditionerResiver conditioner)
        {
            conditionerResiver = conditioner;
            if (conditioner is ConditionerReceiverTemp)
                temp = new ConditionerReceiverTemp();
            else if (conditioner is ConditionerReceiverOffOn)
                offOn = new ConditionerReceiverOffOn();
            else if (conditioner is ConditionerReceiverFanMode)
                fanMode = new ConditionerReceiverFanMode();
        }
        public void Execute()
        {
            if (conditionerResiver is ConditionerReceiverTemp)
                temp.UpTemp();
            else if (conditionerResiver is ConditionerReceiverOffOn)
                offOn.OnConditioner();
            else if (conditionerResiver is ConditionerReceiverFanMode)
                fanMode.UpFanState();
        }

        public void Undo()
        {
            if (conditionerResiver is ConditionerReceiverTemp)
                temp.DownTemp();
            else if (conditionerResiver is ConditionerReceiverOffOn)
                offOn.OffLight();
            else if (conditionerResiver is ConditionerReceiverFanMode)
                fanMode.DownFanState();
        }
    }
}