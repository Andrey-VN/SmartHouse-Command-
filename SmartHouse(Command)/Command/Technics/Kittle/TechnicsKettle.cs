using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse_Command_
{
    public class TechnicsKettle : ITechnicsCommand
    {
        KetteResiver Kette { get; set; }
        public TechnicsKettle(KetteResiver ketteResiver)
        {
            Kette = ketteResiver;
        }
        public void Execute()
        {
            Kette.OnKettle();
        }

        public void Undo()
        {
            Kette.OffKettle();
        }
    }
}