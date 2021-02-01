using SmartHouse_Command_.Receiver.TVReceiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHouse_Command_.Receiver
{
    public class TvOffOnState
    {     
        public static OffOnTv OffOnTV { get; set; }

    }
    public class TVReceiverOffOn : ITVReceiver
    {
        

        public OffOnTv OffOnTV { get; set; }

        public void OnTV()
        {
            OffOnTV = OffOnTv.On;
            TvOffOnState.OffOnTV = OffOnTv.On;
            //new TVReceiverLov().OffOnTV = OffOnTV;
            Console.WriteLine("Телевизор включен");
        }

        public void OffTV()
        {
            OffOnTV = OffOnTv.Off;
            TvOffOnState.OffOnTV = OffOnTv.Off;
            //new TVReceiverLov().OffOnTV = OffOnTV;
            Console.WriteLine("Телевизор выключен");
        }
    }
}
