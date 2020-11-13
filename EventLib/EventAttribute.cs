using System;

namespace NetCoreEvent
{
    [AttributeUsage(AttributeTargets.Method, Inherited = true, AllowMultiple = true)]
    public class EventAttribute : Attribute
    {
        public Type Type;
    }
}
