using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHouse_Command_.Receiver.TVReceiver
{
    public class TVReceiverLov : ITVReceiver
    {
        private int oFF = 0;
        private int high = 100;
        int levelLov;



        public int GetVol { get; private set; }
        public TVReceiverLov()
        {
            levelLov = 20;
            //OffOnTV = TvOffOnState.OffOnTV;
            
        }

        public OffOnTv OffOnTV { get; set; }

        public void UpLov()
        {
            if (TvOffOnState.OffOnTV == OffOnTv.On)
            {
                if (levelLov < high)
                    levelLov++;
                Console.WriteLine("Уровень звука {0}", levelLov);

            }
        }

        public void DownLov()
        {
            if (TvOffOnState.OffOnTV == OffOnTv.On)
            {
                if (levelLov > oFF)
                    levelLov--;
                Console.WriteLine("Уровень звука {0}", levelLov);

            }
        }
    }
}
