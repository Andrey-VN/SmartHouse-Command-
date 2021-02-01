using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHouse_Command_.Receiver.ConditionerReceiver
{
    public enum OffOnConditioner
    {
        Off,
        On
    }
    public class ConditionerReceiverOffOn : IConditionerResiver
    {
        public OffOnConditioner OffOnConditioner { get; set; }

        public void OnConditioner()
        {
            OffOnConditioner = OffOnConditioner.On;
            Console.WriteLine("Кондиционер включен");
        }

        public void OffLight()
        {
            OffOnConditioner = OffOnConditioner.Off;
            Console.WriteLine("Кондиционер выключен");
        }
    }
}
