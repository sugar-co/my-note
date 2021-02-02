using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicProxy
{
    public interface IGamePlayer
    {
        public void Login(string user, string password);
        public void KillBoss();
        public void Upgrade();
    }
}
