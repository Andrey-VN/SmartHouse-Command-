using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHouse_Command_.Receiver.LightReceiver
{
    //public class LightOffOnState
    //{
    //    public static OffOnLight OffOnLight { get; set; }

    //}
    public class LightReceiverOffOn : ILightReceiver
    {

        public OffOnLight OffOnLight { get; set; }

        public void OnLight()
        {
            OffOnLight = OffOnLight.On;
            //LightOffOnState.OffOnLight = OffOnLight.On;
            Console.WriteLine("Свет включен");
        }

        public void OffLight()
        {
            OffOnLight = OffOnLight.Off;
            //LightOffOnState.OffOnLight = OffOnLight.Off;
            Console.WriteLine("Свет выключен");
        }
    }
}
