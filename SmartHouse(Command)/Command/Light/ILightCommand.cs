using SmartHouse_Command_.Receiver.LightReceiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse_Command_
{
    public interface ILightCommand : IComand
    {
        ILightReceiver LResiver { get; set; }
    }
}