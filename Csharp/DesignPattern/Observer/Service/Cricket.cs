using Observer.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Service
{
    public class Cricket : IObserver
    {
        public void Action()
        {
            Sing();
        }

        public void Sing()
        {
            Console.WriteLine($"{typeof(Cricket)} Sing");
        }
    }
}
