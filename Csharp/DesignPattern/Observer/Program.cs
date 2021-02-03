using Observer.Service;
using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var cat = new Cat();
            //cat.AddObserver(new Dog());
            //cat.AddObserver(new Baby());
            //cat.AddObserver(new Father());
            //cat.MiaoObserver();

            cat.CatMiaoEvent+=new Dog().Wang;
            cat.CatMiaoEvent+=new Baby().Cry;
            cat.CatMiaoEvent+=new Father().Roar;
            cat.MiaoEvent();
        }
    }
}
