using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace DynamicProxy
{
    public interface InvocationHandler
    {
        object Invoke(object proxy, MethodInfo method, object[] args);
    }
}
