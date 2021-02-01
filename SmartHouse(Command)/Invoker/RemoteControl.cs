using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace SmartHouse_Command_
{
    public class RemoteControl
    {
        private Dictionary<int, IComand> Command;
        public RemoteControl()
        {
            Command = new Dictionary<int, IComand>();

        }
        public void SetCommand(int number, IComand comand)
        {
            Command[number] = comand;
        }


        public void UpButton(int number)
        {
            Command[number].Execute();
        }
        public void DownButton(int number)
        {
            Command[number].Undo();
        }

    }
}