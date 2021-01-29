using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse_Command_
{
    public class TechnicsConditioner : ITechnicsCommand
    {
        public TechnicsResiver TechnicsResiver { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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