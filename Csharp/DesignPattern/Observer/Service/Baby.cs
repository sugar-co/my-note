using Observer.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Service
{
    public class Baby : IObserver
    {
        public void Action()
        {
            Cry();
        }

        public void Cry()
        {
            Console.WriteLine($"{typeof(Baby)} Cry");
        }
    }
}
