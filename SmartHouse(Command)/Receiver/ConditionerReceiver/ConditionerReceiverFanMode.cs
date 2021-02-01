using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHouse_Command_.Receiver.ConditionerReceiver
{
    public enum ConditionerFanDimming 
    {
        Speed_Off = 0,
        Speed_2 = 1,
        Speed_3 = 2,
        Speed_4 = 3,
        Speed_5 = 4
    }
    public class ConditionerReceiverFanMode : IConditionerResiver
    {
        public ConditionerFanDimming FanModeLevel { get; set; }
        
        public ConditionerReceiverFanMode()
        {
           
        }
        public void SisplayFanState()
        {
            switch (FanModeLevel)
            {
                case ConditionerFanDimming.Speed_Off:
                    Console.WriteLine("Вентилятор выключен");
                    break;
                case ConditionerFanDimming.Speed_2:
                    Console.WriteLine("Скорость 1");
                    break;
                case ConditionerFanDimming.Speed_3:
                    Console.WriteLine("Скорость 2");
                    break;
                case ConditionerFanDimming.Speed_4:
                    Console.WriteLine("Скорость 3");
                    break;
                case ConditionerFanDimming.Speed_5:
                    Console.WriteLine("Скорость 4");
                    break;
            }
        }
        public void UpFanState()
        {
            switch (FanModeLevel)
            {
                case ConditionerFanDimming.Speed_Off:
                    FanModeLevel = ConditionerFanDimming.Speed_2;
                    break;
                case ConditionerFanDimming.Speed_2:
                    FanModeLevel = ConditionerFanDimming.Speed_3;
                    break;
                case ConditionerFanDimming.Speed_3:
                    FanModeLevel = ConditionerFanDimming.Speed_4;
                    break;
                case ConditionerFanDimming.Speed_4:
                    FanModeLevel = ConditionerFanDimming.Speed_5;
                    break;
                case ConditionerFanDimming.Speed_5:
                    FanModeLevel = ConditionerFanDimming.Speed_5;
                    break;

            }
            SisplayFanState();
        }
        public void DownFanState()
        {
            switch (FanModeLevel)
            {
                case ConditionerFanDimming.Speed_5:
                    FanModeLevel = ConditionerFanDimming.Speed_4;
                    break;
                case ConditionerFanDimming.Speed_4:
                    FanModeLevel = ConditionerFanDimming.Speed_3;
                    break;
                case ConditionerFanDimming.Speed_3:
                    FanModeLevel = ConditionerFanDimming.Speed_2;
                    break;
                case ConditionerFanDimming.Speed_2:
                    FanModeLevel = ConditionerFanDimming.Speed_Off;
                    break;
                case ConditionerFanDimming.Speed_Off:
                    FanModeLevel = ConditionerFanDimming.Speed_Off;
                    break;

            }
            SisplayFanState();
        }
    }
}
