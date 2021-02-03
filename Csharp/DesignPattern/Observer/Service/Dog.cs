using Observer.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Service
{
    public class Dog : IObserver
    {
        public void Action()
        {
            Wang();
        }

        public void Wang()
        {
            Console.WriteLine($"{typeof(Dog)} Wang");
        }
    }
}
