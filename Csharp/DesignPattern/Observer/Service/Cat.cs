using Observer.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Service
{
    public class Cat 
    {
        private List<IObserver> _ObserverList = new List<IObserver>();

        public void Miao()
        {
            Console.WriteLine($"{typeof(Cat)} Miao");
            //new Mouse().Run();
        }

        public void AddObserver(IObserver observer)
        {
            _ObserverList.Add(observer);
        }

        public event Action CatMiaoEvent;
        public void MiaoEvent()
        {
            if (CatMiaoEvent != null)
            {
                CatMiaoEvent.Invoke();
            }
        }

        public void RemoveObserver(IObserver observer)
        {
            _ObserverList.Remove(observer);
        }

        public void MiaoObserver()
        {
            Miao();
            foreach (var el in _ObserverList)
            {
                el.Action();
            }
        }
    }
}
