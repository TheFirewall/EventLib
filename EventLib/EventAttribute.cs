using System;

namespace EventLib
{
    [AttributeUsage(AttributeTargets.Method, Inherited = true, AllowMultiple = true)]
    public class EventAttribute : Attribute
    {
        public Type Type;
    }
}
