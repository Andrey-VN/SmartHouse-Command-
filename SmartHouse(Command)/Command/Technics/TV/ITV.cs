using SmartHouse_Command_.Receiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse_Command_
{
    public interface ITV : ITechnicsCommand
    {
        public ITVReceiver tVResiver { get; set; }
    }
}