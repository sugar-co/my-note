using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace DynamicProxy
{
    class GamePlayIH : InvocationHandler
    {
        private object _obj;
        public GamePlayIH(object obj)
        {
            _obj = obj;
        }
        public object Invoke(object proxy, MethodInfo method, object[] args)
        {
            object result = method.Invoke(this._obj, args);
            return result;
        }
    }
}
