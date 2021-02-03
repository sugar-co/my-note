using Observer.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Service
{
    public class Mouse: IObserver
    {
        public void Action()
        {
            Run();
        }

        public void Run()
        {
            Console.WriteLine($"{typeof(Mouse)} Run");
        }
    }
}
