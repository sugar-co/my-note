using Observer.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Service
{
    public class Mother : IObserver
    {
        public void Action()
        {
            Whisper();
        }

        public void Whisper()
        {
            Console.WriteLine($"{typeof(Mother)} Whisper");
        }
    }
}
