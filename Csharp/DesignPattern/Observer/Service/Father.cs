using Observer.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Service
{
    public class Father: IObserver
    {
        public void Action()
        {
            Roar();
        }

        public void Roar()
        {
            Console.WriteLine($"{typeof(Father)} Roar");
        }
    }
}
