using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicProxy
{
    public class GamePlayer : IGamePlayer
    {
        private string _name;
        public GamePlayer(string name)
        {
            _name = name;
        }
        public void Login(string user, string password)
        {
            Console.WriteLine($"登录名为{user}的用户{_name}登录成功");
        }

        public void KillBoss()
        {
            Console.WriteLine($"{_name}在打怪");
        }

        public void Upgrade()
        {
            Console.WriteLine($"{_name}又升了一级");
        }
    }
}
