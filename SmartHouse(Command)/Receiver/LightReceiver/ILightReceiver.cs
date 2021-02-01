using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHouse_Command_.Receiver.LightReceiver
{
    public enum OffOnLight
    {
        Off,
        On
    }
    public interface ILightReceiver
    {
        OffOnLight OffOnLight { get; set; }
    }
}
