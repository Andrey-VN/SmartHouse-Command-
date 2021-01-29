using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse_Command_
{
    public enum LightDimming
    {
        Off = 0,
        Dim =1,
        Medium = 2,
        Bright =3
    }
    public class LightResiver
    {
        public LightDimming Level { get; set; }
        public LightResiver()
        {
            Level = LightDimming.Off;
        }

        public void SisplayLight()
        {
            switch(Level)
            {
                case LightDimming.Off:
                    Console.WriteLine("Cвет выключен");
                    break;
                case LightDimming.Dim:
                    Console.WriteLine("Cвет тусклый");
                    break;
                case LightDimming.Medium:
                    Console.WriteLine("Cвет средний");
                    break;
                case LightDimming.Bright:
                    Console.WriteLine("Cвет выключен");
                    break;

            }
        }
        public void UpLight()
        {
            switch (Level)
            {
                case LightDimming.Off:
                    Level = LightDimming.Dim;
                    break;
                case LightDimming.Dim:
                    Level = LightDimming.Medium;
                    break;
                case LightDimming.Medium:
                    Level = LightDimming.Bright;
                    break;
                case LightDimming.Bright:
                    Level = LightDimming.Bright;
                    break;

            }
            SisplayLight();
        }
        public void DownLight()
        {
            switch (Level)
            {
                case LightDimming.Bright:
                    Level = LightDimming.Medium;
                    break;
                case LightDimming.Medium:
                    Level = LightDimming.Dim;
                    break;
                case LightDimming.Dim:
                    Level = LightDimming.Off;
                    break;
                case LightDimming.Off:
                    Level = LightDimming.Off;
                    break;

            }
            SisplayLight();
        }

    }
}