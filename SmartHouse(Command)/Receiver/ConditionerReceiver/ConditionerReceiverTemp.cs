using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHouse_Command_.Receiver.LightReceiver
{
    public class ConditionerReceiverTemp : IConditionerResiver
    {
        private int oFF = 10;
        private int high = 40;
        int levelTemp;

        public ConditionerReceiverTemp()
        {
            levelTemp = 20;

        }

        public void UpTemp()
        {
                if (levelTemp < high)
                    levelTemp++;
                Console.WriteLine("Температура воздуха {0}", levelTemp);

        }

        public void DownTemp()
        {

            if (levelTemp > oFF)
                levelTemp--;
            Console.WriteLine("Температура воздуха {0}", levelTemp);
        }
    }
}
