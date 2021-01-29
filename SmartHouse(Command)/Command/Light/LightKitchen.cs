using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse_Command_
{
    public class LightKitchen : ILightCommand
    {
        public LightResiver LightResiver { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Execute()
        {
            throw new NotImplementedException();
        }

        public void Undo()
        {
            throw new NotImplementedException();
        }
    }
}