using System;

namespace DynamicProxy
{
    class Program
    {
        static void Main(string[] args)
        {
            IGamePlayer player = new GamePlayer("张三");
            InvocationHandler handler = new GamePlayIH(player);
            Console.WriteLine($"开始时间{DateTime.Now:yyyy-MM-dd HH:mm:ss}");
            IGamePlayer proxy = Proxy
        }
    }
}
