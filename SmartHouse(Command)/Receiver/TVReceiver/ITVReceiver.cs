using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHouse_Command_.Receiver
{
    public enum OffOnTv
    {
        Off,
        On
    }
    public interface ITVReceiver
    {
        OffOnTv OffOnTV { get; set; }
    }
}
