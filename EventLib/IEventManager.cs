using System;
namespace NetCoreEvent
{
    public interface IEventManager
    {
        void LoadListener<T>(T evt);
        void LoadEvents<T>(Type type, T evt);
    }
}
