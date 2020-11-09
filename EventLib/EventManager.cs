using System;
using System.Reflection;


namespace EventLib
{
    public class EventManager : IEventManager
    {
         public void LoadListener<T>(T evt)
        {
            LoadEvents(evt.GetType(), evt);
        }

        public void LoadEvents<T>(Type type, T evt)
        {
            var methods = type.GetMethods();
            foreach (MethodInfo method in methods)
            {
                EventAttribute eventAttribute = Attribute.GetCustomAttribute(method, typeof(EventAttribute), false) as EventAttribute;
                if (eventAttribute == null) continue;

                Console.WriteLine(method.Name);
                EventInfo eventInfo = eventAttribute.Type.GetEvent("EE", BindingFlags.FlattenHierarchy |
    BindingFlags.Instance |
    BindingFlags.NonPublic |
    BindingFlags.Public |
    BindingFlags.Static);

                var eType = eventInfo.EventHandlerType;
                Delegate handler = null;

                try
                {
                    handler = Delegate.CreateDelegate(eType, evt, method);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }

                eventInfo.AddEventHandler(eventAttribute.Type, handler);
            }
        }
    }
}
