using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse_Command_
{

    public enum OffOnKette
    {
        Off,
        On
    }
    public class KetteResiver
    {
        OffOnKette LevelOffOn { get; set; }
        public KetteResiver()
        {
            LevelOffOn = OffOnKette.Off;
        }
        public void OffKettle()
        {
            LevelOffOn = OffOnKette.Off;
            Console.WriteLine("Чайник отключен");
        }

        public void OnKettle()
        {
            LevelOffOn = OffOnKette.On;
            Console.WriteLine("Чайник включен");
        }

    }
}